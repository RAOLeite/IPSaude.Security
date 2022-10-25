using IPSaude.Security.Infra.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Infra.Core.Interfaces
{
    public interface ICommandHandler<in T> where T : CommandBase
    {
        Result Handle(T command);
    }
}
