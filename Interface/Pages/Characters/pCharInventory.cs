using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection;

namespace MOSROManager
{
    public partial class pCharInventory : UserControl
    {
        private readonly string CharName = null;
        // Inventory query
        string InventoryQuery = @"USE {0}
                            SELECT 
                            it.[ID64] ,oc.[ID] ,oc.[CodeName128] ,it.[OptLevel] ,it.[Variance] ,it.[Data] ,ch.[CharName16] 
                            ,iv.[Slot] ,oc.[AssocFileIcon128], iv.[ItemID]
                            FROM [dbo].[_Items] AS it
                            LEFT JOIN [dbo].[_RefObjCommon] oc ON oc.ID = it.RefItemID
                            LEFT JOIN [dbo].[_Inventory] iv ON iv.[ItemID] = it.[ID64]
                            LEFT JOIN [dbo].[_Char] ch on ch.[CharID] = iv.[CharID]
                            WHERE  ch.CharName16 = '{1}' and Slot between {2} and {3} order by slot asc";
        // Stuck Query
        string StuckQuery = @"USE {0}
                            SELECT TOP 1  it.Data , item.MaxStack
                            from _Items as it
                            LEFT JOIN _Inventory as inv ON it.ID64 = inv.ItemID
                            LEFT JOIN _RefObjCommon as obj ON it.RefItemID = obj.ID
                            LEFT JOIN _RefObjItem as item ON obj.Link = item.ID
                            where ID64 = {1}";

        public pCharInventory(string Charname)
        {
            InitializeComponent();
            this.CharName = Charname;
        }

        overlay overlay = new overlay();
        private async void LoadInventorySlots(int SlotStart, int SlotEnd)
        {
            pInventory.Controls.Clear();

            // overlay
            this.Controls.Add(overlay);
            overlay.Size = this.Size;
            overlay.BringToFront();
            overlay.Show();

            int posX = 20, posY = 25, counter = 1;
            try
            {
                SqlDataReader QueryRow = await Common.SqlConnection.GetReaderResult(InventoryQuery, Common.Config.SR_Shard, CharName, SlotStart, SlotEnd);
                while (await QueryRow.ReadAsync())
                {
                    bool isEmpty = Convert.ToInt64(QueryRow["ItemID"]) == 0 ? true : false;
                    bool isLocked = Convert.ToInt64(QueryRow["Slot"]) >= InventorySize ? true : false;
                    if (isEmpty)
                    {
                        DrawSlot(pInventory, null, "empty", QueryRow["Slot"].ToString(), QueryRow["ID64"].ToString(), posX, posY, false, isEmpty, isLocked);
                    } else
                    {
                        bool isSox = QueryRow["CodeName128"].ToString().Contains("RARE") ? true : false;
                        string imgPath = $"{Directory.GetCurrentDirectory().Replace("\\", "/")}/Resources/Game-icons/{QueryRow["AssocFileIcon128"].ToString().Replace("ddj", "png").Replace("\\", "/")}";
                        DrawSlot(pInventory, imgPath, QueryRow["CodeName128"].ToString(), QueryRow["Slot"].ToString(), QueryRow["ID64"].ToString(), posX, posY, isSox, isEmpty);
                    }
                    posX += 45;
                    if (counter++ % 4 == 0) { posX = 20; posY += 45; }
                }
            }
            catch {
                Common.Dashboard.writeLog($"Error while loading Inventory.", 0);
            }
            // Hide overlay
            overlay.Hide();
        }

