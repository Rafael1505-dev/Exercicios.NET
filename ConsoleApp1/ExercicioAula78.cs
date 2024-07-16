﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio78
    {
        public void ExercicioAula78()
        {
            Console.WriteLine("\n===== Exercício Vetores 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine()), counter = 0 ;
            int[] array = new int[indexArray];

            string[] vet = Console.ReadLine().Split(' ');

            array = Array.ConvertAll(vet, int.Parse);


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write(array[i] + " ");
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(counter.ToString());
        }
    }
}
