using System;
using System.Data;

namespace DatabaseEditor.Editor.Item.Edit
{
    public partial class Language : DatabaseEditor.UI.Common.EditorGridForm
    {
        public Language()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                dataTable = new DataTable("Language");
                dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Language") });

                foreach (var record in Dbc.DbcStore.Language.GetRecords())
                {
                    //                               id,                        Language
                    dataTable.Rows.Add(new object[] { record.GetUInt32Value(0), record.GetStringValue(1) });
                }

                DataGrid.DataSource = dataTable;
            }
        }

        public override int Selected
        {
            get
            {
                return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            }

            protected set
            {
                base.Selected = value;
            }
        }
    }
}
