using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethodsAndDelegates.Domain
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        public T Read();
    }
}
