using BuscaIntimacao.Domain.Core.Entity;
using System;

namespace BuscaIntimacao.Domain.Entities
{
    public class Intimacao : Entity
    {
        public Intimacao(
            Cartorio cartorio, 
            Devedor devedor,
            DateTime vencimento,
            bool ativa)
        {
            Cartorio = cartorio;
            Devedor = devedor;
            Vencimento = vencimento;
            Ativa = ativa;
        }

        public string Codigo { get; private set; }
        public Cartorio Cartorio { get; private set; }
        public Devedor Devedor { get; private set; }
        public DateTime Vencimento { get; private set; }
        public bool Ativa { get; private set; }

        public void geraCodigo()
        {
            Codigo = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        }
    }
}
