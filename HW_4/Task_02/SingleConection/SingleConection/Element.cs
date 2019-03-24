using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleConection
{
    class Element<T>
    {
        public T _StoredRecord { get; set; }
        public Element<T> SecondElement { get; set; }

        public Element(T record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }

            _StoredRecord = record;
        }

        public override string ToString()
        {
            return _StoredRecord.ToString();
        }
    }
}

