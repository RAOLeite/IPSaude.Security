using IPSaude.Security.Infra.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Infra.Core.Interfaces
{
    public interface IRepository<in T> : IDisposable where T : IEntity
    {
        int SaveChanges();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
