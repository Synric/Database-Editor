using System;
using System.Data;

namespace DatabaseEditor.UI.Common
{
    public partial class EditorGridForm : DatabaseEditor.UI.Common.EditorBaseForm
    {
        protected DataTable dataTable = null;

        public EditorGridForm()
        {
            InitializeComponent();
        }

        public virtual int Selected { get; protected set; }

        public override string ToString()
        {
            return Selected.ToString();
        }

        void DataGrid_DoubleClick(object sender, System.EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            OkFunc();

            Hide();
        }

        void Search_TextChanged(object sender, System.EventArgs e)
        {
            string filter = String.Empty;

            foreach (DataColumn column in dataTable.Columns)
                filter += $"{column.ColumnName} Like '%{Search.Text}%' OR ";

            if (filter.Contains("' OR "))
                filter = filter.Remove(filter.Length - 3, 3);

            dataTable.DefaultView.RowFilter = filter;
        }
    }
}
