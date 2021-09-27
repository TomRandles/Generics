using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constraints.Domain
{
    public interface IReadOnlyRepository<out T> : IDisposable
    {
        T FindById(int id);
        IQueryable<T> FindAll();
    }
}
