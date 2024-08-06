using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Inferencia
    {
        public static void Executar() {
            var nome = "Jéssica"; //automaticamente é trocado o tipo da váriavel por ter colocado uma string usando aspas / aqui foi inicializada, por isso a troca ocorre automaticamente 
            // nome = 123; não é possível, pois nome foi declarado como uma String

            int a; // apenas declaraando
            a = 7;         
            int b = 10; //declarando e inicializando 

            Console.WriteLine(a + b);


        }
    }
}
