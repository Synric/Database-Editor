using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureLocation
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        void Map_Load(object sender, EventArgs e)
        {
            if (DesignMode == false)
            {
                List<NewItem> list = new List<NewItem>();

                foreach (var record in Dbc.DbcStore.Map.GetRecords())
                    list.Add(new NewItem()
                    {
                        ID = record.GetUInt32Value(0).ToString(), // ID
                        Name = record.GetStringValue(6) // map name
                    });

                DataGrid.DataSource = list;
            }
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

        class NewItem
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