        private async void DrawSlot(Control parent, string path, string Name, string slot, string ID64, int x, int y, bool isSox, bool isEmpty = false, bool isLocked = false)
        {
            try
            {
                PictureBox newSlot = new PictureBox();
                newSlot.Size = new Size(38, 38);
                newSlot.Location = new Point(x, y);
                newSlot.Tag = ID64 + "-" + slot;
                newSlot.SizeMode = PictureBoxSizeMode.CenterImage;

                // drag and drop events
                newSlot.AllowDrop = true;
                newSlot.MouseDown += new MouseEventHandler(Slot_MouseUp);
                newSlot.DragEnter += new DragEventHandler(Slot_DragEnter);
                newSlot.DragDrop += new DragEventHandler(Slot_DragDrop);

                if (isLocked)
                {
                    newSlot.BackColor = Color.FromArgb(80, 80, 80);
                }  
                else if (isSox)
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
            catch (Exception err){ Console.WriteLine(err); }
        }

        private void Slot_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                PictureBox CurrentSlot = (PictureBox)sender;
                CurrentSlot.DoDragDrop(CurrentSlot, DragDropEffects.All);
            }
        }

        private void Slot_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        private async void Slot_DragDrop(object sender, DragEventArgs e) // fix error maybe change to mouse Up??
        {
            try
            {

                PictureBox DragSlot = (PictureBox)e.Data.GetData(e.Data.GetFormats()[0]);
                PictureBox DropSlot = (PictureBox)sender;
                Point plocation = DragSlot.Location;
                // update locations
                DragSlot.Location = DropSlot.Location;
                DropSlot.Location = plocation;
                Console.WriteLine("From Slot {0} [ID- {1}] to Slot {2} [ID- {3}", DragSlot.Tag.ToString().Split('-')[1], DragSlot.Tag.ToString().Split('-')[0], DropSlot.Tag.ToString().Split('-')[1], DropSlot.Tag.ToString().Split('-')[0]);
                await Common.SqlConnection.ExecuteNonQuery("UPDATE {0}.._Inventory Set ItemID = {1} Where Slot = {2}", Common.Config.SR_Shard, DragSlot.Tag.ToString().Split('-')[0], DropSlot.Tag.ToString().Split('-')[1]);
                await Common.SqlConnection.ExecuteNonQuery("UPDATE {0}.._Inventory Set ItemID = {1} Where Slot = {2}", Common.Config.SR_Shard, DropSlot.Tag.ToString().Split('-')[0], DragSlot.Tag.ToString().Split('-')[1]);
            } catch
            {
                Common.Dashboard.writeLog("Error while changing slot location.");
            }
        }

        //private SlotToolTip ToolTip;
        private void SlotHover(object sender, EventArgs e)
        {
            new SlotToolTip(sender);
        }

