using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro.Domain
{
    public class CappedBuffer<T> : QueueBuffer<T>
    {
        int _capacity;
        public CappedBuffer(int capacity = 10)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }
        public bool IsFull { get { return _queue.Count == _capacity; } }
    }
}