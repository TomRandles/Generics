﻿
namespace GenericsIntro.Domain
{
    //Circular buffer
    public class MyBuffer<T>
    {
        private T[] _buffer;
        private int _start;
        private int _end;

        public MyBuffer()
            : this(capacity: 10)
        {
        }

        public MyBuffer(int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;
        }

        public void Write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;
            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }

        public T Read()
        {
            T result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }

        public int Capacity
        {
            get { return _buffer.Length; }
        }

        public bool IsEmpty
        {
            get { return _end == _start; }
        }

        public bool IsFull
        {
            get { return (_end + 1) % _buffer.Length == _start; }
        }
    }
}
