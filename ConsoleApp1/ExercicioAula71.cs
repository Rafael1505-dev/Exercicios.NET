using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio71
    {
        public void ExercicioAula71()
        {
            Console.WriteLine("\n===== Exercício Sequência S II em C# =======\n\n");

            int num;
            double den = 1.0, soma = 0.0;
            for (num = 1; num <= 39; num += 2)
            {
                soma = soma + num / den;
                den = den * 2.0;
            }

            Console.WriteLine(soma.ToString("F2"));

        }
    }
}
