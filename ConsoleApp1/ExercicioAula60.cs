using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio60
    {
        public void ExercicioAula60()
        {
            Console.WriteLine("\n===== Exercício Sequencia IJ 2 em C# =======\n\n");
            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 1; i <= 9;  i += 2) 
            {
                for (int j = 7;  j >= 5; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }

        }
    }
}
