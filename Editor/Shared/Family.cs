using System;
using System.Data;

namespace DatabaseEditor.Editor.Shared
{
    public partial class Family : DatabaseEditor.UI.Common.EditorGridForm
    {
        public Family()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                dataTable = new DataTable("Family");
                dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Family") });

                foreach (var record in Dbc.DbcStore.Family.GetRecords())
                {
                    //                               id,                        Family
                    dataTable.Rows.Add(new object[] { record.GetUInt32Value(0), record.GetStringValue(10) });
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
