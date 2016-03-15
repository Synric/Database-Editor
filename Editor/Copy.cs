using System;
using System.Windows.Forms;

namespace DatabaseEditor.Editor
{
    public partial class Copy : Form
    {
        public int Entry { get; private set; }

        public Copy()
        {
            InitializeComponent();
        }

        public Copy(string title = null) : base()
        {
            if (!string.IsNullOrWhiteSpace(title))
                Text = title;
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Entry = Convert.ToInt32(EntryBox.Value);

            Hide();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }
    }
}
