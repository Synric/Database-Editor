using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class UnitFlags : Form
    {
        int FormFlags { get; set; }

        public UnitFlags(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        private void UnitFlags_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.UnitFlags)).Length - 1, '0');

            CheckBox[] boxs = { Unk0Box, NonAttackableBox, DisableMoveBox, PvPAttackableBox, RenameBox, PreparationBox, Unk6Box, NonPvPAttackableBox, ImmuneToPCBox, ImmuneToNPCBox, LootingBox, PetInCombatBox,
            PVPBox, SilencedBox, Unk14Box, Unk15Box, Unk16Box, PacifiedBox, StunnedBox, InCombatBox, TaxiFlightBox, DisarmedBox, ConfusedBox, FleeingBox, PlayerControlledBox, NotSelectableBox, SkinnableBox,
            MountBox, Unk28Box, Unk29Box, SheatheBox, Unk31Box};
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

            if (Unk0Box.Checked)
                flags += (int)WoW.UnitFlags.Unk0;
            if (NonAttackableBox.Checked)
                flags += (int)WoW.UnitFlags.NonAttackable;
            if (DisableMoveBox.Checked)
                flags += (int)WoW.UnitFlags.DisableMove;
            if (PvPAttackableBox.Checked)
                flags += (int)WoW.UnitFlags.PvPAttackable;
            if (RenameBox.Checked)
                flags += (int)WoW.UnitFlags.Rename;
            if (PreparationBox.Checked)
                flags += (int)WoW.UnitFlags.Preparation;
            if (Unk6Box.Checked)
                flags += (int)WoW.UnitFlags.Unk6;
            if (NonPvPAttackableBox.Checked)
                flags += (int)WoW.UnitFlags.NotAttackable;
            if (ImmuneToPCBox.Checked)
                flags += (int)WoW.UnitFlags.ImmuneToPC;
            if (ImmuneToNPCBox.Checked)
                flags += (int)WoW.UnitFlags.ImmuneToNPC;
            if (LootingBox.Checked)
                flags += (int)WoW.UnitFlags.Looting;
            if (PetInCombatBox.Checked)
                flags += (int)WoW.UnitFlags.PetInCombat;
            if (PVPBox.Checked)
                flags += (int)WoW.UnitFlags.PvP;
            if (SilencedBox.Checked)
                flags += (int)WoW.UnitFlags.Silenced;
            if (Unk14Box.Checked)
                flags += (int)WoW.UnitFlags.Unk14;
            if (Unk15Box.Checked)
                flags += (int)WoW.UnitFlags.Unk15;
            if (Unk16Box.Checked)
                flags += (int)WoW.UnitFlags.Unk16;
            if (PacifiedBox.Checked)
                flags += (int)WoW.UnitFlags.Pacified;
            if (StunnedBox.Checked)
                flags += (int)WoW.UnitFlags.Stunned;
            if (InCombatBox.Checked)
                flags += (int)WoW.UnitFlags.InCombat;
            if (TaxiFlightBox.Checked)
                flags += (int)WoW.UnitFlags.TaxiFlight;
            if (DisarmedBox.Checked)
                flags += (int)WoW.UnitFlags.Disarmed;
            if (ConfusedBox.Checked)
                flags += (int)WoW.UnitFlags.Confused;
            if (FleeingBox.Checked)
                flags += (int)WoW.UnitFlags.Fleeing;
            if (PlayerControlledBox.Checked)
                flags += (int)WoW.UnitFlags.PlayerControlled;
            if (NotSelectableBox.Checked)
                flags += (int)WoW.UnitFlags.NotSelectable;
            if (SkinnableBox.Checked)
                flags += (int)WoW.UnitFlags.Skinnable;
            if (MountBox.Checked)
                flags += (int)WoW.UnitFlags.Mount;
            if (Unk28Box.Checked)
                flags += (int)WoW.UnitFlags.Unk28;
            if (Unk29Box.Checked)
                flags += (int)WoW.UnitFlags.Unk29;
            if (SheatheBox.Checked)
                flags += (int)WoW.UnitFlags.Sheathe;
            if (Unk31Box.Checked)
                flags += unchecked((int)WoW.UnitFlags.Unk31);

            return flags;
        }

        public override string ToString()
        {
            return Flags_().ToString();
        }
    }
}
