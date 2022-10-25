using IPSaude.Security.Domain.Password.Commands.ValidacaoSenha;
using IPSaude.Security.Infra.Core.Commands;
using IPSaude.Security.Infra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace IPSaude.Security.Domain.Password.Handlers.ValidacaoSenha
{
    public class ValidacaoSenhaHandler : CommandHandlerBase, ICommandHandler<ValidacaoSenhaCommand>
    {
        public ValidacaoSenhaHandler()
        {


        }

        public Result Handle(ValidacaoSenhaCommand command)
        {
            var regValidacaoSenha = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            var ehValido = regValidacaoSenha.IsMatch(command.senha);

            if (ehValido)
            {
                return new Result(true);
            }
            else
            {
                return new Result(false, new string[] {"Senha Inválida"});
            }
        }
    }
}
