namespace MOSROManager
{
    partial class textPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textPreview));
            this.basePanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pTitle = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.previewText = new System.Windows.Forms.RichTextBox();
            this.basePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.basePanel.Controls.Add(this.previewPanel);
            this.basePanel.Controls.Add(this.topPanel);
            this.basePanel.Controls.Add(this.bottomPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(1, 1);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1024, 684);
            this.basePanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Controls.Add(this.ExitButton);
            this.topPanel.Controls.Add(this.pTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1024, 37);
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
            this.ExitButton.Location = new System.Drawing.Point(990, 0);
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
            this.pTitle.Size = new System.Drawing.Size(71, 21);
            this.pTitle.TabIndex = 3;
            this.pTitle.Text = "Message";
            this.pTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 638);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1024, 46);
            this.bottomPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(16, 9);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 28);
            this.okButton.TabIndex = 65;
            this.okButton.Text = "Ok";
            this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.Color.Silver;
            this.previewPanel.Controls.Add(this.previewText);
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.previewPanel.Location = new System.Drawing.Point(0, 37);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Padding = new System.Windows.Forms.Padding(1);
            this.previewPanel.Size = new System.Drawing.Size(1024, 601);
            this.previewPanel.TabIndex = 46;
            // 
            // previewText
            // 
            this.previewText.AcceptsTab = true;
            this.previewText.AutoWordSelection = true;
            this.previewText.BackColor = System.Drawing.Color.White;
            this.previewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewText.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewText.ForeColor = System.Drawing.Color.Black;
            this.previewText.HideSelection = false;
            this.previewText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.previewText.Location = new System.Drawing.Point(1, 1);
            this.previewText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewText.Name = "previewText";
            this.previewText.Size = new System.Drawing.Size(1022, 599);
            this.previewText.TabIndex = 29;
            this.previewText.Text = "";
            this.previewText.WordWrap = false;
            // 
            // textPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1026, 686);
            this.ControlBox = false;
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "textPreview";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dialog";
            this.basePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.previewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label pTitle;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.RichTextBox previewText;
    }
}