using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class TrainerClass : Form
    {        
        int FormClass { get; set; }

        public TrainerClass(int current_class)
        {
            InitializeComponent();

            FormClass = current_class;
        }

        void TrainerClass_Load(object sender, EventArgs e)
        {
            if (FormClass == 0)
                NoneRadioButton.Checked = true;
            else if (FormClass == 1)
                WarriorRadioButton.Checked = true;
            else if (FormClass == 2)
                PaladinRadioButton.Checked = true;
            else if (FormClass == 3)
                HunterRadioButton.Checked = true;
            else if (FormClass == 4)
                RogueRadioButton.Checked = true;
            else if (FormClass == 5)
                PriestRadioButton.Checked = true;
            else if (FormClass == 6)
                DKRadioButton.Checked = true;
            else if (FormClass == 7)
                ShamanRadioButton.Checked = true;
            else if (FormClass == 8)
                MageRadioButton.Checked = true;
            else if (FormClass == 9)
                WarlockRadioButton.Checked = true;
            else if (FormClass == 11)
                DruidRadioButton.Checked = true;
            else
                NoneRadioButton.Checked = true;
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

            if (NoneRadioButton.Checked)
                _class = (int)Classes.None;
            else if (WarriorRadioButton.Checked)
                _class = (int)Classes.Warrior;
            else if (PaladinRadioButton.Checked)
                _class = (int)Classes.Paladin;
            else if (HunterRadioButton.Checked)
                _class = (int)Classes.Hunter;
            else if (RogueRadioButton.Checked)
                _class = (int)Classes.Rogue;
            else if (PriestRadioButton.Checked)
                _class = (int)Classes.Priest;
            else if (DKRadioButton.Checked)
                _class = (int)Classes.DeathKnight;
            else if (ShamanRadioButton.Checked)
                _class = (int)Classes.Shaman;
            else if (MageRadioButton.Checked)
                _class = (int)Classes.Mage;
            else if (WarlockRadioButton.Checked)
                _class = (int)Classes.Warlock;
            else if (DruidRadioButton.Checked)
                _class = (int)Classes.Druid;

            return _class;
        }

        public override string ToString()
        {
            return Class().ToString();
        }
    }
}
