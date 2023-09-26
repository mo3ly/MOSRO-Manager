using System;
using System.Drawing;
using System.Windows.Forms;

namespace MOSROManager
{
    // TODO
    // add all silk items in Silk page
    // Logic C# files that handles database an query stuff for the characters
    // Read Character messages

    public partial class pCharMain : UserControl
    {
        private string CharName;
        UserControl CurrentTab = null;
        Button CurrentButton = null;
        // Load tabs every time loads character
        pCharInformation pCharInformation;
        pCharInventory pCharInventory;
        pCharStorage pCharStorage;

        public pCharMain()
        {
            InitializeComponent();
        }
       
        // Search
        private async void SearchChar_ClickAsync(object sender, EventArgs e)
        {
            if (CharBox.Text.Length >= 2)
            {
                int CharaterReader = await Common.SqlConnection.RowCount($"SELECT top 1 CharName16 FROM {Common.Config.SR_Shard}.._Char Where CharName16 = '{CharBox.Text.ToString()}'");
                //MessageBox.Show(CharName);
                if (CharaterReader > 0)
                {
                    this.CharName = CharBox.Text.ToString();
                    CharLabel.Text = CharName;
                    Common.Dashboard.writeLog($"{CharBox.Text.ToString()}'s information has been loaded.", 1);
                    // load labs for the new character
                    if (pCharInformation != null && pCharInventory != null && pCharStorage != null)
                    {
                        pCharInformation.Dispose();
                        pCharInventory.Dispose();
                        pCharStorage.Dispose();
                    }
                    pCharInformation = new pCharInformation(CharName);
                    pCharInventory = new pCharInventory(CharName);
                    pCharStorage = new pCharStorage(CharName);
                    tabButtonsPanel.Enabled = true;
                    bCharacter.PerformClick();
                }
                else
                {
                    tabButtonsPanel.Enabled = false;
                    CharLabel.Text = "Invalid Character";
                    Content.Controls.Clear();
                    Common.Dashboard.writeLog($"Character {CharName} is not found.");
                }
            }
            else
                Common.Dashboard.writeLog($"Character length must be more than 2.");
        }

        private void tabNavigator(object sender, EventArgs e)
        {
            CharName = CharBox.Text;
            switch ((sender as Button).Text)
            {
                case "Information":
                    Tab(pCharInformation);
                    break;
                case "Inventory":
                    Tab(pCharInventory);
                    break;
                case "Storage":
                    Tab(pCharStorage);
                    break;
                default:
                    Common.Dashboard.writeLog("Invalid tab navigation.", 0);
                    break;
            }

            // Change button color for the clicked one
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(31, 31, 31);
            }
            CurrentButton = (sender as Button);
            (sender as Button).BackColor = Color.DarkKhaki;
        }

        private void Tab(UserControl tabPage)
        {
            CurrentTab = tabPage;
            UserControl Page = tabPage;
            Content.Controls.Clear();
            Content.Controls.Add(Page);
            Page.Show();
        }

    }
}
