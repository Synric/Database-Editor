using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEditor
{
    public static class DatabaseHelper
    {
        static string baseComment(Type type)
        {
            string tableName = String.Empty;

            string[] nameSplit = type.Name.Split(new string[] { "_" }, StringSplitOptions.None);

            foreach (string split in nameSplit)
                tableName += $"{split.ToUpper()} ";

            return $"-- {tableName.Remove(tableName.Length - 1, 1)}\n";
        }

        public static string Insert<T>(T table)
        {
            Type type = table.GetType();

            string sql = $"{baseComment(type)}INSERT INTO `{type.Name}`";

            // table columns and values
            string columns = String.Empty;
            string values = String.Empty;

            PropertyInfo[] properties = type.GetProperties(); // get properties name

            foreach (PropertyInfo property in properties)
            {
                columns += $"`{property.Name}`, ";

                if(property.PropertyType != typeof(string))
                    values += $"{property.GetValue(table).ToString().Replace(',', '.')}, ";
                else
                    values += $"'{property.GetValue(table)}', ";
            }

            columns = columns.Remove(columns.Length - 2, 2); // remove ", "
            values = values.Remove(values.Length - 2, 2); // remove ", "

            return $"{sql} ({columns}) VALUES({values});";
        }
    }
}
