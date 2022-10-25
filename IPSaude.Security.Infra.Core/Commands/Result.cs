using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Infra.Core.Commands
{
    public class Result
    {
        public readonly IEnumerable<string> Errors;
        public readonly bool Success;

        public Result(bool success, IEnumerable<string> errors)
        {
            Success = success;
            Errors = errors;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
