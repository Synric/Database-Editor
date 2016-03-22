using System;
using System.Data;

namespace DatabaseEditor.Editor.Creature.Edit
{
    public partial class TrainerSpell : DatabaseEditor.UI.Common.EditorGridForm
    {
        public TrainerSpell()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                dataTable = new DataTable("TrainerSpell");
                dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Spell name") });

                foreach (var record in Dbc.DbcStore.Spell.GetRecords())
                {
                    //                               id,                        Spell name
                    dataTable.Rows.Add(new object[] { record.GetUInt32Value(0), record.GetStringValue(21) });
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
