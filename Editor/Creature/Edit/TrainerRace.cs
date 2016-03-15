using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class TrainerRace : Form
    {
        private int FormRace { get; set; }

        public TrainerRace(int current_race)
        {
            InitializeComponent();

            FormRace = current_race;
        }

        void TrainerRace_Load(object sender, EventArgs e)
        {
            if (FormRace == 0)
                NoneRadioButton.Checked = true;
            else if (FormRace == 1)
                HumanRadioButton.Checked = true;
            else if (FormRace == 2)
                OrcRadioButton.Checked = true;
            else if (FormRace == 3)
                DwarfRadioButton.Checked = true;
            else if (FormRace == 4)
                NightElfRadioButton.Checked = true;
            else if (FormRace == 5)
                UndeadRadioButton.Checked = true;
            else if (FormRace == 6)
                TaurenRadioButton.Checked = true;
            else if (FormRace == 7)
                GnomRadioButton.Checked = true;
            else if (FormRace == 8)
                TrollRadioButton.Checked = true;
            else if (FormRace == 10)
                BloodElfRadioButton.Checked = true;
            else if (FormRace == 11)
                DraeneiRadioButton.Checked = true;
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

        public int Race()
        {
            int race = 0;

            if (NoneRadioButton.Checked)
                race = (int)Races.None;
            else if (HumanRadioButton.Checked)
                race = (int)Races.Human;
            else if (DwarfRadioButton.Checked)
                race = (int)Races.Dwarf;
            else if (NightElfRadioButton.Checked)
                race = (int)Races.NightElf;
            else if (GnomRadioButton.Checked)
                race = (int)Races.Gnome;
            else if (DraeneiRadioButton.Checked)
                race = (int)Races.Draenei;
            else if (OrcRadioButton.Checked)
                race = (int)Races.Orc;
            else if (UndeadRadioButton.Checked)
                race = (int)Races.Undead;
            else if (TaurenRadioButton.Checked)
                race = (int)Races.Tauren;
            else if (TrollRadioButton.Checked)
                race = (int)Races.Troll;
            else if (BloodElfRadioButton.Checked)
                race = (int)Races.BloodElf;

            return race;
        }

        public override string ToString()
        {
            return Race().ToString();
        }
    }
}
