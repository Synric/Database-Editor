using System;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class Loot : Form
    {
        Properties.Settings settings;
        
        int id = 0;

        WorldDatabase world;

        public Loot(int current_item)
        {
            InitializeComponent();

            id = current_item;
        }

        void Loot_Load(object sender, EventArgs e)
        {
            settings = new Properties.Settings();

            world = MainForm.Instance.WorldDB;

            //todo initialize datagrid column names

            var query = world.item_template.Select(x => new { x.entry, x.name }).ToList();

            DataGrid.Load(query);

            // find row and select
        }
        
        void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        void WoWHeadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://old.wowhead.com/?item=" + Selected);
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
