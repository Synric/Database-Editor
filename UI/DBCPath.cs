using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class DBCPath : Form
    {
        private Properties.Settings settings;

        public DBCPath()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowseDialog.Description = "Open DBC Folder";
            FolderBrowseDialog.ShowNewFolderButton = false;

            if (FolderBrowseDialog.ShowDialog() == DialogResult.OK)
                DBCPathBox.Text = FolderBrowseDialog.SelectedPath;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            settings = new Properties.Settings();
            settings.DBC_Path = DBCPathBox.Text + "\\";
            settings.Save();

            this.Close();
        }
    }
}
