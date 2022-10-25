using IPSaude.Security.Domain.Password.Contracts.Models;
using IPSaude.Security.Infra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IPSaude.Security.Domain.Password.Contracts.Repositories
{
    public interface IPadraoRepository : IRepository<Padrao>
    {
        Task<bool> ExistsAsync(string name);
        Task<IEnumerable<Padrao>> GetAllAsync();

        //Padrao GetByFilter(string _campo1, string _campo2);
    }

}

