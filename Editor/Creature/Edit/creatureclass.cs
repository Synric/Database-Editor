using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class CreatureClass : Form
    {        
        int FormClass { get; set; }

        public CreatureClass(int current_class)
        {
            InitializeComponent();

            FormClass = current_class;
        }

        void CreatureClass_Load(object sender, EventArgs e)
        {
            switch (FormClass)
            {
                case 1:
                    WarriorRadioButton.Checked = true;
                break;
                case 2:
                    PaladinRadioButton.Checked = true;
                break;
                case 4:
                    RogueRadioButton.Checked = true;
                break;
                case 8:
                    MageRadioButton.Checked = true;
                break;
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

        public int Class()
        {
            int _class = 0;

            if (WarriorRadioButton.Checked)
                _class = (int)Classes.Warrior;
            else if (PaladinRadioButton.Checked)
                _class = (int)Classes.Paladin;
            else if (RogueRadioButton.Checked)
                _class = (int)Classes.Rogue;
            else if (MageRadioButton.Checked)
                _class = (int)Classes.Mage;

            return _class;
        }

        public override string ToString()
        {
            return Class().ToString();
        }

        private void WarriorRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaladinRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MageRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
