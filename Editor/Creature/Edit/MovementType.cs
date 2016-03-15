using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class MovementType : Form
    {
        private int FormTypes { get; set; }

        public MovementType(int current_types)
        {
            InitializeComponent();

            FormTypes = current_types;
        }

        void MovementType_Load(object sender, EventArgs e)
        {
            if (FormTypes == 1)
                StayRadioButton.Checked = true;
            else if (FormTypes == 2)
                RandomRadioButton.Checked = true;
            else if (FormTypes == 3)
                WaypointRadioButton.Checked = true;
            else
                StayRadioButton.Checked = true;
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

        public int Types()
        {
            int types = 0;

            if (StayRadioButton.Checked)
                types = (int)MovementTypes.Stay;
            else if (RandomRadioButton.Checked)
                types = (int)MovementTypes.Random;
            else if (WaypointRadioButton.Checked)
                types = (int)MovementTypes.Waypoint;

            return types;
        }

        public override string ToString()
        {
            return Types().ToString();
        }
    }
}
