using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pCharacters : UserControl
    {
        private int pageNumber = 0;
        private int selectedCharID = 0;

        public pCharacters()
        {
            InitializeComponent();
            CharactersGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
        }

        private async void pCharacters_Load(object sender, EventArgs e)
        {
            pageNumber = 0;
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            nextPage.Enabled = true;
            paginationLabel.Visible = true;
            await CharactersToGrid(pageNumber);
            try
            {
                int totalChars = await Common.SqlConnection.RowCount($"SELECT * FROM {Common.Config.SR_Shard}.._Char");
                RowsCountNumber.Text = totalChars.ToString();
            } catch { }
        }


        private async Task CharactersToGrid(int pageNumber, string CharName = null)
        {
            paginationLabel.Enabled = false;
            try
            {
                // Link it with user ID and JID and account name
                // show image and race and thief hunter trader
                string Query = @"USE {2} SELECT * FROM _Char WHERE CharName16 like '%{0}%' ORDER BY 1 OFFSET {1} ROWS FETCH NEXT 20 ROWS ONLY";
                Query = string.Format(Query, CharName, (pageNumber * 20), Common.Config.SR_Shard);
                DataTable results = await Common.SqlConnection.GetDataSet(Query);
                //DataGridViewImageColumn img = new DataGridViewImageColumn();
                //Image image = Image.FromFile($"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Characters/14875.gif");
                //img.Image = image;
                //CharactersGrid.Columns.Add(img);
                //img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //img.HeaderText = "";
                //img.Name = "img";

                CharactersGrid.DataSource = results;
                //CharactersGrid.ClearSelection();
                EditGroup.Enabled = true;
                SaveButton.Enabled = true;
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading characters: " + error.Message, 0);
                EditGroup.Enabled = false;
                SaveButton.Enabled = false;
            }
            paginationLabel.Enabled = true;
        }

        private async void nextPage_Click(object sender, EventArgs e)
        {
            pageNumber += 1;
            await CharactersToGrid(pageNumber);
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            if (CharactersGrid.Rows.Count == 0)
            {
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = false;
                //previousPage.PerformClick();
            }
        }

        private async void previousPage_Click(object sender, EventArgs e)
        {
            if (pageNumber > 0)
            {
                pageNumber -= 1;
                await CharactersToGrid(pageNumber);
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = true;
            }
        }

        private async void bSearchMob_Click(object sender, EventArgs e)
        {
            pageNumber = 0;
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            nextPage.Enabled = true;
            await CharactersToGrid(pageNumber, tCharSearch.Text);
            paginationLabel.Visible = true;
        }

        private void CharctersGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CharactersGrid.SelectedRows)
            {
                selectedCharID = int.Parse(row.Cells[0].Value.ToString());
                tCharName16.Text = row.Cells[3].Value.ToString();
                tNickName.Text = row.Cells[4].Value.ToString();
                tStr.Text = row.Cells[10].Value.ToString();
                tInt.Text = row.Cells[11].Value.ToString();
                tHP.Text = row.Cells[17].Value.ToString();
                tMP.Text = row.Cells[18].Value.ToString();
                tHwanLevel.Text = row.Cells[51].Value.ToString();
                tHwanCount.Value =  int.Parse(row.Cells[15].Value.ToString());
                tInventorySize.Value = int.Parse(row.Cells[25].Value.ToString());
                cDeleted.Checked = int.Parse(row.Cells[1].Value.ToString()) != 0;
                tDailyPK.Text = row.Cells[26].Value.ToString();
                tTotalPK.Text = row.Cells[27].Value.ToString();
                tGold.Text = row.Cells[12].Value.ToString();
                tLevel.Text = row.Cells[6].Value.ToString();
                tSkillPoints.Text = row.Cells[13].Value.ToString();
                tStatePoints.Text = row.Cells[14].Value.ToString();
            }
            EditGroup.Enabled = true;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            new dialog("Update character data?", "Are you sure you want to update this character data?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                //int isNameFound = await Common.SqlConnection.RowCount($"SELECT TOP 1 CharName16 FROM {Common.Config.SR_Shard}.._Char Where CharName16 = '{tCharName16.Text}'");
                //if (isNameFound == 0)
                //{
                    string query = @"UPDATE {0}.._Char SET 
                                    Deleted = '{1}',
                                    CharName16 = '{2}',
                                    NickName16 = '{3}',
                                    CurLevel = '{4}',
                                    HP = '{5}',
                                    MP = '{6}',
                                    Strength = '{7}',
                                    Intellect = '{8}',
                                    RemainSkillPoint = '{9}',
                                    RemainStatPoint = '{10}',
                                    InventorySize = '{11}',
                                    RemainHwanCount = '{12}',
                                    HwanLevel = '{13}',
                                    DailyPK = '{14}',
                                    TotalPK = '{15}'
                                    WHERE CharID = {16}";

                    await Common.SqlConnection.ExecuteNonQuery(query, Common.Config.SR_Shard,
                                   (cDeleted.Checked ? 1 : 0),
                                   tCharName16.Text,
                                   tNickName.Text,
                                   tLevel.Text,
                                   tHP.Text,
                                   tMP.Text,
                                   tStr.Text,
                                   tInt.Text,
                                   tSkillPoints.Text,
                                   tStatePoints.Text,
                                   tInventorySize.Text,
                                   tHwanCount.Text,
                                   tHwanLevel.Text,
                                   tDailyPK.Text,
                                   tTotalPK.Text,
                                   selectedCharID);
                    Common.Dashboard.writeLog("Data has beed updated successfully!", 1);
                //} 
                //else
                //{
                    //Common.Dashboard.writeLog("Cannot update the data because this character name is already used!");
                //}
            }
        }

        private void CharactersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string PressedChar = CharactersGrid.SelectedRows[0].Cells[3].Value.ToString();
                if (PressedChar != null)
                {
                    if (Common.Dashboard.subCharacterPanel.Visible == true)
                    {
                        Common.Dashboard.charInfoButton.PerformClick();
                        Common.Dashboard.pCharMain.CharBox.Text = PressedChar;
                        Common.Dashboard.pCharMain.SearchChar.PerformClick();

                    }
                    else
                    {
                        Common.Dashboard.sCharacterButton.PerformClick();
                        Common.Dashboard.charInfoButton.PerformClick();
                        Common.Dashboard.pCharMain.CharBox.Text = PressedChar;
                        Common.Dashboard.pCharMain.SearchChar.PerformClick();
                    }
                    Common.Dashboard.writeLog($"Navigated to {PressedChar}'s information page.");
                }
            }
            catch { }
        }
    }
}
