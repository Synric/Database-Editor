using System;
using System.Data;

namespace DatabaseEditor.Editor.Shared
{
    public partial class Faction : DatabaseEditor.UI.Common.EditorGridForm
    {
        public Faction()
        {
            InitializeComponent();

            if(!DesignMode)
            {
                dataTable = new DataTable("Faction");
                dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Faction") });

                foreach (var record in Dbc.DbcStore.Faction.GetRecords())
                {
                    //                               id,                        Faction
                    dataTable.Rows.Add(new object[] {record.GetUInt32Value(0), record.GetStringValue(23) }); 
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
