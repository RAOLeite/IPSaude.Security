using IPSaude.Security.Domain.Password.Contracts.Models;
using IPSaude.Security.Domain.Password.Contracts.Repositories;
using IPSaude.Security.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSaude.Security.Infra.Data.Repositories
{
    public class RepositoryPadrao : RepositoryBase<Padrao>, IPadraoRepository
    {
        public RepositoryPadrao(SQLContext context) : base(context)
        {
        }

        public void Delete(Guid id)
        {
            var entity = _context.RepositoryPadrao.FirstOrDefault(b => b.Id == id);
            _context.RepositoryPadrao.Remove(entity);
        }

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.RepositoryPadrao.AnyAsync(b => b.Name.Equals(name));
        }

        public async Task<IEnumerable<Padrao>> GetAllAsync()
        {
            return await _context.RepositoryPadrao.ToListAsync();
        }

        //public Padrao GetByFilter(string _campo1, string _campo2)
        //{
        //    return _context.RepositoryPadrao
        //        .AsNoTracking()
        //        .Include(b => b.Name)
        //        .FirstOrDefault(b => b.campo == _campo1 && b.campo2 == _campo2);
        //}

        public Padrao GetById(Guid id)
        {
            return _context.RepositoryPadrao
                .AsNoTracking()
                .Include(b => b.Name)
                .FirstOrDefault(b => b.Id == id);
        }
    }
}
