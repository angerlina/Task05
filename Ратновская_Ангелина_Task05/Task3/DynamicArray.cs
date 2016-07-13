using System;
using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using System.Linq;


namespace Task3
{
    public class DynamicArray : IEnumerable, IEnumerator
    {
        private Object[] _arr;
        private Object[] _temp;
        private int _size;
        private int _pointer = -1;

        private int DefaultCapacity = 8;



        public DynamicArray()
        {

            var section = (MyConfigSection)ConfigurationManager.GetSection("MySection");

            if (section != null)
            {
                DefaultCapacity = section.DefaultCapacity;
            }

            initialize(DefaultCapacity);
        }

        public DynamicArray(int capacity)
        {
            initialize(capacity);

        }

        private void initialize(int capacity)
        {
            _arr = new object[capacity];
        }


        public DynamicArray(IEnumerable<object> collection)
        {
            var enumerable = collection as object[] ?? collection.ToArray();
            _arr = new object[enumerable.Count()];
            int i = 0;
            foreach (var element in enumerable)
            {
                _arr[i] = element;
                ++i;
            }
            _size = i;
        }



        public void Add(object item)
        {
            if (_size == Capacity)
                IncreaseCapacity(Capacity * 2);
            _arr[_size] = item;
            _size++;

        }

        public bool AddRange(IEnumerable<object> collection)
        {
            var enumerable = collection as object[] ?? collection.ToArray();

            if ((enumerable.Length + _size) > Capacity)
                IncreaseCapacity(enumerable.Length + _size);
            int i = 0;
            foreach (var element in enumerable)
            {
                _arr[_size + i] = element;
                ++i;
            }
            _size += i;

            return true;

        }

        public bool Insert(int index, object item)
        {
            if (index < 0 || index > _size) throw new ArgumentOutOfRangeException();


            var oldAmount = Array.FindAll(_arr, item.Equals).Length;

            if (_size == Capacity)
                IncreaseCapacity(Capacity + 1);
            if (index < _size)
            {
                Array.Copy(_arr, index, _arr, index + 1, _size - index);
            }

            _arr[index] = item;
            _size++;

            if (oldAmount + 1 == Array.FindAll(_arr, item.Equals).Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(object item)
        {
            _size--;

            if (Array.Exists(_arr, item.Equals))
            {
                var index = Array.IndexOf(_arr, item);

                if (index < _size)
                {
                    Array.Copy(_arr, index + 1, _arr, index, _size - index);
                }
                _arr[_size] = null;

                return true;
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return this;

        }

        public bool MoveNext()
        {
            if (_pointer == _arr.Length - 1)
            {
                Reset();
                return false;
            }

            _pointer++;
            return true;
        }

        public void Reset()
        {
            _pointer = -1;
        }

        public object Current
        {
            get
            {
                return _arr[_pointer];
            }
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index > _size) throw new ArgumentOutOfRangeException();
                return _arr[index];
            }
            set
            {
                if (index < 0 || index > _size) throw new ArgumentOutOfRangeException();
                _arr[index] = value;
            }
        }

        private void IncreaseCapacity(int number)
        {
            _temp = new object[number];
            _arr.CopyTo(_temp, 0);
            _arr = _temp;
        }


        public int Capacity
        {
            get { return _arr.Length; }

        }

        public int Lenght
        {
            get { return _size; }
        }
    }


}