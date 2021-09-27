using System.Collections;
using System.Collections.Generic;

namespace GenericMethodsAndDelegates.Domain
{
    public class MyQueueBuffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue;

        public MyQueueBuffer()
        {
            _queue = new Queue<T>();
        }
        public virtual bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }
        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }
        public virtual T Read()
        {
            return _queue.Dequeue();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _queue)
            {
                // ...
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}