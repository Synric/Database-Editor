using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class TrainerType : Form
    {
        int FormTrainer { get; set; }

        public TrainerType(int current_trainer)
        {
            InitializeComponent();

            FormTrainer = current_trainer;
        }

        void TrainerType_Load(object sender, EventArgs e)
        {
            if (FormTrainer == 0)
                ClassRadioButton.Checked = true;
            else if (FormTrainer == 1)
                MountsRadioButton.Checked = true;
            else if (FormTrainer == 2)
                TradeSkillsRadioButton.Checked = true;
            else if (FormTrainer == 3)
                PetsRadioButton.Checked = true;
            else
                ClassRadioButton.Checked = true;
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

            if (ClassRadioButton.Checked)
                types = (int)TrainerTypes.Class;
            else if (MountsRadioButton.Checked)
                types = (int)TrainerTypes.Mounts;
            else if (TradeSkillsRadioButton.Checked)
                types = (int)TrainerTypes.TradeSkills;
            else if (PetsRadioButton.Checked)
                types = (int)TrainerTypes.Pets;

            return types;
        }

        public override string ToString()
        {
            return Types().ToString();
        }
    }
}
