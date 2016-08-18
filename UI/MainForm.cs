using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using DatabaseEditor.Dbc;
using DatabaseEditor.Database;
using System.Linq;
using Microsoft.VisualBasic;

namespace DatabaseEditor
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; set; }

        Properties.Settings settings;

        WorldDatabase world;
        
        public MainForm()
        {
            InitializeComponent();

            Instance = this;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _StatusBar = "Closing...";

            if(WindowState == FormWindowState.Normal)
                settings.FormSize = Size;

            Application.ExitThread();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            _StatusBar = "Initializing...";

            settings = new Properties.Settings(); // metadata=res://*/Database.csdl|res://*/Database.ssdl|res://*/Database.msl;
            world = new WorldDatabase($"metadata=res://*/Database.Database.csdl|res://*/Database.Database.ssdl|res://*/Database.Database.msl;provider=MySql.Data.MySqlClient;provider connection string=\";server={settings.IPAdress};user id={settings.User};password={settings.Pass};database={settings.World_DB};persistsecurityinfo=True\"");//new WorldDatabase();

            Text = $"Database Editor - {settings.IPAdress}";

            // Initialize dictionary for tables and set datagridviews column names
            DatabaseStructure.InitializeDictionary();
            
            // Creature Control
            creatureControl.world = world;
            creatureControl.settings = settings;
            creatureControl.Initialize();
            creatureControl.CreatureTab.SelectedIndexChanged += EditorControlTab_SelectedIndexChanged;

            AcceptButton = creatureControl.AcceptButton;

            // GameObject Control
            gameObjectControl.world = world;
            gameObjectControl.settings = settings;
            gameObjectControl.Initialize();
            gameObjectControl.GameObjectTab.SelectedIndexChanged += EditorControlTab_SelectedIndexChanged;

            // Item Control
            itemControl.world = world;
            itemControl.settings = settings;
            itemControl.Initialize();
            itemControl.ItemTab.SelectedIndexChanged += EditorControlTab_SelectedIndexChanged;

            // Load App settings
            if (settings.FormSize.Height != 0 && settings.FormSize.Width != 0)
                Size = settings.FormSize;

            // Load DBCs
            if (settings.DBC_Path == String.Empty)
            {
                DBCPath dbcPath = new DBCPath();
                dbcPath.ShowDialog();
            }

            DbcStore.LoadFiles();
            //DBC.DBCStores.LoadFiles();

            /*List<DBC.FamilyEntry> list = new List<DBC.FamilyEntry>();

            foreach (var record in DBC.DBCStores.Family.Records) // Records in DBC
            {
                list.Add(record.ID, record.
            }

            DBCDataGridView.DataSource = list;*/

            _StatusBar = "Ready, MySQL connect success";
        }

        //// Get, sets
        /// <summary>
        /// Set StatusBar text
        /// </summary>
        public string _StatusBar
        {
            get { return StatusLabel.Text; }
            set { StatusLabel.Text = value; }
        }

        public WorldDatabase WorldDB { get { return world; } }

        //// FORM Menu \\\\
        void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAQ faq = new FAQ();
            faq.ShowDialog();
        }

        void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings _settings = new Settings();
            
            if (_settings.ShowDialog() == DialogResult.OK)
                settings.Reload();
        }

        //// TABS \\\\
        void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTab.SelectedTab == CreaturePage)
                AcceptButton = creatureControl.AcceptButton;
            else if (MainTab.SelectedTab == GameObjectPage)
                AcceptButton = gameObjectControl.AcceptButton;
            else if (MainTab.SelectedTab == ItemPage)
                AcceptButton = itemControl.AcceptButton;
        }

        void EditorControlTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = ((sender as TabControl).Parent as EditorControl).AcceptButton;
        }

        //// DBC \\\\
        DbcTable dbcTable;
        DbcSchema dbcSchema;

        string dbcSchemFile;
        string dbcFile;
        string dbcFilePath;

        bool changingColumnSelectionDBC;
        bool updatingColumnSetDBC;

        void CreateDefaultSchema()
        {
            dbcSchema = new DbcSchema();

            switch(dbcFile)
            {
                case "Spell.dbc":
                    LoadStructure(typeof(SpellDbc));
                    break;

                case "AreaTable.dbc":
                    LoadStructure(typeof(AreaDbc));
                    break;

                case "Emotes.dbc":
                    LoadStructure(typeof(EmoteDbc));
                    break;

                case "Faction.dbc":
                    LoadStructure(typeof(FactionDbc));
                    break;

                case "Family.dbc":
                    LoadStructure(typeof(FamilyDbc));
                    break;

                case "Map.dbc":
                    LoadStructure(typeof(MapDbc));
                    break;

                case "TotemCategory.dbc":
                    LoadStructure(typeof(TotemCategory));
                    break;

                case "Languages.dbc":
                    LoadStructure(typeof(Language));
                    break;

                case "PageTextMaterial.dbc":
                    LoadStructure(typeof(PageMaterial));
                    break;

                case "Holidays.dbc":
                    LoadStructure(typeof(Holiday));
                    break;

                case "HolidayNames.dbc":
                    LoadStructure(typeof(HolidayNames));
                    break;

                case "SkillLine.dbc":
                    LoadStructure(typeof(SkillLine));
                    break;

                default:
                    {
                        for (int i = 0; i < dbcTable.ColumnCount; i++)
                            dbcSchema.AddColumn(new DbcColumnSchema()
                            {
                                Name = $"Column{i}",
                                Position = i,
                                Type = ColumnType.Int32,
                                Width = 100,
                            });
                    }
                    break;
            }

            BindSchema();
        }

        void LoadStructure(Type type)
        {
            FieldInfo[] fields = type.GetFields();

            for (int i = 0; i < dbcTable.ColumnCount; i++)
            {
                FieldInfo field = fields[i];

                dbcSchema.AddColumn(new DbcColumnSchema()
                {
                    Name = (field.GetCustomAttribute(typeof(DbcRecordDetailsAttribute)) as DbcRecordDetailsAttribute).Name,
                    Position = i,
                    Type = DbcColumnSchemaHelper.GetColumnType(field.FieldType),
                    Width = 100
                });
            }
        }

        void BindSchema()
        {
            DBCColumnsList.Items.Clear();

            foreach (var col in dbcSchema.Columns)
                DBCColumnsList.Items.Add(col.Name);

            DBCColumnsList.SelectedItem = null;
        }

        void PopulateDbc()
        {
            DBCView.Columns.Clear();
            
            for (int i = 0; i < dbcTable.ColumnCount; i++)
                DBCView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = dbcSchema[i].Name, Width = dbcSchema[i].Width });

            foreach (var item in dbcTable.GetRecords())
            {
                DataGridViewRow row = new DataGridViewRow();

                foreach (var col in dbcSchema.Columns)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();

                    switch (col.Type)
                    {
                        case ColumnType.Int32:
                            cell.Value = item.GetInt32Value(col.Position);
                            break;

                        case ColumnType.Single:
                            cell.Value = item.GetSingleValue(col.Position);
                            break;

                        case ColumnType.String:
                            cell.Value = item.GetStringValue(col.Position);
                            break;

                        case ColumnType.Int32Flags:
                            cell.Value = item.GetInt32Value(col.Position).ToString("x8");
                            break;

                        case ColumnType.Boolean:
                            cell.Value = item.GetInt32Value(col.Position) == 1;
                            break;

                        case ColumnType.UInt32:
                            cell.Value = item.GetUInt32Value(col.Position);
                            break;
                    }

                    row.Cells.Add(cell);
                }

                DBCView.Rows.Add(row);
            }

            //status.Text = string.Format("{0} rows; string block length {1}, file format {2}; data position 0x{3:x8}", dbcTable.Count, dbcTable.StringBlockLength, dbcTable.FileFormat, dbcTable.DataPosition);
        }

        void RebindColumn(int colIndex)
        {
            int curRow = 0;

            foreach (var item in dbcTable.GetRecords())
            {
                DataGridViewCell cell = DBCView.Rows[curRow++].Cells[colIndex];

                switch (dbcSchema[colIndex].Type)
                {
                    case ColumnType.Int32:
                        cell.Value = item.GetInt32Value(colIndex);
                        break;

                    case ColumnType.Single:
                        cell.Value = item.GetSingleValue(colIndex);
                        break;

                    case ColumnType.String:
                        cell.Value = item.GetStringValue(colIndex);
                        break;

                    case ColumnType.Int32Flags:
                        cell.Value = item.GetInt32Value(colIndex).ToString("x8");
                        break;

                    case ColumnType.Boolean:
                        cell.Value = item.GetInt32Value(colIndex) == 1;
                        break;
                }
            }
        }

        void DBCColumnsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingColumnSetDBC)
                return;

            changingColumnSelectionDBC = true;

            if (DBCColumnsList.SelectedIndex == -1)
            {
                DBCColumnName.Text = "";
                DBCColumnName.Enabled = false;
                DBCColumnType.SelectedItem = null;
                DBCColumnType.Enabled = false;
            }
            else
            {
                var col = dbcSchema[DBCColumnsList.SelectedIndex];

                DBCColumnName.Text = col.Name;
                DBCColumnName.Enabled = true;
                DBCColumnType.SelectedIndex = (int)col.Type;
                DBCColumnType.Enabled = true;
            }

            changingColumnSelectionDBC = false;
        }

        void DBCColumnName_TextChanged(object sender, EventArgs e)
        {
            if (DBCColumnsList.SelectedIndex == -1)
                return;
            
            dbcSchema[DBCColumnsList.SelectedIndex].Name = DBCColumnName.Text;

            DBCView.Columns[DBCColumnsList.SelectedIndex].HeaderText = DBCColumnName.Text;
        }

        void DBCColumnName_Leave(object sender, EventArgs e)
        {
            updatingColumnSetDBC = true;

            DBCColumnsList.Items[DBCColumnsList.SelectedIndex] = DBCColumnName.Text;

            updatingColumnSetDBC = false;
        }

        void DBCColumnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changingColumnSelectionDBC)
                return;

            var colIndex = DBCColumnsList.SelectedIndex;

            if (colIndex == -1 || DBCColumnType.SelectedIndex == -1)
                return;
            
            dbcSchema[colIndex].Type = (ColumnType)DBCColumnType.SelectedIndex;

            RebindColumn(colIndex);
        }

        void DBCView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            int index = DBCView.Columns.IndexOf(e.Column);

            if (index == -1)
                return;

            dbcSchema[index].Width = e.Column.Width;
        }

        // Dbc menu
        private void openDbcMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenDbcDialog.ShowDialog() == DialogResult.OK)
            {
                if (dbcTable != null)
                {
                    DBCView.Rows.Clear();
                    DBCView.Columns.Clear();

                    dbcTable.Dispose();
                    dbcTable = null;
                }

                FileStream fs = File.OpenRead(OpenDbcDialog.FileName);
                dbcFile = Path.GetFileName(OpenDbcDialog.FileName);
                dbcFilePath = Path.GetDirectoryName(OpenDbcDialog.FileName);

                dbcTable = new DbcTable(fs, true);

                var testSchema = Path.Combine(dbcFilePath, dbcFile + "schema");

                if (File.Exists(testSchema))
                {
                    using (var file = File.OpenRead(testSchema))
                    {
                        dbcSchema = DbcSchema.Load(file, dbcTable.ColumnCount);
                        dbcSchemFile = testSchema;
                    }

                    BindSchema();
                }
                else
                {
                    CreateDefaultSchema();
                    dbcSchemFile = null;
                }

                PopulateDbc();
            }
        }

        private void applySchemeMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveSchemeMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dbcSchemFile))
            {
                using (FileStream fs = new FileStream(dbcSchemFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.SetLength(0);

                    dbcSchema.Save(fs, dbcFile);
                }
            }
            else
            {
                SaveSchemaDialog.FileName = dbcFile + "schema";

                if (SaveSchemaDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(SaveSchemaDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fs.SetLength(0);

                        dbcSchema.Save(fs, dbcFile);
                    }
                }
            }
        }

        private void saveDbcMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsDbcMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveDbcDialog.ShowDialog() == DialogResult.OK)
            {
                if (dbcTable == null)
                    return;

                dbcTable.Write(SaveDbcDialog.FileName, dbcSchema, DBCView);
            }
        }

        private void closeDbcMenuItem_Click(object sender, EventArgs e)
        {
            if (dbcTable != null)
            {
                DBCView.Rows.Clear();
                DBCView.Columns.Clear();

                dbcTable.Dispose();
                dbcTable = null;
            }
        }

        private void goToIDMenuItem_Click(object sender, EventArgs e)
        {
            string retVal = Interaction.InputBox("Insert ID", "Go to ID");

            int line = 0;
            Int32.TryParse(retVal, out line);

            DataGridViewRow findedRow = DBCView.Rows.Cast<DataGridViewRow>().Where(row => row.Cells[0].Value.ToString() == line.ToString()).FirstOrDefault();
            
            if(findedRow != null)
            {
                DBCView.ClearSelection();
                DBCView.Rows[findedRow.Index].Selected = true;
                DBCView.FirstDisplayedScrollingRowIndex = findedRow.Index;
                DBCView.Focus();
            }
        }
        
        private void searchDbcMenuItem_Click(object sender, EventArgs e)
        {
            string retVal = Interaction.InputBox("Insert parameter", "Search");

            int col = 0;

            DataGridViewRow findedRow = DBCView.Rows.Cast<DataGridViewRow>().Where(x => x.Cells.Cast<DataGridViewCell>().Where(y =>
            {
                if (y.Value != null && y.Value.ToString().Contains(retVal) && y.RowIndex > DBCView.CurrentRow.Index)
                {
                    col = y.ColumnIndex;

                    return true;
                }

                return false;
            }).Count() > 0).FirstOrDefault();
            
            if(findedRow != null)
            {
                DBCView.ClearSelection();
                DBCView.Rows[findedRow.Index].Selected = true;
                DBCView.Rows[findedRow.Index].Cells[col].Selected = true;
                DBCView.FirstDisplayedScrollingRowIndex = findedRow.Index;
                DBCView.FirstDisplayedScrollingColumnIndex = col;
                DBCView.Focus();
            }
        }

        private void searchColumnDbcMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceColMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyLineMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearLineMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearColMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertLineMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteLineMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
