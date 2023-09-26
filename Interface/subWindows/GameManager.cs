using System;
using System.Collections.Generic;

using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class GameManager : Form
    {
        // TODO
        // Modules list
        // Add spin box for module Delay time
        // Add client part
        // Add drag drop

        private string[] ServerModules = {
                "MiniBillingServer.exe",
                "CertificationServer.exe",
                "GlobalManager.exe",
                "MachineManager.exe",
                "DownloadServer.exe",
                "FarmManager.exe",
                "GatewayServer.exe",
                "AgentServer.exe",
                "SR_ShardManager.exe",
                "SR_GameServer.exe",
                //"SMC.exe"
            };
        // Server path
        private string ServerFilesPath = "D:/disk/Games/Silkroad/SRO Server files/Server files/Stable server files/";//null;
        // Client Path
        private string ClientPath = "D:/disk/Games/Silkroad/SRO Server files/Client/";//null;

        public GameManager()
        {
            InitializeComponent();
            CheckModules();
            bShowModules.MouseHover += ToolTip;
            bHideModules.MouseHover += ToolTip;
            openDirectory.MouseHover += ToolTip;
            StartServer.MouseHover += ToolTip;
            CloseServer.MouseHover += ToolTip;
        }

        private void ToolTip(object sender, EventArgs e)
        {
            string Text = (sender as Button).Tag.ToString() != String.Empty ? (sender as Button).Tag.ToString() : "empty";
            toolTip.Show(Text, (Button)sender);
            toolTip.OwnerDraw = true;
            toolTip.ForeColor = Color.White;
            toolTip.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        #region NavBar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Exit app button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region ServerFiles Section

        #region ServerModule Buttons

        #region Server misc

        // Select server path
        private void FServerPathButton_Click(object sender, EventArgs e)
        {
            using (var FolderDialogServer = new FolderBrowserDialog())
            {
                DialogResult result = FolderDialogServer.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderDialogServer.SelectedPath))
                {
                    ServerFilesPath = FolderDialogServer.SelectedPath;
                    tServerPath.Text = FolderDialogServer.SelectedPath;
                }
            }
        }

        private void OpenDirectory_Click(object sender, EventArgs e)
        {
            if (ServerFilesPath != null)
            {
                if (Directory.Exists(ServerFilesPath))
                {
                    try
                    {
                        Process.Start(ServerFilesPath);
                    }
                    catch { }
                }
                else
                {
                    Common.Dashboard.writeLog("Server file directory is not found!");
                }
            }
            else
            {
                Common.Dashboard.writeLog("No server directory path has been selected!");
            }
        }

        // Modules Auto Detection
        private void CheckAutoDetect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAutoDetect.Checked)
            {
                ModulesTimer.Enabled = true;
            }
            else
            {
                ModulesTimer.Enabled = false;
            }
        }

        private void ModulesTimer_Tick(object sender, EventArgs e)
        {
            if (checkAutoDetect.Checked)
            {
                CheckModules();
            }
        }
        #endregion

        #region Start - Close Modules
        private async void FModuleButton(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            string ModuleName = (sender as Button).Name.Substring(1) + ".exe";

            if (IsModuleRunning(ModuleName))
            {
                if (await CloseModule(ModuleName))
                {
                    UpdateModuleDetails(ModuleName, false);
                }
            }
            else
            {
                string arguement = ModuleName == "CertificationServer.exe" ? "packt.dat" : null;
                if (await StartModule(ModuleName, 1, arguement))
                {
                    UpdateModuleDetails(ModuleName, true);
                }
            }
            (sender as Button).Enabled = true;
        }

        // Start all server modules
        private async void StartServer_Click(object sender, EventArgs e)
        {
            StartServer.Enabled = false;
            if (ServerFilesPath != null)
            {
                foreach (string ModuleName in ServerModules)
                {
                    string arguement = ModuleName == "CertificationServer.exe" ? "packt.dat" : null;
                    int Delay = ModuleName == "SMC.exe" ? 60 : 1;
                    if (await StartModule(ModuleName, Delay, arguement))
                    {
                        UpdateModuleDetails(ModuleName, true);
                    }
                }
            }
            else
            {
                Common.Dashboard.writeLog("No server directory path has been selected!");
            }
            StartServer.Enabled = true;
        }

        // Close all server
        private async void CloseServer_Click(object sender, EventArgs e)
        {
            CloseServer.Enabled = false;
            foreach (string ModuleName in ServerModules)
            {
                if (await CloseModule(ModuleName))
                {
                    UpdateModuleDetails(ModuleName, false);
                }
            }
            CloseServer.Enabled = true;
        }
        #endregion

        #region Moduls Visibility
        //Initialization
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        private void BModuleVisibility(object sender, EventArgs e)
        {
            // button image
            string ImageSrc = $"C:/Users/Mohamed/source/repos/DatabaseManagerDesign/DatabaseManagerDesign/Resources/UI-icons/";
            // module name
            string ModuleName = (sender as Button).Name.Substring(1);
            IntPtr window = FindWindow((string)null, ModuleName);
            if (IsModuleRunning(ModuleName + ".exe") && (window != IntPtr.Zero))
            {
                if (IsWindowVisible(window)) //hide
                {
                    ShowWindow(window.ToInt32(), SW_HIDE);
                    ImageSrc = ImageSrc + "icon-show-b.png";
                }
                else //show
                {
                    ShowWindow(window.ToInt32(), SW_SHOW);
                    ImageSrc = ImageSrc + "icon-hide-b.png";
                }
                // Update icon
                try
                {
                    (sender as Button).Image = Image.FromFile(ImageSrc);
                }
                catch { }
            }
        }

        private void HideAllModules(object sender, EventArgs e)
        {
            bHideModules.Enabled = false;
            foreach (string Module in ServerModules)
            {
                IntPtr window = FindWindow((string)null, Module.Remove(Module.Length - 4));
                ShowWindow(window.ToInt32(), SW_HIDE);
            }
            bHideModules.Enabled = true;
        }

        private void ShowAllModules(object sender, EventArgs e)
        {
            bShowModules.Enabled = false;
            foreach (string Module in ServerModules)
            {
                IntPtr window = FindWindow((string)null, Module.Remove(Module.Length - 4));
                ShowWindow(window.ToInt32(), SW_SHOW);
            }
            bShowModules.Enabled = true;
        }
        #endregion

        #endregion

        #region Server functions
        private void UpdateModuleDetails(string ModuleName, bool Status)
        {
            Color ButtonColor = Status ? Color.DarkOliveGreen : Color.DarkRed;

            string sImageSrc = Directory.GetCurrentDirectory() + "/Resources/UI-icons/";
            sImageSrc = Status ? sImageSrc + "icon-pause-b.png" : sImageSrc + "icon-start-b.png";
            // update Visibilty button
            if (!Status)
                UpdateModuleVisibility(ModuleName, false);

            switch (ModuleName)
            {
                case "MiniBillingServer.exe":
                    lBilling.BackColor = ButtonColor;
                    bMiniBillingServer.Image = Image.FromFile(sImageSrc);
                    break;
                case "CertificationServer.exe":
                    lCerttification.BackColor = ButtonColor;
                    bCertificationServer.Image = Image.FromFile(sImageSrc);
                    break;
                case "GlobalManager.exe":
                    lGlobal.BackColor = ButtonColor;
                    bGlobalManager.Image = Image.FromFile(sImageSrc);
                    break;
                case "MachineManager.exe":
                    lMachine.BackColor = ButtonColor;
                    bMachineManager.Image = Image.FromFile(sImageSrc);
                    break;
                case "DownloadServer.exe":
                    lDownload.BackColor = ButtonColor;
                    bDownloadServer.Image = Image.FromFile(sImageSrc);
                    break;
                case "FarmManager.exe":
                    lFarm.BackColor = ButtonColor;
                    bFarmManager.Image = Image.FromFile(sImageSrc);
                    break;
                case "GatewayServer.exe":
                    lGateway.BackColor = ButtonColor;
                    bGatewayServer.Image = Image.FromFile(sImageSrc);
                    break;
                case "AgentServer.exe":
                    lAgent.BackColor = ButtonColor;
                    bAgentServer.Image = Image.FromFile(sImageSrc);
                    break;
                case "SR_ShardManager.exe":
                    lShard.BackColor = ButtonColor;
                    bSR_ShardManager.Image = Image.FromFile(sImageSrc);
                    break;
                case "SR_GameServer.exe":
                    lGameServer.BackColor = ButtonColor;
                    bSR_GameServer.Image = Image.FromFile(sImageSrc);
                    break;
                case "SMC.exe":
                    lSMC.BackColor = ButtonColor;
                    bSMC.Image = Image.FromFile(sImageSrc);
                    break;
            }
        }
        private void UpdateModuleVisibility(string ModuleName, bool Status)
        {
            string hImageSrc = Directory.GetCurrentDirectory() + "/Resources/UI-icons/";
            hImageSrc = Status ? hImageSrc + "icon-show-b.png" : hImageSrc + "icon-hide-b.png";

            switch (ModuleName)
            {
                case "MiniBillingServer.exe":
                    hMiniBillingServer.Image = Image.FromFile(hImageSrc);
                    break;
                case "CertificationServer.exe":
                    hCertificationServer.Image = Image.FromFile(hImageSrc);
                    break;
                case "GlobalManager.exe":
                    hGlobalManager.Image = Image.FromFile(hImageSrc);
                    break;
                case "MachineManager.exe":
                    hMachineManager.Image = Image.FromFile(hImageSrc);
                    break;
                case "DownloadServer.exe":
                    hDownloadServer.Image = Image.FromFile(hImageSrc);
                    break;
                case "FarmManager.exe":
                    hFarmManager.Image = Image.FromFile(hImageSrc);
                    break;
                case "GatewayServer.exe":
                    hGatewayServer.Image = Image.FromFile(hImageSrc);
                    break;
                case "AgentServer.exe":
                    hAgentServer.Image = Image.FromFile(hImageSrc);
                    break;
                case "SR_ShardManager.exe":
                    hSR_ShardManager.Image = Image.FromFile(hImageSrc);
                    break;
                case "SR_GameServer.exe":
                    hSR_GameServer.Image = Image.FromFile(hImageSrc);
                    break;
                case "SMC.exe":
                    //hSMC.Image = Image.FromFile(hImageSrc);
                    break;
            }
        }

        private async Task<bool> StartModule(string ModuleName, int Delay = 1, string argument = null)
        {
            //ModuleName = "CertificationServer.exe";
            //ServerFilesPath = "D:/disk/Games/Silkroad/SRO Server files/Server files/Stable server files/";
            if (ServerFilesPath != null)
            {
                if (File.Exists($"{ServerFilesPath}//{ModuleName}"))
                {
                    try
                    {
                        if (!IsModuleRunning(ModuleName))
                        {
                            ProcessStartInfo processInfo = new ProcessStartInfo
                            {
                                FileName = ModuleName,
                                WorkingDirectory = ServerFilesPath
                            };
                            // arguement
                            if (argument != null)
                                processInfo.Arguments = argument;
                            // Hide apps on running
                            if (cHideModules.Checked)
                                processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            Process.Start(processInfo);
                            await Task.Delay(Delay * 1000);
                            return true;
                        }
                        else // Module is already opened
                        {
                            //check this part
                            DialogResult ModuleDialog = MessageBox.Show(
                                "Do you want to re-run it?",
                                $"{ModuleName} is already running",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                             );
                            if (ModuleDialog == DialogResult.Yes) // reopen the module
                            {
                                await CloseModule(ModuleName);
                                await StartModule(ModuleName);
                            }
                        }
                        return true;
                    }
                    catch
                    {
                        Common.Dashboard.writeLog($"Error while opening {ModuleName}!", 0);
                    }
                }
                else
                {
                    Common.Dashboard.writeLog(($"{ModuleName} is not found!"));
                }
            }
            else
            {
                Common.Dashboard.writeLog("No server directory path has been selected!");
            }
            return false;
        }

        private async Task<bool> CloseModule(string ModuleName, int Delay = 1)
        {
            // subtract .exe from module name
            ModuleName = ModuleName.Remove(ModuleName.Length - 4);
            Process[] ModuleProcesses = Process.GetProcessesByName(ModuleName);

            if (ModuleProcesses.Length > 0)
            {
                try
                {
                    foreach (Process process in ModuleProcesses)
                    {
                        process.Kill();
                    }
                    await Task.Delay(Delay * 1000);
                }
                catch
                {
                    Common.Dashboard.writeLog($"Error while closing {ModuleName}!", 0);
                }
            }
            else
            {
                Common.Dashboard.writeLog(($"{ModuleName} was not running!"));
            }

            return true;
        }

        private bool IsModuleRunning(string ModuleName)
        {
            // subtract .exe from module name
            ModuleName = ModuleName.Remove(ModuleName.Length - 4);
            Process[] ModuleProcesses = Process.GetProcessesByName(ModuleName);

            if (ModuleProcesses.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void CheckModules()
        {
            foreach (string Module in ServerModules)
            {
                if (IsModuleRunning(Module))
                {
                    UpdateModuleDetails(Module, true);
                    // Visibility part
                    IntPtr window = FindWindow((string)null, Module.Remove(Module.Length - 4));
                    if (IsWindowVisible(window))
                    {
                        UpdateModuleVisibility(Module, false);
                    }
                    else
                    {
                        UpdateModuleVisibility(Module, true);
                    }
                }
                else
                {
                    UpdateModuleDetails(Module, false);
                    UpdateModuleVisibility(Module, false);
                }
            }
        }
        #endregion

        #endregion

        #region Client Section
        private async void bStartClient_Click(object sender, EventArgs e)
        {
            await StartClient("silkroad.exe");
        }
        private async Task<bool> StartClient(string ClientName, int Delay = 1, string argument = null)
        {
            if (ClientPath != null)
            {
                if (File.Exists($"{ClientPath}//{ClientName}"))
                {
                    try
                    {
                        ProcessStartInfo processInfo = new ProcessStartInfo
                        {
                            FileName = ClientName,
                            WorkingDirectory = ClientPath
                        };
                        // arguement
                        if (argument != null)
                            processInfo.Arguments = argument;
                        Process.Start(processInfo);
                        await Task.Delay(Delay * 1000);
                        return true;
                    }
                    catch
                    {
                        Common.Dashboard.writeLog($"Error while opening {ClientName}!", 0);
                    }
                }
                else
                {
                    Common.Dashboard.writeLog(($"{ClientName} is not found!"));
                }
            }
            else
            {
                Common.Dashboard.writeLog("No server directory path has been selected!");
            }
            return false;
        }
        #endregion

        // filter button
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "MOFilter.exe",
                    WorkingDirectory = @"D:\disk\Games\Visual Studio Projects\MOFilter\MOFilter\bin\Debug\"
                };
                Process.Start(processInfo);
            }
            catch
            {
                Common.Dashboard.writeLog($"Error while opening filter");
            }

        }

        private void bSMC_Click(object sender, EventArgs e)
        {
            if (Common.SMCController == null)
                Common.SMCController = new SMCController();
            else
            {
                Common.SMCController.Stop();
                Common.SMCController = new SMCController();
            }

            if (Common.SMCController.Start(tIPBox.Text, tPortBox.Text, tUserBox.Text, tPassBox.Text))
            {
                lSMC.BackColor = Color.DarkOliveGreen;
                Common.Dashboard.writeLog($"[SMC] the server is online.", 1);
                Common.SMCController.Stop();
            }
            else
            {
                lSMC.BackColor = Color.DarkRed;
            }
        }
    }

}
