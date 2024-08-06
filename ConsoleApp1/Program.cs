using System;
using System.Collections.Generic;
using ConsoleApp1;
using CursoCSharp;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"PrimeiroPrograma", PrimeiroPrograma.Executar},
                {"Comentários", Comentários.Executar},
                {"Váriaveis e Constantes", VariaveisEConstantes.Executar},
                {"Inferencia ", Inferencia.Executar},
                {"Interpolacao ",Interpolacao.Executar},
                {"Notação Ponto",NotacaoPonto.Executar},
                {"Lendo dados",LendoDados.Executar},
                {"Formatando Numero", FormatandoNumero.Executar},
                {"Conversões", Conversoes.Executar},
                {"Operadores Aritméticos ", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais ", OperadoresRelacionais.Executar}


            });

            central.SelecionarEExecutar();
        }
    }
}