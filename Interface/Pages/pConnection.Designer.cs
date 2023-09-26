namespace MOSROManager
{
    partial class pConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pConnection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlDisconnectBtn = new System.Windows.Forms.Button();
            this.sqlConnectBtn = new System.Windows.Forms.Button();
            this.sConnectionPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tDatabaseLog = new System.Windows.Forms.TextBox();
            this.tDatabaseShard = new System.Windows.Forms.TextBox();
            this.tDatabaseAccount = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tHost = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newsRichBox = new System.Windows.Forms.RichTextBox();
            this.sConnectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(61, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 2);
            this.panel1.TabIndex = 25;
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ConnectionLabel.Location = new System.Drawing.Point(57, 114);
            this.ConnectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(118, 23);
            this.ConnectionLabel.TabIndex = 24;
            this.ConnectionLabel.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(58, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Connection status:";
            // 
            // sqlDisconnectBtn
            // 
            this.sqlDisconnectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqlDisconnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sqlDisconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlDisconnectBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sqlDisconnectBtn.Image = ((System.Drawing.Image)(resources.GetObject("sqlDisconnectBtn.Image")));
            this.sqlDisconnectBtn.Location = new System.Drawing.Point(62, 500);
            this.sqlDisconnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sqlDisconnectBtn.Name = "sqlDisconnectBtn";
            this.sqlDisconnectBtn.Size = new System.Drawing.Size(133, 34);
            this.sqlDisconnectBtn.TabIndex = 22;
            this.sqlDisconnectBtn.Text = "Disconnect";
            this.sqlDisconnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sqlDisconnectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sqlDisconnectBtn.UseVisualStyleBackColor = false;
            this.sqlDisconnectBtn.Visible = false;
            this.sqlDisconnectBtn.Click += new System.EventHandler(this.sqlDisconnectBtn_Click);
            // 
            // sqlConnectBtn
            // 
            this.sqlConnectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqlConnectBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.sqlConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlConnectBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sqlConnectBtn.Image = ((System.Drawing.Image)(resources.GetObject("sqlConnectBtn.Image")));
            this.sqlConnectBtn.Location = new System.Drawing.Point(60, 500);
            this.sqlConnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sqlConnectBtn.Name = "sqlConnectBtn";
            this.sqlConnectBtn.Size = new System.Drawing.Size(134, 34);
            this.sqlConnectBtn.TabIndex = 13;
            this.sqlConnectBtn.Text = "Connect";
            this.sqlConnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sqlConnectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sqlConnectBtn.UseVisualStyleBackColor = false;
            this.sqlConnectBtn.Click += new System.EventHandler(this.sqlConnectBtn_ClickAsync);
            // 
            // sConnectionPanel
            // 
            this.sConnectionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sConnectionPanel.Controls.Add(this.label9);
            this.sConnectionPanel.Controls.Add(this.label10);
            this.sConnectionPanel.Controls.Add(this.label7);
            this.sConnectionPanel.Controls.Add(this.label8);
            this.sConnectionPanel.Controls.Add(this.label6);
            this.sConnectionPanel.Controls.Add(this.label4);
            this.sConnectionPanel.Controls.Add(this.label3);
            this.sConnectionPanel.Controls.Add(this.label2);
            this.sConnectionPanel.Controls.Add(this.label1);
            this.sConnectionPanel.Controls.Add(this.tDatabaseLog);
            this.sConnectionPanel.Controls.Add(this.tDatabaseShard);
            this.sConnectionPanel.Controls.Add(this.tDatabaseAccount);
            this.sConnectionPanel.Controls.Add(this.tPassword);
            this.sConnectionPanel.Controls.Add(this.tUser);
            this.sConnectionPanel.Controls.Add(this.tHost);
            this.sConnectionPanel.Location = new System.Drawing.Point(60, 157);
            this.sConnectionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sConnectionPanel.Name = "sConnectionPanel";
            this.sConnectionPanel.Size = new System.Drawing.Size(322, 318);
            this.sConnectionPanel.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(60, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 14);
            this.label9.TabIndex = 39;
            this.label9.Text = "Account";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(60, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 14);
            this.label10.TabIndex = 40;
            this.label10.Text = "Log";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(60, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 14);
            this.label7.TabIndex = 41;
            this.label7.Text = "Shard";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(0, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Database";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(0, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Database";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(0, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(0, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-1, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Host";
            // 
            // tDatabaseLog
            // 
            this.tDatabaseLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tDatabaseLog.BackColor = System.Drawing.Color.White;
            this.tDatabaseLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDatabaseLog.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDatabaseLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tDatabaseLog.Location = new System.Drawing.Point(2, 288);
            this.tDatabaseLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDatabaseLog.Name = "tDatabaseLog";
            this.tDatabaseLog.Size = new System.Drawing.Size(261, 24);
            this.tDatabaseLog.TabIndex = 30;
            // 
            // tDatabaseShard
            // 
            this.tDatabaseShard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tDatabaseShard.BackColor = System.Drawing.Color.White;
            this.tDatabaseShard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDatabaseShard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDatabaseShard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tDatabaseShard.Location = new System.Drawing.Point(2, 233);
            this.tDatabaseShard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDatabaseShard.Name = "tDatabaseShard";
            this.tDatabaseShard.Size = new System.Drawing.Size(261, 24);
            this.tDatabaseShard.TabIndex = 31;
            // 
            // tDatabaseAccount
            // 
            this.tDatabaseAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tDatabaseAccount.BackColor = System.Drawing.Color.White;
            this.tDatabaseAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDatabaseAccount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDatabaseAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tDatabaseAccount.Location = new System.Drawing.Point(2, 180);
            this.tDatabaseAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDatabaseAccount.Name = "tDatabaseAccount";
            this.tDatabaseAccount.Size = new System.Drawing.Size(261, 24);
            this.tDatabaseAccount.TabIndex = 32;
            // 
            // tPassword
            // 
            this.tPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPassword.BackColor = System.Drawing.Color.White;
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPassword.Location = new System.Drawing.Point(2, 127);
            this.tPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(261, 24);
            this.tPassword.TabIndex = 29;
            // 
            // tUser
            // 
            this.tUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tUser.BackColor = System.Drawing.Color.White;
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUser.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tUser.Location = new System.Drawing.Point(2, 78);
            this.tUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(261, 24);
            this.tUser.TabIndex = 28;
            // 
            // tHost
            // 
            this.tHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tHost.BackColor = System.Drawing.Color.White;
            this.tHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tHost.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tHost.Location = new System.Drawing.Point(2, 27);
            this.tHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tHost.Name = "tHost";
            this.tHost.Size = new System.Drawing.Size(261, 24);
            this.tHost.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(426, 139);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 2);
            this.panel2.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(422, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ver 1.0";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(423, 102);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "news";
            // 
            // newsRichBox
            // 
            this.newsRichBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newsRichBox.BackColor = System.Drawing.SystemColors.Control;
            this.newsRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsRichBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newsRichBox.Location = new System.Drawing.Point(426, 157);
            this.newsRichBox.Name = "newsRichBox";
            this.newsRichBox.ReadOnly = true;
            this.newsRichBox.Size = new System.Drawing.Size(294, 318);
            this.newsRichBox.TabIndex = 0;
            this.newsRichBox.Text = resources.GetString("newsRichBox.Text");
            // 
            // pConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.newsRichBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sConnectionPanel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sqlDisconnectBtn);
            this.Controls.Add(this.sqlConnectBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pConnection";
            this.Size = new System.Drawing.Size(784, 610);
            this.Load += new System.EventHandler(this.pConnection_Load);
            this.sConnectionPanel.ResumeLayout(false);
            this.sConnectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sqlDisconnectBtn;
        private System.Windows.Forms.Button sqlConnectBtn;
        private System.Windows.Forms.Panel sConnectionPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDatabaseLog;
        private System.Windows.Forms.TextBox tDatabaseShard;
        private System.Windows.Forms.TextBox tDatabaseAccount;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tHost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox newsRichBox;
    }
}