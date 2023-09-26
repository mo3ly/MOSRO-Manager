using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    // For model box, just put the allowed male and female and euro china change the box values based on the selection
    // position different from euro and china, add region id and world it // make it easier maybe and use select box with be setted location
    public partial class pNewCharacter : UserControl
    {
        private string User = null;

        public pNewCharacter()
        {
            InitializeComponent();
        }

        private async void pNewCharacter_Load(object sender, EventArgs e)
        {
            await UsernameToGrid();
        }

        private async Task UsernameToGrid(string Username = null)
        {
            try
            {
                // JID | Username | Characters linked to it
                StringBuilder query = new StringBuilder();
                query.Append($"SELECT TOP 20 TB_User.JID, TB_User.StrUserID as UserID, COUNT({Common.Config.SR_Shard}.._AccountJID.JID) as Chars ");
                query.Append($"FROM  {Common.Config.SR_Account}..TB_User INNER JOIN {Common.Config.SR_Shard}.._AccountJID ON TB_User.JID = _AccountJID.JID ");
                query.Append($"WHERE StrUserID like '%{Username}%' ");
                query.Append("Group by TB_User.JID, TB_User.StrUserID ORDER BY JID");
                DataTable results = await Common.SqlConnection.GetDataSet(query.ToString());
                UsernamesGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
                UsernamesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                UsernamesGrid.DataSource = results;
                UsernamesGrid.ClearSelection();
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading usernames: " + error.Message, 0);
            }
        }
        //exec SRO_VT_SHARD.._AddNewChar parameters //--creation query
        private async void bSearchMob_Click(object sender, EventArgs e)
        {
            await UsernameToGrid(tCharSearch.Text);
        }


        private void UsernamesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                User = UsernamesGrid.SelectedRows[0].Cells[1].Value.ToString();
                UserLabel.Text = "Selected User: " + User;
                if (Convert.ToInt32(UsernamesGrid.SelectedRows[0].Cells[2].Value) == 4)
                {
                    ErrorLabel.Visible = true;
                    nCharLabel.Enabled = false;
                } else
                {
                    ErrorLabel.Visible = false;
                    //nCharLabel.Enabled = true;
                }
            }
            catch { }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // create validation
            Common.Dashboard.writeLog($"Character [name] created to \"{User}\" successfully!", 1);
        }
    }
}
