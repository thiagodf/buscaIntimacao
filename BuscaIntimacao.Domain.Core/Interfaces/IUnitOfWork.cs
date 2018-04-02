using BuscaIntimacao.Domain.Core.Commands;
using System;

namespace BuscaIntimacao.Domain.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
