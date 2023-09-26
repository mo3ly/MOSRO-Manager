namespace MOSROManager
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.basePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pLoadingBar = new System.Windows.Forms.Panel();
            this.Percentage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sLabel = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.Panel();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.basePanel.SuspendLayout();
            this.pLoadingBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.basePanel.Controls.Add(this.label1);
            this.basePanel.Controls.Add(this.ExitButton);
            this.basePanel.Controls.Add(this.label2);
            this.basePanel.Controls.Add(this.pLoadingBar);
            this.basePanel.Controls.Add(this.pictureBox2);
            this.basePanel.Controls.Add(this.pictureBox1);
            this.basePanel.Controls.Add(this.sLabel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(1, 1);
            this.basePanel.Margin = new System.Windows.Forms.Padding(2);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(598, 364);
            this.basePanel.TabIndex = 0;
            this.basePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.basePanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOSRO Manager";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(568, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 32);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "LOADING..";
            // 
            // pLoadingBar
            // 
            this.pLoadingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pLoadingBar.Controls.Add(this.Percentage);
            this.pLoadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLoadingBar.Location = new System.Drawing.Point(0, 347);
            this.pLoadingBar.Margin = new System.Windows.Forms.Padding(2);
            this.pLoadingBar.Name = "pLoadingBar";
            this.pLoadingBar.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.pLoadingBar.Size = new System.Drawing.Size(598, 17);
            this.pLoadingBar.TabIndex = 2;
            // 
            // Percentage
            // 
            this.Percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Percentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Percentage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.ForeColor = System.Drawing.Color.White;
            this.Percentage.Location = new System.Drawing.Point(4, 1);
            this.Percentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(590, 15);
            this.Percentage.TabIndex = 0;
            this.Percentage.Text = "1%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.ForeColor = System.Drawing.Color.White;
            this.sLabel.Location = new System.Drawing.Point(1, 322);
            this.sLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(156, 18);
            this.sLabel.TabIndex = 0;
            this.sLabel.Text = "Generting new text files..";
            // 
            // loadingBar
            // 
            this.loadingBar.BackColor = System.Drawing.Color.DarkKhaki;
            this.loadingBar.Location = new System.Drawing.Point(3, 351);
            this.loadingBar.Margin = new System.Windows.Forms.Padding(2);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(8, 12);
            this.loadingBar.TabIndex = 0;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 1;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loading";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOSRO Manager";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            this.pLoadingBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pLoadingBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Panel loadingBar;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
    }
}