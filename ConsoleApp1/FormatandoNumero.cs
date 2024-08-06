using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FormatandoNumero
    {

        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C")); // O compilador usa o moeda baseada no idioma do Windows (Que no caso e o real)
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##")); // Deixa apenas com duas casas após as virgulas 

            CultureInfo cultura = new CultureInfo("pt-BR"); //Criando informação de cultura
            Console.WriteLine(valor.ToString("CO", cultura ));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Definindo quantas casas decimais vai ter 
        }
    }
}
