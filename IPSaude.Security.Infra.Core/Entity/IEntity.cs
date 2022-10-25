using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Infra.Core.Entity
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
