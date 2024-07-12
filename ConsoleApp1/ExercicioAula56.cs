using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio56
    {
        public void ExercicioAula56()
        {
            Console.WriteLine("\n===== Exercício Resto 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i <= 10000; i++)
            {
                if (i % number == 2)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
