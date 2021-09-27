using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro.Domain
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();
    }
}
