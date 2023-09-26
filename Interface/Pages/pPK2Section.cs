using MediaExtractorLibrary.GDImageLibrary;
using PK2;
using PK2.IO;
using PK2.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pPK2Section : UserControl
    {
        //TODO
        // remanage the whole code
        // add ddj viewer
        // add ipinput
        // add .2dt readr and editor
        // add skills editor
        // fix extractor
        // fix PK2Tree
        // create item in the root directory
        // add editor
        // add search by name
        // make it async
        // drag and drop editor
        // loop selection - multi selection

        OpenFileDialog PK2Dialog = new OpenFileDialog();
        string PK2FilePath;
        PK2Archive PK2;

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        /*
         * When double click on item show image from ddj to png
         */
        public pPK2Section()
        {
            InitializeComponent();
            string ImageSrc = Directory.GetCurrentDirectory() + "/Resources/UI-icons/";

            // PK2Tree
            ImageList PK2TreeImageList = new ImageList();
            PK2TreeImageList.Images.Add(Image.FromFile(ImageSrc + "icon-treefolder-b.png"));
            PK2TreeImageList.Images.Add(Image.FromFile(ImageSrc + "icon-treefolder-closed-b.png"));
            PK2TreeImageList.Images.Add(Image.FromFile(ImageSrc + "icon-file-b.png"));
            PK2Tree.ImageList = PK2TreeImageList;
            PK2Tree.ImageIndex = 0;
            PK2Tree.SelectedImageIndex = 1;
            PK2Tree.NodeMouseClick += NodeDirectory;
            // PK2 Explorer
            ImageList PK2ExplorerImageList = new ImageList();
            PK2ExplorerImageList.Images.Add(Image.FromFile(ImageSrc + "icon-treefolder-b.png"));
            PK2ExplorerImageList.Images.Add(Image.FromFile(ImageSrc + "icon-file-b.png"));
            PK2Explorer.SmallImageList = PK2ExplorerImageList;
        }

        private void OpenMedia_Click(object sender, EventArgs e)
        {
            PK2Dialog.Title = "Select the .pk2 file";
            PK2Dialog.Filter = "PK2 Files|*.pk2";
            if (PK2Dialog.ShowDialog() == DialogResult.OK)
            {
                tPK2Directory.Text = PK2Dialog.FileName;
                PK2FilePath = PK2Dialog.FileName;
            } else
            {
                Common.Dashboard.writeLog("You didn't select a PK2 file");
                return;
            }
        }

        private void LoadMedia_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(PK2FilePath) && tBlowfishKey.Text.Length > 0 && Path.GetExtension(PK2FilePath) == ".pk2") {
                try
                {
                    pLoading.Show();
                    pLoading.Refresh();
                    PK2 = new PK2Archive(PK2FilePath, new PK2Config(PK2Mode.Index, tBlowfishKey.Text));
                    Common.Dashboard.writeLog($"Loading {Path.GetFileName(PK2FilePath)}.", 1);
                    LoadPK.Enabled = false;
                    OpenMedia.Enabled = false;
                    LoadPK2();
                    ClosePK2.Visible = true;
                    pLoading.Hide();
                } catch (Exception error)
                {
                    Console.WriteLine(error);
                    Common.Dashboard.writeLog("Error while reading the PK2 file." + error, 0);
                }
            } else
            {
                Common.Dashboard.writeLog("No PK2 file has been selected.", 0);
            }
        }

        private void LoadPK2()
        {

            // change theme
            SetWindowTheme(PK2Tree.Handle, "explorer", null);
            // PK2 file name
            TreeNode PK2Base = PK2Tree.Nodes.Add(Path.GetFileName(PK2FilePath));
            //PK2Base.Tag = "/";
            // List the PK2 Items
            //foreach (var File in PK2.GetFiles("/", false))
           // {
                //PK2Base.Nodes.Add(new TreeNode(File.Name + Path.GetExtension(File.Type.ToString()), 2, 2) { Tag = File.Path });
            //}

            // Directories
            var PK2Directories = PK2.GetDirectories("/", false);
            foreach (var DirectoryParent in PK2Directories)
            {
                List<TreeNode> ChildList = new List<TreeNode>();
                foreach (var Directory in PK2.GetDirectories(DirectoryParent.Path, false))
                {
                    ChildList.Add(new TreeNode(Directory.Name) { Tag = Directory.Path });
                    //PK2SubTree.Nodes.Add(new TreeNode(Directory.Name)); 
                }
                PK2Base.Nodes.Add(new TreeNode(DirectoryParent.Name, ChildList.ToArray()) { Tag = DirectoryParent.Path });
            }
            inMediaGo.PerformClick();
            PK2Tree.Sort();
            PK2Tree.Nodes[0].Expand();
        }

        private void NodeDirectory(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Expand();
            try
            {
                // find node in PK2Tree by tag -> directory and open it
                inMediaPath.Text = e.Node.Tag.ToString();
                inMediaGo.PerformClick();
            } catch
            {

            }
        }

        
        private void GoMediaPath_Click(object sender, EventArgs e)
        {
            if (PK2FilePath != null && PK2 != null)
            {
                pLoading.Show();
                pLoading.Refresh();
                PK2Explorer.Items.Clear();
                ListViewItem item = null;
                ListViewItem.ListViewSubItem[] subItems;
                // menu
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add("Extract", new EventHandler(PK2_Extract));
                menu.MenuItems.Add("Delete", new EventHandler(PK2_Delete));
                menu.MenuItems.Add("Rename", new EventHandler(PK2_Rename));
                PK2Explorer.ContextMenu = menu;
                // List the PK2 Items
                foreach (var File in PK2.GetFiles($"{inMediaPath.Text}", false))
                {
                    item = new ListViewItem(File.Name, 1) { Tag = File.Path  };
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "File"),
                        new ListViewItem.ListViewSubItem(item, File.Size.ToString()),
                        new ListViewItem.ListViewSubItem(item, File.CreateTime.ToString() + " - Parent: " + File.Parent + " - Path: " + File.Path)
                    };
                    item.SubItems.AddRange(subItems);
                    PK2Explorer.Items.Add(item);
                }

                foreach (var Directory in PK2.GetDirectories($"{inMediaPath.Text}", false))
                {
                    item = new ListViewItem(Directory.Name, 0) { Tag = Directory.Path };
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Directory"),
                        new ListViewItem.ListViewSubItem(item, ""),
                        new ListViewItem.ListViewSubItem(item, Directory.CreateTime.ToString())
                    };
                    item.SubItems.AddRange(subItems);
                    PK2Explorer.Items.Add(item);
                }
                PK2Explorer.Sort();
                PK2Explorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                eCounter.Text = "Items: " + PK2Explorer.Items.Count.ToString();
                pLoading.Hide();
            } else
            {
                Common.Dashboard.writeLog("Cannot load this path, PK2 is not loaded.");
            }
        }

        private void PK2_Extract(object sender, EventArgs  e)
        {
            try {
                // create extrat folder if not found
                string extractPath = Environment.CurrentDirectory + "/extract";
                if (!Directory.Exists(extractPath))
                    Directory.CreateDirectory(extractPath);
                //get selected item
                string SelctedItem = PK2Explorer.SelectedItems[0].Text;

                new dialog($"Extract {SelctedItem}.", $"Do you want to extract {SelctedItem}?").ShowDialog();
                if (Common.dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (PK2Explorer.SelectedItems[0].SubItems[1].Text == "File")
                        {
                            string IconPath = PK2Explorer.SelectedItems[0].Tag.ToString();
                            string fullpath = Environment.CurrentDirectory + "\\extract\\" + Path.GetFileNameWithoutExtension(PK2FilePath) + "\\" + IconPath.Replace(IconPath.Split('/').Last(), "");
                            if (!Directory.Exists(fullpath))
                                Directory.CreateDirectory(fullpath);
                            PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()).Extract($"{fullpath}/{SelctedItem}");
                        } else
                        {
                            foreach (var File in PK2.GetFiles(PK2Explorer.SelectedItems[0].Tag.ToString(), true))
                            {
                                string IconPath = File.Path;
                                string fullpath = Environment.CurrentDirectory + "\\extract\\" + Path.GetFileNameWithoutExtension(PK2FilePath) + "\\" + IconPath.Replace(IconPath.Split('/').Last(), "");
                                if (!Directory.Exists(fullpath))
                                    Directory.CreateDirectory(fullpath);
                                PK2.GetFile(File.Path).Extract($"{fullpath}/{File.Name}");
                            }
                        }
                        Common.Dashboard.writeLog($"{SelctedItem} extracted successfully.", 1);
                    }
                    catch
                    {
                        Common.Dashboard.writeLog($"Error while extracting {SelctedItem}.", 0);
                    }
                }
            } catch {
                Common.Dashboard.writeLog($"No item was selected.");
            }
        }
        
        private void PK2_Delete(object sender, EventArgs e)
        {
            try
            {
                string SelctedItem = PK2Explorer.SelectedItems[0].Text;

                DialogResult ExtractDialog = MessageBox.Show($"Do you want to delete {SelctedItem}?", $"Delete {SelctedItem}.", MessageBoxButtons.YesNo);
                if (ExtractDialog == DialogResult.Yes)
                {
                    try
                    {
                        if (PK2Explorer.SelectedItems[0].SubItems[1].Text == "File")
                        {
                            PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()).Delete();
                        } else
                        {
                            PK2.GetDirectory(PK2Explorer.SelectedItems[0].Tag.ToString()).Delete();
                        }
                        Common.Dashboard.writeLog($"{SelctedItem} deleted successfully.", 1);
                        PK2Explorer.SelectedItems[0].Remove();
                    }
                    catch
                    {
                        Common.Dashboard.writeLog($"Error while deleting {SelctedItem}.", 0);
                    }
                }
            }
            catch
            {
                Common.Dashboard.writeLog($"No item was selected.");
            }
        }
        
        private void PK2_Rename(object sender, EventArgs e)
        {
            try
            {
                string SelctedItem = PK2Explorer.SelectedItems[0].Text;
                new inputDialog("Rename","Enter a new name to this part.").ShowDialog();
                //Save the DialogResult as res
                /*DialogResult res = InputBox.ShowDialog($"Do you want to rename {SelctedItem}?",
                     $"Rename {SelctedItem}.",   //Text message (mandatory), Title (optional)
                    InputBox.Icon.Question, //Set icon type (default info)
                    InputBox.Buttons.OkCancel, //Set buttons (default ok)
                    InputBox.Type.TextBox, //Set type (default nothing)
                    null, //String field as ComboBox items (default null)
                    true //Set visible in taskbar (default false)
                    );*/

                //DialogResult ExtractDialog = MessageBox.Show(, $"Rename {SelctedItem}.", MessageBoxButtons.YesNo);
                if (Common.dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // make sure this dialogInputResult is not null and not affected by an old value
                        string newName = Common.dialogInputResult + Path.GetExtension(PK2Explorer.SelectedItems[0].Text);
                        if (PK2Explorer.SelectedItems[0].SubItems[1].Text == "File")
                        {
                            PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()).Rename(newName); // add GetDirectory
                        } else
                        {
                            PK2.GetDirectory(PK2Explorer.SelectedItems[0].Tag.ToString()).Rename(newName);
                        }
                        Common.Dashboard.writeLog($"{SelctedItem} renamed to {newName} successfully.", 1);
                        // make renaming directories
                        //PK2Entry.Create(PK2EntryType.File, PK2.GetDirectory(PK2Explorer.SelectedItems[0].Tag.ToString()), "newitem.ddj");
                        //PK2Entry.Create(PK2EntryType.File, PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()), "newitem.ddj");
                        PK2Explorer.SelectedItems[0].Text = newName;
                    }
                    catch (Exception error)
                    {
                        Common.Dashboard.writeLog($"Error while changing {SelctedItem} name. {error}", 0);
                    }
                }
            }
            catch(Exception error)
            {
                Common.Dashboard.writeLog($"No item was selected."+error);
            }
        }

        private void tPK2Directory_DragDrop(object sender, DragEventArgs e)
        {
            string[] PK2filesPath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string PK2filePath in PK2filesPath)
            {
                tPK2Directory.Text = PK2filePath;
                PK2FilePath = PK2filePath;
            }
        }

        private void tPK2Directory_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ClosePK2_Click(object sender, EventArgs e)
        {
            PK2.Dispose();
            PK2 = null;
            PK2FilePath = string.Empty;
            tPK2Directory.Text = "C:/";
            inMediaPath.Text = "/";
            PK2Tree.Nodes.Clear();
            PK2Explorer.Items.Clear();
            eCounter.Text = null;
            OpenMedia.Enabled = true;
            LoadPK.Enabled = true;
            ClosePK2.Visible = false;
        }
        
        private void PK2Explorer_DoubleClick(object sender, EventArgs e)
        {
            if (PK2Explorer.SelectedItems[0].SubItems[1].Text == "Directory")
            {
                inMediaPath.Text = PK2Explorer.SelectedItems[0].Tag.ToString();
                inMediaGo.PerformClick();
            }
        }

        private void PK2Explorer_DragDrop(object sender, DragEventArgs e)
        {
            if (PK2 != null)
            {
                try
                {
                    var Data = e.Data.GetData(DataFormats.FileDrop);
                    if (Data != null)
                    {
                        var Files = Data as string[];
                        if (Files.Length > 0)
                        {
                            new dialog($"Import to {Path.GetFileName(PK2FilePath)}", $"Sure you want to import {Files[0]} to {inMediaPath.Text}").ShowDialog();
                            if (Common.dialogResult == DialogResult.Yes)
                            {
                                // TODO, fix importing file toroot directory
                                // import folders
                                // when delete file remove all bytes
                                // Get dat

                                if (PK2.GetFile(inMediaPath.Text + "/" + Path.GetFileName(Files[0])) == null)
                                {
                                    PK2Entry.Create(PK2EntryType.File, PK2.GetDirectory(inMediaPath.Text), Path.GetFileName(Files[0]), File.ReadAllBytes(Files[0]));
                                    Common.Dashboard.writeLog($"{Path.GetFileName(Files[0])} imported suucessfully!", 1);
                                }
                                else
                                {
                                    // needs more work
                                    // var PK2File = 
                                    PK2.GetFile(inMediaPath.Text + "/" + Path.GetFileName(Files[0])).Delete();
                                    PK2Entry.Create(PK2EntryType.File, PK2.GetDirectory(inMediaPath.Text), Path.GetFileName(Files[0]), File.ReadAllBytes(Files[0]));
                                    Common.Dashboard.writeLog($"{Path.GetFileName(Files[0])} Already exist so it will be overwritten", 1);

                                    //byte[] newBytes = File.ReadAllBytes(Files[0]); // new file bytes
                                    //PK2File.Size = (uint)newBytes.Length;
                                    //PK2File.Type = type;
                                    /*PK2File.AccessTime = DateTime.Now;
                                    PK2File.CreateTime = DateTime.Now;
                                    PK2File.ModifyTime = DateTime.Now;
                                    PK2File.Name = Path.GetFileName(Files[0]);
                                    //Write file to PK2 and assign the position
                                    PK2File.Position = (ulong)FileAdapter.GetInstance().WriteData(newBytes, 0);
                                    PK2File.Save();
                                    Common.Dashboard.writeLog($"{Path.GetFileName(Files[0])} Already exist so it will be overwritten", 1); ;*/
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }

        private void PK2Explorer_DragEnter(object sender, DragEventArgs e)
        {
            if (PK2 != null)
                e.Effect = DragDropEffects.All;
        }

        private void PK2Explorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //TODO
            // Extract item when drag to custom location
            // when user drags ddj show a dialog box with combox box of images types to ask which type should be saved as png, dds or ddj
            try{
                DataObject dObject = new DataObject();
                string SelectedItem = PK2Explorer.SelectedItems[0].Text;
                dObject.SetData(DataFormats.FileDrop, SelectedItem);
                DoDragDrop(dObject, DragDropEffects.All);

                if (PK2Explorer.SelectedItems[0].SubItems[1].Text == "File")
                {
                    PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()).Extract($"{Directory.GetCurrentDirectory()}/extract/{SelectedItem}");
                }
                else
                {
                    foreach (var File in PK2.GetFiles(PK2Explorer.SelectedItems[0].Tag.ToString(), false))
                    {
                        PK2.GetFile(File.Path).Extract($"{Directory.GetCurrentDirectory()}/extract/{File.Name}");
                    }
                }
                Common.Dashboard.writeLog($"{SelectedItem} extracted successfully.", 1);
            } catch { }
        }

        private void PK2Explorer_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    string SelctedItem = PK2Explorer.SelectedItems[0].Text;
                    Console.WriteLine(PK2Explorer.SelectedItems[0].Tag);
                    if (PK2Explorer.SelectedItems[0].SubItems[1].Text == "File" && SelctedItem.ToLower().Contains(".ddj"))
                    {
                        byte[] ddjBytes = PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()).GetData();
                        ArraySegment<byte> toDDS = new ArraySegment<byte>(ddjBytes, 20, ddjBytes.Length - 20);
                        Bitmap Image = _DDS.LoadImage(toDDS.ToArray());
                        new imagePreview(SelctedItem, Image).ShowDialog();

                    }
                    else if ((PK2Explorer.SelectedItems[0].SubItems[1].Text == "File" && SelctedItem.ToLower().Contains(".txt")))
                    {
                        byte[] FileBytes = PK2.GetFile(PK2Explorer.SelectedItems[0].Tag.ToString()).GetData();
                        string data = Encoding.GetEncoding(1252).GetString(FileBytes);
                        new textPreview(SelctedItem, data).ShowDialog();
                    }
                }
            }
            catch (Exception er)
            {
                Common.Dashboard.writeLog($"Error while reading file.", 1);
                new message(er.Message).Show();
            }
        }
    }
}
