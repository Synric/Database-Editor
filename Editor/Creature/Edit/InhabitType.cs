using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class InhabitType : Form
    {
        private int FormTypes { get; set; }

        public InhabitType(int current_types)
        {
            InitializeComponent();

            FormTypes = current_types;
        }

        void InhabitType_Load(object sender, EventArgs e)
        {
            if (FormTypes == 1)
                GroundRadioButton.Checked = true;
            else if (FormTypes == 2)
                WaterRadioButton.Checked = true;
            else if (FormTypes == 3)
                AllRadioButton.Checked = true;
            else if (FormTypes == 4)
                AirRadioButton.Checked = true;
            else
                GroundRadioButton.Checked = true;
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

            if (GroundRadioButton.Checked)
                types = (int)InhabitTypes.Ground;
            else if (WaterRadioButton.Checked)
                types = (int)InhabitTypes.Water;
            else if (AirRadioButton.Checked)
                types = (int)InhabitTypes.Air;
            else if (AllRadioButton.Checked)
                types = (int)InhabitTypes.All;

            return types;
        }

        public override string ToString()
        {
            return Types().ToString();
        }
    }
}
