using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MOSROManager
{
    //TODO 
    // item on hover show tooltip
    // on click ask to delete item
    // Check perofrmance issue
    // Try to get max stuck in items query
    // Try not to load items every time
    // maybe the lag is because of the images so try to find a way to reduce it

    public partial class pCharInformation : UserControl
    {
        // Charname
        private readonly string CharName = null;
        // Store character row
        private SqlDataReader CharRow;
        // Gears query
        string GearsQuery = @"USE {0}
                                SELECT 
                                it.[ID64] ,oc.[ID] ,oc.[CodeName128] ,it.[OptLevel] ,it.[Variance] ,it.[Data] ,ch.[CharName16] 
                                ,iv.[Slot] InvoSlot ,oc.[AssocFileIcon128]
                                FROM [dbo].[_Items] AS it
                                LEFT JOIN [dbo].[_RefObjCommon] oc ON oc.ID = it.RefItemID
                                LEFT JOIN [dbo].[_Inventory] iv ON iv.[ItemID] = it.[ID64]
                                LEFT JOIN [dbo].[_Char] ch on ch.[CharID] = iv.[CharID]
                                WHERE  ch.CharID = {1} and Slot in(0,1,2,3,4,5,6,7,9,10,11,12) ORDER BY 
                                (CASE Slot
                                WHEN 7 THEN 2
                                WHEN 6 THEN 1
                                WHEN 2 THEN 4
                                WHEN 0 THEN 3
                                WHEN 3 THEN 6
                                WHEN 1 THEN 5
                                WHEN 5 THEN 8
                                WHEN 4 THEN 7
                                WHEN 9 THEN 10
                                WHEN 10 THEN 9
                                WHEN 12 THEN 12
                                WHEN 11 THEN 11
                                ELSE 100 END)";
        // Avatars Query
        string AvatarQuery = @"USE {0}
                            SELECT 
                            it.[ID64] ,oc.[ID] ,oc.[CodeName128] ,it.[OptLevel] ,it.[Variance] ,it.[Data] ,ch.[CharName16] 
                            ,ava.[Slot] InvoSlot ,oc.[AssocFileIcon128]
                            FROM [dbo].[_Items] AS it
                            LEFT JOIN [dbo].[_RefObjCommon] oc ON oc.ID = it.RefItemID
                            LEFT JOIN [dbo].[_InventoryForAvatar] ava ON ava.[ItemID] = it.[ID64]
                            LEFT JOIN [dbo].[_Char] ch on ch.[CharID] = ava.[CharID]
                            WHERE  ch.CharID = {1} and Slot in(0,1,2,3,4)";
        // Stuck Query
        string StuckQuery = @"USE {0}
                            SELECT TOP 1  it.Data , item.MaxStack
                            from _Items as it
                            LEFT JOIN _Inventory as inv ON it.ID64 = inv.ItemID
                            LEFT JOIN _RefObjCommon as obj ON it.RefItemID = obj.ID
                            LEFT JOIN _RefObjItem as item ON obj.Link = item.ID
                            where ID64 = {1}";

        public pCharInformation(string CharName)
        {
            InitializeComponent();
            this.CharName = CharName;
        }

        private async void pCharInformation_Load(object sender, EventArgs e)
        {
            // overlay
            overlay overlay = new overlay();
            Controls.Add(overlay);
            overlay.Size = Size;
            overlay.BringToFront();

            // Execute character query
            CharRow = await Common.SqlConnection.GetReaderResult("SELECT * FROM {0}.._Char WHERE CharName16 = '{1}'", Common.Config.SR_Shard, CharName);
            await CharRow.ReadAsync();
            // Load main info
            LoadInfo();
            // Main Inventory
            LoadCharSlots("Gears", GearsQuery, pCharGears, 45, 20);
            // Avater Inventory
            LoadCharSlots("Avatar", AvatarQuery, pCharAvatar, 45, 60);

            overlay.Dispose();
        }

        #region load Data
        private async void LoadInfo()
        {
            if (CharRow != null)
            {
                try
                {
                    tCharID.Text = CharRow["CharID"].ToString();
                    tName.Text = CharRow["CharName16"].ToString();
                    tNickName.Text = CharRow["NickName16"].ToString();
                    tLevel.Text = CharRow["CurLevel"].ToString();
                    tHP.Text = CharRow["HP"].ToString();
                    tMP.Text = CharRow["MP"].ToString();
                    tRegionID.Text = CharRow["LatestRegion"].ToString();
                    tXPos.Text = CharRow["PosX"].ToString();
                    tYPos.Text = CharRow["PosY"].ToString();
                    tZPos.Text = CharRow["PosZ"].ToString();
                    tHwanLevel.Text = CharRow["HwanLevel"].ToString();
                    tStr.Text = CharRow["Strength"].ToString();
                    tInt.Text = CharRow["Intellect"].ToString();
                    tExp.Text = CharRow["GatheredExpPoint"].ToString();
                    tSkillPoints.Text = CharRow["RemainSkillPoint"].ToString();
                    tStatePoints.Text = CharRow["RemainStatPoint"].ToString();
                    tInventorySize.Value = int.Parse(CharRow["InventorySize"].ToString());
                    tHwanCount.Value = int.Parse(CharRow["RemainHwanCount"].ToString());
                    cDeleted.Checked = int.Parse(CharRow["Deleted"].ToString()) != 0;

                    CharPicture.Image = Image.FromFile($"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Characters/{CharRow["RefObjID"]}.gif");
                    HPLabel.Text = CharRow["HP"] + " / " + CharRow["HP"];
                    MPLabel.Text = CharRow["MP"] + " / " + CharRow["MP"];
                    xLabel.Text = "X: " + CharRow["PosX"];
                    yLabel.Text = "Y: " + CharRow["PosY"];
                    pLevelLabel.Text = "Level: " + CharRow["CurLevel"];
                    //Load gold and silk
                    int ownSilk = await Common.SqlConnection.QueryFetchCell<int>($"SELECT silk_own FROM {Common.Config.SR_Account}..SK_Silk where JID = (select UserJID from _User where CharID = {CharRow["CharID"]})", "silk_own");
                    labelSilk.Text = string.Format("{0:n0}", ownSilk) + " Silk(s)";
                    labelGold.Text = string.Format("{0:n0}", CharRow["RemainGold"]);
                } catch { }
            }
        }

        private async void LoadCharSlots(string pType, string Query, Control parent, int startX, int startY)
        {
            parent.Controls.Clear();
            int posX = startX, posY = startY, counter = 1;
            try
            {
                SqlDataReader QueryRow = await Common.SqlConnection.GetReaderResult(Query, Common.Config.SR_Shard, CharRow["CharID"]);
                while (await QueryRow.ReadAsync())
                {
                    bool isEmpty = Convert.ToInt32(QueryRow["ID64"]) == 0 ? true : false;
                    bool isSox = QueryRow["CodeName128"].ToString().Contains("RARE") ? true : false;
                    string imgPath = $"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Game-icons/{QueryRow["AssocFileIcon128"].ToString().Replace("ddj", "png").Replace("\\", "/")}";
                    DrawSlot(parent, imgPath, QueryRow["CodeName128"].ToString(), QueryRow["ID64"].ToString(), posX, posY, isSox, isEmpty);
                    posX += 120;
                    if (counter++ % 2 == 0) { posX = 45; posY += 45; }
                }
            }
            catch {  Common.Dashboard.writeLog($"Error while loading character {pType} items.", 0);  }
        }
        #endregion

        private async void DrawSlot(Control parent, string path, string Name,string ID64, int x, int y, bool isSox, bool isEmpty = false)
        {
            try
            {
                PictureBox newSlot = new PictureBox();
                if (isSox)
                {
                    newSlot.BackColor = Color.DarkKhaki;
                    PictureBox sox = new PictureBox();
                    sox.BackColor = Color.Transparent;
                    sox.Image = Image.FromFile($"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Game-icons/slots/soxglow.gif");
                    sox.Size = new Size(20, 20);
                    newSlot.Controls.Add(sox);
                } else {
                    newSlot.BackColor = Color.FromArgb(31, 31, 31);
                }
                newSlot.Size = new Size(38, 38);
                newSlot.Location = new Point(x, y);
                newSlot.SizeMode = PictureBoxSizeMode.CenterImage;
                if (!isEmpty)
                {
                    // Slot image
                    if (File.Exists(path))
                        newSlot.Image = Image.FromFile(path);
                    else
                        newSlot.Image = Image.FromFile($"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Game-icons/icon_default.png");
                    // Slot info
                    newSlot.Name = Name;
                    newSlot.MouseHover += new EventHandler(SlotHover);
                    newSlot.MouseClick += new MouseEventHandler(SlotClicked);
                    newSlot.Tag = ID64;
                }
                // append the new slot to the parent
                parent.Controls.Add(newSlot);
                // Stuck Part
                if (!isEmpty)
                {
                    SqlDataReader StuckRow = await Common.SqlConnection.GetReaderResult(StuckQuery, Common.Config.SR_Shard, ID64);
                    if (await StuckRow.ReadAsync())
                    {
                        if (Convert.ToUInt64(StuckRow["Data"]) <= Convert.ToUInt64(StuckRow["MaxStack"]) && Convert.ToUInt64(StuckRow["Data"]) != 0)
                        {
                            Label Quantity = new Label();
                            Quantity.Text = StuckRow["Data"].ToString();
                            Quantity.Font = new Font(new FontFamily("Arial"), 6, FontStyle.Bold);
                            Quantity.BackColor = Color.Transparent;
                            Quantity.ForeColor = Color.White;
                            Quantity.Location = new Point(3, 5);
                            Quantity.Size = new Size(15, 15);
                            newSlot.Controls.Add(Quantity);
                        }
                    }
                }
            }
            catch { }
        }

        private void SlotHover(object sender, EventArgs e)
        {
            new SlotToolTip(sender);
        }


        private async void SlotClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox CurrentSlot = (PictureBox)sender;
                new dialog($"Delete {CurrentSlot.Name}?", "Are you sure you want to remove this item from this user?", CurrentSlot.Image).ShowDialog();
                if (Common.dialogResult == DialogResult.Yes)
                {
                    await Common.SqlConnection.ExecuteNonQuery($"UPDATE {Common.Config.SR_Shard}.._Inventory Set ItemID = 0 WHERE ItemID = {CurrentSlot.Tag} UPDATE {Common.Config.SR_Shard}.._InventoryForAvatar Set ItemID = 0 WHERE ItemID = {CurrentSlot.Tag}");
                    Common.Dashboard.writeLog($"{CurrentSlot.Name} has been removed from {CharName} successfully.", 1);
                    CurrentSlot.Image = null;
                    CurrentSlot.Controls.Clear();
                    CurrentSlot.MouseHover -= SlotHover;
                    CurrentSlot.MouseClick -= SlotClicked;
                    CurrentSlot.BackColor = Color.FromArgb(31, 31, 31);
                }
            } 
            else if (e.Button == MouseButtons.Right)
            {
                new message("Edit item stats here").Show();
            }
        }

        private void InvAvaButton_Click(object sender, EventArgs e)
        {
            if (pCharGears.Visible)
            {
                pCharGears.Visible = false;
                pCharAvatar.Visible = true;
                pCharAvatar.BringToFront();
                GearsAvaButton.Text = "Gears";
            }
            else if (pCharAvatar.Visible)
            {
                pCharGears.Visible = true;
                pCharGears.BringToFront();
                pCharAvatar.Visible = false;
                GearsAvaButton.Text = "Avatar";
            }
            GearsAvaButton.BringToFront();
        }

        private async void editGold_Click(object sender, EventArgs e)
        {
            try
            {

                new inputDialog($"Update {CharName} Gold amount", $"Gold Amount").ShowDialog();
                if (Common.dialogInputResult != null && Convert.ToInt64(Common.dialogInputResult) >= 0)
                {
                    await Common.SqlConnection.ExecuteNonQuery("UPDATE {0}.._Char set RemainGold = {11} WHERE CharName16 = '{2}'",  Common.Config.SR_Shard, Common.dialogInputResult, CharName);
                    labelGold.Text = string.Format("{0:n0}", Convert.ToInt64(Common.dialogInputResult));
                    Common.Dashboard.writeLog($"[{Common.dialogInputResult}] Gold has been added to {CharName}.", 1);
                }
            }
            catch {
                Common.Dashboard.writeLog("Error while updating character gold.", 0);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            //int isNameFound = await Common.SqlConnection.RowCount($"SELECT TOP 1 CharName16 FROM {Common.Config.SR_Shard}.._Char Where CharName16 = '{tName.Text}'");
            //if (isNameFound == 0 && CharName != tName.Text)
            //{
                new dialog($"Update {CharName}", $"Are you sure you want to update this character?").ShowDialog();
                if (Common.dialogResult == DialogResult.Yes)
                {
                    string query = @"UPDATE {0}.._Char SET 
                                Deleted = '{1}',
                                CharName16 = '{2}',
                                NickName16 = '{3}',
                                CurLevel = '{4}',
                                HP = '{5}',
                                MP = '{6}',
                                Strength = '{7}',
                                Intellect = '{8}',
                                GatheredExpPoint = '{9}',
                                RemainSkillPoint = '{10}',
                                RemainStatPoint = '{11}',
                                InventorySize = '{12}',
                                LatestRegion = '{13}',
                                PosX = '{14}',
                                PosY = '{15}',
                                PosZ = '{16}',
                                RemainHwanCount = '{17}',
                                HwanLevel = '{18}'
                                WHERE CharID = {19}";
                    await Common.SqlConnection.ExecuteNonQuery(query, Common.Config.SR_Shard,
                                   (cDeleted.Checked ? 1 : 0),
                                   tName.Text,
                                   tNickName.Text,
                                   tLevel.Text,
                                   tHP.Text,
                                   tMP.Text,
                                   tStr.Text,
                                   tInt.Text,
                                   tExp.Text,
                                   tSkillPoints.Text,
                                   tStatePoints.Text,
                                   tInventorySize.Text,
                                   tRegionID.Text,
                                   tXPos.Text,
                                   tYPos.Text,
                                   tZPos.Text,
                                   tHwanCount.Value,
                                   tHwanLevel.Text,
                                   tCharID.Text);
                    Common.Dashboard.writeLog($"{CharName}'s data has been updated succesfully.", 1);
                    new message($"{CharName}'s data has been updated succesfully.").Show();
                }
            //}
            //else
            //{
            //    Common.Dashboard.writeLog("Cannot update the data because this character name is already used!");
            //}
        }
    }
}
