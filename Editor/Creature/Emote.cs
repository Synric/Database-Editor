using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatabaseEditor.Creature
{
    public partial class Emote : Form
    {
        public Emote()
        {
            InitializeComponent();
        }

        private void Emote_Load(object sender, EventArgs e)
        {
            if (DesignMode == false)
            {
                List<NewItem> list = new List<NewItem>();

                foreach (var record in Dbc.DbcStore.Emote.GetRecords())
                    list.Add(new NewItem()
                    {
                        ID = record.GetUInt32Value(0).ToString(), // ID
                        Emote = record.GetStringValue(1) // Name
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
            public string ID    { get; set; }
            public string Emote { get; set; }
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
