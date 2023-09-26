using System;
using System.Drawing;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pConnection : UserControl
    {
        public pConnection()
        {
            InitializeComponent();
        }

        private async void sqlConnectBtn_ClickAsync(object sender, EventArgs e)
        {
            // disable button after click
            sqlConnectBtn.Enabled = false;

            // update config
            Common.ConfigController.UpdateDBConfig(tHost.Text, tUser.Text, tPassword.Text, tDatabaseAccount.Text, tDatabaseShard.Text, tDatabaseLog.Text);

            // do this part inside the sql class
            Common.SqlConnection = new SQL(Common.Config.Host, Common.Config.User, Common.Config.Password, Common.Config.SR_Account);

            if (await Common.SqlConnection.Connect())
            {
                sConnectionPanel.Enabled = false;
                ConnectionLabel.ForeColor = Color.DarkOliveGreen;
                ConnectionLabel.Text = "Connected";
                sqlConnectBtn.Visible = false;
                sqlDisconnectBtn.Visible = true; // show disconnect button
                Common.Dashboard.queryWindowButton.Enabled = true;
                Common.Dashboard.pNavButtons.Enabled = true;
                Common.Dashboard.pNavButtons.Visible = true;
                // redirect to statistics spage after login
                Common.Dashboard.pStatisticsButton.PerformClick();
                Common.Dashboard.writeLog("SQL Connection made successfully!", 1);
                new alert("Connection has been made.");
            }
            sqlConnectBtn.Enabled = true; // enable button when done

        }

        private void sqlDisconnectBtn_Click(object sender, EventArgs e)
        {
            sqlDisconnectBtn.Enabled = false; // disable button after click
            Common.SqlConnection.Disconnect();
            sConnectionPanel.Enabled = true;
            Common.Dashboard.queryWindowButton.Enabled = false;
            Common.Dashboard.pNavButtons.Enabled = false;
            sqlConnectBtn.Visible = true;
            sqlDisconnectBtn.Visible = false;
            Common.Dashboard.CloseQueryWindow();
            ConnectionLabel.ForeColor = Color.DarkRed;
            ConnectionLabel.Text = "Disconnected";
            Common.Dashboard.writeLog( "SQL Connection closed!");
            sqlDisconnectBtn.Enabled = true; // enable button when done
        }

        private void pConnection_Load(object sender, EventArgs e)
        {
            // delete those two lines later
            Common.Dashboard.pNavButtons.Enabled = true;
            Common.Dashboard.pNavButtons.Visible = true;

            try
            {
                if (Common.Config != null)
                {
                    tHost.Text = Common.Config.Host;
                    tUser.Text = Common.Config.User;
                    tPassword.Text = Common.Config.Password;
                    tDatabaseAccount.Text = Common.Config.SR_Account;
                    tDatabaseShard.Text = Common.Config.SR_Shard;
                    tDatabaseLog.Text = Common.Config.SR_ShardLog;
                }
            } catch { }
        }
    }
}
