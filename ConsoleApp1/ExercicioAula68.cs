using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio68
    {
        public void ExercicioAula68()
        {
            Console.WriteLine("\n===== Exercício Fibonacci Fácil em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int quatity = int.Parse(Console.ReadLine());
            int j = 0, k = 1;

            for (int i = 0; i < quatity; i++)
            {
                if (i == (quatity - 1))
                {
                    Console.WriteLine($"{j}");
                }
                else
                {
                    Console.Write($"{j} ");
                }

                int temp = j;
                j = k;
                k = temp + j;
            }


        }
    }
}
