using System;

namespace DatabaseEditor.Dbc
{
    public class DbcRecord
    {
        WeakReference<DbcTable> pointer;
        int pos, index;
        
        internal DbcRecord(int position, int startIndex, DbcTable owner)
        {
            pos     = position;
            index   = startIndex;
            pointer = new WeakReference<DbcTable>(owner);
        }

        public int GetInt32Value(int column)
        {
            DbcTable owner;

            if (!pointer.TryGetTarget(out owner))
                throw new InvalidOperationException();

            return owner.GetInt32Value(index, column);
        }

        public uint GetUInt32Value(int column)
        {
            DbcTable owner;

            if (!pointer.TryGetTarget(out owner))
                throw new InvalidOperationException();

            return owner.GetUInt32Value(index, column);
        }

        public float GetSingleValue(int column)
        {
            DbcTable owner;

            if (!pointer.TryGetTarget(out owner))
                throw new InvalidOperationException();

            return owner.GetSingleValue(index, column);
        }

        public string GetStringValue(int column)
        {
            DbcTable owner;

            if (!pointer.TryGetTarget(out owner))
                throw new InvalidOperationException();

            return owner.GetStringValue(index, column);
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class DbcRecordPositionAttribute : Attribute
    {
        public DbcRecordPositionAttribute(int position, int length = 1)
        {
            if (position < 0)
                throw new ArgumentException("position");
            if (length < 1)
                throw new ArgumentException("length");

            Position = position;
            Length   = length;
        }

        public int Position { get; private set; }
        public int Length { get; private set; }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class DbcRecordDetailsAttribute : Attribute
    {
        public DbcRecordDetailsAttribute(string displayName)
        {
            if (displayName.Length < 1)
                throw new ArgumentException("displayName");

            Name = displayName;
        }

        public string Name { get; private set; }
    }
}
