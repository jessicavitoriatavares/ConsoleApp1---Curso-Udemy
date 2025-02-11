﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC

            double peso = 63.400;
            double altura = 1.82;
            double imc = peso / (altura * altura ); // Math.Pow(altura, 2) --> Também tem como fazer a potência 
            Console.WriteLine($"IMC é {imc}.");

            //Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); //% resultado da divisão 
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
