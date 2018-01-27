using System;
using System.Collections.Generic;

namespace HighArray
{
    public class HighArray
    {
        private int[] _array;
        private int _numberOfElements;

        public HighArray(int n)
        {
            _array = new int[n];
            _numberOfElements = 0;
        }

        public int Get(int index)
        {
            if (index > 0 && index < _numberOfElements-1)
            {
                return _array[index];
            }

            throw new ArgumentOutOfRangeException(nameof(index));
        }

        public int Find(int elem)
        {
            var k = -1;
            for (var i = 0; i < _numberOfElements; i++)
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
                _array[_numberOfElements] = elem;
                _numberOfElements++;
            }
            catch
            {
                throw new OverflowException(nameof(_array));
            }

        }

        public void Delete(int elem)
        {
            var k = Find(elem);

            try
            {
                if (k == 0)
                {
                    _numberOfElements--;
                }
                else
                {
                    for (var i = k; i < _array.Length; i++)
                    {
                        _array[i] = _array[i + 1];
                        _numberOfElements--;
                    }
                }
                
            }

            catch
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
