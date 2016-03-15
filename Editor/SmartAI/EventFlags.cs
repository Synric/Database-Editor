using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor.Creature.CreatureSmartAI
{
    public partial class EventFlags : Form
    {
        int FormFlags { get; set; }

        public EventFlags(int current_flags)
        {
            InitializeComponent();

            FormFlags = current_flags;
        }

        void EventFlags_Load(object sender, EventArgs e)
        {
            string flags = Convert.ToString(FormFlags, 2).PadLeft(8, '0');
            
            if (flags[0] == '1')
                FlagBox1.Checked = true;
            if (flags[1] == '1')
                FlagBox2.Checked = true;
            if (flags[2] == '1')
                FlagBox4.Checked = true;
            if (flags[3] == '1')
                FlagBox8.Checked = true;
            if (flags[4] == '1')
                FlagBox16.Checked = true;
            if (flags[7] == '1')
                FlagBox128.Checked = true;
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
        enum Flags : uint
        {
            None          = 0,
            NotRepeatable = 1,
            Difficulty0   = 2,
            Difficulty1   = 4,
            Difficulty2   = 8,
            Difficulty3   = 16,
            Debug         = 128
        }

        public int Flags_()
        {
            int flags = 0;

            if (FlagBox1.Checked)
                flags += (int)Flags.NotRepeatable;
            if (FlagBox2.Checked)
                flags += (int)Flags.Difficulty0;
            if (FlagBox4.Checked)
                flags += (int)Flags.Difficulty1;
            if (FlagBox8.Checked)
                flags += (int)Flags.Difficulty2;
            if (FlagBox16.Checked)
                flags += (int)Flags.Difficulty3;
            if (FlagBox128.Checked)
                flags += (int)Flags.Debug;

            return flags;
        }

        public override string ToString()
        {
            return Flags_().ToString();
        }
    }
}
