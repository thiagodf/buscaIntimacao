using BuscaIntimacao.Domain.Enums;

namespace BuscaIntimacao.Domain.ValueObjects
{
    public class Endereco
    {
        public Endereco(
            string logradouro,
            int numero,
            string bairro, 
            string cidade,
            string cep,
            EEstado estado)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
            Estado = estado;
        }

        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Cep { get; private set; }
        public EEstado Estado { get; private set; }
    }
}
