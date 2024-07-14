using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio70
    {
        public void ExercicioAula70()
        {
            Console.WriteLine("\n===== Exercício Sequência S em C# =======\n\n");

            double soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma = soma + 1.0 / i;
            }

            Console.WriteLine(soma.ToString("F2"));

        }
    }
}
