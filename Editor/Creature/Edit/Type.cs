using DatabaseEditor.WoW;
using System;
using System.Windows.Forms;

namespace DatabaseEditor.CreatureEdit
{
    public partial class Type : Form
    {
        int FormType { get; set; }

        public Type(int current_type)
        {
            InitializeComponent();

            FormType = current_type;
        }

        void Type_Load(object sender, EventArgs e)
        {
            if (FormType == 0)
                NoneRadioButton.Checked = true;
            else if (FormType == 1)
                BeastRadioButton.Checked = true;
            else if (FormType == 2)
                DragonkinRadioButton.Checked = true;
            else if (FormType == 3)
                DemonRadioButton.Checked = true;
            else if (FormType == 4)
                ElementalRadioButton.Checked = true;
            else if (FormType == 5)
                GiantRadioButton.Checked = true;
            else if (FormType == 6)
                UndeadRadioButton.Checked = true;
            else if (FormType == 7)
                HumanoidRadioButton.Checked = true;
            else if (FormType == 8)
                CritterRadioButton.Checked = true;
            else if (FormType == 9)
                MechanicalRadioButton.Checked = true;
            else if (FormType == 10)
                UnknownRadioButton.Checked = true;
            else if (FormType == 11)
                TotemRadioButton.Checked = true;
            else if (FormType == 12)
                NonCombatPetRadioButton.Checked = true;
            else if (FormType == 13)
                GasCloudRadioButton.Checked = true;
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

        public int Typs()
        {
            int types = 0;

            if (NoneRadioButton.Checked)
                types = (int)Types.None;
            else if (BeastRadioButton.Checked)
                types = (int)Types.Beast;
            else if (DragonkinRadioButton.Checked)
                types = (int)Types.Dragonkin;
            else if (DemonRadioButton.Checked)
                types = (int)Types.Demon;
            else if (ElementalRadioButton.Checked)
                types = (int)Types.Elemental;
            else if (GiantRadioButton.Checked)
                types = (int)Types.Giant;
            else if (UndeadRadioButton.Checked)
                types = (int)Types.Undead;
            else if (HumanoidRadioButton.Checked)
                types = (int)Types.Humanoid;
            else if (CritterRadioButton.Checked)
                types = (int)Types.Critter;
            else if (MechanicalRadioButton.Checked)
                types = (int)Types.Mechanical;
            else if (UnknownRadioButton.Checked)
                types = (int)Types.Unknown;
            else if (TotemRadioButton.Checked)
                types = (int)Types.Totem;
            else if (NonCombatPetRadioButton.Checked)
                types = (int)Types.NonCombatPet;
            else if (GasCloudRadioButton.Checked)
                types = (int)Types.GasCloud;

            return types;
        }

        public override string ToString()
        {
            return Typs().ToString();
        }
    }
}
