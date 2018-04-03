using BuscaIntimacao.Domain.Core.Commands;
using BuscaIntimacao.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaIntimacao.Domain.Commands
{
    public class DevedorCommand : Command
    {
        public string Nome { get; set; }
        public ETipoDocumento Tipo { get; set; }
        public string Numero { get; set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
