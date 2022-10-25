using IPSaude.Security.Application.Password.Contracts.Interfaces;
using IPSaude.Security.Application.Password.Contracts.ViewModel;
using IPSaude.Security.Domain.Password.Commands.ValidacaoSenha;
using IPSaude.Security.Infra.Core.Commands;
using IPSaude.Security.Infra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Application.Password.AppServices
{
    public class ValidacaoSenhaApp: IValidacaoSenhaApp
    {
        private readonly ICommandHandler<ValidacaoSenhaCommand> _validacaoSenhaCommandHandler;

        public ValidacaoSenhaApp(ICommandHandler<ValidacaoSenhaCommand> validacaoSenhaCommandHandler)
        {
            _validacaoSenhaCommandHandler = validacaoSenhaCommandHandler;
        }

        public Result Validar(ValidacaoSenhaViewModel model)
        {
            return _validacaoSenhaCommandHandler.Handle(new ValidarValidacaoSenhaCommand(model.senha));
        }


    }
}
