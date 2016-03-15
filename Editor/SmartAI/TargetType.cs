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
    public partial class TargetType : Form
    {
        public TargetType()
        {
            InitializeComponent();
        }

        private void TargetType_Load(object sender, EventArgs e)
        {
            addRow(0, "SMART_TARGET_NONE", "", "", "", "", "", "", "", "None, default to invoker");
            addRow(1, "SMART_TARGET_SELF", "", "", "", "", "", "", "", "Self cast");
            addRow(2, "SMART_TARGET_VICTIM", "", "", "", "", "", "", "", "Our current target (ie: highest aggro)");
            addRow(3, "SMART_TARGET_HOSTILE_SECOND_AGGRO", "", "", "", "", "", "", "", "Second highest aggro");
            addRow(4, "SMART_TARGET_HOSTILE_LAST_AGGRO", "", "", "", "", "", "", "", "Dead last on aggro");
            addRow(5, "SMART_TARGET_HOSTILE_RANDOM", "", "", "", "", "", "", "", "Just any random target on our threat list");
            addRow(6, "SMART_TARGET_HOSTILE_RANDOM_NOT_TOP", "", "", "", "", "", "", "", "Any random target except top threat");
            addRow(7, "SMART_TARGET_ACTION_INVOKER", "", "", "", "", "", "", "", "Unit who caused this Event to occur");
            addRow(8, "SMART_TARGET_POSITION", "", "", "", "x", "y", "z", "o", "Use xyz from event params");
            addRow(9, "SMART_TARGET_CREATURE_RANGE", "creature Entry (0 any)", "min Dist", "max Dist", "", "", "", "", "");
            addRow(10, "SMART_TARGET_CREATURE_GUID", "guid", "entry", "", "", "", "", "", "");
            addRow(11, "SMART_TARGET_CREATURE_DISTANCE", "creature Entry (0 any)", "max Dist", "", "", "", "", "", "");
            addRow(12, "SMART_TARGET_STORED", "id", "", "", "", "", "", "", "Uses pre-stored target (list)");
            addRow(13, "SMART_TARGET_GAMEOBJECT_RANGE", "go Entry (0 any)", "min Dist", "max Dist", "", "", "", "", "");
            addRow(14, "SMART_TARGET_GAMEOBJECT_GUID", "guid", "entry", "", "", "", "", "", "");
            addRow(15, "SMART_TARGET_GAMEOBJECT_DISTANCE", "go Entry (0 any)", "max Dist", "", "", "", "", "", "");
            addRow(16, "SMART_TARGET_INVOKER_PARTY", "", "", "", "", "", "", "", "Invoker's party members");
            addRow(17, "SMART_TARGET_PLAYER_RANGE", "min Dist", "max Dist", "", "", "", "", "", "");
            addRow(18, "SMART_TARGET_PLAYER_DISTANCE", "max Dist", "", "", "", "", "", "", "");
            addRow(19, "SMART_TARGET_CLOSEST_CREATURE", "creature Entry (0 any)", "max Dist", "dead? (0/1)", "", "", "", "", "param 2 = 0 -> 100 yards");
            addRow(20, "SMART_TARGET_CLOSEST_GAMEOBJECT", "go Entry (0 any)", "max Dist", "", "", "", "", "", "param 2 = 0 -> 100 yards");
            addRow(21, "SMART_TARGET_CLOSEST_PLAYER", "max Dist", "", "", "", "", "", "", "");
            addRow(22, "SMART_TARGET_ACTION_INVOKER_VEHICLE", "", "", "", "", "", "", "", "Unit's vehicle who caused this Event to occur");
            addRow(23, "SMART_TARGET_OWNER_OR_SUMMONER", "", "", "", "", "", "", "", "Unit's owner or summoner");
            addRow(24, "SMART_TARGET_THREAT_LIST", "", "", "", "", "", "", "", "All units on creature's threat list");	
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

        void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        void addRow(int index, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(DataGrid);
            row.Cells[0].Value = index.ToString();
            row.Cells[1].Value = text1;
            row.Cells[2].Value = text2;
            row.Cells[3].Value = text3;
            row.Cells[4].Value = text4;
            row.Cells[5].Value = text5;
            row.Cells[6].Value = text6;
            row.Cells[7].Value = text7;
            row.Cells[8].Value = text8;
            row.Cells[9].Value = text9;

            DataGrid.Rows.Add(row);
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
