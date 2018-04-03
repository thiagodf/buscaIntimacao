using BuscaIntimacao.Domain.Core.Entity;
using BuscaIntimacao.Domain.ValueObjects;

namespace BuscaIntimacao.Domain.Entities
{
    public class Devedor : Entity
    {
        public Devedor(string nome, Documento documento)
        {
            Nome = nome;
            Documento = documento;
        }

        public string Nome { get; private set; }
        public Documento Documento { get; private set; }
    }
}
