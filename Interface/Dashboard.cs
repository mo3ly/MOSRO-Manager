using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class DashboardForm : Form
    {
        //TODO:
        // form - TopLevel = true -> do that to the bot
        // Create loading page to load the names and check all required files
        // check for all needed files before start
        // Add file handeling for queries.json and log.txt
        // switch from form to usercontrol
        // Add config file
        // Add dataGrid with image
        // Add skills decrypt/encrypt
        // Add media editor and extractor
        // Add Privileged IPs editor, Launcher Notice editor in management
        // Disable Enable regions
        // Add register account
        // DDJ viewer from media
        // complete todo page
        // Edit Charname in all tables.
        // Edit Guild in all tables.
        // Edit Pet name in all tables.
        // Edit Union owner in all tables
        // Edit Guild owner in all tables.
        // Show - edit friend name list
        // Txt exporter
        // Server -> show current uniques alive
        // Server -> show name of players online
        // Image formats convertor
        // Add erformance window
        // PK2 => add .dt extractor and editor  
        // PK2 => add SV.T extractor and editor [IP Input] 
        // Skill editor
        // Reduse the txt files -> names
        // make all namespaces (MOSROManager) not (MOSRO_Manager)

        //define variables for SlidePanel
        int panelWidth;
        bool Hidden = false;
        bool LogHidden = false;


        // Declare sub Windows
        QueryWindow queryWindow = new QueryWindow();
        ToDoWindow todoWindow = new ToDoWindow();
        Calculator calculator = new Calculator();
        GameManager GameManager = new GameManager();
        internal PacketSniffer PacketSniffer = new PacketSniffer();

        // Declare sub forms
        pConnection pConnection = new pConnection();
        pStatistics pStatistics = new pStatistics();
        pCharacters pCharacters = new pCharacters();
        internal pCharMain pCharMain = new pCharMain();
        pNewCharacter pNewCharacter = new pNewCharacter();
        pNewUser pNewUser = new pNewUser();
        pPK2Section pPK2Section = new pPK2Section();
        pManagement pManagement = new pManagement();
        pMobEditor pMobEditor = new pMobEditor();
        pAbout pAbout = new pAbout();

        // some needs
        private UserControl CurrentPage;
        private Button pButton;
        private Color pButtonColor;

        public DashboardForm()
        {
            InitializeComponent();
            PrepareTooltips();
            Common.Dashboard = this;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            panelWidth = pNavButtons.Width;
            Navigation(pConnection, pConnectionButton);
            pNavButtons.Enabled = false;

            // sLogList image list
            string ImageSrc = Directory.GetCurrentDirectory() + "/Resources/UI-icons/";
            ImageList LogImageList = new ImageList();
            LogImageList.Images.Add(Image.FromFile(ImageSrc + "icon-failed.png"));
            LogImageList.Images.Add(Image.FromFile(ImageSrc + "icon-success.png"));
            LogImageList.Images.Add(Image.FromFile(ImageSrc + "icon-warning.png"));
            sLogList.SmallImageList = LogImageList;
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {
            writeLog("Application loaded successfully", 1);

        }

        #region tooltip
        private ToolTip DashToolTip;
        private void PrepareTooltips()
        {
            DashToolTip = new ToolTip();
            DashToolTip.Draw += DashToolTip_Draw;
            foreach (var button in GetAll(this, typeof(Button)))
            {
                if (button.Tag != string.Empty && button.Tag != null)
                {
                    button.MouseHover += new EventHandler(delegate (object sender, EventArgs a)
                    {
                        DashToolTip.Show((sender as Button).Tag.ToString(), (sender as Button));
                        DashToolTip.ToolTipTitle = "Info";
                        DashToolTip.OwnerDraw = true;
                    });
                }
            }
        }

        private void DashToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            DashToolTip.BackColor = Color.FromArgb(31, 31, 31);
            DashToolTip.ForeColor = Color.White;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        #endregion

        #region Header Panel
        /// <summary>
        /// dragging the window ith drap button
        /// </summary>
        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowAPI.ReleaseCapture();
                WindowAPI.SendMessage(Handle, WindowAPI.WM_NCLBUTTONDOWN, WindowAPI.HT_CAPTION, 0);
                CurrentPage.Size = mContent.Size;
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                ResizeButton.Image = MOSRO_Manager.Properties.Resources.icon_maximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                ResizeButton.Image = MOSRO_Manager.Properties.Resources.icon_normal;
            }
            CurrentPage.Size = mContent.Size;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new dialog("Close the app ? ", "Are you sure you want to exit?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                if (Common.Config != null)
                    Common.ConfigController.SaveConfig();

                if (Common.SMCController != null)
                    Common.SMCController.Stop();

                Environment.Exit(0);
            }
        }

        #endregion

        #region Navbar
        private void queryWindowButton_Click(object sender, EventArgs e)
        {
            queryWindow.Show();
            queryWindow.BringToFront();
        }

        public void CloseQueryWindow()
        {
            queryWindow.Hide();
        }


        private void LogClear_Click(object sender, EventArgs e)
        {
            sLogList.Items.Clear();
            new alert("Log panel has been cleared.");
        }

        private void ToDo_Click(object sender, EventArgs e)
        {
            todoWindow.Show();
            todoWindow.BringToFront();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            calculator.Show();
            calculator.BringToFront();
        }

        private void bGameManager_Click(object sender, EventArgs e)
        {
            GameManager.Show();
            GameManager.BringToFront();
        }

        private void pPacketSnifferButton_Click(object sender, EventArgs e)
        {
            PacketSniffer.Show();
            PacketSniffer.BringToFront();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory());
            }
            catch { writeLog("Couldn't open app location.", 0); }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {

            new dialog("Restart the app? ", "Are you sure you want to restart the app?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Common.Config != null)
                {
                    new dialog("Save the config? ", "Are you sure you want to save the config?").ShowDialog();
                    if (Common.dialogResult == DialogResult.Yes)
                    {
                        Common.ConfigController.SaveConfig();
                        writeLog($"Config has been saved successfully.", 1);
                    }
                }
            }
            catch
            {
                writeLog($"An error occurred while saving config.", 0);
            }
        }
        #endregion

        #region Sidebar and navigation
        private void MenuButton_Click(object sender, EventArgs e)
        {
            pSlideTimer.Start();

        }

        public void Navigation(UserControl control, Button button, bool isSubMenu = false)
        {
            CurrentPage = control;
            //form.TopLevel = false;
            mContent.Controls.Clear();
            control.Height = mContent.Height - 50;
            control.Width = mContent.Width;
            // for responsive size
            mContent.Controls.Add(control);
            control.Show();
            // active the clicked button
            if (pButton != null)
                pButton.BackColor = pButtonColor;

            pButton = button;
            pButtonColor = button.BackColor;
            button.BackColor = Color.DarkKhaki;
            if (!isSubMenu)
                HideSubMenus();
        }

        private void SubMenu(Panel subMenu, Button button)
        {
            if (subMenu.Visible == false) // show
            {
                HideSubMenus();
                button.Text = button.Text.Replace("⮟", "⮝");
                subMenu.Visible = true;
            }
            else // hide
            {
                button.Text = button.Text.Replace("⮝", "⮟");
                subMenu.Visible = false;
            }
        }


        private void HideSubMenus()
        {
            subCharacterPanel.Visible = false;
            sCharacterButton.Text = sCharacterButton.Text.Replace("⮝", "⮟");
            subNPCPanel.Visible = false;
            sNPCButton.Text = sNPCButton.Text.Replace("⮝", "⮟");
        }

        private void pSlideTimer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                pNavButtons.Width = pNavButtons.Width + 10;
                if (pNavButtons.Width >= panelWidth)
                {
                    pSlideTimer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pNavButtons.Width = pNavButtons.Width - 10;
                if (pNavButtons.Width <= 0)
                {
                    pSlideTimer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
            // resize current form
            CurrentPage.Size = mContent.Size;
        }


        private void LogButton_Click(object sender, EventArgs e)
        {
            if (LogHidden) // show
            {
                pLogList.Visible = true;
                LogHidden = false;
                pLogList.Height = 80;
                this.Refresh();
            }
            else // hide
            {
                pLogList.Visible = false;
                LogHidden = true;
                pLogList.Height = 0;
                this.Refresh();
                new alert("Log panel is hidden.");

            }
            // resize current form
            CurrentPage.Size = mContent.Size;
        }

        private void HideAppButton_Click(object sender, EventArgs e)
        {
            new dialog("Hide the app? ", "Are you sure you want to hide this app?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                Notify.BalloonTipTitle = "MOSRO Manager";
                Notify.BalloonTipText = "The application has been minimized to the taskbar.";
                Notify.Visible = true;
                Hide();
                Notify.ShowBalloonTip(2000);
                new alert("The app has been minimized.", 1);
            }
        }

        private void Notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Notify.Visible = false;
            base.Show();
            WindowState = FormWindowState.Normal;
        }
        #endregion

        #region Navigation Buttons
        private void pConntectionButton_Click(object sender, EventArgs e)
        {
            Navigation(pConnection, (Button)sender);
        }

        private void pStatisticsButton_Click(object sender, EventArgs e)
        {
            Navigation(pStatistics, (Button)sender);
        }

        private void sCharacterButton_Click(object sender, EventArgs e)
        {
            SubMenu(subCharacterPanel, (Button)sender);
        }

        private void CharactersButton_Click(object sender, EventArgs e)
        {
            Navigation(pCharacters, (Button)sender, true);
        }

        private void charInfoButton_Click(object sender, EventArgs e)
        {
            Navigation(pCharMain, (Button)sender, true);
        }

        private void newCharButton_Click(object sender, EventArgs e)
        {
            Navigation(pNewCharacter, (Button)sender, true);
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            Navigation(pNewUser, (Button)sender, true);
        }

        private void sNPCButton_Click(object sender, EventArgs e)
        {
            SubMenu(subNPCPanel, (Button)sender);
        }

        private void pAddNPCButton_Click(object sender, EventArgs e)
        {
            //Navigation(new pCharInfo(), pAddNPCButton, true);
        }

        private void sPK2Button_Click(object sender, EventArgs e)
        {
            Navigation(pPK2Section, (Button)sender);
        }

        private void pManagmentButton_Click(object sender, EventArgs e)
        {
            //Navigation(pManagement, (Button)sender);
        }

        private void pMobEditorButton_Click(object sender, EventArgs e)
        {
            Navigation(pMobEditor, (Button)sender);
        }
        private void pAboutButton_Click(object sender, EventArgs e)
        {
            Navigation(pAbout, (Button)sender);
        }
        #endregion

        #region Logger
        // change the type to enum instead of number
        // improve the log function and the text log one also
        private static object ListLocker = new object();
        public void writeLog(string msg, int type = 2)
        {
            string mType;
            Color color;
            try
            {
                if (sLogList.InvokeRequired)
                    sLogList.Invoke(new MethodInvoker(delegate
                    {
                        writeLog(msg, type);

                    }));
                else
                {
                    lock (ListLocker)
                    {
                        switch (type)
                        {
                            case 0:
                                color = Color.Red;
                                mType = "[FATAL]";
                                break;
                            case 1:
                                color = Color.DarkOliveGreen;
                                mType = "[NOTIFY]";
                                break;
                            case 2:
                                color = Color.FromArgb(70, 68, 52);
                                mType = "[INFO]";
                                break;
                            default:
                                color = Color.FromArgb(70, 68, 52);
                                mType = "[INFO]";
                                break;
                        }
                        string[] Message = { "", DateTime.Now.ToLongTimeString(), msg };
                        ListViewItem item = new ListViewItem(Message, type);
                        item.ForeColor = color;

                        sLogList.Items.Add(item);
                        sLogList.Items[sLogList.Items.Count - 1].EnsureVisible();
                        sLogList.Columns[sLogList.Columns.Count - 1].Width = -2;
                        // add to text file add file handeling
                        string LogMessage = $"{mType} \t {DateTime.Now} \t {msg}\n";
                        File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "Required/log.txt"), LogMessage);
                        // show message box if Log panel is hidden
                        if (LogHidden)
                            new message(msg).Show();
                        // new alert type
                        //new alert(msg, type);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        private void sLogList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string Selected = sLogList.SelectedItems[0].SubItems[2].Text;
                Clipboard.SetText(Selected);
                new alert("Coppied to the clipboard.", 1);

            }
            catch
            {
                writeLog($"Error while copying to clipboard.", 0);
            }
        }

        private void HeaderPanel_DoubleClick(object sender, EventArgs e)
        {
        }

        private void HeaderPanel_DoubleClick(object sender, MouseEventArgs e)
        {
            this.ResizeButton.PerformClick();
        }
    }
}
