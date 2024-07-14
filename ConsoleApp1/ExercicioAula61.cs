using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio61
    {
        public void ExercicioAula61()
        {
            Console.WriteLine("\n===== Exercício Sequencia IJ 3 em C# =======\n\n");

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = (i + 6); j >= (i + 4); j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }

        }
    }
}
