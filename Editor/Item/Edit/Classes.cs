using System;

namespace DatabaseEditor.Editor.Item.Edit
{
    public partial class Classes : DatabaseEditor.UI.Common.EditorBaseForm
    {
        public Classes(int currentFlags)
        {
            InitializeComponent();

            if (currentFlags == -1)
                return;

            string flags = Convert.ToString(currentFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.Classes)).Length - 1, '0');

            for (int i = 0; i < checkListBox.Items.Count; i++)
            {
                if (flags[i] == '1')
                    checkListBox.SetItemChecked(checkListBox.Items.Count - 1 - i, true);
            }
        }

        public int Flags()
        {
            int flags = -1;

            var values = (WoW.Classes[])Enum.GetValues(typeof(WoW.Classes));

            for (int i = 0; i < checkListBox.Items.Count; i++)
            {
                if (checkListBox.GetItemChecked(i))
                    flags += (int)Math.Pow(2, (int)values[i]);
            }

            if (flags != -1)
                flags += 1;

            return flags;
        }

        public override string ToString()
        {
            return Flags().ToString();
        }
    }
}
