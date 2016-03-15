using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class ImmuneMask : Form
    {
        int FormFlags { get; set; }

        public ImmuneMask(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        private void ImmuneMask_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.ImmuneMasks)).Length - 2, '0');

            CheckBox[] boxs = { CharmBox, DisorientedBox, DisarmBox, DistractBox, FearBox, GripBox, RootBox, PacifyBox, SilenceBox, SleepBox, SnareBox, StunBox, FreezeBox, KnockoutBox, BleedBox,
            BandageBox, PolymorphBox, BanishBox, ShieldBox, ShackleBox, MountBox, InfectedBox, TurnBox, HorrorBox, InvulnerabilityBox, InterruptBox, DazeBox, DiscoveryBox, ImmuneShieldBox, SappedBox, EnragedBox};
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

            if (CharmBox.Checked)
                flags += (int)ImmuneMasks.Charm;
            if (DisorientedBox.Checked)
                flags += (int)ImmuneMasks.Disoriented;
            if (DisarmBox.Checked)
                flags += (int)ImmuneMasks.Disarm;
            if (DistractBox.Checked)
                flags += (int)ImmuneMasks.Distract;
            if (FearBox.Checked)
                flags += (int)ImmuneMasks.Fear;
            if (GripBox.Checked)
                flags += (int)ImmuneMasks.Grip;
            if (RootBox.Checked)
                flags += (int)ImmuneMasks.Root;
            if (PacifyBox.Checked)
                flags += (int)ImmuneMasks.Pacify;
            if (SilenceBox.Checked)
                flags += (int)ImmuneMasks.Silence;
            if (SleepBox.Checked)
                flags += (int)ImmuneMasks.Sleep;
            if (SnareBox.Checked)
                flags += (int)ImmuneMasks.Snare;
            if (StunBox.Checked)
                flags += (int)ImmuneMasks.Stun;
            if (FreezeBox.Checked)
                flags += (int)ImmuneMasks.Freeze;
            if (KnockoutBox.Checked)
                flags += (int)ImmuneMasks.Knockout;
            if (BleedBox.Checked)
                flags += (int)ImmuneMasks.Bleed;
            if (BandageBox.Checked)
                flags += (int)ImmuneMasks.Bandage;
            if (PolymorphBox.Checked)
                flags += (int)ImmuneMasks.Polymorph;
            if (BanishBox.Checked)
                flags += (int)ImmuneMasks.Banish;
            if (ShieldBox.Checked)
                flags += (int)ImmuneMasks.Shield;
            if (ShackleBox.Checked)
                flags += (int)ImmuneMasks.Shackle;
            if (MountBox.Checked)
                flags += (int)ImmuneMasks.Mount;
            if (InfectedBox.Checked)
                flags += (int)ImmuneMasks.Infected;
            if (TurnBox.Checked)
                flags += (int)ImmuneMasks.Turn;
            if (HorrorBox.Checked)
                flags += (int)ImmuneMasks.Horror;
            if (InvulnerabilityBox.Checked)
                flags += (int)ImmuneMasks.Invulnerability;
            if (InterruptBox.Checked)
                flags += (int)ImmuneMasks.Interrupt;
            if (DazeBox.Checked)
                flags += (int)ImmuneMasks.Daze;
            if (DiscoveryBox.Checked)
                flags += (int)ImmuneMasks.Discovery;
            if (ImmuneShieldBox.Checked)
                flags += (int)ImmuneMasks.Immune_Shield;
            if (SappedBox.Checked)
                flags += (int)ImmuneMasks.Sapped;
            if (EnragedBox.Checked)
                flags += (int)ImmuneMasks.Enraged;

            return flags;
        }

        public override string ToString()
        {
            return Flags().ToString();
        }
    }
}
