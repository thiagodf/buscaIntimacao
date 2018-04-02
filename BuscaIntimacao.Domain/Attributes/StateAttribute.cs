using System;

namespace BuscaIntimacao.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class StateAttribute : Attribute
    {
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public string Regiao { get; private set; }

        public StateAttribute(string sigla, string nome, string regiao)
        {
            Sigla = sigla;
            Nome = nome;
            Regiao = regiao;
        }
    }
}
