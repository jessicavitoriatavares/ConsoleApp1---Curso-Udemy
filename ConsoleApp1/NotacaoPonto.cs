using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class NotacaoPonto
    {
        public static void Executar() 
        {
            var saudacao = "olá".ToUpper().Insert(3, "Word!").Replace("Word!", "Mundo!");
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //só acessa a váriavel valor importante se ela estiver diferente de nula 

        }

    }
}
