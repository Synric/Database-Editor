using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class Settings : Form
    {
        Properties.Settings settings;
        
        public Settings()
        {
            InitializeComponent();
        }

        void Settings_Load(object sender, EventArgs e)
        {
            settings = new Properties.Settings();

            if (!settings.DatabaseSQL)
                DatabaseInsertRadioButton.Checked = true;
            else
                DatabaseReplaceRadioButton.Checked = true;
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            if (DatabaseInsertRadioButton.Checked)
                settings.DatabaseSQL = false;
            else
                settings.DatabaseSQL = true;

            settings.Save();

            DialogResult = DialogResult.OK;

            Hide();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
