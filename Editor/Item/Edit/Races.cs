using System;

namespace DatabaseEditor.Editor.Item.Edit
{
    public partial class Races : DatabaseEditor.UI.Common.EditorBaseForm
    {
        public Races(int currentFlags)
        {
            InitializeComponent();

            if (currentFlags == -1)
                return;

            string flags = Convert.ToString(currentFlags, 2).PadLeft(Enum.GetNames(typeof(WoW.Races)).Length - 1, '0');

            for (int i = 0; i < checkListBox.Items.Count; i++)
            {
                if (flags[i] == '1')
                    checkListBox.SetItemChecked(checkListBox.Items.Count - 1 - i, true);
            }
        }

        public int Flags()
        {
            int flags = -1;

            var values = (WoW.Races[])Enum.GetValues(typeof(WoW.Races));

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
