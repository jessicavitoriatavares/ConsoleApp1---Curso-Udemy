using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia 

            double raio = 4.5; 
            const double PI = Math.PI;
            double area = raio / PI;

            Console.WriteLine("Área é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldeDeGols = sbyte.MinValue; //sbyte aceita valores negativos e positivos (com sinal)
            Console.WriteLine("Saldo de gols " + saldeDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Slario é " + salario); // rodando aparece o maior valor short

            int menorValorInt = int.MinValue; //mais usado dos inteiros 
            Console.WriteLine("Menor valor dos inteiros " + menorValorInt);

            uint populacaoBrasileira = 207600000;
            Console.WriteLine("Populão brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7600000000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 100000000000000;
            Console.WriteLine("Valor de mercado da apple " + valorDeMercadoDaApple); //mais usado

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia Entre estrelas: " + distanciaEntreEstrelas);

            char letra = 'j';
            Console.WriteLine("Letra " + letra);

            string texto = "Diferença entre váriaveis";
            Console.WriteLine(texto);


        }
    }
}
