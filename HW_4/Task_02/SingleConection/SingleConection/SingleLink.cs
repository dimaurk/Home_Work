using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleConection
{
    public class SingleLink<T> : IEnumerable<T>
    {
        private Element<T> _first = null;
        private Element<T> _last = null;
        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void AddRecord(T record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }

            var elem = new Element<T>(record);

            if (_first == null)
            {
                _first = elem;
            }
            else
            {
                _last.SecondElement = elem;
            }

            _last = elem;
            _count++;
        }

        public void DeleteRecord(T record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }

        var _current = _first;
        Element<T> _previous = null;

        while (_current != null)
            {
                if (_current._StoredRecord.Equals(record))
                {
                    if (_previous != null)
                    {
                        _previous.SecondElement = _current.SecondElement;

                        if (_current.SecondElement == null)
                        {
                            _last = _previous;
                        }
                    }
                    else
                    {
                        _first = _first.SecondElement;
                        if (_first == null)
                        {
                            _first = null;
                        }
                    }
                    _count--;
                    break;
                }
                _previous = _current;
                _current = _current.SecondElement;
            }
        }    
        public void ClearList()
        {
            _first = null;
            _first = null;
            _count = 0;
        }

        

        public IEnumerator<T> GetEnumerator()
        {
            var current = _first;
            while (current != null)
            {
                yield return current._StoredRecord;
                current = current.SecondElement;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}

