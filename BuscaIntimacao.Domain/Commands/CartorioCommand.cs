using BuscaIntimacao.Domain.Core.Commands;
using BuscaIntimacao.Domain.Enums;
using System;

namespace BuscaIntimacao.Domain.Commands
{
    public class CartorioCommand : Command
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public EEstado Estado { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
