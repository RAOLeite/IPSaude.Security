using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPSaude.Security.Infra.Core.AutoMapper
{
    public static class Mapper<TEntity, TCommand>
        where TEntity : IPSaude.Security.Infra.Core.Entity.Entity
        where TCommand : IPSaude.Security.Infra.Core.Commands.CommandBase
    {
        public static TEntity CommandToEntity(TCommand command)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TCommand, TEntity>());

            var mapper = config.CreateMapper();
            return mapper.Map<TEntity>(command);
        }

        public static TCommand EntityToCommand(TEntity command)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TCommand>());

            var mapper = config.CreateMapper();
            return mapper.Map<TCommand>(command);
        }
    }
}
