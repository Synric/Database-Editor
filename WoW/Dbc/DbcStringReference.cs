using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEditor.Dbc
{
    public class DbcStringReference
    {
        WeakReference<DbcTable> pointer;
        int pos;
        Lazy<string> val;

        internal DbcStringReference(DbcTable owner, int position)
        {
            if (owner == null)
                throw new ArgumentNullException("owner");

            if (position < 0)
                throw new ArgumentException("position");

            pointer = new WeakReference<DbcTable>(owner);
            pos = position;
            val = new Lazy<string>(() =>
            {
                DbcTable table;

                if (!pointer.TryGetTarget(out table))
                    throw new ObjectDisposedException("DbcTable");

                return table.GetString(pos);
            });
        }

        public override string ToString()
        {
            return val.Value;
        }
    }
}
