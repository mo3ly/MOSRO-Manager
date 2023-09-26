using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSyntaxHighlighter;

namespace MOSROManager
{
    // add query syntax colors
    // changes quries to folder instead of json
    // DBs - load tables and databases
    // Load stored precodures

    public partial class QueryWindow : Form
    {
        // Queries map.
        Dictionary<string, string> Queries = new Dictionary<string, string>();
        private int pageNumber = 0;
        private int searchColumnID = 0;
        bool isLoaded = false;

        public QueryWindow()
        {
            InitializeComponent();
            // load previous queries
            loadQueries();
            // Syntax
            var syntaxHighlighter = new SyntaxHighlighter(QueryTextBox);
            // multi-line comments
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"/\*(.|[\r\n])*?\*/", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.DarkSeaGreen, false, true));
            // singlie-line comments
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"//.*?$", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.Green, false, true));
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"--.*?$", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.Green, false, true));
            // varaiable
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition("@"), new SyntaxStyle(Color.Blue, true, false));
            // numbers
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\d+\.\d+|\d+"), new SyntaxStyle(Color.Purple));
            // double quote strings
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\""([^""]|\""\"")+\"""), new SyntaxStyle(Color.DarkRed));
            // single quote strings
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\'([^']|\'\')+\'"), new SyntaxStyle(Color.Red));
            // keywords1
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition("int", "bigint", "datetime", "smallint", "tinyint", "varchar", "nvarchar"), new SyntaxStyle(Color.Blue));
            // keywords2
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition("declare", "create", "set", "no", "nocount", "into", "nolock", "exists", "on", "alter", "off", "not", "select", "with", "execute", "update", "or", "end", "rollback", "procedure", "commit", "insert", "values", "transaction", "from", "for", "foreach", "close", "next", "exec", "where", "is", "null", "return", "order", "by", "in", "as", "and", "if", "begin", "else", "fetch"), new SyntaxStyle(Color.Navy, true, false));
            // operators and brackets
            syntaxHighlighter.AddPattern(new PatternDefinition("+", "-", ">", "<", "&", "|", "(", ")", "="), new SyntaxStyle(Color.Brown));
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void LoadData()
        {
            // change theme
            SetWindowTheme(DBTree.Handle, "explorer", null);

            // QueryImageList
            string ImgSrc = Directory.GetCurrentDirectory() + "/Resources/UI-icons/";
            ImageList ImageList = new ImageList();
            ImageList.Images.Add(Image.FromFile(ImgSrc + "icon-query-b.png"));
            ImageList.Images.Add(Image.FromFile(ImgSrc + "icon-table-b.png"));
            ImageList.Images.Add(Image.FromFile(ImgSrc + "icon-procedure-b.png"));
            DBTree.ImageList = ImageList;
            try
            {
                SqlDataReader SQLDBs = await Common.SqlConnection.GetReaderResult("SELECT name FROM sys.databases where name not in ('master','model','msdb','tempdb')");
                while (await SQLDBs.ReadAsync())
                {
                    List<TreeNode> TablesList = new List<TreeNode>();
                    SqlDataReader SQLTables = await Common.SqlConnection.GetReaderResult("USE {0} SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", SQLDBs["name"]);

                    TreeNode parentNode = DBTree.Nodes.Add(SQLDBs["name"].ToString());
                    while (await SQLTables.ReadAsync())
                    {
                        TablesList.Add(new TreeNode(SQLTables["TABLE_NAME"].ToString(), 1, 1));
                    }

                    List<TreeNode> ProceduresList = new List<TreeNode>();
                    SqlDataReader SQLProcedures = await Common.SqlConnection.GetReaderResult("SELECT * FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'", SQLDBs["name"]);
                    while (await SQLProcedures.ReadAsync())
                    {
                        ProceduresList.Add(new TreeNode(SQLProcedures["ROUTINE_NAME"].ToString(), 2, 2));
                    }

                    parentNode.Nodes.Add(new TreeNode("Tables", 1, 1, TablesList.ToArray()));
                    parentNode.Nodes.Add(new TreeNode("Procedures", 2, 2, ProceduresList.ToArray()));
                }
            }
            catch
            {
                new message("Error while loading database data").Show();
            }
            isLoaded = true;
        }

        private void loadQueries()
        {
            // change theme
            SetWindowTheme(pQueriesTree.Handle, "explorer", null);

            // QueryImageList
            string ImageSrc = Directory.GetCurrentDirectory() + "/Resources/UI-icons/";
            ImageList QueryImageList = new ImageList();
            QueryImageList.Images.Add(Image.FromFile(ImageSrc + "icon-query-b.png"));
            pQueriesTree.ImageList = QueryImageList;
            try
            {
                // add file handeling
                string Data = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Required/queries.json"));
                dynamic Json = JsonConvert.DeserializeObject<dynamic>(Data);
                foreach (var parent in Json)
                {
                    List<TreeNode> ChildList = new List<TreeNode>();
                    foreach (var child in parent.Value)
                    {
                        Queries.Add((string)child.Name, (string)child.Value);
                        ChildList.Add(new TreeNode(child.Name, 0, 0));
                    }
                    pQueriesTree.Nodes.Add(new TreeNode(parent.Name, ChildList.ToArray()));

                }
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading queries: " + error.Message, 0);
            }

        }

        private async void ExecuteQuery_ClickAsync(object sender, EventArgs e)
        {
            if (QueryTextBox.Text.Length > 1)
                await Execute();
            else
                new message("The query box is empty.").Show();
        }

        private async Task Execute()
        {
            pageNumber = 0;
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            nextPage.Enabled = true;
            // Execute to table
            if (radioGridResult.Checked)
            {
                try
                {
                    await ExecuteToGrid(pageNumber);
                    paginationLabel.Visible = true;
                    searchBox.Visible = true;
                    searchGrid.Visible = true;
                    SearchBy.Visible = true;
                }
                catch (Exception ex)
                {
                    Common.Dashboard.writeLog("Exception Error: " + ex, 0);
                    new message("Exception Error: " + ex).Show();
                }
            }
            // Execute only
            else if (radioExecuteOnly.Checked)
            {
                try
                {
                    QueryGridResult.DataSource = null; // clear grid
                    int Results = await Common.SqlConnection.ExecuteAsync(QueryTextBox.Text);
                    if (Results < 0)
                    {
                        RowsCountNumber.Text = "0 affected";
                        // Query text result
                        QueryTextResult.Text = null;
                        QueryTextResult.Text = String.Format("No row(s) affected - Query {1}", Results, QueryTextBox.Text);
                        Common.Dashboard.writeLog("No row(s) affected - Query: " + QueryTextBox.Text, 1);
                    }
                    else
                    {
                        RowsCountNumber.Text = $"{Results} affected";
                        // Query text result
                        QueryTextResult.Text = null;
                        QueryTextResult.Text = String.Format("{0} Row(s) Updated - Query {1}", Results, QueryTextBox.Text);
                        Common.Dashboard.writeLog(String.Format("{0} Row(s) Updated - Query {1}", Results, QueryTextBox.Text), 1);
                    }
                    paginationLabel.Visible = false;
                    searchBox.Visible = false;
                    searchGrid.Visible = false;
                    SearchBy.Visible = false;
                }
                catch (Exception ex)
                {
                    Common.Dashboard.writeLog("Exception Error: " + ex, 0);
                    new message("Exception Error: " + ex).Show();
                }
            }
        }

        private async Task ExecuteToGrid(int pageNumber)
        {
            paginationLabel.Enabled = false;
            searchBox.Visible = false;
            searchGrid.Visible = false;
            SearchBy.Visible = false;
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                // prepare query
                string Query = null;
                if (QueryTextBox.Text.ToLower().Contains("order"))
                    Query = QueryTextBox.Text + $" OFFSET {pageNumber * RowPerPage.Value} ROWS FETCH NEXT {RowPerPage.Value} ROWS ONLY";
                else
                    Query = QueryTextBox.Text + $" ORDER BY 1 OFFSET {pageNumber * RowPerPage.Value} ROWS FETCH NEXT {RowPerPage.Value} ROWS ONLY";
                DataTable results = await Common.SqlConnection.GetDataSet(Query);
                watch.Stop();
                QueryGridResult.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                if (results.Columns.Count < 8)
                    QueryGridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                else
                    QueryGridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                QueryGridResult.DataSource = results;
                ExecutionTime.Text = watch.ElapsedMilliseconds.ToString() + " MS";
                RowsCountNumber.Text = (QueryGridResult.Rows.Count).ToString();
                QueryGridResult.ClearSelection();
                Common.Dashboard.writeLog("Query executed: " + QueryTextBox.Text, 1);
                paginationLabel.Enabled = true;
                searchBox.Visible = true;
                searchGrid.Visible = true;
                SearchBy.Visible = true;
                SearchBy.Text = "Search By: " + QueryGridResult.Columns[0].HeaderText;
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("SQL Error: " + error.Message, 0);
                new message("Exception Error: " + error.Message).Show();
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (radioExecuteOnly.Checked)
            {
                QueryTextResult.Visible = true;
                QueryGridResult.Visible = false;
            }
            else
            {
                QueryTextResult.Visible = false;
                QueryGridResult.Visible = true;
            }
        }

        private void pQueriesTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (pQueriesTree.SelectedNode != null && Queries.ContainsKey(pQueriesTree.SelectedNode.Text))
            {
                QueryTextBox.Text = Queries[pQueriesTree.SelectedNode.Text];
            }
        }

        private async void nextPage_ClickAsync(object sender, EventArgs e)
        {
            pageNumber += 1;
            await ExecuteToGrid(pageNumber);
            pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
            if (QueryGridResult.Rows.Count == 0)
            {
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = false;
                //previousPage.PerformClick();
            }
        }

        private async void previousPage_ClickAsync(object sender, EventArgs e)
        {
            if (pageNumber > 0)
            {
                pageNumber -= 1;
                await ExecuteToGrid(pageNumber);
                pageNumberLabel.Text = "Page " + (pageNumber + 1).ToString();
                nextPage.Enabled = true;
            }
        }


        private void ChangeSearchIndex(object sender, DataGridViewCellEventArgs e)
        {
            searchColumnID = e.ColumnIndex;

            SearchBy.Text = "Search By: " + QueryGridResult.Columns[e.ColumnIndex].HeaderText;
        }

        private void reloadQuires_Click(object sender, EventArgs e)
        {
            isLoaded = false;
            pQueriesTree.Nodes.Clear();
            DBTree.Nodes.Clear();
            Queries.Clear();
            loadQueries();
            LoadData();
            Common.Dashboard.writeLog("Queires and tables list has been loaded successfully.", 1);
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (QueryGridResult.Rows.Count > 0)
            {
                QueryGridResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                QueryGridResult.CurrentCell = null;
                try
                {
                    foreach (DataGridViewRow row in QueryGridResult.Rows)
                    {
                        string Cell = row.Cells[searchColumnID].Value.ToString();
                        if (Cell != null && Cell.ToLower().Contains(searchBox.Text.ToLower()))
                        {
                            QueryGridResult.ClearSelection();
                            row.Selected = true;
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
                catch (Exception error)
                {
                    Common.Dashboard.writeLog("Error: " + error.Message, 0);
                }
            }
        }

        private void bDropMenu_Click(object sender, EventArgs e)
        {
            pDropMenu.Visible = pDropMenu.Visible ? false : true;
        }


        private void bDBdata_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                LoadData(); //Load SQL Data
            }
            DBTree.Visible = true;
            pQueriesTree.Visible = false;
            bDBdata.BackColor = Color.DarkKhaki;
            bStoredQueries.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void bStoredQueries_Click(object sender, EventArgs e)
        {
            DBTree.Visible = false;
            pQueriesTree.Visible = true;
            bStoredQueries.BackColor = Color.DarkKhaki;
            bDBdata.BackColor = Color.FromArgb(31, 31, 31);
        }

        private async void DBTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent.Text == "Tables")
                {
                    new dialog($"Load {e.Node.Text}", "Are you sure you want to load table data?").ShowDialog();
                    if (Common.dialogResult == DialogResult.Yes)
                    {
                        QueryTextBox.Text = $"SELECT * FROM {e.Node.Parent.Parent.Text}..{e.Node.Text}";
                        ExecuteQuery.PerformClick();
                    }
                }
                else if (e.Node.Parent.Text == "Procedures")
                {
                    new dialog($"Load {e.Node.Text}", "Are you sure you want to load procedure content?").ShowDialog();
                    if (Common.dialogResult == DialogResult.Yes)
                    {
                        QueryTextBox.Text = await Common.SqlConnection.QueryFetchCell<string>($"SELECT ROUTINE_DEFINITION FROM {e.Node.Parent.Parent.Text}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' AND ROUTINE_NAME = '{e.Node.Text}'", "ROUTINE_DEFINITION");
                    }
                }
            }
            catch { }

        }

        private void ClearQueryBox_Click(object sender, EventArgs e)
        {
            new dialog("Clear Query box", "Are you sure you want to clear query content?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                QueryTextBox.Text = "";
                // Clear data grid and data execute
            }
        }

        private void QueryGridResult_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try to detect the database and table to update cell
            Console.WriteLine(QueryGridResult.Rows[e.RowIndex].Selected);
            Console.WriteLine(QueryGridResult.Columns[e.ColumnIndex].HeaderText);
            Console.WriteLine(QueryGridResult.SelectedCells[0].Value);
        }

        #region SaveQuery
        private void bSaveQueryToggle_Click(object sender, EventArgs e)
        {
            mDropSaveQuery.Visible = mDropSaveQuery.Visible ? false : true;
        }
        #endregion

        private void bSaveQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (tSectionName.Text.Length <= 2 || tQueryName.Text.Length <= 2 || QueryTextBox.Text.Length <= 2)
                {
                    Common.Dashboard.writeLog("Query box, Query name or section can't be empty or less than 2 character.", 0);
                    return;
                }

                string filePath = Directory.GetCurrentDirectory() + "/Required/queries.json";
                var fileData = File.ReadAllText(filePath);

                dynamic JsonData = JsonConvert.DeserializeObject<dynamic>(fileData);

                // check if section is already found add to it
                // check if same query name is found update it
                JsonData[tSectionName.Text] = new JObject
                {
                    { tQueryName.Text, QueryTextBox.Text.Replace(Environment.NewLine, "\\n") }
                };

                JsonData = JsonConvert.SerializeObject(JsonData);
                File.WriteAllText(filePath, JsonData);

                Common.Dashboard.writeLog($"{tQueryName.Text} Query has been added successfully.", 1);
                reloadQuires.PerformClick();
            } catch {
                Common.Dashboard.writeLog("Couldn't save the new query", 0);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
