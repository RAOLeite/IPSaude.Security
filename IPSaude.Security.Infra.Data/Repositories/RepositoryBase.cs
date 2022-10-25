using IPSaude.Security.Infra.Core.Entity;
using IPSaude.Security.Infra.Core.Interfaces;
using IPSaude.Security.Infra.Data.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : IEntity
    {
        protected readonly SQLContext _context;

        public RepositoryBase(SQLContext context)
        {
            _context = context;
        }

        public int SaveChanges() => _context.SaveChangesAsync().Result;

        public void Add(T entity) => _context.Add(entity);
        public void Update(T entity) => _context.Update(entity);

        public void Remove(T entity) => _context.Remove(entity);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
