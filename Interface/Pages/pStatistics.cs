using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pStatistics : UserControl
    {
        // Count of items
        // Count of pets
        // count of avatars
        // count of mobs
        // total female and male characters
        // total thief hunter and trader
        // total academy

        #region Declaration

        // Pagination
        int pageNumber = 0;

        // Current Active Button
        Button CurrentButton = null;

        //Queries
        string CurrentQuery = null;

        // Top Characters
        string TopCharactersQuery = string.Format(@"USE {0} 
                            SELECT DISTINCT 
			                _Char.CharName16,
			                _Char.CharID,
			                _Char.CurLevel,
			                SUM (_Items.OptLevel*3)+10 + _Char.CurLevel + count(_RefObjCommon.Codename128) + SUM (_Items.MagParamNum)  AS ItemPoints
			                FROM
			                _Char
			                INNER JOIN _Inventory ON _Char.CharID = _Inventory.CharID
			                INNER JOIN _Items ON _Inventory.ItemID = _Items.ID64
			                INNER JOIN _RefObjCommon ON _Items.RefItemID = _RefObjCommon.ID
			                --WHERE
			                --_RefObjCommon.ReqLevel1 > 100
			                --AND _inventory.Slot between 0 and 12
			                --AND _RefObjCommon.Codename128 like '%RARE%'
			                GROUP BY
			                _Char.CharName16,
			                _Char.CharID,
			                _Char.RefObjID,
			                _Char.CurLevel,
			                _RefObjCommon.ReqLevel1
			                ORDER BY
			                ItemPoints DESC", Common.Config.SR_Shard);

        // Top Guilds
        string TopGuildsQuery = string.Format(@"USE {0} 
                            SELECT  DISTINCT
			                _Guild.Name as Name,Lvl, SUM(_Items.OptLevel) AS ItemPoint ,_Guild.GatheredSP, Count(_GuildMember.GuildID) as Members
			                FROM         
			                _Char INNER JOIN
			                _Inventory ON _Char.CharID = _Inventory.CharID INNER JOIN
			                _Items ON _Inventory.ItemID = _Items.ID64 INNER JOIN
			                _GuildMember ON _Char.CharID = _GuildMember.CharID INNER JOIN
			                _Guild ON _GuildMember.GuildID = _Guild.ID
			                Where _Guild.Name != _char.Charname16 and _Guild.ID != 0
			                AND _inventory.Slot between 1 and 12
			                GROUP BY _Guild.Name, _Guild.GatheredSP,_Guild.Lvl,_Guild.ID
			                Order by SUM(_Items.OptLevel) desc,_Guild.GatheredSP desc", Common.Config.SR_Shard);

        // Top Hunters
        string TopJobQuery = @"USE {0} 
                            SELECT
                            --_CharTrijob.JobType,
                            _Char.CharName16,
                            _CharTrijob.Level,
                            _CharTrijob.Exp
                            FROM
                            _CharTrijob
                            INNER JOIN _Char ON _CharTrijob.CharID = _Char.CharID
                            where _CharTrijob.JobType = {1} and _Char.CurLevel !=1
                            GROUP BY
                            _CharTrijob.JobType,
                            _Char.CharName16,
                            _CharTrijob.Level,
                            _CharTrijob.Exp
                            ORDER BY Exp DESC";

        // Top Academy
        string TopAcademyQuery = string.Format(@"USE {0} 
                            SELECT
                            _Char.CharName16,
                            _Char.CurLevel,
                            _TrainingCamp.GraduateCount
                            FROM
                            _TrainingCampMember
                            INNER JOIN _Char ON _TrainingCampMember.CharID = _Char.CharID 
                            INNER JOIN _TrainingCamp ON _TrainingCampMember.CampID = _TrainingCamp.ID 
                            where _TrainingCamp.GraduateCount != 0
                            GROUP BY
                            _Char.CharName16,
                            _Char.CurLevel,
                            _TrainingCamp.GraduateCount
                            ORDER BY GraduateCount DESC", Common.Config.SR_Shard);

        // Pvp logs query
        string PvpLogsQuery = string.Format(@"USE {0}
                            SELECT 
                            EventTime, 
                            CASE EventID
                                WHEN 19 THEN 'pk'
                                WHEN 20 THEN 'vs'
                                WHEN 101 THEN 'trade'
                            END AS cateogory,
                            CASE 
                                WHEN strDesc LIKE '%Robber%' THEN 'job'
                                WHEN strDesc LIKE '%Trader%' THEN 'job'
                                WHEN strDesc LIKE '%Hunter%' THEN 'job'
                                ELSE 'pvp'
                            END as mode,
                            cnl.CharName16 as Killer,
                            REPLACE(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), ''), RIGHT(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), ''), CHARINDEX(')', REVERSE(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), '')))), '') as Dead,
                            lec.CharID as KillerID,
                            cnl2.CharID as DeadID,
                            CASE 
                                WHEN c.NickName16 = '' THEN '-'
                                ELSE c.Nickname16
                            END as KillerJobName,
                            CASE 
                                WHEN c2.NickName16 = '' THEN '-'
                                ELSE c2.Nickname16
                            END as DeadJobName,
                            c.MaxLevel as KillerLevel,
                            c2.MaxLevel as DeadLevel
                            FROM {0}.dbo._LogEventChar lec
                            LEFT JOIN  {1}.dbo._CharNameList cnl on cnl.CharID = lec.CharID
                            LEFT JOIN {1}.dbo._Char c on c.CharID = lec.CharID
                            LEFT JOIN {1}.dbo._Char c2 on CONVERT(varchar(50), c2.CharName16) COLLATE Latin1_General_CI_AS = REPLACE(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), ''), RIGHT(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), ''), CHARINDEX(')', REVERSE(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), '')))), '') 
                            LEFT JOIN {1}.dbo._CharNameList cnl2 on CONVERT(varchar(50), cnl2.CharName16) COLLATE Latin1_General_CI_AS = REPLACE(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), ''), RIGHT(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), ''), CHARINDEX(')', REVERSE(REPLACE(strDesc, LEFT(strDesc, CHARINDEX('(', strDesc)), '')))), '') 
                            WHERE strDesc IS NOT NULL AND strDesc LIKE '%Neutral, no freebattle team%' AND strDesc NOT LIKE '%Monster%'
                            ORDER BY 1 DESC", Common.Config.SR_ShardLog, Common.Config.SR_Shard);
        #endregion

        #region init
        public pStatistics()
        {
            InitializeComponent();
            StatisticsGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
        }
        #endregion

        #region Form Load
        private async void pStatistics_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                // Load Rank Characters
                int nAccounts = await Common.SqlConnection.RowCount($"SELECT * FROM {Common.Config.SR_Account}..TB_User");
                nAccountsLabel.Text = string.Format("{0:n0}", nAccounts);

                int nChars = await Common.SqlConnection.RowCount($"SELECT * FROM {Common.Config.SR_Shard}.._Char");
                nCharsCount.Text = string.Format("{0:n0}", nChars);

                int nSilks = await Common.SqlConnection.QueryFetchCell<int>($"SELECT SUM (silk_own) as silk_own FROM {Common.Config.SR_Account}..SK_Silk", "silk_own");
                nSilkCount.Text = string.Format("{0:n0}", nSilks);

                long nGold = await Common.SqlConnection.QueryFetchCell<long>($"SELECT SUM (RemainGold) as gold FROM {Common.Config.SR_Shard}.._Char", "gold");
                nGoldCount.Text = string.Format("{0:n0}", nGold);

                //int nSox = await Common.SqlConnection.QueryFetchCell<int>($"SELECT SUM (CurLevel) as sox FROM {Common.Config.SR_Shard}.._Char", "sox");
                //nSoxCount.Text = string.Format("{0:n0}", nSox);

                // Load Top Characters
                bTopCharacter.PerformClick();
            }
            catch (Exception err)
            {
                Common.Dashboard.writeLog($"Error while loading statistics data {err.Message}.", 0);
            }
        }
        #endregion

        #region Rank Navigator
        private async void LoadRank(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                // Top Characters
                case ("Top Characters"):
                    ResetGrid();
                    CurrentQuery = TopCharactersQuery;
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                // Top Guilds
                case ("Top Guilds"):
                    ResetGrid();
                    CurrentQuery = TopGuildsQuery;
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                // Top Traders
                case ("Top Traders"):
                    ResetGrid();
                    CurrentQuery = string.Format(TopJobQuery, Common.Config.SR_Shard, "1");
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                // Top Hunters
                case ("Top Hunters"):
                    ResetGrid();
                    CurrentQuery = string.Format(TopJobQuery, Common.Config.SR_Shard, "3");
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                // Top Thieves
                case ("Top Thieves"):
                    ResetGrid();
                    CurrentQuery = string.Format(TopJobQuery, Common.Config.SR_Shard, "2");
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                // Top Academy
                case ("Top Academy"):
                    ResetGrid();
                    CurrentQuery = TopAcademyQuery;
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                // Pvps Logs
                case ("PVP Logs"):
                    ResetGrid();
                    CurrentQuery = PvpLogsQuery;
                    await UpdateGrid(CurrentQuery, pageNumber);
                    break;

                default:
                    new message("Invalid rank button has been clicked.").Show();
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
        #endregion

        #region Grid view
        private async Task UpdateGrid(string query, int pageNumber)
        {
            try
            {
                paginationLabel.Enabled = false;
                if (query == null)
                {
                    new message("Invalid query couldn't load the data grid.").Show();
                    return;
                }
                DataTable results = await Common.SqlConnection.GetDataSet(query + $" OFFSET { pageNumber * 50} ROWS FETCH NEXT 50 ROWS ONLY" );
                if (results.Columns.Count < 6)
                    StatisticsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                else
                    StatisticsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                StatisticsGrid.DataSource = results;
                StatisticsGrid.ClearSelection();
                paginationLabel.Enabled = true;
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading statistics data grid: " + error.Message, 0);
            }
        }
        private void ResetGrid()
        {
            pageNumber = 0;
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            nextPage.Enabled = true;
            paginationLabel.Visible = true;
        }

        private async void nextPage_Click(object sender, EventArgs e)
        {
            pageNumber += 1;
            await UpdateGrid(CurrentQuery, pageNumber);
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            if (StatisticsGrid.Rows.Count == 0)
            {
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = false;
            }
        }

        private async void previousPage_Click(object sender, EventArgs e)
        {
            if (pageNumber > 0)
            {
                pageNumber -= 1;
                await UpdateGrid(CurrentQuery, pageNumber);
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = true;
            }
        }
        #endregion
    }
}
