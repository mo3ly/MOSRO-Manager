namespace MOSROManager
{
    partial class pPK2Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pPK2Section));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tPK2Directory = new System.Windows.Forms.TextBox();
            this.LoadPK = new System.Windows.Forms.Button();
            this.ClosePK2 = new System.Windows.Forms.Button();
            this.tBlowfishKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PK2Tree = new System.Windows.Forms.TreeView();
            this.inMediaPath = new System.Windows.Forms.TextBox();
            this.inMediaGo = new System.Windows.Forms.Button();
            this.PK2Explorer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pLoading = new System.Windows.Forms.Label();
            this.eCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(46, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 2);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(42, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Section";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(43, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "PK2";
            // 
            // OpenMedia
            // 
            this.OpenMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenMedia.BackColor = System.Drawing.SystemColors.Control;
            this.OpenMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenMedia.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenMedia.Image = ((System.Drawing.Image)(resources.GetObject("OpenMedia.Image")));
            this.OpenMedia.Location = new System.Drawing.Point(694, 40);
            this.OpenMedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenMedia.Name = "OpenMedia";
            this.OpenMedia.Size = new System.Drawing.Size(32, 27);
            this.OpenMedia.TabIndex = 40;
            this.OpenMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenMedia.UseVisualStyleBackColor = false;
            this.OpenMedia.Click += new System.EventHandler(this.OpenMedia_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(367, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Media Directory";
            // 
            // tPK2Directory
            // 
            this.tPK2Directory.AllowDrop = true;
            this.tPK2Directory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPK2Directory.BackColor = System.Drawing.Color.White;
            this.tPK2Directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPK2Directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPK2Directory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPK2Directory.Location = new System.Drawing.Point(369, 45);
            this.tPK2Directory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPK2Directory.Name = "tPK2Directory";
            this.tPK2Directory.Size = new System.Drawing.Size(321, 21);
            this.tPK2Directory.TabIndex = 30;
            this.tPK2Directory.Text = "C:/";
            this.tPK2Directory.DragDrop += new System.Windows.Forms.DragEventHandler(this.tPK2Directory_DragDrop);
            this.tPK2Directory.DragEnter += new System.Windows.Forms.DragEventHandler(this.tPK2Directory_DragEnter);
            // 
            // LoadPK
            // 
            this.LoadPK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadPK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPK.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadPK.Image = ((System.Drawing.Image)(resources.GetObject("LoadPK.Image")));
            this.LoadPK.Location = new System.Drawing.Point(626, 510);
            this.LoadPK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadPK.Name = "LoadPK";
            this.LoadPK.Size = new System.Drawing.Size(100, 35);
            this.LoadPK.TabIndex = 58;
            this.LoadPK.Text = "Load";
            this.LoadPK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadPK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadPK.UseVisualStyleBackColor = false;
            this.LoadPK.Click += new System.EventHandler(this.LoadMedia_Click);
            // 
            // ClosePK2
            // 
            this.ClosePK2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClosePK2.BackColor = System.Drawing.Color.DarkRed;
            this.ClosePK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClosePK2.ForeColor = System.Drawing.SystemColors.Control;
            this.ClosePK2.Image = ((System.Drawing.Image)(resources.GetObject("ClosePK2.Image")));
            this.ClosePK2.Location = new System.Drawing.Point(520, 510);
            this.ClosePK2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClosePK2.Name = "ClosePK2";
            this.ClosePK2.Size = new System.Drawing.Size(100, 35);
            this.ClosePK2.TabIndex = 58;
            this.ClosePK2.Text = "Close";
            this.ClosePK2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClosePK2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClosePK2.UseVisualStyleBackColor = false;
            this.ClosePK2.Visible = false;
            this.ClosePK2.Click += new System.EventHandler(this.ClosePK2_Click);
            // 
            // tBlowfishKey
            // 
            this.tBlowfishKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBlowfishKey.BackColor = System.Drawing.Color.White;
            this.tBlowfishKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBlowfishKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBlowfishKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tBlowfishKey.Location = new System.Drawing.Point(251, 45);
            this.tBlowfishKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBlowfishKey.Name = "tBlowfishKey";
            this.tBlowfishKey.Size = new System.Drawing.Size(99, 21);
            this.tBlowfishKey.TabIndex = 30;
            this.tBlowfishKey.Text = "169841";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(249, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Blowfish Key";
            // 
            // PK2Tree
            // 
            this.PK2Tree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PK2Tree.Location = new System.Drawing.Point(45, 96);
            this.PK2Tree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PK2Tree.Name = "PK2Tree";
            this.PK2Tree.ShowLines = false;
            this.PK2Tree.Size = new System.Drawing.Size(187, 410);
            this.PK2Tree.TabIndex = 59;
            // 
            // inMediaPath
            // 
            this.inMediaPath.AllowDrop = true;
            this.inMediaPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inMediaPath.BackColor = System.Drawing.Color.White;
            this.inMediaPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inMediaPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inMediaPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.inMediaPath.Location = new System.Drawing.Point(251, 96);
            this.inMediaPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inMediaPath.Name = "inMediaPath";
            this.inMediaPath.Size = new System.Drawing.Size(438, 21);
            this.inMediaPath.TabIndex = 30;
            this.inMediaPath.Text = "/";
            this.inMediaPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tPK2Directory_DragDrop);
            this.inMediaPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tPK2Directory_DragEnter);
            // 
            // inMediaGo
            // 
            this.inMediaGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inMediaGo.BackColor = System.Drawing.SystemColors.Control;
            this.inMediaGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inMediaGo.ForeColor = System.Drawing.SystemColors.Control;
            this.inMediaGo.Image = ((System.Drawing.Image)(resources.GetObject("inMediaGo.Image")));
            this.inMediaGo.Location = new System.Drawing.Point(694, 92);
            this.inMediaGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inMediaGo.Name = "inMediaGo";
            this.inMediaGo.Size = new System.Drawing.Size(32, 27);
            this.inMediaGo.TabIndex = 40;
            this.inMediaGo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inMediaGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inMediaGo.UseVisualStyleBackColor = false;
            this.inMediaGo.Click += new System.EventHandler(this.GoMediaPath_Click);
            // 
            // PK2Explorer
            // 
            this.PK2Explorer.AllowDrop = true;
            this.PK2Explorer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PK2Explorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PK2Explorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.PK2Explorer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PK2Explorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PK2Explorer.FullRowSelect = true;
            this.PK2Explorer.HideSelection = false;
            this.PK2Explorer.Location = new System.Drawing.Point(251, 121);
            this.PK2Explorer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PK2Explorer.Name = "PK2Explorer";
            this.PK2Explorer.Size = new System.Drawing.Size(472, 385);
            this.PK2Explorer.TabIndex = 60;
            this.PK2Explorer.UseCompatibleStateImageBehavior = false;
            this.PK2Explorer.View = System.Windows.Forms.View.Details;
            this.PK2Explorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.PK2Explorer_ItemDrag);
            this.PK2Explorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.PK2Explorer_DragDrop);
            this.PK2Explorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.PK2Explorer_DragEnter);
            this.PK2Explorer.DoubleClick += new System.EventHandler(this.PK2Explorer_DoubleClick);
            this.PK2Explorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PK2Explorer_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CreateTime";
            this.columnHeader4.Width = 450;
            // 
            // pLoading
            // 
            this.pLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLoading.AutoSize = true;
            this.pLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pLoading.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLoading.ForeColor = System.Drawing.Color.White;
            this.pLoading.Location = new System.Drawing.Point(43, 516);
            this.pLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLoading.Name = "pLoading";
            this.pLoading.Size = new System.Drawing.Size(68, 18);
            this.pLoading.TabIndex = 0;
            this.pLoading.Text = "Loading...";
            this.pLoading.Visible = false;
            // 
            // eCounter
            // 
            this.eCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eCounter.AutoSize = true;
            this.eCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eCounter.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eCounter.ForeColor = System.Drawing.Color.White;
            this.eCounter.Location = new System.Drawing.Point(250, 516);
            this.eCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eCounter.Name = "eCounter";
            this.eCounter.Size = new System.Drawing.Size(0, 18);
            this.eCounter.TabIndex = 0;
            // 
            // pPK2Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eCounter);
            this.Controls.Add(this.pLoading);
            this.Controls.Add(this.PK2Explorer);
            this.Controls.Add(this.PK2Tree);
            this.Controls.Add(this.ClosePK2);
            this.Controls.Add(this.LoadPK);
            this.Controls.Add(this.inMediaGo);
            this.Controls.Add(this.OpenMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBlowfishKey);
            this.Controls.Add(this.inMediaPath);
            this.Controls.Add(this.tPK2Directory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pPK2Section";
            this.Size = new System.Drawing.Size(770, 572);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPK2Directory;
        private System.Windows.Forms.Button LoadPK;
        private System.Windows.Forms.Button ClosePK2;
        private System.Windows.Forms.TextBox tBlowfishKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView PK2Tree;
        private System.Windows.Forms.TextBox inMediaPath;
        private System.Windows.Forms.Button inMediaGo;
        private System.Windows.Forms.ListView PK2Explorer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label pLoading;
        private System.Windows.Forms.Label eCounter;
    }
}