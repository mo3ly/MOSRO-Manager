using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MOSROManager
{
    public partial class pCharStorage : UserControl
    {
        private readonly string CharName = null;
        // Storage query
        string StorageQuery = @"USE {4}
                                SELECT 
                                it.[ID64] ,oc.[ID] ,oc.[CodeName128] ,it.[OptLevel] ,it.[Variance] ,it.[Data]
                                ,ch.[Slot] ,oc.[AssocFileIcon128], ch.[ItemID]
                                FROM [dbo].[_Items] AS it
                                LEFT JOIN [dbo].[_RefObjCommon] oc ON oc.ID = it.RefItemID
                                LEFT JOIN [dbo].[_Chest] ch ON ISNULL(ch.[ItemID], 0) = it.[ID64]
                                WHERE  ch.UserJID in (SELECT UserJID FROM _User WHERE CharID in (SELECT CharID FROM _Char WHERE CharName16 = '{0}')) 
                                and Slot between {1} and {2} order by Slot asc";

        // pet query
        string PetQuery = @"USE [{4}]
                            SELECT pet_invo.[ItemID]
                            ,pet_invo.[Slot] PetSlot
                            ,pet_item.[ID64] 
                            ,pet_item.[RefItemID]
                            ,pet_common.[CodeName128]
                            ,pet_common.[AssocFileIcon128]
                            ,pet.[ID] PetID
                            ,pet.[CharName] PetName
                            ,pet.[RentEndTime]
                            ,char_invo.[Slot]
                            ,char_item.[ID64]
                            ,char_item.[RefItemID]
                            ,char_common.[CodeName128]
                            ,chr.[CharID]
                            ,chr.[CharName16]
                            FROM [dbo].[_InvCOS] AS pet_invo
                            JOIN [dbo].[_Items] pet_item ON pet_item.[ID64] = pet_invo.[ItemID]
                            JOIN [dbo].[_RefObjCommon] pet_common ON pet_common.[ID] = pet_item.[RefItemID]
                            JOIN [dbo].[_CharCOS] AS pet ON pet.[ID] = pet_invo.[COSID]
                            JOIN [dbo].[_Items] AS char_item ON char_item.[Data] = pet.[ID] AND char_item.RefItemID IN (SELECT [ID] FROM [{4}].[dbo].[_RefObjCommon] WHERE [Service] = 1 AND [TypeID1] = 3 AND [TypeID2] = 2 AND [TypeID3] = 1 AND [TypeID4] = 2)
                            JOIN [dbo].[_RefObjCommon] char_common ON char_common.[ID] = char_item.[RefItemID]
                            JOIN [dbo].[_Inventory] AS char_invo ON char_invo.[ItemID] = ISNULL(char_item.[ID64], 0)
                            JOIN [dbo].[_Char] AS chr on chr.[CharID] = char_invo.[CharID]
                            WHERE CharName16 = '{0}' and pet_invo.[Slot] between {1} and {2} and pet.ID = {3} order by pet_invo.[Slot] asc";

        // Char pets query
        string CharPetsQuery = @"USE [{1}]
                            SELECT DISTINCT
                            char_common.[CodeName128]
                            ,pet.[ID] PetID
                            ,chr.[CharName16]
                            FROM [dbo].[_InvCOS] AS pet_invo
                            JOIN [dbo].[_Items] pet_item ON pet_item.[ID64] = pet_invo.[ItemID]
                            JOIN [dbo].[_RefObjCommon] pet_common ON pet_common.[ID] = pet_item.[RefItemID]
                            JOIN [dbo].[_CharCOS] AS pet ON pet.[ID] = pet_invo.[COSID]
                            JOIN [dbo].[_Items] AS char_item ON char_item.[Data] = pet.[ID] AND char_item.RefItemID IN (SELECT [ID] FROM [{1}].[dbo].[_RefObjCommon] WHERE [Service] = 1 AND [TypeID1] = 3 AND [TypeID2] = 2 AND [TypeID3] = 1 AND [TypeID4] = 2)
                            JOIN [dbo].[_RefObjCommon] char_common ON char_common.[ID] = char_item.[RefItemID]
                            JOIN [dbo].[_Inventory] AS char_invo ON char_invo.[ItemID] = char_item.[ID64]
                            JOIN [dbo].[_Char] AS chr on chr.[CharID] = char_invo.[CharID]
                            WHERE CharName16 = '{0}'";

        // Stuck Query
        string StuckQuery = @"USE {1}
                            SELECT TOP 1  it.Data , item.MaxStack
                            from _Items as it
                            LEFT JOIN _Inventory as inv ON it.ID64 = inv.ItemID
                            LEFT JOIN _RefObjCommon as obj ON it.RefItemID = obj.ID
                            LEFT JOIN _RefObjItem as item ON obj.Link = item.ID
                            where ID64 = {0}";

        public pCharStorage(string Charname)
        {
            InitializeComponent();
            this.CharName = Charname;
        }



        // delete item from user in write click
        // on hover show states
        // on click show ItemID and Serial64
        // allow copy on logBox
        private async void pCharStorage_Load(object sender, EventArgs e)
        {
            try
            {
                // load storage query
                LoadSlots(StorageQuery, pStorage, 0, 29, 6);

                // default pets combo box selected item

                // Pets reader
                SqlDataReader PetsReader = await Common.SqlConnection.GetReaderResult(CharPetsQuery, CharName, Common.Config.SR_Shard);
                if (PetsReader != null)
                {
                    PetsComboBox.Items.Clear();
                    while (await PetsReader.ReadAsync())
                    {
                        PetsComboBox.Items.Add($"{PetsReader["PetID"]} - {PetsReader["CodeName128"]}");
                    }

                    PetsComboBox.SelectedIndex = 0;
                    PetStatusLabel.Text = $"This character has {PetsComboBox.Items.Count} pets.";

                    // load pets query
                    LoadSlots(PetQuery, pPetStroage, 0, 27, 7, Convert.ToInt32(PetsComboBox.SelectedItem.ToString().Split('-')[0]));
                    PetsComboBox.Enabled = true;
                    PetBoxNavigation.Enabled = true;
                }


                sGoldLabel.Text = string.Format("{0:n0}", await Common.SqlConnection.QueryFetchCell<long>($"SELECT Gold FROM {Common.Config.SR_Shard}.._AccountJID where JID = (select UserJID from {Common.Config.SR_Shard}.._User where CharID = (SELECT CharID FROM {Common.Config.SR_Shard}.._Char WHERE CharName16 = '{CharName}'))", "Gold"));
            }
            catch (Exception ee) // check error
            {
                Console.WriteLine(ee);
                Common.Dashboard.writeLog("Error while loading character storage.", 0);
            }
        }

        overlay overlay = new overlay();
        private async void LoadSlots(string Query, GroupBox slotsBox, int SlotStart, int SlotEnd, int breaker, int petid = 0)
        {
            slotsBox.Controls.Clear();

            // overlay
            this.Controls.Add(overlay);
            overlay.Size = this.Size;
            overlay.BringToFront();

            int posX = 20, posY = 30, counter = 1;
            try
            {
                SqlDataReader QueryRow = await Common.SqlConnection.GetReaderResult(Query, CharName, SlotStart, SlotEnd, petid, Common.Config.SR_Shard);
                while (await QueryRow.ReadAsync())
                {
                    bool isEmpty = Convert.ToInt64(QueryRow["ID64"]) == 0 ? true : false;
                    if (isEmpty)
                    {
                        DrawSlot(slotsBox, null, "empty", QueryRow["ID64"].ToString(), posX, posY, false, isEmpty);
                    }
                    else
                    {
                        bool isSox = QueryRow["CodeName128"].ToString().Contains("RARE") ? true : false;
                        string imgPath = $"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Game-icons/{QueryRow["AssocFileIcon128"].ToString().Replace("ddj", "png").Replace("\\", "/")}";
                        DrawSlot(slotsBox, imgPath, QueryRow["CodeName128"].ToString(), QueryRow["ID64"].ToString(), posX, posY, isSox, isEmpty);
                    }
                    posX += 40;
                    if (counter++ % breaker == 0) { posX = 20; posY += 40; }
                }
            }
            catch (Exception er)
            {
                Common.Dashboard.writeLog($"Error while loading storage." + er, 0);
            }
            // Hide overlay
            overlay.Hide();
        }

        private async void DrawSlot(Control parent, string path, string Name, string ID64, int x, int y, bool isSox, bool isEmpty = false)
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
                }
                else
                {
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
                    newSlot.Click += new EventHandler(SlotClicked);
                    newSlot.Tag = ID64;
                }
                // append the new slot to the parent
                parent.Controls.Add(newSlot);
                // Stuck Part
                if (!isEmpty)
                {
                    SqlDataReader StuckRow = await Common.SqlConnection.GetReaderResult(StuckQuery, ID64, Common.Config.SR_Shard);
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
            catch (Exception err) { Console.WriteLine(err); }
        }

        private void SlotHover(object sender, EventArgs e)
        {
            SlotToolTip ToolTip = new SlotToolTip(sender);
        }

        private async void SlotClicked(object sender, EventArgs e)
        {
            PictureBox CurrentSlot = (PictureBox)sender;
            new dialog($"Delete {CurrentSlot.Name}?", "Are you sure you want to remove this item from this user's storage?", CurrentSlot.Image).ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                await Common.SqlConnection.ExecuteNonQuery("UPDATE {1}.._Chest Set ItemID = 0 WHERE ItemID = {0} UPDATE {1}.._InvCOS Set ItemID = 0 WHERE ItemID = {0}", CurrentSlot.Tag, Common.Config.SR_Shard);
                Common.Dashboard.writeLog($"{CurrentSlot.Name} has been removed from {CharName} successfully.", 1);
                CurrentSlot.Image = null;
                CurrentSlot.Controls.Clear();
                CurrentSlot.MouseHover -= SlotHover;
                CurrentSlot.Click -= SlotClicked;
                CurrentSlot.BackColor = Color.FromArgb(31, 31, 31);
            }
        }

        private int currentStoragePage = 1;

        private void previousPageStorage_Click(object sender, EventArgs e)
        {
            if (currentStoragePage > 1)
            {
                currentStoragePage--;
                StoragePageBox.Text = currentStoragePage.ToString();
                LoadSlots(StorageQuery, pStorage, 0 + ((currentStoragePage - 1) * 30), 29 + ((currentStoragePage - 1) * 30), 6);
            }
        }

        private void nextPageStorage_Click(object sender, EventArgs e)
        {
            if (currentStoragePage < 5)
            {
                currentStoragePage++;
                StoragePageBox.Text = currentStoragePage.ToString();
                LoadSlots(StorageQuery, pStorage, 0 + ((currentStoragePage - 1) * 30), 29 + ((currentStoragePage - 1) * 30),6 );
            }
        }

        private async void editGold_Click(object sender, EventArgs e)
        {
            try
            {

                new inputDialog($"Update {CharName} Storage Gold amount", $"Gold Amount").ShowDialog();
                if (Common.dialogInputResult != null && Convert.ToInt64(Common.dialogInputResult) >= 0)
                {
                    long storageGold = await Common.SqlConnection.QueryFetchCell<long>($"SELECT Gold FROM {Common.Config.SR_Shard}.._AccountJID where JID = (select UserJID from {Common.Config.SR_Shard}.._User where CharID = (SELECT CharID FROM {Common.Config.SR_Shard}.._Char WHERE CharName16 = '{CharName}'))", "Gold");
                    await Common.SqlConnection.ExecuteNonQuery("UPDATE {2}.._AccountJID SET Gold = {0} where JID = (select UserJID from {2}.._User where CharID = (SELECT CharID FROM {2}.._Char WHERE CharName16 = '{1}'))", Common.dialogInputResult, CharName, Common.Config.SR_Shard);
                    sGoldLabel.Text = string.Format("{0:n0}", Convert.ToInt64(Common.dialogInputResult));
                    Common.Dashboard.writeLog($"{CharName}'s Storage Gold has been set to [{Common.dialogInputResult}].", 1);
                }
            }
            catch
            {
                Common.Dashboard.writeLog("Error while updating storage gold.", 0);
            }
        }


        // pet pages navigation
        private int currentPetPage = 1;
        private void previousPetStorage_Click(object sender, EventArgs e)
        {
            if (currentPetPage > 1)
            {
                currentPetPage--;
                PetPageBox.Text = currentPetPage.ToString();
                LoadSlots(PetQuery, pPetStroage, 0 + ((currentPetPage - 1) * 28), 27 + ((currentPetPage - 1) * 28), 7, Convert.ToInt32(PetsComboBox.SelectedItem.ToString().Split('-')[0]));
            }
        }

        private void nextPetStorage_Click(object sender, EventArgs e)
        {
            if (currentPetPage < 5)
            {
                currentPetPage++;
                PetPageBox.Text = currentPetPage.ToString();
                LoadSlots(PetQuery, pPetStroage, 0 + ((currentPetPage - 1) * 28), 27 + ((currentPetPage - 1) * 28), 7, Convert.ToInt32(PetsComboBox.SelectedItem.ToString().Split('-')[0]));
            }
        }

        private void PetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSlots(PetQuery, pPetStroage, 0, 27, 7, Convert.ToInt32(PetsComboBox.SelectedItem.ToString().Split('-')[0]));
            currentPetPage = 1;
            PetPageBox.Text = currentPetPage.ToString();
        }
    }
}
