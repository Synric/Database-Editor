using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.Creature
{
    public partial class RepMaxStanding : Form
    {
        int FormStanding { get; set; }

        public RepMaxStanding(int current_standing)
        {
            InitializeComponent();

            FormStanding = current_standing;
        }

        void RepMaxStanding_Load(object sender, EventArgs e)
        {
            if (FormStanding == 0)
                HatedRadioButton.Checked = true;
            else if (FormStanding == 1)
                HostileRadioButton.Checked = true;
            else if (FormStanding == 2)
                UnfriendlyRadioButton.Checked = true;
            else if (FormStanding == 3)
                NeutralRadioButton.Checked = true;
            else if (FormStanding == 4)
                FriendlyRadioButton.Checked = true;
            else if (FormStanding == 5)
                HonoredRadioButton.Checked = true;
            else if (FormStanding == 6)
                ReveredRadioButton.Checked = true;
            else if (FormStanding == 7)
                ExaltedRadioButton.Checked = true;
            else
                HatedRadioButton.Checked = true;
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

        public int Reputation()
        {
            int reputation = 0;

            if (HatedRadioButton.Checked)
                reputation = (int)Reputations.Hated;
            else if (HostileRadioButton.Checked)
                reputation = (int)Reputations.Hostile;
            else if (UnfriendlyRadioButton.Checked)
                reputation = (int)Reputations.Unfriendly;
            else if (NeutralRadioButton.Checked)
                reputation = (int)Reputations.Neutral;
            else if (FriendlyRadioButton.Checked)
                reputation = (int)Reputations.Friendly;
            else if (HonoredRadioButton.Checked)
                reputation = (int)Reputations.Honored;
            else if (ReveredRadioButton.Checked)
                reputation = (int)Reputations.Revered;
            else if (ExaltedRadioButton.Checked)
                reputation = (int)Reputations.Exalted;

            return reputation;
        }

        public override string ToString()
        {
            return Reputation().ToString();
        }
    }
}
