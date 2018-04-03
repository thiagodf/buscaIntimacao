using BuscaIntimacao.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaIntimacao.Domain.Commands
{
    public class IntimacaoCommand : Command
    {
        public string Codigo { get; set; }
        public CartorioCommand Cartorio { get; set; }
        public DevedorCommand Devedor { get; set; }
        public bool Ativa { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
