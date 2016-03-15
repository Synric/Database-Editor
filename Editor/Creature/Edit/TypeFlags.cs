using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class TypeFlags : Form
    {
        int FormFlags { get; set; }

        public TypeFlags(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        void TypeFlags_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.TypeFlags)).Length - 1, '0');

            CheckBox[] boxs = { TameableBox, GhostBox, Unk3Box, Unk4Box, Unk5Box, Unk6Box, Unk7Box, DeadInteractBox, HerbLootBox, MiningLootBox, Unk11Box, MountedCombatBox, AidPlayersBox, Unk14Box,
            Unk15Box, EngLootBox, ExoticBox, Unk18Box, Unk19Box, Unk20Box, Unk21Box, Unk22Box, Unk23Box, Unk24Box };
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
        
        public int Flags_()
        {
            int flags = 0;

            if (TameableBox.Checked)
                flags += (int)WoW.TypeFlags.Tameable;
            if (GhostBox.Checked)
                flags += (int)WoW.TypeFlags.Ghost;
            if (Unk3Box.Checked)
                flags += (int)WoW.TypeFlags.Unk3;
            if (Unk4Box.Checked)
                flags += (int)WoW.TypeFlags.Unk4;
            if (Unk5Box.Checked)
                flags += (int)WoW.TypeFlags.Unk5;
            if (Unk6Box.Checked)
                flags += (int)WoW.TypeFlags.Unk6;
            if (Unk7Box.Checked)
                flags += (int)WoW.TypeFlags.Unk7;
            if (DeadInteractBox.Checked)
                flags += (int)WoW.TypeFlags.DeadInteract;
            if (HerbLootBox.Checked)
                flags += (int)WoW.TypeFlags.HerbLoot;
            if (MiningLootBox.Checked)
                flags += (int)WoW.TypeFlags.MiningLoot;
            if (Unk11Box.Checked)
                flags += (int)WoW.TypeFlags.Unk11;
            if (MountedCombatBox.Checked)
                flags += (int)WoW.TypeFlags.MountedCombat;
            if (AidPlayersBox.Checked)
                flags += (int)WoW.TypeFlags.AidPlayers;
            if (Unk14Box.Checked)
                flags += (int)WoW.TypeFlags.Unk14;
            if (Unk15Box.Checked)
                flags += (int)WoW.TypeFlags.Unk15;
            if (EngLootBox.Checked)
                flags += (int)WoW.TypeFlags.EngLoot;
            if (ExoticBox.Checked)
                flags += (int)WoW.TypeFlags.Exotic;
            if (Unk18Box.Checked)
                flags += (int)WoW.TypeFlags.Unk18;
            if (Unk19Box.Checked)
                flags += (int)WoW.TypeFlags.Unk19;
            if (Unk20Box.Checked)
                flags += (int)WoW.TypeFlags.Unk20;
            if (Unk21Box.Checked)
                flags += (int)WoW.TypeFlags.Unk21;
            if (Unk22Box.Checked)
                flags += (int)WoW.TypeFlags.Unk22;
            if (Unk23Box.Checked)
                flags += (int)WoW.TypeFlags.Unk23;
            if (Unk24Box.Checked)
                flags += (int)WoW.TypeFlags.Unk24;

            return flags;
        }

        public override string ToString()
        {
            return Flags_().ToString();
        }
    }
}
