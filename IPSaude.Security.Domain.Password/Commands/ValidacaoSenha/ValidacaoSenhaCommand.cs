using IPSaude.Security.Infra.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Domain.Password.Commands.ValidacaoSenha
{
    public abstract class ValidacaoSenhaCommand : CommandBase
    {

        public ValidacaoSenhaCommand(string _senha)
        {
            senha = _senha;
        }

        public string senha { get; set; }
    }
}
