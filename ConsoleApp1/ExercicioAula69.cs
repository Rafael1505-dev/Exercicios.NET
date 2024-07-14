using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio69
    {
        public void ExercicioAula69()
        {
            Console.WriteLine("\n===== Exercício Fatorial Simples em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");


            int factorial = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = factorial; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result.ToString());

        }
    }
}
