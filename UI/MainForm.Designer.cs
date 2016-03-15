namespace DatabaseEditor
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.CreaturePage = new System.Windows.Forms.TabPage();
            this.GameObjectPage = new System.Windows.Forms.TabPage();
            this.DBCPage = new System.Windows.Forms.TabPage();
            this.DBCSave = new System.Windows.Forms.Button();
            this.DBCColumnsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DBCColumnType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DBCColumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DBCSaveScheme = new System.Windows.Forms.Button();
            this.DBCApplyScheme = new System.Windows.Forms.Button();
            this.DBCOpen = new System.Windows.Forms.Button();
            this.DBCView = new System.Windows.Forms.DataGridView();
            this.DBCMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.insertLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenDbcDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenSchemaDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveSchemaDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveDbcDialog = new System.Windows.Forms.SaveFileDialog();
            this.creatureControl = new DatabaseEditor.Creature.CreatureControl();
            this.gameObjectControl = new DatabaseEditor.Editor.GameObject.GameObjectControl();
            this.dbcTableBinding = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenu.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.CreaturePage.SuspendLayout();
            this.GameObjectPage.SuspendLayout();
            this.DBCPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBCView)).BeginInit();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbcTableBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1264, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.CreaturePage);
            this.MainTab.Controls.Add(this.GameObjectPage);
            this.MainTab.Controls.Add(this.DBCPage);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTab.Location = new System.Drawing.Point(0, 24);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1264, 933);
            this.MainTab.TabIndex = 1;
            this.MainTab.TabStop = false;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // CreaturePage
            // 
            this.CreaturePage.AutoScroll = true;
            this.CreaturePage.Controls.Add(this.creatureControl);
            this.CreaturePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreaturePage.Location = new System.Drawing.Point(4, 22);
            this.CreaturePage.Name = "CreaturePage";
            this.CreaturePage.Padding = new System.Windows.Forms.Padding(3);
            this.CreaturePage.Size = new System.Drawing.Size(1256, 907);
            this.CreaturePage.TabIndex = 0;
            this.CreaturePage.Text = "Creature";
            this.CreaturePage.UseVisualStyleBackColor = true;
            // 
            // GameObjectPage
            // 
            this.GameObjectPage.AutoScroll = true;
            this.GameObjectPage.Controls.Add(this.gameObjectControl);
            this.GameObjectPage.Location = new System.Drawing.Point(4, 22);
            this.GameObjectPage.Name = "GameObjectPage";
            this.GameObjectPage.Padding = new System.Windows.Forms.Padding(3);
            this.GameObjectPage.Size = new System.Drawing.Size(1256, 907);
            this.GameObjectPage.TabIndex = 2;
            this.GameObjectPage.Text = "Game Object";
            this.GameObjectPage.UseVisualStyleBackColor = true;
            // 
            // DBCPage
            // 
            this.DBCPage.AutoScroll = true;
            this.DBCPage.Controls.Add(this.DBCSave);
            this.DBCPage.Controls.Add(this.DBCColumnsList);
            this.DBCPage.Controls.Add(this.label3);
            this.DBCPage.Controls.Add(this.DBCColumnType);
            this.DBCPage.Controls.Add(this.label2);
            this.DBCPage.Controls.Add(this.DBCColumnName);
            this.DBCPage.Controls.Add(this.label4);
            this.DBCPage.Controls.Add(this.DBCSaveScheme);
            this.DBCPage.Controls.Add(this.DBCApplyScheme);
            this.DBCPage.Controls.Add(this.DBCOpen);
            this.DBCPage.Controls.Add(this.DBCView);
            this.DBCPage.Controls.Add(this.DBCMenu);
            this.DBCPage.Location = new System.Drawing.Point(4, 22);
            this.DBCPage.Name = "DBCPage";
            this.DBCPage.Padding = new System.Windows.Forms.Padding(3);
            this.DBCPage.Size = new System.Drawing.Size(1256, 907);
            this.DBCPage.TabIndex = 1;
            this.DBCPage.Text = "DBC";
            this.DBCPage.UseVisualStyleBackColor = true;
            // 
            // DBCSave
            // 
            this.DBCSave.Location = new System.Drawing.Point(303, 6);
            this.DBCSave.Name = "DBCSave";
            this.DBCSave.Size = new System.Drawing.Size(75, 23);
            this.DBCSave.TabIndex = 12;
            this.DBCSave.Text = "Save";
            this.DBCSave.UseVisualStyleBackColor = true;
            this.DBCSave.Click += new System.EventHandler(this.DBCSave_Click);
            // 
            // DBCColumnsList
            // 
            this.DBCColumnsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DBCColumnsList.FormattingEnabled = true;
            this.DBCColumnsList.Location = new System.Drawing.Point(17, 133);
            this.DBCColumnsList.Margin = new System.Windows.Forms.Padding(2);
            this.DBCColumnsList.Name = "DBCColumnsList";
            this.DBCColumnsList.Size = new System.Drawing.Size(194, 745);
            this.DBCColumnsList.TabIndex = 11;
            this.DBCColumnsList.SelectedIndexChanged += new System.EventHandler(this.DBCColumnsList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Columns:";
            // 
            // DBCColumnType
            // 
            this.DBCColumnType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBCColumnType.Enabled = false;
            this.DBCColumnType.FormattingEnabled = true;
            this.DBCColumnType.Items.AddRange(new object[] {
            "Int32",
            "Single",
            "String",
            "Flags",
            "Boolean"});
            this.DBCColumnType.Location = new System.Drawing.Point(90, 81);
            this.DBCColumnType.Margin = new System.Windows.Forms.Padding(2);
            this.DBCColumnType.Name = "DBCColumnType";
            this.DBCColumnType.Size = new System.Drawing.Size(121, 21);
            this.DBCColumnType.TabIndex = 9;
            this.DBCColumnType.SelectedIndexChanged += new System.EventHandler(this.DBCColumnType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // DBCColumnName
            // 
            this.DBCColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBCColumnName.Enabled = false;
            this.DBCColumnName.Location = new System.Drawing.Point(90, 51);
            this.DBCColumnName.Margin = new System.Windows.Forms.Padding(2);
            this.DBCColumnName.Name = "DBCColumnName";
            this.DBCColumnName.Size = new System.Drawing.Size(121, 20);
            this.DBCColumnName.TabIndex = 7;
            this.DBCColumnName.TextChanged += new System.EventHandler(this.DBCColumnName_TextChanged);
            this.DBCColumnName.Leave += new System.EventHandler(this.DBCColumnName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Column name:";
            // 
            // DBCSaveScheme
            // 
            this.DBCSaveScheme.Location = new System.Drawing.Point(194, 6);
            this.DBCSaveScheme.Name = "DBCSaveScheme";
            this.DBCSaveScheme.Size = new System.Drawing.Size(103, 23);
            this.DBCSaveScheme.TabIndex = 4;
            this.DBCSaveScheme.Text = "Save scheme";
            this.DBCSaveScheme.UseVisualStyleBackColor = true;
            this.DBCSaveScheme.Click += new System.EventHandler(this.DBCSaveScheme_Click);
            // 
            // DBCApplyScheme
            // 
            this.DBCApplyScheme.Location = new System.Drawing.Point(84, 6);
            this.DBCApplyScheme.Name = "DBCApplyScheme";
            this.DBCApplyScheme.Size = new System.Drawing.Size(104, 23);
            this.DBCApplyScheme.TabIndex = 3;
            this.DBCApplyScheme.Text = "Apply scheme";
            this.DBCApplyScheme.UseVisualStyleBackColor = true;
            this.DBCApplyScheme.Click += new System.EventHandler(this.DBCApplyScheme_Click);
            // 
            // DBCOpen
            // 
            this.DBCOpen.Location = new System.Drawing.Point(3, 6);
            this.DBCOpen.Name = "DBCOpen";
            this.DBCOpen.Size = new System.Drawing.Size(75, 23);
            this.DBCOpen.TabIndex = 2;
            this.DBCOpen.Text = "Open";
            this.DBCOpen.UseVisualStyleBackColor = true;
            this.DBCOpen.Click += new System.EventHandler(this.DBCOpen_Click);
            // 
            // DBCView
            // 
            this.DBCView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBCView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DBCView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBCView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DBCView.Location = new System.Drawing.Point(216, 51);
            this.DBCView.Name = "DBCView";
            this.DBCView.Size = new System.Drawing.Size(1037, 827);
            this.DBCView.TabIndex = 1;
            this.DBCView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DBCView_ColumnWidthChanged);
            // 
            // DBCMenu
            // 
            this.DBCMenu.Location = new System.Drawing.Point(3, 3);
            this.DBCMenu.Name = "DBCMenu";
            this.DBCMenu.Size = new System.Drawing.Size(1250, 24);
            this.DBCMenu.TabIndex = 13;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // goToIDToolStripMenuItem
            // 
            this.goToIDToolStripMenuItem.Name = "goToIDToolStripMenuItem";
            this.goToIDToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // insertLineToolStripMenuItem
            // 
            this.insertLineToolStripMenuItem.Name = "insertLineToolStripMenuItem";
            this.insertLineToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // deleteLineToolStripMenuItem
            // 
            this.deleteLineToolStripMenuItem.Name = "deleteLineToolStripMenuItem";
            this.deleteLineToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 935);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1264, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "lop";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // OpenDbcDialog
            // 
            this.OpenDbcDialog.Filter = "Known file types (*.dbc, *.db2)|*.dbc;*.db2|DBC files (*.dbc)|*.dbc|DB2 files (*." +
    "db2)|*.db2|All files (*.*)|*.*";
            this.OpenDbcDialog.Title = "Open WoW Database file";
            // 
            // OpenSchemaDialog
            // 
            this.OpenSchemaDialog.Filter = "DBC Schema files (*.dbcschema)|*.dbcschema|All files (*.*)|*.*";
            this.OpenSchemaDialog.Title = "Apply DBC Schema";
            // 
            // SaveSchemaDialog
            // 
            this.SaveSchemaDialog.DefaultExt = "dbcschema";
            this.SaveSchemaDialog.Filter = "DBC Schema Files (*.dbcschema)|*.dbcschema|All files (*.*)|*.*";
            this.SaveSchemaDialog.Title = "Save DBC Schema";
            // 
            // SaveDbcDialog
            // 
            this.SaveDbcDialog.Filter = "Known file types (*.dbc, *.db2)|*.dbc;*.db2|DBC files (*.dbc)|*.dbc|DB2 files (*." +
    "db2)|*.db2|All files (*.*)|*.*";
            this.SaveDbcDialog.Title = "Save WoW Database file";
            // 
            // creatureControl
            // 
            this.creatureControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creatureControl.Location = new System.Drawing.Point(0, 0);
            this.creatureControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.creatureControl.Name = "creatureControl";
            this.creatureControl.Size = new System.Drawing.Size(1253, 887);
            this.creatureControl.TabIndex = 1;
            // 
            // gameObjectControl
            // 
            this.gameObjectControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameObjectControl.Location = new System.Drawing.Point(0, 0);
            this.gameObjectControl.Name = "gameObjectControl";
            this.gameObjectControl.Size = new System.Drawing.Size(1253, 887);
            this.gameObjectControl.TabIndex = 1;
            // 
            // dbcTableBinding
            // 
            this.dbcTableBinding.DataSource = typeof(DatabaseEditor.Dbc.DbcRecord);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 957);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.CreaturePage.ResumeLayout(false);
            this.GameObjectPage.ResumeLayout(false);
            this.DBCPage.ResumeLayout(false);
            this.DBCPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBCView)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbcTableBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage CreaturePage;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabPage DBCPage;
        private System.Windows.Forms.MenuStrip DBCMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.DataGridView DBCView;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem insertLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLineToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage GameObjectPage;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ListBox DBCColumnsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DBCColumnType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DBCColumnName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DBCSaveScheme;
        private System.Windows.Forms.Button DBCApplyScheme;
        private System.Windows.Forms.Button DBCOpen;
        private System.Windows.Forms.Button DBCSave;
        private System.Windows.Forms.BindingSource dbcTableBinding;
        private System.Windows.Forms.OpenFileDialog OpenDbcDialog;
        private System.Windows.Forms.OpenFileDialog OpenSchemaDialog;
        private System.Windows.Forms.SaveFileDialog SaveSchemaDialog;
        private System.Windows.Forms.SaveFileDialog SaveDbcDialog;
        private Creature.CreatureControl creatureControl;
        private Editor.GameObject.GameObjectControl gameObjectControl;
    }
}

