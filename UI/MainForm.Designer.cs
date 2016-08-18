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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applySchemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSchemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsDbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.goToIDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.searchDbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchColumnDbcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceColMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyLineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearColMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertLineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.CreaturePage = new System.Windows.Forms.TabPage();
            this.creatureControl = new DatabaseEditor.Creature.CreatureControl();
            this.GameObjectPage = new System.Windows.Forms.TabPage();
            this.gameObjectControl = new DatabaseEditor.Editor.GameObject.GameObjectControl();
            this.ItemPage = new System.Windows.Forms.TabPage();
            this.itemControl = new DatabaseEditor.Editor.Item.ItemControl();
            this.DBCPage = new System.Windows.Forms.TabPage();
            this.DBCColumnsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DBCColumnType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DBCColumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dbcTableBinding = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenu.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.CreaturePage.SuspendLayout();
            this.GameObjectPage.SuspendLayout();
            this.ItemPage.SuspendLayout();
            this.DBCPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBCView)).BeginInit();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbcTableBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.dbcMenuItem,
            this.helpMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1264, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileMenuItem.Text = "File";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dbcMenuItem
            // 
            this.dbcMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDbcMenuItem,
            this.applySchemeMenuItem,
            this.saveSchemeMenuItem,
            this.saveDbcMenuItem,
            this.saveAsDbcMenuItem,
            this.closeDbcMenuItem,
            this.toolStripSeparator5,
            this.goToIDMenuItem,
            this.toolStripSeparator6,
            this.searchDbcMenuItem,
            this.searchColumnDbcMenuItem,
            this.replaceColMenuItem,
            this.toolStripSeparator7,
            this.copyLineMenuItem,
            this.clearLineMenuItem,
            this.clearColMenuItem,
            this.insertLineMenuItem,
            this.deleteLineMenuItem});
            this.dbcMenuItem.Name = "dbcMenuItem";
            this.dbcMenuItem.Size = new System.Drawing.Size(48, 24);
            this.dbcMenuItem.Text = "Dbc";
            // 
            // openDbcMenuItem
            // 
            this.openDbcMenuItem.Name = "openDbcMenuItem";
            this.openDbcMenuItem.Size = new System.Drawing.Size(206, 26);
            this.openDbcMenuItem.Text = "Open";
            this.openDbcMenuItem.Click += new System.EventHandler(this.openDbcMenuItem_Click);
            // 
            // applySchemeMenuItem
            // 
            this.applySchemeMenuItem.Name = "applySchemeMenuItem";
            this.applySchemeMenuItem.Size = new System.Drawing.Size(206, 26);
            this.applySchemeMenuItem.Text = "Apply scheme";
            this.applySchemeMenuItem.Click += new System.EventHandler(this.applySchemeMenuItem_Click);
            // 
            // saveSchemeMenuItem
            // 
            this.saveSchemeMenuItem.Name = "saveSchemeMenuItem";
            this.saveSchemeMenuItem.Size = new System.Drawing.Size(206, 26);
            this.saveSchemeMenuItem.Text = "Save scheme";
            this.saveSchemeMenuItem.Click += new System.EventHandler(this.saveSchemeMenuItem_Click);
            // 
            // saveDbcMenuItem
            // 
            this.saveDbcMenuItem.Name = "saveDbcMenuItem";
            this.saveDbcMenuItem.Size = new System.Drawing.Size(206, 26);
            this.saveDbcMenuItem.Text = "Save";
            this.saveDbcMenuItem.Click += new System.EventHandler(this.saveDbcMenuItem_Click);
            // 
            // saveAsDbcMenuItem
            // 
            this.saveAsDbcMenuItem.Name = "saveAsDbcMenuItem";
            this.saveAsDbcMenuItem.Size = new System.Drawing.Size(206, 26);
            this.saveAsDbcMenuItem.Text = "Save as";
            this.saveAsDbcMenuItem.Click += new System.EventHandler(this.saveAsDbcMenuItem_Click);
            // 
            // closeDbcMenuItem
            // 
            this.closeDbcMenuItem.Name = "closeDbcMenuItem";
            this.closeDbcMenuItem.Size = new System.Drawing.Size(206, 26);
            this.closeDbcMenuItem.Text = "Close";
            this.closeDbcMenuItem.Click += new System.EventHandler(this.closeDbcMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
            // 
            // goToIDMenuItem
            // 
            this.goToIDMenuItem.Name = "goToIDMenuItem";
            this.goToIDMenuItem.Size = new System.Drawing.Size(206, 26);
            this.goToIDMenuItem.Text = "Go to ID";
            this.goToIDMenuItem.Click += new System.EventHandler(this.goToIDMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(203, 6);
            // 
            // searchDbcMenuItem
            // 
            this.searchDbcMenuItem.Name = "searchDbcMenuItem";
            this.searchDbcMenuItem.Size = new System.Drawing.Size(206, 26);
            this.searchDbcMenuItem.Text = "Search";
            this.searchDbcMenuItem.Click += new System.EventHandler(this.searchDbcMenuItem_Click);
            // 
            // searchColumnDbcMenuItem
            // 
            this.searchColumnDbcMenuItem.Name = "searchColumnDbcMenuItem";
            this.searchColumnDbcMenuItem.Size = new System.Drawing.Size(206, 26);
            this.searchColumnDbcMenuItem.Text = "Search column";
            this.searchColumnDbcMenuItem.Click += new System.EventHandler(this.searchColumnDbcMenuItem_Click);
            // 
            // replaceColMenuItem
            // 
            this.replaceColMenuItem.Name = "replaceColMenuItem";
            this.replaceColMenuItem.Size = new System.Drawing.Size(206, 26);
            this.replaceColMenuItem.Text = "Replace in column";
            this.replaceColMenuItem.Click += new System.EventHandler(this.replaceColMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(203, 6);
            // 
            // copyLineMenuItem
            // 
            this.copyLineMenuItem.Name = "copyLineMenuItem";
            this.copyLineMenuItem.Size = new System.Drawing.Size(206, 26);
            this.copyLineMenuItem.Text = "Copy line to";
            this.copyLineMenuItem.Click += new System.EventHandler(this.copyLineMenuItem_Click);
            // 
            // clearLineMenuItem
            // 
            this.clearLineMenuItem.Name = "clearLineMenuItem";
            this.clearLineMenuItem.Size = new System.Drawing.Size(206, 26);
            this.clearLineMenuItem.Text = "Clear line";
            this.clearLineMenuItem.Click += new System.EventHandler(this.clearLineMenuItem_Click);
            // 
            // clearColMenuItem
            // 
            this.clearColMenuItem.Name = "clearColMenuItem";
            this.clearColMenuItem.Size = new System.Drawing.Size(206, 26);
            this.clearColMenuItem.Text = "Clear column";
            this.clearColMenuItem.Click += new System.EventHandler(this.clearColMenuItem_Click);
            // 
            // insertLineMenuItem
            // 
            this.insertLineMenuItem.Name = "insertLineMenuItem";
            this.insertLineMenuItem.Size = new System.Drawing.Size(206, 26);
            this.insertLineMenuItem.Text = "Insert line";
            this.insertLineMenuItem.Click += new System.EventHandler(this.insertLineMenuItem_Click);
            // 
            // deleteLineMenuItem
            // 
            this.deleteLineMenuItem.Name = "deleteLineMenuItem";
            this.deleteLineMenuItem.Size = new System.Drawing.Size(206, 26);
            this.deleteLineMenuItem.Text = "Delete line";
            this.deleteLineMenuItem.Click += new System.EventHandler(this.deleteLineMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpMenuItem.Text = "Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(122, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.CreaturePage);
            this.MainTab.Controls.Add(this.GameObjectPage);
            this.MainTab.Controls.Add(this.ItemPage);
            this.MainTab.Controls.Add(this.DBCPage);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTab.Location = new System.Drawing.Point(0, 28);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1264, 929);
            this.MainTab.TabIndex = 1;
            this.MainTab.TabStop = false;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // CreaturePage
            // 
            this.CreaturePage.AutoScroll = true;
            this.CreaturePage.Controls.Add(this.creatureControl);
            this.CreaturePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreaturePage.Location = new System.Drawing.Point(4, 26);
            this.CreaturePage.Name = "CreaturePage";
            this.CreaturePage.Padding = new System.Windows.Forms.Padding(3);
            this.CreaturePage.Size = new System.Drawing.Size(1256, 899);
            this.CreaturePage.TabIndex = 0;
            this.CreaturePage.Text = "Creature";
            this.CreaturePage.UseVisualStyleBackColor = true;
            // 
            // creatureControl
            // 
            this.creatureControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creatureControl.Location = new System.Drawing.Point(0, 0);
            this.creatureControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.creatureControl.Name = "creatureControl";
            this.creatureControl.Size = new System.Drawing.Size(1253, 879);
            this.creatureControl.TabIndex = 1;
            // 
            // GameObjectPage
            // 
            this.GameObjectPage.AutoScroll = true;
            this.GameObjectPage.Controls.Add(this.gameObjectControl);
            this.GameObjectPage.Location = new System.Drawing.Point(4, 26);
            this.GameObjectPage.Name = "GameObjectPage";
            this.GameObjectPage.Padding = new System.Windows.Forms.Padding(3);
            this.GameObjectPage.Size = new System.Drawing.Size(1256, 899);
            this.GameObjectPage.TabIndex = 2;
            this.GameObjectPage.Text = "Gameobject";
            this.GameObjectPage.UseVisualStyleBackColor = true;
            // 
            // gameObjectControl
            // 
            this.gameObjectControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameObjectControl.Location = new System.Drawing.Point(0, 0);
            this.gameObjectControl.Margin = new System.Windows.Forms.Padding(5);
            this.gameObjectControl.Name = "gameObjectControl";
            this.gameObjectControl.Size = new System.Drawing.Size(1253, 887);
            this.gameObjectControl.TabIndex = 1;
            // 
            // ItemPage
            // 
            this.ItemPage.Controls.Add(this.itemControl);
            this.ItemPage.Location = new System.Drawing.Point(4, 26);
            this.ItemPage.Name = "ItemPage";
            this.ItemPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemPage.Size = new System.Drawing.Size(1256, 899);
            this.ItemPage.TabIndex = 3;
            this.ItemPage.Text = "Item";
            this.ItemPage.UseVisualStyleBackColor = true;
            // 
            // itemControl
            // 
            this.itemControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemControl.Location = new System.Drawing.Point(0, 0);
            this.itemControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itemControl.Name = "itemControl";
            this.itemControl.Size = new System.Drawing.Size(0, 0);
            this.itemControl.TabIndex = 0;
            // 
            // DBCPage
            // 
            this.DBCPage.AutoScroll = true;
            this.DBCPage.Controls.Add(this.DBCColumnsList);
            this.DBCPage.Controls.Add(this.label3);
            this.DBCPage.Controls.Add(this.DBCColumnType);
            this.DBCPage.Controls.Add(this.label2);
            this.DBCPage.Controls.Add(this.DBCColumnName);
            this.DBCPage.Controls.Add(this.label4);
            this.DBCPage.Controls.Add(this.DBCView);
            this.DBCPage.Controls.Add(this.DBCMenu);
            this.DBCPage.Location = new System.Drawing.Point(4, 26);
            this.DBCPage.Name = "DBCPage";
            this.DBCPage.Padding = new System.Windows.Forms.Padding(3);
            this.DBCPage.Size = new System.Drawing.Size(1256, 899);
            this.DBCPage.TabIndex = 1;
            this.DBCPage.Text = "DBC";
            this.DBCPage.UseVisualStyleBackColor = true;
            // 
            // DBCColumnsList
            // 
            this.DBCColumnsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DBCColumnsList.FormattingEnabled = true;
            this.DBCColumnsList.ItemHeight = 17;
            this.DBCColumnsList.Location = new System.Drawing.Point(17, 109);
            this.DBCColumnsList.Margin = new System.Windows.Forms.Padding(2);
            this.DBCColumnsList.Name = "DBCColumnsList";
            this.DBCColumnsList.Size = new System.Drawing.Size(194, 786);
            this.DBCColumnsList.TabIndex = 11;
            this.DBCColumnsList.SelectedIndexChanged += new System.EventHandler(this.DBCColumnsList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
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
            this.DBCColumnType.Location = new System.Drawing.Point(63, 60);
            this.DBCColumnType.Margin = new System.Windows.Forms.Padding(2);
            this.DBCColumnType.Name = "DBCColumnType";
            this.DBCColumnType.Size = new System.Drawing.Size(1045, 25);
            this.DBCColumnType.TabIndex = 9;
            this.DBCColumnType.SelectedIndexChanged += new System.EventHandler(this.DBCColumnType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // DBCColumnName
            // 
            this.DBCColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBCColumnName.Enabled = false;
            this.DBCColumnName.Location = new System.Drawing.Point(65, 29);
            this.DBCColumnName.Margin = new System.Windows.Forms.Padding(2);
            this.DBCColumnName.Name = "DBCColumnName";
            this.DBCColumnName.Size = new System.Drawing.Size(1045, 23);
            this.DBCColumnName.TabIndex = 7;
            this.DBCColumnName.TextChanged += new System.EventHandler(this.DBCColumnName_TextChanged);
            this.DBCColumnName.Leave += new System.EventHandler(this.DBCColumnName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DBCView
            // 
            this.DBCView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBCView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBCView.Location = new System.Drawing.Point(216, 30);
            this.DBCView.Name = "DBCView";
            this.DBCView.Size = new System.Drawing.Size(1045, 840);
            this.DBCView.TabIndex = 1;
            this.DBCView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DBCView_ColumnWidthChanged);
            // 
            // DBCMenu
            // 
            this.DBCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // dbcTableBinding
            // 
            this.dbcTableBinding.DataSource = typeof(DatabaseEditor.Dbc.DbcRecord);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
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
            this.ItemPage.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
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
        private System.Windows.Forms.BindingSource dbcTableBinding;
        private System.Windows.Forms.OpenFileDialog OpenDbcDialog;
        private System.Windows.Forms.OpenFileDialog OpenSchemaDialog;
        private System.Windows.Forms.SaveFileDialog SaveSchemaDialog;
        private System.Windows.Forms.SaveFileDialog SaveDbcDialog;
        private Creature.CreatureControl creatureControl;
        private Editor.GameObject.GameObjectControl gameObjectControl;
        private System.Windows.Forms.TabPage ItemPage;
        private Editor.Item.ItemControl itemControl;
        private System.Windows.Forms.ToolStripMenuItem dbcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDbcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applySchemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSchemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDbcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsDbcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDbcMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem goToIDMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem searchDbcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchColumnDbcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceColMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem copyLineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearColMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertLineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLineMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DBCColumnType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DBCColumnName;
        private System.Windows.Forms.Label label4;
    }
}

