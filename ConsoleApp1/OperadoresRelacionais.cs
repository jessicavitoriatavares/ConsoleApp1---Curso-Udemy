﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OperadoresRelacionais
    {
        public static void Executar() {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0} ", nota > 10);
            Console.WriteLine("Nota inválida {0}", nota < 0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado ? {0}", nota <= 3.0);
        } 

    }
}
