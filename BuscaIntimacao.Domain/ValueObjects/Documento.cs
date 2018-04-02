using BuscaIntimacao.Domain.Enums;

namespace BuscaIntimacao.Domain.ValueObjects
{
    public class Documento
    {
        public Documento(ETipoDocumento tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        public ETipoDocumento Tipo { get; private set; }
        public string Numero { get; set; }
    }
}
