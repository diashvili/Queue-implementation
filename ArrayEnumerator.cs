using System;
using System.Collections;

namespace ConsoleApp9
{
    class ArrayEnumerator : IEnumerator
    {
        private object[] _array;
        private int _index;
        private int _count;

        public ArrayEnumerator(object[] array, int count)
        {
            _array = array;
            _index = -1;
            _count = count;
        }
        public object Current
        {
            get
            {
                return _array[_index];
            }
        }
        public bool MoveNext()
        {
            if (_index + 1 < _count)
            {
                _index++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            _index = -1;

        }
    }
}
