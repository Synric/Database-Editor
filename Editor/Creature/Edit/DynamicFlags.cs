using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class DynamicFlags : Form
    {
        int FormFlags { get; set; }

        public DynamicFlags(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        private void DynamicFlags_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.DynamicFlags)).Length - 2, '0');

            CheckBox[] boxs = { LootableBox, TrackUnitBox, TappedBox, TappedByPlayerBox, SpecialInfoBox, DeadBox, ReferAFriendBox, TappedByAllThreatListBox };
            Array.Reverse(boxs);

            for (int i = 0; i < boxs.Length; i++)
            {
                if (flags[i] == '1')
                    boxs[i].Checked = true;
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

        public int Flags()
        {
            int flags = 0;

            if (LootableBox.Checked)
                flags += (int)WoW.DynamicFlags.Lootable;
            if (TrackUnitBox.Checked)
                flags += (int)WoW.DynamicFlags.Track_Unit;
            if (TappedBox.Checked)
                flags += (int)WoW.DynamicFlags.Tapped;
            if (TappedByPlayerBox.Checked)
                flags += (int)WoW.DynamicFlags.Tapped_By_Player;
            if (SpecialInfoBox.Checked)
                flags += (int)WoW.DynamicFlags.SpecialInfo;
            if (DeadBox.Checked)
                flags += (int)WoW.DynamicFlags.Dead;
            if (ReferAFriendBox.Checked)
                flags += (int)WoW.DynamicFlags.Refer_A_Friend;
            if (TappedByAllThreatListBox.Checked)
                flags += (int)WoW.DynamicFlags.Tapped_By_All_Threat_List;

            return flags;
        }

        public override string ToString()
        {
            return Flags().ToString();
        }
    }
}
