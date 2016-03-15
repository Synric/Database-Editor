using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class Rank : Form
    {
        private int FormRank { get; set; }

        public Rank(int current_rank)
        {
            InitializeComponent();

            FormRank = current_rank;
        }

        void Rank_Load(object sender, EventArgs e)
        {
            if (FormRank == 0)
                NoneRadioButton.Checked = true;
            else if (FormRank == 1)
                EliteRadioButton.Checked = true;
            else if (FormRank == 2)
                RareEliteRadioButton.Checked = true;
            else if (FormRank == 3)
                WorldBossRadioButton.Checked = true;
            else if (FormRank == 4)
                RareRadioButton.Checked = true;
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

        public int Rank_()
        {
            int rank = 0;

            if (NoneRadioButton.Checked)
                rank = (int)Ranks.None;
            else if (EliteRadioButton.Checked)
                rank = (int)Ranks.Elite;
            else if (RareEliteRadioButton.Checked)
                rank = (int)Ranks.RareElite;
            else if (WorldBossRadioButton.Checked)
                rank = (int)Ranks.WorldBoss;
            else if (RareRadioButton.Checked)
                rank = (int)Ranks.Rare;

            return rank;
        }

        public override string ToString()
        {
            return Rank_().ToString();
        }
    }
}
