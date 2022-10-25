using IPSaude.Security.Application.Password.Contracts.Interfaces;
using IPSaude.Security.Application.Password.Contracts.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPSaude.Security.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValidacaoSenhaController : Controller
    {
        private readonly IValidacaoSenhaApp _validacaoSenhaApp;
        private readonly ILogger<ValidacaoSenhaController> _logger;

        public ValidacaoSenhaController(ILogger<ValidacaoSenhaController> logger, IValidacaoSenhaApp validacaoSenhaApp)
        {
            _logger = logger;
            _validacaoSenhaApp = validacaoSenhaApp;
        }

        /// <summary>
        /// Posts the.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An ActionResult.</returns>
        [HttpPost]
        public ActionResult Post([FromBody] ValidacaoSenhaViewModel value)
        {
            return new JsonResult(_validacaoSenhaApp.Validar(value));
        }

    }
}
