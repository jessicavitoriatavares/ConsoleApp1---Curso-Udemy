using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conversoes
    {

        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; //Conversão implicita 
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; //Conversão explcícita 
            Console.WriteLine("Nota truncada: " + notaTruncada);

            Console.Write("Digite sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: " + idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado" + idadeInteiro);

            Console.WriteLine("Digite o primeiro numero");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1 : " + numero1 );

            Console.WriteLine("Digite o segundo numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2 : " + numero2);

        }
    }
}
