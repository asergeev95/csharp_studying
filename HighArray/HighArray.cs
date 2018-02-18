using System;
using System.Collections.Generic;

namespace HighArray
{
    public class HighArray
    {
        private int[] _array;
        private int _numberOfElements;

        public int Length => _numberOfElements;

        public HighArray(int n)
        {
            _array = new int[n];
            _numberOfElements = 0;
        }

        public int Get(int index)
        {
            if (index >= 0 && index < _numberOfElements)
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

            if (k == -1)
            {
                throw new Exception("Element not found");
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

            if (k == 0)
            {
                _numberOfElements--;
            }
            else
            {
                for (var i = k; i < _numberOfElements - 1; i++)
                {
                    _array[i] = _array[i + 1];

                }
                _numberOfElements--;
            }
        }

        public int GetMax()
        {
            var currentMax = -1;

            for (var index = 0; index < _numberOfElements; index++)
            {
                var elem = _array[index];
                if (elem > currentMax)
                {
                    currentMax = elem;
                }
            }

            return currentMax;
        }

        public int RemoveMax()
        {
            var max = GetMax();

            Delete(max);

            return max;
        }
    }
}