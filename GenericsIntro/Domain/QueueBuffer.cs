using System.Collections;
using System.Collections.Generic;

namespace GenericsIntro.Domain
{
    public class QueueBuffer<T> : IBuffer<T>
    {
        protected Queue _queue = new Queue();

        public virtual bool IsEmpty 
        {
            get { return _queue.Count == 0; } 
        }
        public virtual T Read()
        {
            return (T)_queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _queue)
            {
                // ...
                yield return (T)item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
