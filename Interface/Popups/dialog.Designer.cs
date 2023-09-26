namespace MOSROManager
{
    partial class dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialog));
            this.pContent = new System.Windows.Forms.Label();
            this.basePanel = new System.Windows.Forms.Panel();
            this.slotPanel = new System.Windows.Forms.Panel();
            this.itemSlot = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pTitle = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.basePanel.SuspendLayout();
            this.slotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pContent.Location = new System.Drawing.Point(153, 37);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(345, 115);
            this.pContent.TabIndex = 4;
            this.pContent.Text = "Here is the dialog conent";
            this.pContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.basePanel.Controls.Add(this.pContent);
            this.basePanel.Controls.Add(this.slotPanel);
            this.basePanel.Controls.Add(this.pictureBox1);
            this.basePanel.Controls.Add(this.topPanel);
            this.basePanel.Controls.Add(this.bottomPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(1, 1);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(498, 198);
            this.basePanel.TabIndex = 1;
            // 
            // slotPanel
            // 
            this.slotPanel.Controls.Add(this.itemSlot);
            this.slotPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slotPanel.Location = new System.Drawing.Point(81, 37);
            this.slotPanel.Name = "slotPanel";
            this.slotPanel.Size = new System.Drawing.Size(72, 115);
            this.slotPanel.TabIndex = 7;
            this.slotPanel.Visible = false;
            // 
            // itemSlot
            // 
            this.itemSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.itemSlot.Location = new System.Drawing.Point(11, 33);
            this.itemSlot.Name = "itemSlot";
            this.itemSlot.Size = new System.Drawing.Size(48, 48);
            this.itemSlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.itemSlot.TabIndex = 6;
            this.itemSlot.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Controls.Add(this.ExitButton);
            this.topPanel.Controls.Add(this.pTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(498, 37);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(464, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(34, 37);
            this.ExitButton.TabIndex = 30;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pTitle
            // 
            this.pTitle.AutoSize = true;
            this.pTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pTitle.Location = new System.Drawing.Point(3, 6);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(84, 21);
            this.pTitle.TabIndex = 3;
            this.pTitle.Text = "Dialog title";
            this.pTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bottomPanel.Controls.Add(this.noButton);
            this.bottomPanel.Controls.Add(this.yesButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 152);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(498, 46);
            this.bottomPanel.TabIndex = 0;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.noButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.noButton.FlatAppearance.BorderSize = 0;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.Color.White;
            this.noButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noButton.Location = new System.Drawing.Point(244, 10);
            this.noButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(99, 28);
            this.noButton.TabIndex = 64;
            this.noButton.Text = "No";
            this.noButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.yesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.Color.White;
            this.yesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yesButton.Location = new System.Drawing.Point(143, 10);
            this.yesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(95, 28);
            this.yesButton.TabIndex = 65;
            this.yesButton.Text = "Yes";
            this.yesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.ControlBox = false;
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dialog";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dialog";
            this.basePanel.ResumeLayout(false);
            this.slotPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pContent;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label pTitle;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.PictureBox itemSlot;
        private System.Windows.Forms.Panel slotPanel;
    }
}