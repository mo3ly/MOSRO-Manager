namespace MOSROManager
{
    partial class pCharInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pCharInventory));
            this.pInventory = new System.Windows.Forms.GroupBox();
            this.Loading = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PageOne = new System.Windows.Forms.Button();
            this.PageTwo = new System.Windows.Forms.Button();
            this.PageThree = new System.Windows.Forms.Button();
            this.lRemainSlots = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lAvaliableSlots = new System.Windows.Forms.Label();
            this.unlockPage2 = new System.Windows.Forms.Button();
            this.unlockPage3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pInventory
            // 
            this.pInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pInventory.Controls.Add(this.Loading);
            this.pInventory.Controls.Add(this.pictureBox4);
            this.pInventory.Location = new System.Drawing.Point(295, 33);
            this.pInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pInventory.Name = "pInventory";
            this.pInventory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pInventory.Size = new System.Drawing.Size(285, 459);
            this.pInventory.TabIndex = 1;
            this.pInventory.TabStop = false;
            // 
            // Loading
            // 
            this.Loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loading.AutoSize = true;
            this.Loading.Location = new System.Drawing.Point(116, 256);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(59, 17);
            this.Loading.TabIndex = 1;
            this.Loading.Text = "Loading";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(109, 178);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // PageOne
            // 
            this.PageOne.BackColor = System.Drawing.Color.DarkKhaki;
            this.PageOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PageOne.FlatAppearance.BorderSize = 0;
            this.PageOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PageOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PageOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageOne.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageOne.ForeColor = System.Drawing.Color.White;
            this.PageOne.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PageOne.Location = new System.Drawing.Point(587, 42);
            this.PageOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PageOne.Name = "PageOne";
            this.PageOne.Size = new System.Drawing.Size(89, 34);
            this.PageOne.TabIndex = 2;
            this.PageOne.Text = "Page 1";
            this.PageOne.UseVisualStyleBackColor = false;
            this.PageOne.Click += new System.EventHandler(this.PageOne_Click);
            // 
            // PageTwo
            // 
            this.PageTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PageTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PageTwo.FlatAppearance.BorderSize = 0;
            this.PageTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PageTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PageTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageTwo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTwo.ForeColor = System.Drawing.Color.White;
            this.PageTwo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PageTwo.Location = new System.Drawing.Point(587, 82);
            this.PageTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PageTwo.Name = "PageTwo";
            this.PageTwo.Size = new System.Drawing.Size(89, 34);
            this.PageTwo.TabIndex = 2;
            this.PageTwo.Text = "Page 2";
            this.PageTwo.UseVisualStyleBackColor = false;
            this.PageTwo.Click += new System.EventHandler(this.Page2_Click);
            // 
            // PageThree
            // 
            this.PageThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PageThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PageThree.FlatAppearance.BorderSize = 0;
            this.PageThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PageThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PageThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageThree.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageThree.ForeColor = System.Drawing.Color.White;
            this.PageThree.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PageThree.Location = new System.Drawing.Point(587, 124);
            this.PageThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PageThree.Name = "PageThree";
            this.PageThree.Size = new System.Drawing.Size(89, 34);
            this.PageThree.TabIndex = 2;
            this.PageThree.Text = "Page 3";
            this.PageThree.UseVisualStyleBackColor = false;
            this.PageThree.Click += new System.EventHandler(this.PageThree_Click);
            // 
            // lRemainSlots
            // 
            this.lRemainSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRemainSlots.AutoSize = true;
            this.lRemainSlots.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRemainSlots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lRemainSlots.Location = new System.Drawing.Point(292, 17);
            this.lRemainSlots.Name = "lRemainSlots";
            this.lRemainSlots.Size = new System.Drawing.Size(103, 17);
            this.lRemainSlots.TabIndex = 48;
            this.lRemainSlots.Text = "Remaining slots: ";
            this.lRemainSlots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lAvaliableSlots
            // 
            this.lAvaliableSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lAvaliableSlots.AutoSize = true;
            this.lAvaliableSlots.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvaliableSlots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lAvaliableSlots.Location = new System.Drawing.Point(453, 17);
            this.lAvaliableSlots.Name = "lAvaliableSlots";
            this.lAvaliableSlots.Size = new System.Drawing.Size(94, 17);
            this.lAvaliableSlots.TabIndex = 48;
            this.lAvaliableSlots.Text = "Avaliable slots: ";
            this.lAvaliableSlots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unlockPage2
            // 
            this.unlockPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.unlockPage2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.unlockPage2.FlatAppearance.BorderSize = 0;
            this.unlockPage2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.unlockPage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unlockPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlockPage2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockPage2.ForeColor = System.Drawing.Color.White;
            this.unlockPage2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.unlockPage2.Location = new System.Drawing.Point(587, 81);
            this.unlockPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unlockPage2.Name = "unlockPage2";
            this.unlockPage2.Size = new System.Drawing.Size(89, 34);
            this.unlockPage2.TabIndex = 49;
            this.unlockPage2.Text = "Unlock 2";
            this.unlockPage2.UseVisualStyleBackColor = false;
            this.unlockPage2.Visible = false;
            this.unlockPage2.Click += new System.EventHandler(this.unlockPage2_Click);
            // 
            // unlockPage3
            // 
            this.unlockPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.unlockPage3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.unlockPage3.FlatAppearance.BorderSize = 0;
            this.unlockPage3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.unlockPage3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.unlockPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlockPage3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockPage3.ForeColor = System.Drawing.Color.White;
            this.unlockPage3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.unlockPage3.Location = new System.Drawing.Point(587, 122);
            this.unlockPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unlockPage3.Name = "unlockPage3";
            this.unlockPage3.Size = new System.Drawing.Size(89, 34);
            this.unlockPage3.TabIndex = 49;
            this.unlockPage3.Text = "Unlock 3";
            this.unlockPage3.UseVisualStyleBackColor = false;
            this.unlockPage3.Visible = false;
            this.unlockPage3.Click += new System.EventHandler(this.unlockPage3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(292, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "ⓘ Right click to delete an item.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(587, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 51;
            this.button1.Text = "Add item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(587, 420);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 52;
            this.button2.Text = "Clear inv";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pCharInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unlockPage3);
            this.Controls.Add(this.unlockPage2);
            this.Controls.Add(this.lAvaliableSlots);
            this.Controls.Add(this.lRemainSlots);
            this.Controls.Add(this.PageThree);
            this.Controls.Add(this.PageTwo);
            this.Controls.Add(this.PageOne);
            this.Controls.Add(this.pInventory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pCharInventory";
            this.Size = new System.Drawing.Size(903, 533);
            this.Load += new System.EventHandler(this.pCharInventory_Load);
            this.pInventory.ResumeLayout(false);
            this.pInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pInventory;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button PageOne;
        private System.Windows.Forms.Button PageTwo;
        private System.Windows.Forms.Button PageThree;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Label lRemainSlots;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lAvaliableSlots;
        private System.Windows.Forms.Button unlockPage2;
        private System.Windows.Forms.Button unlockPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
