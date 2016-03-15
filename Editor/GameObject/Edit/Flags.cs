using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.GameObject.Edit
{
    public partial class Flags : Form
    {
        int FormFlags { get; set; }

        public Flags(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        private void Flags_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.GO_Flags)).Length - 1, '0');

            CheckBox[] boxs = { FlagBox1, FlagBox2, FlagBox4, FlagBox8, FlagBox16, FlagBox32, FlagBox64, FlagBox128 };
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

            if (FlagBox1.Checked)
                flags += (int)GO_Flags.InUse;
            if (FlagBox2.Checked)
                flags += (int)GO_Flags.Locked;
            if (FlagBox4.Checked)
                flags += (int)GO_Flags.Untargetable;
            if (FlagBox8.Checked)
                flags += (int)GO_Flags.Transport;
            if (FlagBox16.Checked)
                flags += (int)GO_Flags.NotSelectable;
            if (FlagBox32.Checked)
                flags += (int)GO_Flags.NoDespawn;
            if (FlagBox64.Checked)
                flags += (int)GO_Flags.Damaged;
            if (FlagBox128.Checked)
                flags += (int)GO_Flags.Destroyed;

            return flags;
        }

        public override string ToString()
        {
            return Flags_().ToString();
        }
    }
}
