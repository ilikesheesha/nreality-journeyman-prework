using System;

namespace Journeyman.Pre.Collections
{
    public class List<T>
    {
        private T[] _itemArray;
        private int _nextItemIndex;
        private const decimal ResizeFactor = 1.2m;

        public List()
            : this(new T[0])
        {
        }

        public List(T[] initialArray)
        {
            if (initialArray == null)
                throw new ArgumentNullException("initialArray");

            ReSizeItemArray(initialArray);
        }

        public int Count
        {
            get { return _nextItemIndex; }
        }

        public void Add(T item)
        {
            if (_nextItemIndex == _itemArray.Length)
            {
                ReSizeItemArray(_itemArray);
            }
            _itemArray[_nextItemIndex] = item;
            _nextItemIndex++;
        }

        public void Clear()
        {
            _itemArray = new T[0];
            ReSizeItemArray(_itemArray);
        }

        public int Capacity
        {
            get { return _itemArray.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _nextItemIndex)
                    throw new ArgumentOutOfRangeException("index");

                return _itemArray[index];
            }
            set
            {
                if (index < 0 || index >= _nextItemIndex)
                    throw new ArgumentOutOfRangeException("index");

                _itemArray[index] = value;
            }
        }

        private void ReSizeItemArray(T[] initialArray)
        {
            if (initialArray == null)
                throw new ArgumentNullException("initialArray");

            var size = (int)Math.Round((initialArray.Length > 4 ? initialArray.Length : 4m) * ResizeFactor, 0);
            _nextItemIndex = initialArray.Length;
            _itemArray = new T[size];
            Array.Copy(initialArray, _itemArray, initialArray.Length);
        }
    }
}
