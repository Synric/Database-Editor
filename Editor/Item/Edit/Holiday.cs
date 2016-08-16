using System;
using System.Data;

namespace DatabaseEditor.Editor.Item.Edit
{
    public partial class Holiday : DatabaseEditor.UI.Common.EditorGridForm
    {
        public Holiday()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                dataTable = new DataTable("Holiday");
                dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Holiday") });

                foreach (var record in Dbc.DbcStore.HolidayNames.GetRecords())
                {
                    //                               id,                        Holiday
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
