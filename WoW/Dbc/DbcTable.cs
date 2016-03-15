using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor.Dbc
{
    public enum DbcFileFormat
    {
        Dbc,
        Db2,
        AdbCache
    }

    public class DbcTable : IDisposable
    {
        protected const int HEADER_LENGTH_DBC = 20;
        protected const int HEADER_LENGTH_DB2 = 48;

        protected DbcFileFormat format;
        protected int count,
                        /// <summary>Number of bytes per record</summary>
                        recordLength,
                        /// <summary>Number of entries per record</summary>
                        perRecord,
                        stringBlockLength,
                        stringBlockOffset;

        protected bool streamOwner;
        protected Stream stream;
        protected BinaryReader reader;
        protected BinaryWriter writer;

        protected int headerLength;
        protected int lookupID;

        protected int hashTable, build, _lastWrittenTimestamp, minID, maxID, locale;
        protected int magic;
        protected int unknown;
        
        Dictionary<int, string> stringTable = new Dictionary<int, string>();

        public DbcTable(Stream storage, bool storageOwner = true)
        {
            if (storage == null)
                throw new ArgumentNullException("storage");

            if (!storage.CanSeek || !storage.CanRead)
                throw new ArgumentException("storage");

            stream = storage;
            streamOwner = storageOwner;

            stream.Seek(0, SeekOrigin.Begin);
            reader = new BinaryReader(storage, Encoding.UTF8, true);

            magic = reader.ReadInt32();

            if (magic == 0x43424457)
            {
                format = DbcFileFormat.Dbc;
                headerLength = HEADER_LENGTH_DBC;
            }
            else if (magic == 0x32424457)
            {
                format = DbcFileFormat.Db2;
                headerLength = HEADER_LENGTH_DB2;
            }
            else if (magic == 0x32484357)
            {
                format = DbcFileFormat.AdbCache;
                headerLength = HEADER_LENGTH_DB2;
            }
            else
                throw new InvalidDataException("Invalid header.");

            count = reader.ReadInt32();
            recordLength = reader.ReadInt32();
            perRecord = reader.ReadInt32();
            stringBlockLength = reader.ReadInt32();

            if (format != DbcFileFormat.Dbc)
            {
                hashTable = reader.ReadInt32();
                build = reader.ReadInt32();
                _lastWrittenTimestamp = reader.ReadInt32();
                minID = reader.ReadInt32();
                maxID = reader.ReadInt32();
                locale = reader.ReadInt32();
                unknown = reader.ReadInt32();

                if (maxID != 0)
                {
                    lookupID = headerLength;

                    headerLength = headerLength + (maxID - minID + 1) * 6;
                }
            }
            else
            {
                hashTable = 0;
                build = -1;
                _lastWrittenTimestamp = 0;
                minID = -1;
                maxID = -1;
                locale = 0;
            }

            stringBlockOffset = perRecord * count + headerLength;
        }

        public int StringBlockLength
        {
            get { return stringBlockLength; }
        }

        #region Disposable implementation
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (streamOwner && stream != null)
                {
                    stream.Dispose();
                    stream = null;
                }

                if (reader != null)
                {
                    reader.Dispose();
                    reader = null;
                }

                count = recordLength = perRecord = stringBlockLength = stringBlockOffset = 0;
            }
        }

        ~DbcTable()
        {
            Dispose(false);
        }
        #endregion

        public int Count
        {
            get { return count; }
        }

        public int ColumnCount
        {
            get { return recordLength; }
        }

        public DbcFileFormat FileFormat
        {
            get { return format; }
        }

        public int DataPosition
        {
            get { return headerLength; }
        }

        public string GetString(int stringTablePosition)
        {
            if (stream == null)
                throw new ObjectDisposedException("DbcTable");

            var curPos = stream.Position;

            stream.Seek(stringBlockOffset + stringTablePosition, SeekOrigin.Begin);

            using (BinaryReader br = new BinaryReader(stream, Encoding.UTF8, true))
            {
                int len = 0;

                try
                {
                    while (br.ReadByte() != 0)
                        len++;
                }
                catch (Exception)
                {
                    return "<invalid string definition>";
                }

                stream.Seek(stringBlockOffset + stringTablePosition, SeekOrigin.Begin);

                byte[] temp = br.ReadBytes(len);

                stream.Seek(curPos, SeekOrigin.Begin);

                return Encoding.UTF8.GetString(temp);
            }
        }

        internal int GetInt32Value(int record, int column)
        {
            stream.Seek(record * perRecord + headerLength + column * 4, SeekOrigin.Begin);

            return reader.ReadInt32();
        }

        internal uint GetUInt32Value(int record, int column)
        {
            stream.Seek(record * perRecord + headerLength + column * 4, SeekOrigin.Begin);

            return reader.ReadUInt32();
        }

        internal float GetSingleValue(int record, int column)
        {
            stream.Seek(record * perRecord + headerLength + column * 4, SeekOrigin.Begin);

            return reader.ReadSingle();
        }

        internal string GetStringValue(int record, int column)
        {
            stream.Seek(record * perRecord + headerLength + column * 4, SeekOrigin.Begin);

            return GetString(reader.ReadInt32());
        }

        public IEnumerable<DbcRecord> GetRecords()
        {
            int curPos = headerLength;

            for (int i = 0; i < count; i++)
            {
                yield return new DbcRecord(curPos, i, this);

                curPos += recordLength * 4;
            }
        }

        public void Write(string destination, DbcSchema schema, DataGridView view)
        {
            if (!streamOwner)
                throw new ArgumentException("streamOwner is false");

            if(writer != null)
                writer.Dispose();

            List<DbcRow> rows = new List<DbcRow>();

            for (int y = 0; y < view.RowCount; y++)
            {
                if (y == view.RowCount - 1 && view.Rows[y].HasEmptyCell())
                    continue;

                rows.Add(new DbcRow(view.Rows[y]));
            }

            FileStream fileStream = new FileStream(destination, FileMode.Create);

            writer = new BinaryWriter(fileStream, Encoding.UTF8);
            writer.Write(magic);
            writer.Write(rows.Count);
            writer.Write(view.ColumnCount);
            writer.Write(view.ColumnCount * 4);
            writer.Write(0);//writer.Write(stringBlockLength);

            if (format != DbcFileFormat.Dbc)
            {
                writer.Write(hashTable);
                writer.Write(build);
                writer.Write(_lastWrittenTimestamp);
                writer.Write(minID);
                writer.Write(maxID);
                writer.Write(locale);
                writer.Write(unknown);
            }

            // convert it back into DbcRecord list
            DbcColumnSchema[] columnSchema = schema.Columns.ToArray();

            foreach(DbcRow row in rows)
            {
                for(int x = 0; x < ColumnCount; x++)
                {
                    switch(columnSchema[x].Type)
                    {
                        case ColumnType.Int32:
                        case ColumnType.Boolean:
                            writer.Write(row.GetInt32Value(x));
                            break;

                        case ColumnType.Int32Flags:
                            writer.Write(row.GetInt32Flags(x));
                            break;

                        case ColumnType.Single:
                            writer.Write(row.GetSingleValue(x));
                            break;

                        case ColumnType.String:
                            writer.Write(AddStringToTable(row.GetStringValue(x)));
                            break;

                        case ColumnType.UInt32:
                            writer.Write(row.GetUInt32Value(x));
                            break;
                    }
                }
            }

            // stringTable
            foreach (string str in stringTable.Values)
            {
                writer.Write(Encoding.UTF8.GetBytes(str));
                writer.Write((byte)0);
            }

            writer.BaseStream.Position = 16;

            if (stringTable.Count > 0)
                writer.Write(stringTable.Last().Key + Encoding.UTF8.GetByteCount(stringTable.Last().Value) + 1);

            // dispose
            writer.Close();
            writer.Dispose();
            writer = null;
        }

        int AddStringToTable(string str)
        {
            if (str == null)
                str = "";

            int stringHash = str.GetHashCode();

            foreach (KeyValuePair<int, string> pair in stringTable)
            {
                if (pair.Value.GetHashCode() == stringHash)
                    return pair.Key;
            }

            int pos = stringTable.Count == 0 ? 0 : stringTable.Last().Key + Encoding.UTF8.GetByteCount(stringTable.Last().Value) + 1;

            stringTable.Add(pos, str);

            return pos;
        }
    }

    internal delegate void DbcReaderProducer<T>(BinaryReader reader, int fieldsPerRecord, DbcTable table, T target) where T : class;

    public class DbcTable<T> : DbcTable, IEnumerable<T> where T : class, new()
    {
        static Lazy<DbcReaderProducer<T>> Convert = new Lazy<DbcReaderProducer<T>>(() =>
        {
            /*if (Config.ForceSlowMode)
                return DbcTable<T>.ConvertSlow;
                */
            try
            {
                return DbcTableCompiler.Compile<T>();
            }
            catch
            {
                if (Debugger.IsAttached/* && !Config.ForceSlowMode*/)
                    Debugger.Break();

                return DbcTable<T>.ConvertSlow;
            }
        });
        
        public DbcTable(Stream storage, bool ownsStorage = true) : base(storage, ownsStorage)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            int count = Count;

            for (int i = 0; i < count; i++)
                yield return GetAt(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T GetAt(int index)
        {
            if (stream == null)
                throw new ObjectDisposedException("DbcTable");

            stream.Seek(perRecord * index + headerLength, SeekOrigin.Begin);

            T target = new T();

            Convert.Value(reader, recordLength, this, target);

            return target;
        }

        public Type Type
        {
            get { return typeof(T); }
        }

        static void ConvertSlow(BinaryReader reader, int fieldsPerRecord, DbcTable table, T target)
        {
            int[] values = new int[fieldsPerRecord];

            for (int i = 0; i < fieldsPerRecord; i++)
                values[i] = reader.ReadInt32();
            
            foreach (var targetInfo in DbcTableCompiler.GetTargetInfoForType(typeof(T)))
                targetInfo.SetValue(target, values[targetInfo.Position], table);
        }
    }

    public class DbcRow
    {
        DataGridViewRow dbcRow;
        
        public DbcRow(DataGridViewRow row)
        {
            dbcRow = row;
        }

        public int GetInt32Value(int column)
        {
            if (column >= dbcRow.Cells.Count)
                throw new ArgumentOutOfRangeException("column");

            return Convert.ToInt32(dbcRow.Cells[column].Value);
        }

        public uint GetUInt32Value(int column)
        {
            if (column >= dbcRow.Cells.Count)
                throw new ArgumentOutOfRangeException("column");

            return Convert.ToUInt32(dbcRow.Cells[column].Value);
        }

        public int GetInt32Flags(int column)
        {
            if (column >= dbcRow.Cells.Count)
                throw new ArgumentOutOfRangeException("column");

            return Convert.ToInt32(dbcRow.Cells[column].Value);
        }

        public float GetSingleValue(int column)
        {
            if (column >= dbcRow.Cells.Count)
                throw new ArgumentOutOfRangeException("column");

            return Convert.ToSingle(dbcRow.Cells[column].Value);
        }

        public string GetStringValue(int column)
        {
            if (column >= dbcRow.Cells.Count)
                throw new ArgumentOutOfRangeException("column");

            return dbcRow.Cells[column].Value.ToString();
        }
    }
}
