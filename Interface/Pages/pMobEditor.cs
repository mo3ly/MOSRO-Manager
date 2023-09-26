using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pMobEditor : UserControl
    {
        private int pageNumber = 0;

        public pMobEditor()
        {
            InitializeComponent();
        }

        private async void pMobEditor_Load(object sender, EventArgs e)
        {
            pageNumber = 0;
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            nextPage.Enabled = true;
            await MobsToGrid(pageNumber);
            paginationLabel.Visible = true;
        }
        // to do select row
        private async Task MobsToGrid(int pageNumber, string likeMob = null)
        {
            paginationLabel.Enabled = false;
            try
            {
                string Query = @"USE {2}
                                SELECT d.CodeName128 AS 'Monster Code', e.Lvl AS 'Level', SUM(a.dwMaxTotalCount) AS 'Max Spawn', 
                                e.MaxHP as 'HP', e.MaxMP as 'MP'
                                FROM Tab_RefNest a
                                INNER JOIN Tab_RefTactics b ON a.dwTacticsID = b.dwTacticsID
                                JOIN Tab_RefHive c ON a.dwHiveID = c.dwHiveID
                                JOIN _RefObjCommon d ON b.dwObjID = d.ID
                                JOIN _RefObjChar e ON d.Link = e.ID
                                JOIN _RefRegion f ON a.nRegionDBID = f.wRegionID
                                WHERE d.Rarity IN(0,3,6,8)--Only select Regular and Elite, add 3,8 for uniques
                                AND f.ContinentName NOT LIKE 'GOD_TOGUI'-- Not including FGW monsters
                                AND(d.[Service] = 1 AND d.Codename128 LIKE 'MOB_%{0}%' AND d.Codename128 NOT LIKE 'MOB_GOD_%')-- Not including FGW monsters
                                GROUP BY d.CodeName128, e.Lvl, d.Rarity, e.MaxHP, e.MaxMP ORDER BY e.Lvl ASC, 
                                1 OFFSET {1} ROWS FETCH NEXT 20 ROWS ONLY";
                Query = string.Format(Query, likeMob, (pageNumber * 20),  Common.Config.SR_Shard);
                DataTable results = await Common.SqlConnection.GetDataSet(Query);
                MobsGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                MobsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MobsGrid.DataSource = results;
                RowsCountNumber.Text = (MobsGrid.Rows.Count).ToString();
                MobsGrid.ClearSelection();
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading mobs: " + error.Message, 0);
            }
            paginationLabel.Enabled = true;
        }

        private async void nextPage_Click(object sender, EventArgs e)
        {
            pageNumber += 1;
            await MobsToGrid(pageNumber);
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            if (MobsGrid.Rows.Count == 0)
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
                await MobsToGrid(pageNumber);
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = true;
            }
        }

        private async void bSearchMob_Click(object sender, EventArgs e)
        {
            pageNumber = 0;
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            nextPage.Enabled = true;
            await MobsToGrid(pageNumber, tMobSearch.Text);
            paginationLabel.Visible = true;
        }

        private void MobsGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in MobsGrid.SelectedRows)
            {
                mobCode128.Text = row.Cells[0].Value.ToString();
                mobLevel.Text = row.Cells[1].Value.ToString();
                mobMaxSpawn.Text = row.Cells[2].Value.ToString();
                mobHP.Text = row.Cells[3].Value.ToString();
                mobMP.Text = row.Cells[4].Value.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Common.Dashboard.writeLog("Data has beed updated successfully!", 1);
        }
    }
}
