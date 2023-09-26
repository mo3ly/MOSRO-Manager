namespace MOSROManager
{
    partial class QueryWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.basePanel = new System.Windows.Forms.Panel();
            this.layoutPanel = new System.Windows.Forms.Panel();
            this.mDropSaveQuery = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tSectionName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tQueryName = new System.Windows.Forms.TextBox();
            this.bSaveQuery = new System.Windows.Forms.Button();
            this.bSaveQueryToggle = new System.Windows.Forms.Button();
            this.pDropMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bStoredQueries = new System.Windows.Forms.Button();
            this.bDBdata = new System.Windows.Forms.Button();
            this.paginationLabel = new System.Windows.Forms.GroupBox();
            this.pageNumberLabel = new System.Windows.Forms.Label();
            this.previousPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.searchGrid = new System.Windows.Forms.Button();
            this.ClearQueryBox = new System.Windows.Forms.Button();
            this.reloadQuires = new System.Windows.Forms.Button();
            this.QueryTextResult = new System.Windows.Forms.RichTextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RowPerPage = new System.Windows.Forms.NumericUpDown();
            this.ExecutionTime = new System.Windows.Forms.Label();
            this.RowsCountNumber = new System.Windows.Forms.Label();
            this.RowsCount = new System.Windows.Forms.Label();
            this.ExecutionTimeLabel = new System.Windows.Forms.Label();
            this.radioExecuteOnly = new System.Windows.Forms.RadioButton();
            this.radioGridResult = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.bDropMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryGridResult = new System.Windows.Forms.DataGridView();
            this.ExecuteQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QueriesListPanel = new System.Windows.Forms.Panel();
            this.pQueriesTree = new System.Windows.Forms.TreeView();
            this.DBTree = new System.Windows.Forms.TreeView();
            this.QueryBoxPanel = new System.Windows.Forms.Panel();
            this.QueryTextBox = new System.Windows.Forms.RichTextBox();
            this.basePanel.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.mDropSaveQuery.SuspendLayout();
            this.pDropMenu.SuspendLayout();
            this.paginationLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowPerPage)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryGridResult)).BeginInit();
            this.QueriesListPanel.SuspendLayout();
            this.QueryBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.basePanel.Controls.Add(this.layoutPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Margin = new System.Windows.Forms.Padding(2);
            this.basePanel.Name = "basePanel";
            this.basePanel.Padding = new System.Windows.Forms.Padding(1);
            this.basePanel.Size = new System.Drawing.Size(900, 731);
            this.basePanel.TabIndex = 0;
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.layoutPanel.Controls.Add(this.mDropSaveQuery);
            this.layoutPanel.Controls.Add(this.bSaveQueryToggle);
            this.layoutPanel.Controls.Add(this.pDropMenu);
            this.layoutPanel.Controls.Add(this.bStoredQueries);
            this.layoutPanel.Controls.Add(this.bDBdata);
            this.layoutPanel.Controls.Add(this.paginationLabel);
            this.layoutPanel.Controls.Add(this.searchGrid);
            this.layoutPanel.Controls.Add(this.ClearQueryBox);
            this.layoutPanel.Controls.Add(this.reloadQuires);
            this.layoutPanel.Controls.Add(this.QueryTextResult);
            this.layoutPanel.Controls.Add(this.searchBox);
            this.layoutPanel.Controls.Add(this.label4);
            this.layoutPanel.Controls.Add(this.RowPerPage);
            this.layoutPanel.Controls.Add(this.ExecutionTime);
            this.layoutPanel.Controls.Add(this.RowsCountNumber);
            this.layoutPanel.Controls.Add(this.RowsCount);
            this.layoutPanel.Controls.Add(this.ExecutionTimeLabel);
            this.layoutPanel.Controls.Add(this.radioExecuteOnly);
            this.layoutPanel.Controls.Add(this.radioGridResult);
            this.layoutPanel.Controls.Add(this.label5);
            this.layoutPanel.Controls.Add(this.HeaderPanel);
            this.layoutPanel.Controls.Add(this.SearchBy);
            this.layoutPanel.Controls.Add(this.label1);
            this.layoutPanel.Controls.Add(this.QueryGridResult);
            this.layoutPanel.Controls.Add(this.ExecuteQuery);
            this.layoutPanel.Controls.Add(this.label3);
            this.layoutPanel.Controls.Add(this.QueriesListPanel);
            this.layoutPanel.Controls.Add(this.QueryBoxPanel);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(1, 1);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(898, 729);
            this.layoutPanel.TabIndex = 0;
            // 
            // mDropSaveQuery
            // 
            this.mDropSaveQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mDropSaveQuery.Controls.Add(this.label6);
            this.mDropSaveQuery.Controls.Add(this.tSectionName);
            this.mDropSaveQuery.Controls.Add(this.label27);
            this.mDropSaveQuery.Controls.Add(this.tQueryName);
            this.mDropSaveQuery.Controls.Add(this.bSaveQuery);
            this.mDropSaveQuery.Location = new System.Drawing.Point(340, 69);
            this.mDropSaveQuery.Margin = new System.Windows.Forms.Padding(2);
            this.mDropSaveQuery.Name = "mDropSaveQuery";
            this.mDropSaveQuery.Size = new System.Drawing.Size(150, 141);
            this.mDropSaveQuery.TabIndex = 65;
            this.mDropSaveQuery.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 49;
            this.label6.Text = "Section Name";
            // 
            // tSectionName
            // 
            this.tSectionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSectionName.BackColor = System.Drawing.Color.White;
            this.tSectionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSectionName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tSectionName.Location = new System.Drawing.Point(9, 72);
            this.tSectionName.Margin = new System.Windows.Forms.Padding(2);
            this.tSectionName.Name = "tSectionName";
            this.tSectionName.Size = new System.Drawing.Size(130, 22);
            this.tSectionName.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 9F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(7, 8);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 14);
            this.label27.TabIndex = 47;
            this.label27.Text = "Query Name";
            // 
            // tQueryName
            // 
            this.tQueryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tQueryName.BackColor = System.Drawing.Color.White;
            this.tQueryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tQueryName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tQueryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tQueryName.Location = new System.Drawing.Point(9, 24);
            this.tQueryName.Margin = new System.Windows.Forms.Padding(2);
            this.tQueryName.Name = "tQueryName";
            this.tQueryName.Size = new System.Drawing.Size(130, 22);
            this.tQueryName.TabIndex = 46;
            // 
            // bSaveQuery
            // 
            this.bSaveQuery.BackColor = System.Drawing.Color.DarkKhaki;
            this.bSaveQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveQuery.ForeColor = System.Drawing.SystemColors.Control;
            this.bSaveQuery.Location = new System.Drawing.Point(10, 107);
            this.bSaveQuery.Margin = new System.Windows.Forms.Padding(2);
            this.bSaveQuery.Name = "bSaveQuery";
            this.bSaveQuery.Size = new System.Drawing.Size(68, 22);
            this.bSaveQuery.TabIndex = 40;
            this.bSaveQuery.Text = "Save";
            this.bSaveQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSaveQuery.UseVisualStyleBackColor = false;
            this.bSaveQuery.Click += new System.EventHandler(this.bSaveQuery_Click);
            // 
            // bSaveQueryToggle
            // 
            this.bSaveQueryToggle.BackColor = System.Drawing.SystemColors.Control;
            this.bSaveQueryToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveQueryToggle.ForeColor = System.Drawing.SystemColors.Control;
            this.bSaveQueryToggle.Image = ((System.Drawing.Image)(resources.GetObject("bSaveQueryToggle.Image")));
            this.bSaveQueryToggle.Location = new System.Drawing.Point(338, 41);
            this.bSaveQueryToggle.Margin = new System.Windows.Forms.Padding(2);
            this.bSaveQueryToggle.Name = "bSaveQueryToggle";
            this.bSaveQueryToggle.Size = new System.Drawing.Size(28, 25);
            this.bSaveQueryToggle.TabIndex = 65;
            this.bSaveQueryToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSaveQueryToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSaveQueryToggle.UseVisualStyleBackColor = false;
            this.bSaveQueryToggle.Click += new System.EventHandler(this.bSaveQueryToggle_Click);
            // 
            // pDropMenu
            // 
            this.pDropMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pDropMenu.Controls.Add(this.button6);
            this.pDropMenu.Controls.Add(this.button4);
            this.pDropMenu.Controls.Add(this.button3);
            this.pDropMenu.Location = new System.Drawing.Point(718, 37);
            this.pDropMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pDropMenu.Name = "pDropMenu";
            this.pDropMenu.Size = new System.Drawing.Size(150, 109);
            this.pDropMenu.TabIndex = 64;
            this.pDropMenu.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 68);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "Sub Menu 3";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 34);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sub Menu 2";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Backup";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // bStoredQueries
            // 
            this.bStoredQueries.BackColor = System.Drawing.Color.DarkKhaki;
            this.bStoredQueries.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bStoredQueries.FlatAppearance.BorderSize = 0;
            this.bStoredQueries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bStoredQueries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bStoredQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStoredQueries.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStoredQueries.ForeColor = System.Drawing.Color.White;
            this.bStoredQueries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStoredQueries.Location = new System.Drawing.Point(28, 72);
            this.bStoredQueries.Margin = new System.Windows.Forms.Padding(2);
            this.bStoredQueries.Name = "bStoredQueries";
            this.bStoredQueries.Size = new System.Drawing.Size(112, 23);
            this.bStoredQueries.TabIndex = 63;
            this.bStoredQueries.Text = "Stored Queries";
            this.bStoredQueries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStoredQueries.UseVisualStyleBackColor = false;
            this.bStoredQueries.Click += new System.EventHandler(this.bStoredQueries_Click);
            // 
            // bDBdata
            // 
            this.bDBdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bDBdata.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bDBdata.FlatAppearance.BorderSize = 0;
            this.bDBdata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bDBdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bDBdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDBdata.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDBdata.ForeColor = System.Drawing.Color.White;
            this.bDBdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDBdata.Location = new System.Drawing.Point(144, 72);
            this.bDBdata.Margin = new System.Windows.Forms.Padding(2);
            this.bDBdata.Name = "bDBdata";
            this.bDBdata.Size = new System.Drawing.Size(107, 23);
            this.bDBdata.TabIndex = 63;
            this.bDBdata.Text = "SQL Data";
            this.bDBdata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDBdata.UseVisualStyleBackColor = false;
            this.bDBdata.Click += new System.EventHandler(this.bDBdata_Click);
            // 
            // paginationLabel
            // 
            this.paginationLabel.Controls.Add(this.pageNumberLabel);
            this.paginationLabel.Controls.Add(this.previousPage);
            this.paginationLabel.Controls.Add(this.nextPage);
            this.paginationLabel.Location = new System.Drawing.Point(416, 668);
            this.paginationLabel.Margin = new System.Windows.Forms.Padding(2);
            this.paginationLabel.Name = "paginationLabel";
            this.paginationLabel.Padding = new System.Windows.Forms.Padding(2);
            this.paginationLabel.Size = new System.Drawing.Size(141, 37);
            this.paginationLabel.TabIndex = 61;
            this.paginationLabel.TabStop = false;
            this.paginationLabel.Visible = false;
            // 
            // pageNumberLabel
            // 
            this.pageNumberLabel.AutoSize = true;
            this.pageNumberLabel.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pageNumberLabel.Location = new System.Drawing.Point(51, 14);
            this.pageNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageNumberLabel.Name = "pageNumberLabel";
            this.pageNumberLabel.Size = new System.Drawing.Size(40, 14);
            this.pageNumberLabel.TabIndex = 42;
            this.pageNumberLabel.Text = "Page 1";
            // 
            // previousPage
            // 
            this.previousPage.BackColor = System.Drawing.SystemColors.Control;
            this.previousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousPage.ForeColor = System.Drawing.SystemColors.Control;
            this.previousPage.Image = ((System.Drawing.Image)(resources.GetObject("previousPage.Image")));
            this.previousPage.Location = new System.Drawing.Point(0, 4);
            this.previousPage.Margin = new System.Windows.Forms.Padding(2);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(42, 35);
            this.previousPage.TabIndex = 41;
            this.previousPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.previousPage.UseVisualStyleBackColor = false;
            this.previousPage.Click += new System.EventHandler(this.previousPage_ClickAsync);
            // 
            // nextPage
            // 
            this.nextPage.BackColor = System.Drawing.SystemColors.Control;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPage.ForeColor = System.Drawing.SystemColors.Control;
            this.nextPage.Image = ((System.Drawing.Image)(resources.GetObject("nextPage.Image")));
            this.nextPage.Location = new System.Drawing.Point(98, 4);
            this.nextPage.Margin = new System.Windows.Forms.Padding(2);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(44, 35);
            this.nextPage.TabIndex = 40;
            this.nextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.nextPage_ClickAsync);
            // 
            // searchGrid
            // 
            this.searchGrid.BackColor = System.Drawing.SystemColors.Control;
            this.searchGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGrid.ForeColor = System.Drawing.SystemColors.Control;
            this.searchGrid.Image = ((System.Drawing.Image)(resources.GetObject("searchGrid.Image")));
            this.searchGrid.Location = new System.Drawing.Point(354, 386);
            this.searchGrid.Margin = new System.Windows.Forms.Padding(2);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.Size = new System.Drawing.Size(28, 25);
            this.searchGrid.TabIndex = 58;
            this.searchGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchGrid.UseVisualStyleBackColor = false;
            this.searchGrid.Visible = false;
            this.searchGrid.Click += new System.EventHandler(this.searchBox_Enter);
            // 
            // ClearQueryBox
            // 
            this.ClearQueryBox.BackColor = System.Drawing.SystemColors.Control;
            this.ClearQueryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearQueryBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearQueryBox.Image = ((System.Drawing.Image)(resources.GetObject("ClearQueryBox.Image")));
            this.ClearQueryBox.Location = new System.Drawing.Point(308, 41);
            this.ClearQueryBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClearQueryBox.Name = "ClearQueryBox";
            this.ClearQueryBox.Size = new System.Drawing.Size(28, 25);
            this.ClearQueryBox.TabIndex = 58;
            this.ClearQueryBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearQueryBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearQueryBox.UseVisualStyleBackColor = false;
            this.ClearQueryBox.Click += new System.EventHandler(this.ClearQueryBox_Click);
            // 
            // reloadQuires
            // 
            this.reloadQuires.BackColor = System.Drawing.SystemColors.Control;
            this.reloadQuires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadQuires.ForeColor = System.Drawing.SystemColors.Control;
            this.reloadQuires.Image = ((System.Drawing.Image)(resources.GetObject("reloadQuires.Image")));
            this.reloadQuires.Location = new System.Drawing.Point(110, 44);
            this.reloadQuires.Margin = new System.Windows.Forms.Padding(2);
            this.reloadQuires.Name = "reloadQuires";
            this.reloadQuires.Size = new System.Drawing.Size(28, 25);
            this.reloadQuires.TabIndex = 58;
            this.reloadQuires.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reloadQuires.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reloadQuires.UseVisualStyleBackColor = false;
            this.reloadQuires.Click += new System.EventHandler(this.reloadQuires_Click);
            // 
            // QueryTextResult
            // 
            this.QueryTextResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QueryTextResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTextResult.ForeColor = System.Drawing.Color.White;
            this.QueryTextResult.Location = new System.Drawing.Point(29, 414);
            this.QueryTextResult.Margin = new System.Windows.Forms.Padding(2);
            this.QueryTextResult.Name = "QueryTextResult";
            this.QueryTextResult.ReadOnly = true;
            this.QueryTextResult.Size = new System.Drawing.Size(840, 250);
            this.QueryTextResult.TabIndex = 57;
            this.QueryTextResult.Text = "";
            this.QueryTextResult.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.searchBox.HideSelection = false;
            this.searchBox.Location = new System.Drawing.Point(272, 389);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(79, 22);
            this.searchBox.TabIndex = 56;
            this.searchBox.Text = "Search";
            this.searchBox.Visible = false;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(690, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 55;
            this.label4.Text = "(Rows per page)";
            // 
            // RowPerPage
            // 
            this.RowPerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RowPerPage.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.RowPerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RowPerPage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RowPerPage.Location = new System.Drawing.Point(778, 43);
            this.RowPerPage.Margin = new System.Windows.Forms.Padding(2);
            this.RowPerPage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RowPerPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowPerPage.Name = "RowPerPage";
            this.RowPerPage.Size = new System.Drawing.Size(90, 22);
            this.RowPerPage.TabIndex = 54;
            this.RowPerPage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ExecutionTime
            // 
            this.ExecutionTime.AutoSize = true;
            this.ExecutionTime.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.ExecutionTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExecutionTime.Location = new System.Drawing.Point(820, 672);
            this.ExecutionTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExecutionTime.Name = "ExecutionTime";
            this.ExecutionTime.Size = new System.Drawing.Size(49, 14);
            this.ExecutionTime.TabIndex = 52;
            this.ExecutionTime.Text = "00:00:00";
            // 
            // RowsCountNumber
            // 
            this.RowsCountNumber.AutoSize = true;
            this.RowsCountNumber.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.RowsCountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RowsCountNumber.Location = new System.Drawing.Point(775, 690);
            this.RowsCountNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RowsCountNumber.Name = "RowsCountNumber";
            this.RowsCountNumber.Size = new System.Drawing.Size(31, 14);
            this.RowsCountNumber.TabIndex = 51;
            this.RowsCountNumber.Text = "none";
            // 
            // RowsCount
            // 
            this.RowsCount.AutoSize = true;
            this.RowsCount.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.RowsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RowsCount.Location = new System.Drawing.Point(735, 690);
            this.RowsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RowsCount.Name = "RowsCount";
            this.RowsCount.Size = new System.Drawing.Size(46, 14);
            this.RowsCount.TabIndex = 50;
            this.RowsCount.Text = "Row(s): ";
            // 
            // ExecutionTimeLabel
            // 
            this.ExecutionTimeLabel.AutoSize = true;
            this.ExecutionTimeLabel.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.ExecutionTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExecutionTimeLabel.Location = new System.Drawing.Point(735, 672);
            this.ExecutionTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExecutionTimeLabel.Name = "ExecutionTimeLabel";
            this.ExecutionTimeLabel.Size = new System.Drawing.Size(86, 14);
            this.ExecutionTimeLabel.TabIndex = 49;
            this.ExecutionTimeLabel.Text = "Execution time: ";
            // 
            // radioExecuteOnly
            // 
            this.radioExecuteOnly.AutoSize = true;
            this.radioExecuteOnly.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.radioExecuteOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radioExecuteOnly.Location = new System.Drawing.Point(790, 392);
            this.radioExecuteOnly.Margin = new System.Windows.Forms.Padding(2);
            this.radioExecuteOnly.Name = "radioExecuteOnly";
            this.radioExecuteOnly.Size = new System.Drawing.Size(86, 18);
            this.radioExecuteOnly.TabIndex = 48;
            this.radioExecuteOnly.Text = "Execute only";
            this.radioExecuteOnly.UseVisualStyleBackColor = true;
            this.radioExecuteOnly.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioGridResult
            // 
            this.radioGridResult.AutoSize = true;
            this.radioGridResult.Checked = true;
            this.radioGridResult.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.radioGridResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radioGridResult.Location = new System.Drawing.Point(705, 392);
            this.radioGridResult.Margin = new System.Windows.Forms.Padding(2);
            this.radioGridResult.Name = "radioGridResult";
            this.radioGridResult.Size = new System.Drawing.Size(77, 18);
            this.radioGridResult.TabIndex = 46;
            this.radioGridResult.TabStop = true;
            this.radioGridResult.Text = "Grid result";
            this.radioGridResult.UseVisualStyleBackColor = true;
            this.radioGridResult.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(268, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Query";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HeaderPanel.Controls.Add(this.bDropMenu);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(898, 32);
            this.HeaderPanel.TabIndex = 42;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // bDropMenu
            // 
            this.bDropMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.bDropMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bDropMenu.FlatAppearance.BorderSize = 0;
            this.bDropMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.bDropMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bDropMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDropMenu.Image = ((System.Drawing.Image)(resources.GetObject("bDropMenu.Image")));
            this.bDropMenu.Location = new System.Drawing.Point(838, 0);
            this.bDropMenu.Margin = new System.Windows.Forms.Padding(2);
            this.bDropMenu.Name = "bDropMenu";
            this.bDropMenu.Size = new System.Drawing.Size(30, 32);
            this.bDropMenu.TabIndex = 30;
            this.bDropMenu.UseVisualStyleBackColor = true;
            this.bDropMenu.Click += new System.EventHandler(this.bDropMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(24, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Query Executar";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(868, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 32);
            this.ExitButton.TabIndex = 28;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchBy
            // 
            this.SearchBy.AutoSize = true;
            this.SearchBy.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SearchBy.Location = new System.Drawing.Point(120, 396);
            this.SearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(56, 14);
            this.SearchBy.TabIndex = 41;
            this.SearchBy.Text = "Search By:";
            this.SearchBy.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(28, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Query Result";
            // 
            // QueryGridResult
            // 
            this.QueryGridResult.AllowUserToAddRows = false;
            this.QueryGridResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.QueryGridResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QueryGridResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QueryGridResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryGridResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.QueryGridResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryGridResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QueryGridResult.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QueryGridResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.QueryGridResult.EnableHeadersVisualStyles = false;
            this.QueryGridResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QueryGridResult.Location = new System.Drawing.Point(30, 414);
            this.QueryGridResult.Margin = new System.Windows.Forms.Padding(2);
            this.QueryGridResult.Name = "QueryGridResult";
            this.QueryGridResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryGridResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.QueryGridResult.RowHeadersVisible = false;
            this.QueryGridResult.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QueryGridResult.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.QueryGridResult.RowTemplate.Height = 30;
            this.QueryGridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueryGridResult.Size = new System.Drawing.Size(838, 249);
            this.QueryGridResult.TabIndex = 40;
            this.QueryGridResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeSearchIndex);
            this.QueryGridResult.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.QueryGridResult_CellValueChanged);
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.BackColor = System.Drawing.Color.DarkKhaki;
            this.ExecuteQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteQuery.ForeColor = System.Drawing.SystemColors.Control;
            this.ExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("ExecuteQuery.Image")));
            this.ExecuteQuery.Location = new System.Drawing.Point(30, 672);
            this.ExecuteQuery.Margin = new System.Windows.Forms.Padding(2);
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Size = new System.Drawing.Size(158, 34);
            this.ExecuteQuery.TabIndex = 39;
            this.ExecuteQuery.Text = "Execute";
            this.ExecuteQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExecuteQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExecuteQuery.UseVisualStyleBackColor = false;
            this.ExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_ClickAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(27, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "SQL Quesires";
            // 
            // QueriesListPanel
            // 
            this.QueriesListPanel.BackColor = System.Drawing.Color.Silver;
            this.QueriesListPanel.Controls.Add(this.pQueriesTree);
            this.QueriesListPanel.Controls.Add(this.DBTree);
            this.QueriesListPanel.Location = new System.Drawing.Point(28, 104);
            this.QueriesListPanel.Margin = new System.Windows.Forms.Padding(2);
            this.QueriesListPanel.Name = "QueriesListPanel";
            this.QueriesListPanel.Padding = new System.Windows.Forms.Padding(1);
            this.QueriesListPanel.Size = new System.Drawing.Size(224, 266);
            this.QueriesListPanel.TabIndex = 45;
            // 
            // pQueriesTree
            // 
            this.pQueriesTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pQueriesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQueriesTree.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.pQueriesTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pQueriesTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pQueriesTree.Location = new System.Drawing.Point(1, 1);
            this.pQueriesTree.Margin = new System.Windows.Forms.Padding(2);
            this.pQueriesTree.Name = "pQueriesTree";
            this.pQueriesTree.ShowLines = false;
            this.pQueriesTree.Size = new System.Drawing.Size(222, 264);
            this.pQueriesTree.TabIndex = 36;
            this.pQueriesTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.pQueriesTree_NodeMouseDoubleClick);
            // 
            // DBTree
            // 
            this.DBTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBTree.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.DBTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DBTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DBTree.Location = new System.Drawing.Point(1, 1);
            this.DBTree.Margin = new System.Windows.Forms.Padding(2);
            this.DBTree.Name = "DBTree";
            this.DBTree.ShowLines = false;
            this.DBTree.Size = new System.Drawing.Size(222, 264);
            this.DBTree.TabIndex = 37;
            this.DBTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DBTree_NodeMouseClick);
            // 
            // QueryBoxPanel
            // 
            this.QueryBoxPanel.BackColor = System.Drawing.Color.Silver;
            this.QueryBoxPanel.Controls.Add(this.QueryTextBox);
            this.QueryBoxPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QueryBoxPanel.Location = new System.Drawing.Point(271, 69);
            this.QueryBoxPanel.Margin = new System.Windows.Forms.Padding(2);
            this.QueryBoxPanel.Name = "QueryBoxPanel";
            this.QueryBoxPanel.Padding = new System.Windows.Forms.Padding(1);
            this.QueryBoxPanel.Size = new System.Drawing.Size(598, 301);
            this.QueryBoxPanel.TabIndex = 44;
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.AcceptsTab = true;
            this.QueryTextBox.AutoWordSelection = true;
            this.QueryTextBox.BackColor = System.Drawing.Color.White;
            this.QueryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryTextBox.Font = new System.Drawing.Font("Calibri", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTextBox.ForeColor = System.Drawing.Color.Black;
            this.QueryTextBox.HideSelection = false;
            this.QueryTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.QueryTextBox.Location = new System.Drawing.Point(1, 1);
            this.QueryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(596, 299);
            this.QueryTextBox.TabIndex = 29;
            this.QueryTextBox.Text = "";
            this.QueryTextBox.WordWrap = false;
            // 
            // QueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(900, 731);
            this.ControlBox = false;
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QueryWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.basePanel.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.mDropSaveQuery.ResumeLayout(false);
            this.mDropSaveQuery.PerformLayout();
            this.pDropMenu.ResumeLayout(false);
            this.paginationLabel.ResumeLayout(false);
            this.paginationLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowPerPage)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryGridResult)).EndInit();
            this.QueriesListPanel.ResumeLayout(false);
            this.QueryBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel layoutPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExecuteQuery;
        private System.Windows.Forms.Panel QueriesListPanel;
        private System.Windows.Forms.Panel QueryBoxPanel;
        private System.Windows.Forms.RadioButton radioExecuteOnly;
        private System.Windows.Forms.RadioButton radioGridResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox QueryTextBox;
        private System.Windows.Forms.TreeView pQueriesTree;
        private System.Windows.Forms.Label ExecutionTimeLabel;
        private System.Windows.Forms.Label RowsCount;
        private System.Windows.Forms.Label RowsCountNumber;
        private System.Windows.Forms.Label ExecutionTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RowPerPage;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button reloadQuires;
        private System.Windows.Forms.Button searchGrid;
        private System.Windows.Forms.GroupBox paginationLabel;
        private System.Windows.Forms.Label pageNumberLabel;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.DataGridView QueryGridResult;
        private System.Windows.Forms.Button bStoredQueries;
        private System.Windows.Forms.Button bDBdata;
        private System.Windows.Forms.Panel pDropMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bDropMenu;
        private System.Windows.Forms.RichTextBox QueryTextResult;
        private System.Windows.Forms.TreeView DBTree;
        private System.Windows.Forms.Label SearchBy;
        private System.Windows.Forms.Button ClearQueryBox;
        private System.Windows.Forms.Panel mDropSaveQuery;
        private System.Windows.Forms.Button bSaveQuery;
        private System.Windows.Forms.Button bSaveQueryToggle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tSectionName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tQueryName;
    }
}