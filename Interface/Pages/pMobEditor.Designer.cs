namespace MOSROManager
{
    partial class pMobEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pMobEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tMobSearch = new System.Windows.Forms.TextBox();
            this.MobsGrid = new System.Windows.Forms.DataGridView();
            this.pageNumberLabel = new System.Windows.Forms.Label();
            this.previousPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.bSearchMob = new System.Windows.Forms.Button();
            this.EditGroup = new System.Windows.Forms.GroupBox();
            this.Code128 = new System.Windows.Forms.Label();
            this.mobCode128 = new System.Windows.Forms.TextBox();
            this.Level = new System.Windows.Forms.Label();
            this.mobLevel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MP = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.MaxSpawn = new System.Windows.Forms.Label();
            this.mobMP = new System.Windows.Forms.TextBox();
            this.mobHP = new System.Windows.Forms.TextBox();
            this.mobMaxSpawn = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RowsCountNumber = new System.Windows.Forms.Label();
            this.RowsCount = new System.Windows.Forms.Label();
            this.paginationLabel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MobsGrid)).BeginInit();
            this.EditGroup.SuspendLayout();
            this.paginationLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(61, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 2);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(56, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Monester";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(57, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Editor";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(743, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Monester Name";
            // 
            // tMobSearch
            // 
            this.tMobSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tMobSearch.BackColor = System.Drawing.Color.White;
            this.tMobSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMobSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMobSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tMobSearch.Location = new System.Drawing.Point(747, 50);
            this.tMobSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tMobSearch.Name = "tMobSearch";
            this.tMobSearch.Size = new System.Drawing.Size(189, 24);
            this.tMobSearch.TabIndex = 30;
            // 
            // MobsGrid
            // 
            this.MobsGrid.AllowUserToAddRows = false;
            this.MobsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MobsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MobsGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MobsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MobsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MobsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MobsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MobsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MobsGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MobsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MobsGrid.EnableHeadersVisualStyles = false;
            this.MobsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MobsGrid.Location = new System.Drawing.Point(61, 100);
            this.MobsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MobsGrid.Name = "MobsGrid";
            this.MobsGrid.ReadOnly = true;
            this.MobsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MobsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MobsGrid.RowHeadersVisible = false;
            this.MobsGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MobsGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MobsGrid.RowTemplate.Height = 30;
            this.MobsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MobsGrid.Size = new System.Drawing.Size(657, 489);
            this.MobsGrid.TabIndex = 47;
            this.MobsGrid.SelectionChanged += new System.EventHandler(this.MobsGrid_SelectionChanged);
            // 
            // pageNumberLabel
            // 
            this.pageNumberLabel.AutoSize = true;
            this.pageNumberLabel.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pageNumberLabel.Location = new System.Drawing.Point(68, 17);
            this.pageNumberLabel.Name = "pageNumberLabel";
            this.pageNumberLabel.Size = new System.Drawing.Size(48, 18);
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
            this.previousPage.Location = new System.Drawing.Point(0, 5);
            this.previousPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(56, 43);
            this.previousPage.TabIndex = 41;
            this.previousPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.previousPage.UseVisualStyleBackColor = false;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.BackColor = System.Drawing.SystemColors.Control;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPage.ForeColor = System.Drawing.SystemColors.Control;
            this.nextPage.Image = ((System.Drawing.Image)(resources.GetObject("nextPage.Image")));
            this.nextPage.Location = new System.Drawing.Point(131, 5);
            this.nextPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(59, 43);
            this.nextPage.TabIndex = 40;
            this.nextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // bSearchMob
            // 
            this.bSearchMob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSearchMob.BackColor = System.Drawing.Color.DarkKhaki;
            this.bSearchMob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearchMob.ForeColor = System.Drawing.SystemColors.Control;
            this.bSearchMob.Image = ((System.Drawing.Image)(resources.GetObject("bSearchMob.Image")));
            this.bSearchMob.Location = new System.Drawing.Point(925, 46);
            this.bSearchMob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearchMob.Name = "bSearchMob";
            this.bSearchMob.Size = new System.Drawing.Size(49, 33);
            this.bSearchMob.TabIndex = 40;
            this.bSearchMob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSearchMob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSearchMob.UseVisualStyleBackColor = false;
            this.bSearchMob.Click += new System.EventHandler(this.bSearchMob_Click);
            // 
            // EditGroup
            // 
            this.EditGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditGroup.Controls.Add(this.Code128);
            this.EditGroup.Controls.Add(this.mobCode128);
            this.EditGroup.Controls.Add(this.Level);
            this.EditGroup.Controls.Add(this.mobLevel);
            this.EditGroup.Controls.Add(this.label10);
            this.EditGroup.Controls.Add(this.label18);
            this.EditGroup.Controls.Add(this.label9);
            this.EditGroup.Controls.Add(this.MP);
            this.EditGroup.Controls.Add(this.HP);
            this.EditGroup.Controls.Add(this.textBox7);
            this.EditGroup.Controls.Add(this.textBox13);
            this.EditGroup.Controls.Add(this.textBox6);
            this.EditGroup.Controls.Add(this.MaxSpawn);
            this.EditGroup.Controls.Add(this.mobMP);
            this.EditGroup.Controls.Add(this.mobHP);
            this.EditGroup.Controls.Add(this.mobMaxSpawn);
            this.EditGroup.Location = new System.Drawing.Point(747, 94);
            this.EditGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditGroup.Size = new System.Drawing.Size(228, 497);
            this.EditGroup.TabIndex = 55;
            this.EditGroup.TabStop = false;
            // 
            // Code128
            // 
            this.Code128.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Code128.AutoSize = true;
            this.Code128.BackColor = System.Drawing.Color.Transparent;
            this.Code128.Font = new System.Drawing.Font("Calibri", 9F);
            this.Code128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Code128.Location = new System.Drawing.Point(19, 14);
            this.Code128.Name = "Code128";
            this.Code128.Size = new System.Drawing.Size(80, 18);
            this.Code128.TabIndex = 56;
            this.Code128.Text = "Code Name";
            // 
            // mobCode128
            // 
            this.mobCode128.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobCode128.BackColor = System.Drawing.Color.White;
            this.mobCode128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobCode128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobCode128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mobCode128.Location = new System.Drawing.Point(21, 33);
            this.mobCode128.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobCode128.Name = "mobCode128";
            this.mobCode128.Size = new System.Drawing.Size(183, 24);
            this.mobCode128.TabIndex = 55;
            // 
            // Level
            // 
            this.Level.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.Color.Transparent;
            this.Level.Font = new System.Drawing.Font("Calibri", 9F);
            this.Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Level.Location = new System.Drawing.Point(19, 69);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(41, 18);
            this.Level.TabIndex = 54;
            this.Level.Text = "Level";
            // 
            // mobLevel
            // 
            this.mobLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobLevel.BackColor = System.Drawing.Color.White;
            this.mobLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mobLevel.Location = new System.Drawing.Point(21, 89);
            this.mobLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobLevel.Name = "mobLevel";
            this.mobLevel.Size = new System.Drawing.Size(183, 24);
            this.mobLevel.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(19, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 18);
            this.label10.TabIndex = 48;
            this.label10.Text = "HP";
            this.label10.Visible = false;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Calibri", 9F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(19, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 18);
            this.label18.TabIndex = 48;
            this.label18.Text = "Gold";
            this.label18.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(19, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Job Level";
            this.label9.Visible = false;
            // 
            // MP
            // 
            this.MP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MP.AutoSize = true;
            this.MP.BackColor = System.Drawing.Color.Transparent;
            this.MP.Font = new System.Drawing.Font("Calibri", 9F);
            this.MP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MP.Location = new System.Drawing.Point(19, 249);
            this.MP.Name = "MP";
            this.MP.Size = new System.Drawing.Size(28, 18);
            this.MP.TabIndex = 50;
            this.MP.Text = "MP";
            // 
            // HP
            // 
            this.HP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HP.AutoSize = true;
            this.HP.BackColor = System.Drawing.Color.Transparent;
            this.HP.Font = new System.Drawing.Font("Calibri", 9F);
            this.HP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HP.Location = new System.Drawing.Point(19, 190);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(25, 18);
            this.HP.TabIndex = 51;
            this.HP.Text = "HP";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox7.Location = new System.Drawing.Point(21, 457);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 24);
            this.textBox7.TabIndex = 43;
            this.textBox7.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox13.Location = new System.Drawing.Point(21, 396);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(183, 24);
            this.textBox13.TabIndex = 43;
            this.textBox13.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox6.Location = new System.Drawing.Point(21, 332);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 24);
            this.textBox6.TabIndex = 44;
            this.textBox6.Visible = false;
            // 
            // MaxSpawn
            // 
            this.MaxSpawn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxSpawn.AutoSize = true;
            this.MaxSpawn.BackColor = System.Drawing.Color.Transparent;
            this.MaxSpawn.Font = new System.Drawing.Font("Calibri", 9F);
            this.MaxSpawn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaxSpawn.Location = new System.Drawing.Point(19, 128);
            this.MaxSpawn.Name = "MaxSpawn";
            this.MaxSpawn.Size = new System.Drawing.Size(78, 18);
            this.MaxSpawn.TabIndex = 52;
            this.MaxSpawn.Text = "Max Spawn";
            // 
            // mobMP
            // 
            this.mobMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobMP.BackColor = System.Drawing.Color.White;
            this.mobMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mobMP.Location = new System.Drawing.Point(21, 270);
            this.mobMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobMP.Name = "mobMP";
            this.mobMP.Size = new System.Drawing.Size(183, 24);
            this.mobMP.TabIndex = 45;
            // 
            // mobHP
            // 
            this.mobHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobHP.BackColor = System.Drawing.Color.White;
            this.mobHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mobHP.Location = new System.Drawing.Point(21, 210);
            this.mobHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobHP.Name = "mobHP";
            this.mobHP.Size = new System.Drawing.Size(183, 24);
            this.mobHP.TabIndex = 46;
            // 
            // mobMaxSpawn
            // 
            this.mobMaxSpawn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobMaxSpawn.BackColor = System.Drawing.Color.White;
            this.mobMaxSpawn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobMaxSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobMaxSpawn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mobMaxSpawn.Location = new System.Drawing.Point(21, 148);
            this.mobMaxSpawn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobMaxSpawn.Name = "mobMaxSpawn";
            this.mobMaxSpawn.Size = new System.Drawing.Size(183, 24);
            this.mobMaxSpawn.TabIndex = 47;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(747, 610);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(228, 43);
            this.SaveButton.TabIndex = 57;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RowsCountNumber
            // 
            this.RowsCountNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RowsCountNumber.AutoSize = true;
            this.RowsCountNumber.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.RowsCountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RowsCountNumber.Location = new System.Drawing.Point(679, 610);
            this.RowsCountNumber.Name = "RowsCountNumber";
            this.RowsCountNumber.Size = new System.Drawing.Size(39, 18);
            this.RowsCountNumber.TabIndex = 59;
            this.RowsCountNumber.Text = "none";
            // 
            // RowsCount
            // 
            this.RowsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RowsCount.AutoSize = true;
            this.RowsCount.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.RowsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RowsCount.Location = new System.Drawing.Point(625, 610);
            this.RowsCount.Name = "RowsCount";
            this.RowsCount.Size = new System.Drawing.Size(55, 18);
            this.RowsCount.TabIndex = 58;
            this.RowsCount.Text = "Mob(s):";
            // 
            // paginationLabel
            // 
            this.paginationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paginationLabel.Controls.Add(this.pageNumberLabel);
            this.paginationLabel.Controls.Add(this.previousPage);
            this.paginationLabel.Controls.Add(this.nextPage);
            this.paginationLabel.Location = new System.Drawing.Point(61, 594);
            this.paginationLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paginationLabel.Name = "paginationLabel";
            this.paginationLabel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paginationLabel.Size = new System.Drawing.Size(188, 46);
            this.paginationLabel.TabIndex = 60;
            this.paginationLabel.TabStop = false;
            // 
            // pMobEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paginationLabel);
            this.Controls.Add(this.RowsCountNumber);
            this.Controls.Add(this.RowsCount);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditGroup);
            this.Controls.Add(this.bSearchMob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tMobSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MobsGrid);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pMobEditor";
            this.Size = new System.Drawing.Size(1027, 704);
            this.Load += new System.EventHandler(this.pMobEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MobsGrid)).EndInit();
            this.EditGroup.ResumeLayout(false);
            this.EditGroup.PerformLayout();
            this.paginationLabel.ResumeLayout(false);
            this.paginationLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tMobSearch;
        private System.Windows.Forms.Button bSearchMob;
        private System.Windows.Forms.DataGridView MobsGrid;
        private System.Windows.Forms.Label pageNumberLabel;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.GroupBox EditGroup;
        private System.Windows.Forms.Label Code128;
        private System.Windows.Forms.TextBox mobCode128;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.TextBox mobLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MP;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label MaxSpawn;
        private System.Windows.Forms.TextBox mobMP;
        private System.Windows.Forms.TextBox mobHP;
        private System.Windows.Forms.TextBox mobMaxSpawn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label RowsCountNumber;
        private System.Windows.Forms.Label RowsCount;
        private System.Windows.Forms.GroupBox paginationLabel;
    }
}