using IPSaude.Security.Application.Password.Contracts.ViewModel;
using IPSaude.Security.Infra.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Application.Password.Contracts.Interfaces
{
    public interface IValidacaoSenhaApp
    {
        Result Validar(ValidacaoSenhaViewModel plano);
    }
}
