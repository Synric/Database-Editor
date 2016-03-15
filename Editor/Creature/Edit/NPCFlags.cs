using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class NPCFlags : Form
    {
        int FormFlags { get; set; }

        public NPCFlags(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        void NPCFlags_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.NPCFlags)).Length - 1, '0');

            CheckBox[] boxs = { GossipBox, QuestGiverBox, TrainerBox, TrainerClassBox, TrainerProfBox, VendorBox, VendorAmmoBox, VendorFoodBox, VendorPoisonBox, VendorReagentBox, RepairerBox,
            FlightBox, SpiritHealerBox, SpiritGuideBox, InnBox, BankerBox, PetitionerBox, TabardDesignerBox, BattlemasterBox, AuctioneerBox, StablemasterBox, GuildBankerBox, SpellclickBox, null, MailboxBox};
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

            if (GossipBox.Checked)
                flags += (int)WoW.NPCFlags.Gossip;
            if (QuestGiverBox.Checked)
                flags += (int)WoW.NPCFlags.QuestGiver;
            if (TrainerBox.Checked)
                flags += (int)WoW.NPCFlags.Trainer;
            if (TrainerClassBox.Checked)
                flags += (int)WoW.NPCFlags.TrainerClass;
            if (TrainerProfBox.Checked)
                flags += (int)WoW.NPCFlags.TrainerProfession;
            if (VendorBox.Checked)
                flags += (int)WoW.NPCFlags.Vendor;
            if (VendorAmmoBox.Checked)
                flags += (int)WoW.NPCFlags.VendorAmmo;
            if (VendorFoodBox.Checked)
                flags += (int)WoW.NPCFlags.VendorFood;
            if (VendorPoisonBox.Checked)
                flags += (int)WoW.NPCFlags.VendorPoison;
            if (VendorReagentBox.Checked)
                flags += (int)WoW.NPCFlags.VendorReagent;
            if (RepairerBox.Checked)
                flags += (int)WoW.NPCFlags.Repairer;
            if (FlightBox.Checked)
                flags += (int)WoW.NPCFlags.FlightMaster;
            if (SpiritHealerBox.Checked)
                flags += (int)WoW.NPCFlags.SpiritHealer;
            if (SpiritGuideBox.Checked)
                flags += (int)WoW.NPCFlags.SpiritGuide;
            if (InnBox.Checked)
                flags += (int)WoW.NPCFlags.Innkeeper;
            if (BankerBox.Checked)
                flags += (int)WoW.NPCFlags.Banker;
            if (PetitionerBox.Checked)
                flags += (int)WoW.NPCFlags.Petitioner;
            if (TabardDesignerBox.Checked)
                flags += (int)WoW.NPCFlags.TabardDesigner;
            if (BattlemasterBox.Checked)
                flags += (int)WoW.NPCFlags.Battlemaster;
            if (AuctioneerBox.Checked)
                flags += (int)WoW.NPCFlags.Auctioneer;
            if (StablemasterBox.Checked)
                flags += (int)WoW.NPCFlags.StableMaster;
            if (GuildBankerBox.Checked)
                flags += (int)WoW.NPCFlags.GuildBanker;
            if (SpellclickBox.Checked)
                flags += (int)WoW.NPCFlags.Spellclick;
            if (MailboxBox.Checked)
                flags += (int)WoW.NPCFlags.Mailbox;

            return flags;
        }

        public override string ToString()
        {
            return Flags_().ToString();
        }
    }
}
