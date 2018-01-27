using System;
using System.Collections.Generic;

namespace HighArray
{
    public class HighArray
    {
        private readonly int[] _array;

        public HighArray(int n)
        {
            _array = new int[n];
        }

        public int Get(int index)
        {
            if (index > 0 && index < _array.Length)
            {
                return _array[index];
            }

            throw new ArgumentOutOfRangeException(nameof(index));
        }

        public int Find(int elem)
        {
            var k = -1;
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i] == elem)
                {
                    k = i;
                    break;
                }
            }

            return k;
        }

        public void Insert(int elem)
        {
            try
            {
                _array[_array.Length-1] = elem;
            }
            catch
            {
                throw new OverflowException(nameof(_array));
            }

        }

        public void Delete(int elem)
        {
            var k = Find(elem);

            if (k != -1)
            {
                for (var i = k; i < _array.Length; i++)
                {
                    _array[i] = _array[i + 1];
                }

            }

            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
