﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio30
    {
        public void ExercicioAula30()
        {
            Console.WriteLine("\n===== Exercício Lanche em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double biggerNumber = Math.Max (a, Math.Max(b, c));
            double lessThanNumber = Math.Min(a, Math.Min(b, c));


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if()

        }
    }
}
