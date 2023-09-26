namespace MOSROManager
{
    partial class ToDoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoWindow));
            this.basePanel = new System.Windows.Forms.Panel();
            this.layoutPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ExecuteQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QueriesListPqnel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryBoxPanel = new System.Windows.Forms.Panel();
            this.QueryTextBox = new System.Windows.Forms.RichTextBox();
            this.basePanel.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.QueriesListPqnel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.QueryBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.basePanel.Controls.Add(this.layoutPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Padding = new System.Windows.Forms.Padding(1);
            this.basePanel.Size = new System.Drawing.Size(870, 697);
            this.basePanel.TabIndex = 0;
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.layoutPanel.Controls.Add(this.label5);
            this.layoutPanel.Controls.Add(this.panel2);
            this.layoutPanel.Controls.Add(this.ExecuteQuery);
            this.layoutPanel.Controls.Add(this.label3);
            this.layoutPanel.Controls.Add(this.QueriesListPqnel);
            this.layoutPanel.Controls.Add(this.QueryBoxPanel);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Enabled = false;
            this.layoutPanel.Location = new System.Drawing.Point(1, 1);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(868, 695);
            this.layoutPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(314, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Wrtie";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 39);
            this.panel2.TabIndex = 42;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(32, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "ToDo";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(828, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 39);
            this.ExitButton.TabIndex = 28;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExecuteQuery.BackColor = System.Drawing.Color.DarkKhaki;
            this.ExecuteQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteQuery.ForeColor = System.Drawing.SystemColors.Control;
            this.ExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("ExecuteQuery.Image")));
            this.ExecuteQuery.Location = new System.Drawing.Point(41, 628);
            this.ExecuteQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Size = new System.Drawing.Size(210, 42);
            this.ExecuteQuery.TabIndex = 39;
            this.ExecuteQuery.Text = "Save";
            this.ExecuteQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExecuteQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExecuteQuery.UseVisualStyleBackColor = false;
            this.ExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tasks";
            // 
            // QueriesListPqnel
            // 
            this.QueriesListPqnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QueriesListPqnel.Controls.Add(this.panel3);
            this.QueriesListPqnel.Controls.Add(this.panel1);
            this.QueriesListPqnel.Location = new System.Drawing.Point(41, 99);
            this.QueriesListPqnel.Name = "QueriesListPqnel";
            this.QueriesListPqnel.Padding = new System.Windows.Forms.Padding(1);
            this.QueriesListPqnel.Size = new System.Drawing.Size(243, 496);
            this.QueriesListPqnel.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 43);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Status: done";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Do something in the game";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 43);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status: not done";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete the item in the database";
            // 
            // QueryBoxPanel
            // 
            this.QueryBoxPanel.BackColor = System.Drawing.Color.Silver;
            this.QueryBoxPanel.Controls.Add(this.QueryTextBox);
            this.QueryBoxPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QueryBoxPanel.Location = new System.Drawing.Point(318, 98);
            this.QueryBoxPanel.Name = "QueryBoxPanel";
            this.QueryBoxPanel.Padding = new System.Windows.Forms.Padding(1);
            this.QueryBoxPanel.Size = new System.Drawing.Size(507, 498);
            this.QueryBoxPanel.TabIndex = 44;
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.BackColor = System.Drawing.Color.White;
            this.QueryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryTextBox.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QueryTextBox.Location = new System.Drawing.Point(1, 1);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(505, 496);
            this.QueryTextBox.TabIndex = 29;
            this.QueryTextBox.Text = "Do the item coloring";
            // 
            // ToDoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(870, 697);
            this.ControlBox = false;
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo window";
            this.basePanel.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.QueriesListPqnel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.QueryBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel layoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ExecuteQuery;
        private System.Windows.Forms.Panel QueriesListPqnel;
        private System.Windows.Forms.Panel QueryBoxPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox QueryTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}