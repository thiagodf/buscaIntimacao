using BuscaIntimacao.Domain.Attributes;

namespace BuscaIntimacao.Domain.Enums
{
    public enum EEstado
    {
        [State(sigla: "AC", nome: "Acre", regiao: "Norte")]
        AC = 1,
        [State(sigla: "AL", nome: "Alagoas", regiao: "Nordeste")]
        AL = 2,
        [State(sigla: "AP", nome: "Amapá", regiao: "Norte")]
        AP = 3,
        [State(sigla: "AM", nome: "Amazonas", regiao: "Norte")]
        AM = 4,
        [State(sigla: "BA", nome: "Bahia", regiao: "Nordeste")]
        BA = 5,
        [State(sigla: "CE", nome: "Ceará", regiao: "Nordeste")]
        CE = 6,
        [State(sigla: "DF", nome: "Distrito Federal", regiao: "Centro-Oeste")]
        DF = 7,
        [State(sigla: "ES", nome: "Espírito Santo", regiao: "Sudeste")]
        ES = 8,
        [State(sigla: "GO", nome: "Goiás", regiao: "Centro-Oeste")]
        GO = 9,
        [State(sigla: "MA", nome: "Maranhão", regiao: "Nordeste")]
        MA = 10,
        [State(sigla: "MT", nome: "Mato Grosso", regiao: "Centro-Oeste")]
        MT = 11,
        [State(sigla: "MS", nome: "Mato Grosso do Sul", regiao: "Centro-Oeste")]
        MS = 12,
        [State(sigla: "MG", nome: "Minas Gerais", regiao: "Sudeste")]
        MG = 13,
        [State(sigla: "PA", nome: "Pará", regiao: "Norte")]
        PA = 14,
        [State(sigla: "PB", nome: "Paraíba", regiao: "Nordeste")]
        PB = 15,
        [State(sigla: "PR", nome: "Paraná", regiao: "Sul")]
        PR = 16,
        [State(sigla: "PE", nome: "Pernambuco", regiao: "Nordeste")]
        PE = 17,
        [State(sigla: "PI", nome: "Piauí", regiao: "Nordeste")]
        PI = 18,
        [State(sigla: "RN", nome: "Rio Grande do Norte", regiao: "Nordeste")]
        RN = 19,
        [State(sigla: "RS", nome: "Rio Grande do Sul", regiao: "Sul")]
        RS = 20,
        [State(sigla: "RJ", nome: "Rio de Janeiro", regiao: "Sudeste")]
        RJ = 21,
        [State(sigla: "RO", nome: "Rondônia", regiao: "Norte")]
        RO = 22,
        [State(sigla: "RR", nome: "Roraima", regiao: "Norte")]
        RR = 23,
        [State(sigla: "SC", nome: "Santa Catarina", regiao: "Sul")]
        SC = 24,
        [State(sigla: "SP", nome: "São Paulo", regiao: "Sudeste")]
        SP = 25,
        [State(sigla: "SE", nome: "Sergipe", regiao: "Nordeste")]
        SE = 26,
        [State(sigla: "TO", nome: "Tocantins", regiao: "Norte")]
        TO = 27
    }
}
