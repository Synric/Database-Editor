using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DatabaseEditor
{
    public partial class EditorControl : UserControl
    {
        public EditorControl()
        {
            InitializeComponent();
        }

        public WorldDatabase world { protected get; set; }
        public Properties.Settings settings { protected get; set; }

        public virtual void Initialize()
        {

        }

        protected void CodeExecute(string Code, Button ExecuteButton)
        {
            try
            {
                world.Database.ExecuteSqlCommand(Code);

                if (MessageBox.Show("Do you want clear Code box?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Code = String.Empty;
                    ExecuteButton.Enabled = false;
                }

                MainForm.Instance._StatusBar = "Execute to database was successful!";
            }
            catch (Exception ex)
            {
                MainForm.Instance._StatusBar = ex.Message;
            }
        }

        protected void CodeSave(string Code)
        {
            SaveFileDialog.Filter = "SQL files (*.sql)|*.sql|All Files (*.*)|*.*";
            SaveFileDialog.FilterIndex = 1;
            SaveFileDialog.RestoreDirectory = true;

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream;

                if ((stream = SaveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(Code);
                        writer.Flush();
                        writer.Close();
                    }

                    MainForm.Instance._StatusBar = $"SQL code was saved to: {SaveFileDialog.FileName}";

                    stream.Close();
                }
            }
        }

        protected void CodeCopy(string Code)
        {
            Clipboard.SetText(Code);

            MainForm.Instance._StatusBar = "Code copied to Clipboard";
        }

        protected string CodeGeneration(string arg, DataGridView dataGrid, string sqlStatement)
        {
            string sql = arg != String.Empty ? $"{arg}\n" : String.Empty;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                DataGridViewRow row = dataGrid.Rows[i];

                if (row.IsEmpty())
                    continue;

                sql += $"{(!settings.DatabaseSQL ? "INSERT INTO" : "REPLACE INTO")} {sqlStatement}";

                for (int j = 0; j < row.Cells.Count; j++)
                    sql = sql.Replace($"{{{i}}}", row.Cells[i].Value.ToString().Replace(',', '.'));
            }

            return sql;
        }

        protected void DeleteLine(DataGridView dataGrid, string DeleteString, string IfCode, string ElseCode)
        {
            if (dataGrid.Rows[dataGrid.CurrentCell.RowIndex].IsNewRow)
            {
                MessageBox.Show("Error: This is new row, you can't delete row in EditMode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (DeleteString == String.Empty)
                DeleteString = $"{IfCode} = `{dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()}`;\n";
            else
                DeleteString += $"{ElseCode} = `{dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()}`;\n";

            dataGrid.Rows.RemoveAt(dataGrid.CurrentCell.RowIndex);
        }

        protected string DisplayColumnName(string propertyName)
        {
            return DatabaseStructure.Dictionary[propertyName]; // DatabaseStructure.Dictionary.FirstOrDefault(x => x.Value == propertyName).Key;
        }

        protected void SetDataGridViewColumns(DataGridView view, string[] columns)
        {
            view.ColumnCount = columns.Count();

            for (int i = 0; i < columns.Length; i++)
                view.Columns[i].HeaderText = DisplayColumnName(columns[i]);
        }

        // Creature and GO
        protected void LootDialog(DataGridView view, int cellIndex)
        {
            if (view.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int current_item = 0;

                if (view.Rows[view.CurrentCell.RowIndex].Cells[cellIndex].Value != null)
                    current_item = Convert.ToInt32(view.Rows[view.CurrentCell.RowIndex].Cells[cellIndex].Value.ToString());

                Loot loot = new Loot(current_item);

                if (loot.ShowDialog() == DialogResult.OK)
                    view.Rows[view.CurrentCell.RowIndex].Cells[cellIndex].Value = loot.ToString();
            }
        }

        protected void SmartAIDialog(DataGridView view, Type formClass, int cellIndex)
        {
            if (view.SelectedCells.Count == 0)
                MessageBox.Show("Error: Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Form form = Activator.CreateInstance(formClass) as Form;

                if (form.ShowDialog() == DialogResult.OK)
                    view.Rows[view.CurrentCell.RowIndex].Cells[cellIndex].Value = form.ToString();
            }
        }
    }
}
