using System;

namespace DatabaseEditor.Editor.Item.Edit
{
    public partial class ItemFlags : DatabaseEditor.UI.Common.EditorBaseForm
    {
        public ItemFlags(int currentFlags)
        {
            InitializeComponent();

            string flags = Convert.ToString(currentFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.I_Flags)).Length - 1, '0');

            for (int i = 0; i < checkListBox.Items.Count; i++)
            {
                if (flags[i] == '1')
                    checkListBox.SetItemChecked(checkListBox.Items.Count - 1 - i, true);
            }
        }

        public int Flags()
        {
            int flags = 0;

            var values = (WoW.I_Flags[])Enum.GetValues(typeof(WoW.I_Flags));

            for(int i = 0; i < checkListBox.Items.Count; i++)
            {
                if (checkListBox.GetItemChecked(i))
                    flags += (int)values[i + 1];
            }

            return flags;
        }

        public override string ToString()
        {
            return Flags().ToString();
        }
    }
}
