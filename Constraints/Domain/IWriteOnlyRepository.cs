using System;
using System.Collections.Generic;
using System.Text;

namespace Constraints.Domain
{
    public interface IWriteOnlyRepository<in T> : IDisposable
    {
        void Add(T newEntity);
        void Delete(T entity);
        int Commit();
    }
}