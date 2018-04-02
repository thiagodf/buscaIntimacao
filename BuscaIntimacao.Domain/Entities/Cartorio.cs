using BuscaIntimacao.Domain.Core.Entity;
using BuscaIntimacao.Domain.ValueObjects;

namespace BuscaIntimacao.Domain.Entities
{
    public class Cartorio : Entity
    {
        public Cartorio(
            string nome,
            int codigo,
            string telefone,
            Endereco endereco)
        {
            Nome = nome;
            Codigo = codigo;
            Telefone = telefone;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public string Telefone { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
