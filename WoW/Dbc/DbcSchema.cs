using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseEditor.Dbc
{
    public class DbcSchema
    {
        List<DbcColumnSchema> columns = new List<DbcColumnSchema>();
        public int ColumnCount { get; set; }

        public IEnumerable<DbcColumnSchema> Columns
        {
            get { return columns.AsEnumerable(); }
        }

        public void AddColumn(DbcColumnSchema column)
        {
            columns.Add(column);
        }

        public DbcColumnSchema this[int index]
        {
            get { return columns[index]; }
        }

        public void Save(Stream outputStream, string associatedDbc)
        {
            foreach (var col in columns)
            {
                if (col.Width == 0)
                    col.Width = 100;
            }

            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", null), 
                                          new XElement("DbcSchema", new XAttribute("Version", "1.0"), new XAttribute("Target", associatedDbc), columns.Select(c => new XElement("Column", new XAttribute("Name", c.Name), new XAttribute("Position", c.Position), new XAttribute("Type", c.Type), new XAttribute("Width", c.Width))))
            );

            doc.Save(outputStream);
        }

        public static DbcSchema Load(Stream source, int specifiedColumns)
        {
            XDocument doc = XDocument.Load(source);
            DbcSchema result = new DbcSchema();

            foreach (var e in doc.Root.Elements("Column"))
            {
                var col = new DbcColumnSchema()
                {
                    Position = int.Parse(e.Attribute("Position").Value),
                    Name = e.Attribute("Name").Value,
                    Type = (ColumnType)Enum.Parse(typeof(ColumnType), e.Attribute("Type").Value, true),
                    Width = int.Parse(e.Attribute("Width").Value)
                };

                result.AddColumn(col);
            }

            while (result.ColumnCount > specifiedColumns)
                result.columns.RemoveAt(result.ColumnCount - 1);

            while (result.columns.Count < specifiedColumns)
            {
                var col = new DbcColumnSchema()
                {
                    Position = result.ColumnCount,
                    Name = "Column" + result.ColumnCount,
                    Type = ColumnType.Int32,
                    Width = 100,
                };

                result.AddColumn(col);
            }

            return result;
        }
    }

    public class DbcColumnSchema
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public ColumnType Type { get; set; }
        public int Width { get; set; }
    }

    public static class DbcColumnSchemaHelper
    {
        public static ColumnType GetColumnType(Type type)
        {
            if (type == typeof(string))
                return ColumnType.String;
            else if (type == typeof(int))
                return ColumnType.Int32;
            else if (type == typeof(bool))
                return ColumnType.Boolean;
            else if (type == typeof(float))
                return ColumnType.Single;
            else if (type == typeof(uint))
                return ColumnType.UInt32;
            else
                return ColumnType.Int32Flags;
        }
    }

    public enum ColumnType
    {
        Int32 = 0,
        Single = 1,
        String = 2,
        Int32Flags = 3,
        Boolean = 4,
        UInt32 = 5
    }
}
