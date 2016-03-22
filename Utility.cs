using DatabaseEditor.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public static class StringUtility
    {
        public static string DefaultValue(this string str, string defaultValue)
        {
            return string.IsNullOrWhiteSpace(str) ? defaultValue : str.Replace(',', '.');
        }
    }

    public static class DataGridViewUtility
    {
        public static void Load<T>(this DataGridView view, List<T> query)
        {
            view.Reset();

            if (query.Count > 1)
                view.Rows.Add(query.Count - 1);

            for (int i = 0; i < query.Count; i++)
            {
                PropertyInfo[] properties = query[i].GetType().GetProperties(); // get properties name

                foreach (PropertyInfo property in properties) // bind property.Name and property.Value to target column
                    view.SetColumnValue(i, DatabaseStructure.Dictionary[property.Name], property.GetValue(query[i]));
            }
        }

        public static void Reset(this DataGridView view)
        {
            if (view.RowCount > 0)
            {
                view.Rows.Clear();

                for (int i = 0; i < view.Rows.Count; i++)
                {
                    if (view.Rows[i].IsNewRow)
                        continue;

                    view.Rows.RemoveAt(i);
                }
            }
        }

        public static void SetColumnValue(this DataGridView view, int row, string columnName, object value)
        {
            if (value == null)
                return;

            for(int i = 0; i < view.ColumnCount; i++)
            {
                if(view.Columns[i].HeaderText == columnName)
                {
                    view.Rows[row].Cells[i].Value = value.ToString();

                    return;
                }
            }
        }

        public static bool IsEmpty(this DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null)
                    return false;
            }

            return true;
        }

        public static bool HasEmptyCell(this DataGridViewRow row)
        {
            foreach(DataGridViewCell cell in row.Cells)
            {
                if (cell.Value == null)
                    return true;
            }

            return false;
        }
    }

    public static class BindingSourceUtility
    {
        public static void ReflectionBinding(this BindingSource binding, EditorControl control, string memberPrefix)
        {
            FieldInfo[] fields = control.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                if(field.Name.StartsWith(memberPrefix))
                {
                    if(field.FieldType == typeof(TextBox))
                    {
                        TextBox box = field.GetValue(control) as TextBox;
                        box.DataBindings.Add("Text", binding, field.Name.Remove(0, memberPrefix.Length));
                    }
                    else if(field.FieldType == typeof(CheckBox))
                    {
                        CheckBox box = field.GetValue(control) as CheckBox;
                        box.DataBindings.Add("Checked", binding, field.Name.Remove(0, memberPrefix.Length));
                    }
                    else if(field.FieldType == typeof(ComboBox))
                    {
                        ComboBox box = field.GetValue(control) as ComboBox;

                        box.DataBindings.Add("SelectedIndex", binding, field.Name.Remove(0, memberPrefix.Length));
                    }
                    else if(field.FieldType == typeof(ComboBoxBasic))
                    {
                        ComboBoxBasic box = field.GetValue(control) as ComboBoxBasic;

                        box.DataBindings.Add("SelectedItemValue", binding, field.Name.Remove(0, memberPrefix.Length));
                    }
                }
            }
        }
    }

    public static class ObjectUtility
    {
        public static bool IsAnyNullOrEmpty(this object obj)
        {
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                    string value = property.GetValue(obj) as string;

                    if (string.IsNullOrWhiteSpace(value))
                        return true;
                }
                else if (property.PropertyType == typeof(int) && (int)property.GetValue(obj) == 0)
                    return true;
            }

            return false;
        }

        public static bool IsAllNullOrEmpty(this object obj)
        {
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                    string value = property.GetValue(obj) as string;

                    if (!string.IsNullOrWhiteSpace(value))
                        return false;
                }
                else if (property.PropertyType == typeof(int) && (int)property.GetValue(obj) != 0)
                    return false;
            }

            return true;
        }
    }
}
