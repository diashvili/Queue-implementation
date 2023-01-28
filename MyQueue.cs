using System;
using System.Collections;

namespace ConsoleApp9
{
    class MyQueue : ICollection
    {
        private object[] _items = new object[0];

        public virtual void Enqueue(object obj)
        {
            ArrayResize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = obj;
        }

        public virtual object Dequeue()
        {
            object temp = Peek();

            for (int i = 0; i < _items.Length - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            ArrayResize(ref _items, _items.Length - 1);

            return temp;
        }

        public virtual object Peek()
        {
            return _items[0];
        }

        public int Count
        {
            get
            {
                return _items.Length;
            }
        }

        public virtual void Clear()
        {
            _items = new object[0];
        }

        public virtual bool Contains(object? obj)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(obj))
                {
                    return true;
                }
            }
            return false;
        }

        private static void ArrayResize(ref object[] array, int newSize)
        {
            object[] temp = new object[newSize];
            int size = Math.Min(array.Length, newSize);

            for (int i = 0; i < size; i++)
            {
                temp[i] = array[i];
            }

            array = temp;
        }

        public IEnumerator GetEnumerator()
        {
            return new ArrayEnumerator(_items, Count);
        }

        //----------------------------------------

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
