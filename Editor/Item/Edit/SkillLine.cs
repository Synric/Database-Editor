using System;
using System.Data;

namespace DatabaseEditor.Editor.Item.Edit
{
    public partial class SkillLine : DatabaseEditor.UI.Common.EditorGridForm
    {
        public SkillLine()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                dataTable = new DataTable("Skill");
                dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Skill") });

                foreach (var record in Dbc.DbcStore.SkillLine.GetRecords())
                {
                    //                               id,                        Skill
                    dataTable.Rows.Add(new object[] { record.GetUInt32Value(0), record.GetStringValue(4) });
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
