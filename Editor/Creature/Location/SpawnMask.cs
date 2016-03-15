using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureLocation
{
    public partial class SpawnMask : Form
    {
        private int FormSpawnMask { get; set; }

        public SpawnMask(int current_mask)
        {
            InitializeComponent();

            FormSpawnMask = current_mask;
        }

        void SpawnMask_Load(object sender, EventArgs e)
        {
            if (FormSpawnMask == 0)
                SpawnMask0RadioButton.Checked = true;
            else if (FormSpawnMask == 1)
                SpawnMask1RadioButton.Checked = true;
            else if (FormSpawnMask == 2)
                SpawnMask2RadioButton.Checked = true;
            else if (FormSpawnMask == 4)
                SpawnMask4RadioButton.Checked = true;
            else if (FormSpawnMask == 8)
                SpawnMask8RadioButton.Checked = true;
            else if (FormSpawnMask == 15)
                SpawnMask15RadioButton.Checked = true;
            else
                SpawnMask0RadioButton.Checked = true;
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

        [Flags]
        enum SpawnMasks : uint
        {
            NotSpawned          = 0,
            TenManNormal        = 1,
            TwentyFiveManNormal = 2,
            TenManHeroic        = 4,
            TwentyFiveManHeroic = 8,
            All                 = 15,
        }

        public int SpawnMask_()
        {
            int spawn_mask = 0;

            if (SpawnMask0RadioButton.Checked)
                spawn_mask = (int)SpawnMasks.NotSpawned;
            if (SpawnMask1RadioButton.Checked)
                spawn_mask = (int)SpawnMasks.TenManNormal;
            if (SpawnMask2RadioButton.Checked)
                spawn_mask = (int)SpawnMasks.TwentyFiveManNormal;
            if (SpawnMask4RadioButton.Checked)
                spawn_mask = (int)SpawnMasks.TenManHeroic;
            if (SpawnMask8RadioButton.Checked)
                spawn_mask = (int)SpawnMasks.TwentyFiveManHeroic;
            if (SpawnMask15RadioButton.Checked)
                spawn_mask = (int)SpawnMasks.All;

            return spawn_mask;
        }

        public override string ToString()
        {
            return SpawnMask_().ToString();
        }
    }
}