        private async void SlotClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                PictureBox CurrentSlot = (PictureBox)sender;
                new dialog($"Delete {CurrentSlot.Name}?", "Are you sure you want to remove this item from this user?", CurrentSlot.Image).ShowDialog();
                if (Common.dialogResult == DialogResult.Yes)
                {
                    await Common.SqlConnection.ExecuteNonQuery($"UPDATE {Common.Config.SR_Shard}.._Inventory Set ItemID = 0 WHERE ItemID = {CurrentSlot.Tag.ToString().Split('-')[0]} and CharID = (SELECT CharID FROM {Common.Config.SR_Shard}.._Char where CharName16 = '{CharName}')");
                    Common.Dashboard.writeLog($"{CurrentSlot.Name} has been removed from {CharName} successfully.", 1);
                    CurrentSlot.Image = null;
                    CurrentSlot.Controls.Clear();
                    CurrentSlot.MouseHover -= SlotHover;
                    CurrentSlot.MouseClick -= SlotClicked;
                    CurrentSlot.BackColor = Color.FromArgb(31, 31, 31);
                }
            }
        }

        private void PageOne_Click(object sender, EventArgs e)
        {
            LoadInventorySlots(13, 44);
            (sender as Button).BackColor = Color.DarkKhaki;
            PageTwo.BackColor = Color.FromArgb(31, 31, 31);
            PageThree.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void Page2_Click(object sender, EventArgs e)
        {
            LoadInventorySlots(45, 76);
            (sender as Button).BackColor = Color.DarkKhaki;
            PageOne.BackColor = Color.FromArgb(31, 31, 31);
            PageThree.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void PageThree_Click(object sender, EventArgs e)
        {
            LoadInventorySlots(77, 108);
            (sender as Button).BackColor = Color.DarkKhaki;
            PageOne.BackColor = Color.FromArgb(31, 31, 31);
            PageTwo.BackColor = Color.FromArgb(31, 31, 31);
        }

        int InventorySize;
        private async void pCharInventory_Load(object sender, EventArgs e)
        {
            try
            {
                InventorySize = await Common.SqlConnection.QueryFetchCell<int>(string.Format("SELECT InventorySize FROM {0}.._Char WHERE CharName16 = '{1}'", Common.Config.SR_Shard, CharName), "InventorySize");
                int EmptySlots = await Common.SqlConnection.QueryFetchCell<int>($"SELECT COUNT(*) as Empty FROM {Common.Config.SR_Shard}.._Inventory WHERE CharID in (SELECT CharID FROM {Common.Config.SR_Shard}.._Char where CharName16 = '{CharName}') and ItemID = 0 and Slot between 13 and {InventorySize}", "Empty");
                lAvaliableSlots.Text = "Avaliable slots: " + InventorySize.ToString();
                lRemainSlots.Text = "Remaining slots: " + (EmptySlots - 1).ToString();


                if (InventorySize <= 77)
                {
                    PageThree.Visible = false;
                    unlockPage3.Visible = true;
                } 
                
                if (InventorySize <= 45)
                {
                    PageTwo.Visible = false;
                    unlockPage2.Visible = true;
                }

                //load first page
                PageOne.PerformClick();
            }
            catch (Exception err) {
                Console.WriteLine(err);
                Common.Dashboard.writeLog("Error while loading character inventory.", 0);
            }
        }

        private async void unlockPage2_Click(object sender, EventArgs e)
        {
            new dialog("Unlock second inventory page?", $"Are you sure you want to unlock second inventory page for the user {CharName}?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                try
                {
                    await Common.SqlConnection.ExecuteNonQuery(@"UPDATE {0}.._Char SET InventorySize = 77 WHERE CharName16 = '{1}'", Common.Config.SR_Shard, CharName);
                    PageTwo.Visible = true;
                    unlockPage2.Visible = false;
                    InventorySize = 77;
                    lAvaliableSlots.Text = "Avaliable slots: " + InventorySize.ToString();
                    lRemainSlots.Text = "Remaining slots: " + Convert.ToInt32(lRemainSlots.Text) + 32;
                    new message($"Second inventoy page has been unlocked for the user {CharName}.").Show();
                }
                catch { }
            }
        }

        private async void unlockPage3_Click(object sender, EventArgs e)
        {
            new dialog("Unlock Third inventory page?", $"Are you sure you want to unlock Third inventory page for the user {CharName}?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                try
                {
                    await Common.SqlConnection.ExecuteNonQuery(@"UPDATE {0}.._Char SET InventorySize = 109 WHERE CharName16 = '{1}'", Common.Config.SR_Shard, CharName);
                    PageThree.Visible = true;
                    unlockPage3.Visible = false;
                    InventorySize = 109;
                    lAvaliableSlots.Text = "Avaliable slots: " + InventorySize.ToString();
                    lRemainSlots.Text = "Remaining slots: " + Convert.ToInt32(lRemainSlots.Text) + 32;
                    new message($"Third inventoy page has been unlocked for the user {CharName}.").Show();

                }
                catch { }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            new dialog("Remove inventory items?", $"Are you sure you want to remove all the inventory items fomr the user {CharName}?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                try
                {
                    await Common.SqlConnection.ExecuteNonQuery(@"UPDATE {0}.._Inventory SET ItemID = 0 WHERE CharID in (SELECT CharID FROM {0}.._Char WHERE CharName16 = {1})", Common.Config.SR_Shard, CharName);

                    new message($"All the inventory items has been removed from the user {CharName}.").Show();

                }
                catch { }
            }
        }
    }
}
