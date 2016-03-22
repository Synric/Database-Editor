using System;
using System.Windows.Forms;

namespace DatabaseEditor.UI.Common
{
    public partial class EditorBaseForm : Form
    {
        public EditorBaseForm()
        {
            InitializeComponent();
        }

        /*public EditorBaseForm(string title) : base()
        {
            if (!string.IsNullOrWhiteSpace(title))
                Text = title;
        }*/

        public virtual void OkFunc()
        {
        }

        public virtual void CancelFunc()
        {
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            OkFunc();

            Hide();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            CancelFunc();

            Hide();
        }
    }
}
