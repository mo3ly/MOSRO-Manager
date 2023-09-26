namespace MOSROManager
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pCalculatorButton = new System.Windows.Forms.Button();
            this.pPacketSnifferButton = new System.Windows.Forms.Button();
            this.pDirShortcutsButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.queryWindowButton = new System.Windows.Forms.Button();
            this.bGameManager = new System.Windows.Forms.Button();
            this.ToDo = new System.Windows.Forms.Button();
            this.HideAppButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LogClear = new System.Windows.Forms.Button();
            this.pNavButtons = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pAboutButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pMobEditorButton = new System.Windows.Forms.Button();
            this.pManagmentButton = new System.Windows.Forms.Button();
            this.sPK2Button = new System.Windows.Forms.Button();
            this.sDataButton = new System.Windows.Forms.Button();
            this.subNPCPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pAddNPCButton = new System.Windows.Forms.Button();
            this.sNPCButton = new System.Windows.Forms.Button();
            this.subCharacterPanel = new System.Windows.Forms.Panel();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.newCharButton = new System.Windows.Forms.Button();
            this.charInfoButton = new System.Windows.Forms.Button();
            this.CharactersButton = new System.Windows.Forms.Button();
            this.sCharacterButton = new System.Windows.Forms.Button();
            this.pStatisticsButton = new System.Windows.Forms.Button();
            this.pConnectionButton = new System.Windows.Forms.Button();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.pSlideTimer = new System.Windows.Forms.Timer(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mContent = new System.Windows.Forms.Panel();
            this.sLogList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pLogList = new System.Windows.Forms.Panel();
            this.pButtom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.pNavButtons.SuspendLayout();
            this.subNPCPanel.SuspendLayout();
            this.subCharacterPanel.SuspendLayout();
            this.pLogList.SuspendLayout();
            this.pButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HeaderPanel.Controls.Add(this.Logo);
            this.HeaderPanel.Controls.Add(this.minimizeButton);
            this.HeaderPanel.Controls.Add(this.ResizeButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1020, 40);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_DoubleClick);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageLocation = "";
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(43, 40);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(927, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 40);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ResizeButton.FlatAppearance.BorderSize = 0;
            this.ResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeButton.Image = ((System.Drawing.Image)(resources.GetObject("ResizeButton.Image")));
            this.ResizeButton.Location = new System.Drawing.Point(958, 0);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(31, 40);
            this.ResizeButton.TabIndex = 5;
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(989, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 40);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.DarkKhaki;
            this.LogoLabel.Location = new System.Drawing.Point(41, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(160, 22);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "MOSRO Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.pCalculatorButton);
            this.panel2.Controls.Add(this.pPacketSnifferButton);
            this.panel2.Controls.Add(this.pDirShortcutsButton);
            this.panel2.Controls.Add(this.reloadButton);
            this.panel2.Controls.Add(this.locationButton);
            this.panel2.Controls.Add(this.configButton);
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.queryWindowButton);
            this.panel2.Controls.Add(this.bGameManager);
            this.panel2.Controls.Add(this.ToDo);
            this.panel2.Controls.Add(this.HideAppButton);
            this.panel2.Controls.Add(this.LogButton);
            this.panel2.Controls.Add(this.MenuButton);
            this.panel2.Controls.Add(this.LogClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 680);
            this.panel2.TabIndex = 1;
            // 
            // pCalculatorButton
            // 
            this.pCalculatorButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pCalculatorButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pCalculatorButton.FlatAppearance.BorderSize = 0;
            this.pCalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.pCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pCalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("pCalculatorButton.Image")));
            this.pCalculatorButton.Location = new System.Drawing.Point(0, 160);
            this.pCalculatorButton.Name = "pCalculatorButton";
            this.pCalculatorButton.Size = new System.Drawing.Size(40, 40);
            this.pCalculatorButton.TabIndex = 18;
            this.pCalculatorButton.Tag = "Calculator";
            this.pCalculatorButton.UseVisualStyleBackColor = false;
            this.pCalculatorButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // pPacketSnifferButton
            // 
            this.pPacketSnifferButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pPacketSnifferButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPacketSnifferButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pPacketSnifferButton.FlatAppearance.BorderSize = 0;
            this.pPacketSnifferButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.pPacketSnifferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pPacketSnifferButton.Image = ((System.Drawing.Image)(resources.GetObject("pPacketSnifferButton.Image")));
            this.pPacketSnifferButton.Location = new System.Drawing.Point(0, 200);
            this.pPacketSnifferButton.Name = "pPacketSnifferButton";
            this.pPacketSnifferButton.Size = new System.Drawing.Size(40, 40);
            this.pPacketSnifferButton.TabIndex = 17;
            this.pPacketSnifferButton.Tag = "Packet Sniffer";
            this.pPacketSnifferButton.UseVisualStyleBackColor = true;
            this.pPacketSnifferButton.Click += new System.EventHandler(this.pPacketSnifferButton_Click);
            // 
            // pDirShortcutsButton
            // 
            this.pDirShortcutsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pDirShortcutsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDirShortcutsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pDirShortcutsButton.FlatAppearance.BorderSize = 0;
            this.pDirShortcutsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.pDirShortcutsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pDirShortcutsButton.Image = ((System.Drawing.Image)(resources.GetObject("pDirShortcutsButton.Image")));
            this.pDirShortcutsButton.Location = new System.Drawing.Point(0, 240);
            this.pDirShortcutsButton.Name = "pDirShortcutsButton";
            this.pDirShortcutsButton.Size = new System.Drawing.Size(40, 40);
            this.pDirShortcutsButton.TabIndex = 16;
            this.pDirShortcutsButton.Tag = "Directories shorcuts";
            this.pDirShortcutsButton.UseVisualStyleBackColor = false;
            // 
            // reloadButton
            // 
            this.reloadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reloadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.Image")));
            this.reloadButton.Location = new System.Drawing.Point(0, 280);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(40, 40);
            this.reloadButton.TabIndex = 15;
            this.reloadButton.Tag = "Reload application";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.locationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.locationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.locationButton.FlatAppearance.BorderSize = 0;
            this.locationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.locationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationButton.Image = ((System.Drawing.Image)(resources.GetObject("locationButton.Image")));
            this.locationButton.Location = new System.Drawing.Point(0, 320);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(40, 40);
            this.locationButton.TabIndex = 14;
            this.locationButton.Tag = "Open app location";
            this.locationButton.UseVisualStyleBackColor = false;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // configButton
            // 
            this.configButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.configButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.configButton.FlatAppearance.BorderSize = 0;
            this.configButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Image = ((System.Drawing.Image)(resources.GetObject("configButton.Image")));
            this.configButton.Location = new System.Drawing.Point(0, 360);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(40, 40);
            this.configButton.TabIndex = 13;
            this.configButton.Tag = "Save config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(0, 400);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(40, 40);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Tag = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // queryWindowButton
            // 
            this.queryWindowButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.queryWindowButton.Enabled = false;
            this.queryWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.queryWindowButton.FlatAppearance.BorderSize = 0;
            this.queryWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.queryWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("queryWindowButton.Image")));
            this.queryWindowButton.Location = new System.Drawing.Point(0, 440);
            this.queryWindowButton.Name = "queryWindowButton";
            this.queryWindowButton.Size = new System.Drawing.Size(40, 40);
            this.queryWindowButton.TabIndex = 9;
            this.queryWindowButton.Tag = "Query window";
            this.queryWindowButton.UseVisualStyleBackColor = true;
            this.queryWindowButton.Click += new System.EventHandler(this.queryWindowButton_Click);
            // 
            // bGameManager
            // 
            this.bGameManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bGameManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bGameManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bGameManager.FlatAppearance.BorderSize = 0;
            this.bGameManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.bGameManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGameManager.Image = ((System.Drawing.Image)(resources.GetObject("bGameManager.Image")));
            this.bGameManager.Location = new System.Drawing.Point(0, 480);
            this.bGameManager.Name = "bGameManager";
            this.bGameManager.Size = new System.Drawing.Size(40, 40);
            this.bGameManager.TabIndex = 11;
            this.bGameManager.Tag = "Game manager";
            this.bGameManager.UseVisualStyleBackColor = false;
            this.bGameManager.Click += new System.EventHandler(this.bGameManager_Click);
            // 
            // ToDo
            // 
            this.ToDo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToDo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ToDo.FlatAppearance.BorderSize = 0;
            this.ToDo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.ToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDo.Image = ((System.Drawing.Image)(resources.GetObject("ToDo.Image")));
            this.ToDo.Location = new System.Drawing.Point(0, 520);
            this.ToDo.Name = "ToDo";
            this.ToDo.Size = new System.Drawing.Size(40, 40);
            this.ToDo.TabIndex = 8;
            this.ToDo.Tag = "To Do window";
            this.ToDo.UseVisualStyleBackColor = true;
            this.ToDo.Click += new System.EventHandler(this.ToDo_Click);
            // 
            // HideAppButton
            // 
            this.HideAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.HideAppButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HideAppButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HideAppButton.FlatAppearance.BorderSize = 0;
            this.HideAppButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.HideAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideAppButton.Image = ((System.Drawing.Image)(resources.GetObject("HideAppButton.Image")));
            this.HideAppButton.Location = new System.Drawing.Point(0, 560);
            this.HideAppButton.Name = "HideAppButton";
            this.HideAppButton.Size = new System.Drawing.Size(40, 40);
            this.HideAppButton.TabIndex = 5;
            this.HideAppButton.Tag = "Hide appliction";
            this.HideAppButton.UseVisualStyleBackColor = false;
            this.HideAppButton.Click += new System.EventHandler(this.HideAppButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogButton.FlatAppearance.BorderSize = 0;
            this.LogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Image = ((System.Drawing.Image)(resources.GetObject("LogButton.Image")));
            this.LogButton.Location = new System.Drawing.Point(0, 600);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(40, 40);
            this.LogButton.TabIndex = 3;
            this.LogButton.Tag = "Show/Hide Log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(3, 6);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(34, 31);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // LogClear
            // 
            this.LogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogClear.FlatAppearance.BorderSize = 0;
            this.LogClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.LogClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogClear.Image = ((System.Drawing.Image)(resources.GetObject("LogClear.Image")));
            this.LogClear.Location = new System.Drawing.Point(0, 640);
            this.LogClear.Name = "LogClear";
            this.LogClear.Size = new System.Drawing.Size(40, 40);
            this.LogClear.TabIndex = 4;
            this.LogClear.Tag = "Clear Log";
            this.LogClear.UseVisualStyleBackColor = false;
            this.LogClear.Click += new System.EventHandler(this.LogClear_Click);
            // 
            // pNavButtons
            // 
            this.pNavButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pNavButtons.Controls.Add(this.button3);
            this.pNavButtons.Controls.Add(this.pAboutButton);
            this.pNavButtons.Controls.Add(this.button2);
            this.pNavButtons.Controls.Add(this.pMobEditorButton);
            this.pNavButtons.Controls.Add(this.pManagmentButton);
            this.pNavButtons.Controls.Add(this.sPK2Button);
            this.pNavButtons.Controls.Add(this.sDataButton);
            this.pNavButtons.Controls.Add(this.subNPCPanel);
            this.pNavButtons.Controls.Add(this.sNPCButton);
            this.pNavButtons.Controls.Add(this.subCharacterPanel);
            this.pNavButtons.Controls.Add(this.sCharacterButton);
            this.pNavButtons.Controls.Add(this.pStatisticsButton);
            this.pNavButtons.Controls.Add(this.pConnectionButton);
            this.pNavButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pNavButtons.Location = new System.Drawing.Point(40, 40);
            this.pNavButtons.Name = "pNavButtons";
            this.pNavButtons.Size = new System.Drawing.Size(200, 680);
            this.pNavButtons.TabIndex = 3;
            this.pNavButtons.Visible = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 672);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 42);
            this.button3.TabIndex = 23;
            this.button3.Text = "Documentations";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pAboutButton
            // 
            this.pAboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAboutButton.FlatAppearance.BorderSize = 0;
            this.pAboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAboutButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAboutButton.ForeColor = System.Drawing.Color.White;
            this.pAboutButton.Image = ((System.Drawing.Image)(resources.GetObject("pAboutButton.Image")));
            this.pAboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pAboutButton.Location = new System.Drawing.Point(0, 638);
            this.pAboutButton.Name = "pAboutButton";
            this.pAboutButton.Size = new System.Drawing.Size(200, 42);
            this.pAboutButton.TabIndex = 22;
            this.pAboutButton.Text = "About";
            this.pAboutButton.UseVisualStyleBackColor = true;
            this.pAboutButton.Click += new System.EventHandler(this.pAboutButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Quest";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pMobEditorButton
            // 
            this.pMobEditorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMobEditorButton.FlatAppearance.BorderSize = 0;
            this.pMobEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pMobEditorButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMobEditorButton.ForeColor = System.Drawing.Color.White;
            this.pMobEditorButton.Image = ((System.Drawing.Image)(resources.GetObject("pMobEditorButton.Image")));
            this.pMobEditorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pMobEditorButton.Location = new System.Drawing.Point(0, 588);
            this.pMobEditorButton.Name = "pMobEditorButton";
            this.pMobEditorButton.Size = new System.Drawing.Size(200, 42);
            this.pMobEditorButton.TabIndex = 20;
            this.pMobEditorButton.Text = "Mob editor";
            this.pMobEditorButton.UseVisualStyleBackColor = true;
            this.pMobEditorButton.Click += new System.EventHandler(this.pMobEditorButton_Click);
            // 
            // pManagmentButton
            // 
            this.pManagmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pManagmentButton.FlatAppearance.BorderSize = 0;
            this.pManagmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pManagmentButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pManagmentButton.ForeColor = System.Drawing.Color.White;
            this.pManagmentButton.Image = ((System.Drawing.Image)(resources.GetObject("pManagmentButton.Image")));
            this.pManagmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pManagmentButton.Location = new System.Drawing.Point(0, 546);
            this.pManagmentButton.Name = "pManagmentButton";
            this.pManagmentButton.Size = new System.Drawing.Size(200, 42);
            this.pManagmentButton.TabIndex = 19;
            this.pManagmentButton.Text = "Management";
            this.pManagmentButton.UseVisualStyleBackColor = true;
            this.pManagmentButton.Click += new System.EventHandler(this.pManagmentButton_Click);
            // 
            // sPK2Button
            // 
            this.sPK2Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.sPK2Button.FlatAppearance.BorderSize = 0;
            this.sPK2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sPK2Button.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPK2Button.ForeColor = System.Drawing.Color.White;
            this.sPK2Button.Image = ((System.Drawing.Image)(resources.GetObject("sPK2Button.Image")));
            this.sPK2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sPK2Button.Location = new System.Drawing.Point(0, 504);
            this.sPK2Button.Name = "sPK2Button";
            this.sPK2Button.Size = new System.Drawing.Size(200, 42);
            this.sPK2Button.TabIndex = 18;
            this.sPK2Button.Text = "PK2 Section";
            this.sPK2Button.UseVisualStyleBackColor = true;
            this.sPK2Button.Click += new System.EventHandler(this.sPK2Button_Click);
            // 
            // sDataButton
            // 
            this.sDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sDataButton.FlatAppearance.BorderSize = 0;
            this.sDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sDataButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDataButton.ForeColor = System.Drawing.Color.White;
            this.sDataButton.Image = ((System.Drawing.Image)(resources.GetObject("sDataButton.Image")));
            this.sDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sDataButton.Location = new System.Drawing.Point(0, 462);
            this.sDataButton.Name = "sDataButton";
            this.sDataButton.Size = new System.Drawing.Size(200, 42);
            this.sDataButton.TabIndex = 17;
            this.sDataButton.Text = "Data Analysis";
            this.sDataButton.UseVisualStyleBackColor = true;
            // 
            // subNPCPanel
            // 
            this.subNPCPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.subNPCPanel.Controls.Add(this.button5);
            this.subNPCPanel.Controls.Add(this.button1);
            this.subNPCPanel.Controls.Add(this.pAddNPCButton);
            this.subNPCPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subNPCPanel.Location = new System.Drawing.Point(0, 336);
            this.subNPCPanel.Name = "subNPCPanel";
            this.subNPCPanel.Size = new System.Drawing.Size(200, 126);
            this.subNPCPanel.TabIndex = 16;
            this.subNPCPanel.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 42);
            this.button5.TabIndex = 12;
            this.button5.Text = "Mall (F10)";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pAddNPCButton
            // 
            this.pAddNPCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pAddNPCButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAddNPCButton.FlatAppearance.BorderSize = 0;
            this.pAddNPCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAddNPCButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAddNPCButton.ForeColor = System.Drawing.Color.White;
            this.pAddNPCButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pAddNPCButton.Location = new System.Drawing.Point(0, 0);
            this.pAddNPCButton.Name = "pAddNPCButton";
            this.pAddNPCButton.Size = new System.Drawing.Size(200, 42);
            this.pAddNPCButton.TabIndex = 10;
            this.pAddNPCButton.Text = "Add NPC";
            this.pAddNPCButton.UseVisualStyleBackColor = false;
            this.pAddNPCButton.Click += new System.EventHandler(this.pAddNPCButton_Click);
            // 
            // sNPCButton
            // 
            this.sNPCButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sNPCButton.FlatAppearance.BorderSize = 0;
            this.sNPCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sNPCButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNPCButton.ForeColor = System.Drawing.Color.White;
            this.sNPCButton.Image = ((System.Drawing.Image)(resources.GetObject("sNPCButton.Image")));
            this.sNPCButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sNPCButton.Location = new System.Drawing.Point(0, 294);
            this.sNPCButton.Name = "sNPCButton";
            this.sNPCButton.Size = new System.Drawing.Size(200, 42);
            this.sNPCButton.TabIndex = 13;
            this.sNPCButton.Text = "NPC(s)  ⮟";
            this.sNPCButton.UseVisualStyleBackColor = true;
            this.sNPCButton.Click += new System.EventHandler(this.sNPCButton_Click);
            // 
            // subCharacterPanel
            // 
            this.subCharacterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.subCharacterPanel.Controls.Add(this.newAccountButton);
            this.subCharacterPanel.Controls.Add(this.newCharButton);
            this.subCharacterPanel.Controls.Add(this.charInfoButton);
            this.subCharacterPanel.Controls.Add(this.CharactersButton);
            this.subCharacterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subCharacterPanel.Location = new System.Drawing.Point(0, 126);
            this.subCharacterPanel.Name = "subCharacterPanel";
            this.subCharacterPanel.Size = new System.Drawing.Size(200, 168);
            this.subCharacterPanel.TabIndex = 8;
            this.subCharacterPanel.TabStop = true;
            this.subCharacterPanel.Visible = false;
            // 
            // newAccountButton
            // 
            this.newAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newAccountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newAccountButton.FlatAppearance.BorderSize = 0;
            this.newAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAccountButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountButton.ForeColor = System.Drawing.Color.White;
            this.newAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newAccountButton.Location = new System.Drawing.Point(0, 126);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(200, 42);
            this.newAccountButton.TabIndex = 11;
            this.newAccountButton.Text = "New Account";
            this.newAccountButton.UseVisualStyleBackColor = false;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // newCharButton
            // 
            this.newCharButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newCharButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newCharButton.FlatAppearance.BorderSize = 0;
            this.newCharButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCharButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCharButton.ForeColor = System.Drawing.Color.White;
            this.newCharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newCharButton.Location = new System.Drawing.Point(0, 84);
            this.newCharButton.Name = "newCharButton";
            this.newCharButton.Size = new System.Drawing.Size(200, 42);
            this.newCharButton.TabIndex = 10;
            this.newCharButton.Text = "New Character";
            this.newCharButton.UseVisualStyleBackColor = false;
            this.newCharButton.Click += new System.EventHandler(this.newCharButton_Click);
            // 
            // charInfoButton
            // 
            this.charInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.charInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.charInfoButton.FlatAppearance.BorderSize = 0;
            this.charInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charInfoButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInfoButton.ForeColor = System.Drawing.Color.White;
            this.charInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.charInfoButton.Location = new System.Drawing.Point(0, 42);
            this.charInfoButton.Name = "charInfoButton";
            this.charInfoButton.Size = new System.Drawing.Size(200, 42);
            this.charInfoButton.TabIndex = 9;
            this.charInfoButton.Text = "Character Data";
            this.charInfoButton.UseVisualStyleBackColor = false;
            this.charInfoButton.Click += new System.EventHandler(this.charInfoButton_Click);
            // 
            // CharactersButton
            // 
            this.CharactersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CharactersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CharactersButton.FlatAppearance.BorderSize = 0;
            this.CharactersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharactersButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharactersButton.ForeColor = System.Drawing.Color.White;
            this.CharactersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CharactersButton.Location = new System.Drawing.Point(0, 0);
            this.CharactersButton.Name = "CharactersButton";
            this.CharactersButton.Size = new System.Drawing.Size(200, 42);
            this.CharactersButton.TabIndex = 8;
            this.CharactersButton.Text = "Load Characters";
            this.CharactersButton.UseVisualStyleBackColor = false;
            this.CharactersButton.Click += new System.EventHandler(this.CharactersButton_Click);
            // 
            // sCharacterButton
            // 
            this.sCharacterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sCharacterButton.FlatAppearance.BorderSize = 0;
            this.sCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sCharacterButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCharacterButton.ForeColor = System.Drawing.Color.White;
            this.sCharacterButton.Image = ((System.Drawing.Image)(resources.GetObject("sCharacterButton.Image")));
            this.sCharacterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sCharacterButton.Location = new System.Drawing.Point(0, 84);
            this.sCharacterButton.Name = "sCharacterButton";
            this.sCharacterButton.Size = new System.Drawing.Size(200, 42);
            this.sCharacterButton.TabIndex = 6;
            this.sCharacterButton.Text = "User ＆ Character  ⮟";
            this.sCharacterButton.UseVisualStyleBackColor = true;
            this.sCharacterButton.Click += new System.EventHandler(this.sCharacterButton_Click);
            // 
            // pStatisticsButton
            // 
            this.pStatisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatisticsButton.FlatAppearance.BorderSize = 0;
            this.pStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pStatisticsButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pStatisticsButton.ForeColor = System.Drawing.Color.White;
            this.pStatisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("pStatisticsButton.Image")));
            this.pStatisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pStatisticsButton.Location = new System.Drawing.Point(0, 42);
            this.pStatisticsButton.Name = "pStatisticsButton";
            this.pStatisticsButton.Size = new System.Drawing.Size(200, 42);
            this.pStatisticsButton.TabIndex = 6;
            this.pStatisticsButton.Text = "Statistics";
            this.pStatisticsButton.UseVisualStyleBackColor = true;
            this.pStatisticsButton.Click += new System.EventHandler(this.pStatisticsButton_Click);
            // 
            // pConnectionButton
            // 
            this.pConnectionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConnectionButton.FlatAppearance.BorderSize = 0;
            this.pConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pConnectionButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pConnectionButton.ForeColor = System.Drawing.Color.White;
            this.pConnectionButton.Image = ((System.Drawing.Image)(resources.GetObject("pConnectionButton.Image")));
            this.pConnectionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pConnectionButton.Location = new System.Drawing.Point(0, 0);
            this.pConnectionButton.Name = "pConnectionButton";
            this.pConnectionButton.Size = new System.Drawing.Size(200, 42);
            this.pConnectionButton.TabIndex = 6;
            this.pConnectionButton.Text = "Connection";
            this.pConnectionButton.UseVisualStyleBackColor = true;
            this.pConnectionButton.Click += new System.EventHandler(this.pConntectionButton_Click);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "MOSRO Manager";
            this.Notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseDoubleClick);
            // 
            // pSlideTimer
            // 
            this.pSlideTimer.Interval = 1;
            this.pSlideTimer.Tick += new System.EventHandler(this.pSlideTimer_Tick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Message";
            this.columnHeader3.Width = 600;
            // 
            // mContent
            // 
            this.mContent.BackColor = System.Drawing.SystemColors.Control;
            this.mContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mContent.Location = new System.Drawing.Point(240, 40);
            this.mContent.Margin = new System.Windows.Forms.Padding(2);
            this.mContent.Name = "mContent";
            this.mContent.Size = new System.Drawing.Size(780, 585);
            this.mContent.TabIndex = 1;
            // 
            // sLogList
            // 
            this.sLogList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sLogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sLogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.sLogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sLogList.ForeColor = System.Drawing.Color.White;
            this.sLogList.FullRowSelect = true;
            this.sLogList.GridLines = true;
            this.sLogList.HideSelection = false;
            this.sLogList.Location = new System.Drawing.Point(0, 0);
            this.sLogList.MultiSelect = false;
            this.sLogList.Name = "sLogList";
            this.sLogList.Size = new System.Drawing.Size(780, 80);
            this.sLogList.TabIndex = 10;
            this.sLogList.UseCompatibleStateImageBehavior = false;
            this.sLogList.View = System.Windows.Forms.View.Details;
            this.sLogList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sLogList_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Message";
            this.columnHeader6.Width = 600;
            // 
            // pLogList
            // 
            this.pLogList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pLogList.Controls.Add(this.sLogList);
            this.pLogList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLogList.ForeColor = System.Drawing.Color.White;
            this.pLogList.Location = new System.Drawing.Point(240, 625);
            this.pLogList.Name = "pLogList";
            this.pLogList.Size = new System.Drawing.Size(780, 80);
            this.pLogList.TabIndex = 11;
            // 
            // pButtom
            // 
            this.pButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pButtom.Controls.Add(this.label1);
            this.pButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtom.Location = new System.Drawing.Point(240, 705);
            this.pButtom.Name = "pButtom";
            this.pButtom.Size = new System.Drawing.Size(780, 15);
            this.pButtom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Copyrights © mo3ly 2019 - 2021";
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1020, 720);
            this.Controls.Add(this.mContent);
            this.Controls.Add(this.pLogList);
            this.Controls.Add(this.pButtom);
            this.Controls.Add(this.pNavButtons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOSRO Manager";
            this.Load += new System.EventHandler(this.BaseWindow_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pNavButtons.ResumeLayout(false);
            this.subNPCPanel.ResumeLayout(false);
            this.subCharacterPanel.ResumeLayout(false);
            this.pLogList.ResumeLayout(false);
            this.pButtom.ResumeLayout(false);
            this.pButtom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button pConnectionButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button HideAppButton;
        private System.Windows.Forms.Button minimizeButton;
        internal System.Windows.Forms.Panel pNavButtons;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.Timer pSlideTimer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.Button queryWindowButton;
        private System.Windows.Forms.Button sPK2Button;
        private System.Windows.Forms.Button sDataButton;
        private System.Windows.Forms.Panel subNPCPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pAddNPCButton;
        private System.Windows.Forms.Button sNPCButton;
        private System.Windows.Forms.Button pMobEditorButton;
        private System.Windows.Forms.PictureBox Logo;
        internal System.Windows.Forms.Button pStatisticsButton;
        private System.Windows.Forms.Button pManagmentButton;
        private System.Windows.Forms.Button LogClear;
        private System.Windows.Forms.Button ToDo;
        private System.Windows.Forms.Button bGameManager;
        private System.Windows.Forms.Panel mContent;
        private System.Windows.Forms.ListView sLogList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel pLogList;
        private System.Windows.Forms.Panel pButtom;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button sCharacterButton;
        internal System.Windows.Forms.Panel subCharacterPanel;
        internal System.Windows.Forms.Button newAccountButton;
        internal System.Windows.Forms.Button newCharButton;
        internal System.Windows.Forms.Button charInfoButton;
        private System.Windows.Forms.Button CharactersButton;
        internal System.Windows.Forms.Button settingsButton;
        internal System.Windows.Forms.Button configButton;
        internal System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button reloadButton;
        internal System.Windows.Forms.Button pDirShortcutsButton;
        private System.Windows.Forms.Button pAboutButton;
        internal System.Windows.Forms.Button pPacketSnifferButton;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button pCalculatorButton;
    }
}

