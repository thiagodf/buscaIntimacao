using BuscaIntimacao.Domain.Entities;
using BuscaIntimacao.Domain.Interfaces.Repositories;
using BuscaIntimacao.Infra.Context;

namespace BuscaIntimacao.Infra.Repositories
{
    public class IntimacaoRepository : BaseRepository<Intimacao>, IIntimacaoRepository
    {
        private EntityContext _eContext;

        public IntimacaoRepository(EntityContext eContext)
            : base(eContext)
        {
            _eContext = eContext;
        }
    }
}
