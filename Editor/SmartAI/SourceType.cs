using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor.Creature.CreatureSmartAI
{
    public partial class SourceType : Form
    {
        public SourceType()
        {
            InitializeComponent();
        }

        private void SourceType_Load(object sender, EventArgs e)
        {
            addRow(0, "SMART_SCRIPT_TYPE_CREATURE");
            addRow(1, "SMART_SCRIPT_TYPE_GAMEOBJECT");
            addRow(2, "SMART_SCRIPT_TYPE_AREATRIGGER");
            addRow(3, "SMART_SCRIPT_TYPE_EVENT [NOT IMPLEMENTED]");
            addRow(4, "SMART_SCRIPT_TYPE_GOSSIP [NOT IMPLEMENTED]");
            addRow(5, "SMART_SCRIPT_TYPE_QUEST [NOT IMPLEMENTED]");
            addRow(6, "SMART_SCRIPT_TYPE_SPELL [NOT IMPLEMENTED]");
            addRow(7, "SMART_SCRIPT_TYPE_TRANSPORT [NOT IMPLEMENTED]");
            addRow(8, "SMART_SCRIPT_TYPE_INSTANCE [NOT IMPLEMENTED]");
            addRow(9, "SMART_SCRIPT_TYPE_TIMED_ACTIONLIST");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void addRow(int index, string text2)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(DataGrid);
            row.Cells[0].Value = index.ToString();
            row.Cells[1].Value = text2;

            DataGrid.Rows.Add(row);
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
