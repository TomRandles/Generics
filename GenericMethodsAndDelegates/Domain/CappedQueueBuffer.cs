﻿using System;

namespace GenericMethodsAndDelegates.Domain
{
    public class CappedQueueBuffer<T> : MyQueueBuffer<T>
    {
        int _capacity;
        public CappedQueueBuffer(int capacity = 10)
        {
            _capacity = capacity;
        }
        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                var discard = _queue.Dequeue();
                OnItemDiscarded(discard, value);
            }
        }
        private void OnItemDiscarded(T discard, T value)
        {
            if (ItemDiscarded != null)
            {
                var args = new ItemDiscardedEventArgs<T>(discard, value);
                ItemDiscarded(this, args);
            }
        }

        public event EventHandler<ItemDiscardedEventArgs<T>> ItemDiscarded;
        public bool IsFull { get { return _queue.Count == _capacity; } }
    }
}