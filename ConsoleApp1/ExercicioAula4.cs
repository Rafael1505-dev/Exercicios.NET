using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio4
    {
        public void ExercicioAula4()
        {
            // Exercício Produto Simples em C#

            Console.WriteLine("\n===== Exercício Produto Simples em C# =======\n\n");

            Console.WriteLine("Informe abaixo dois valores para calcular o produto (Multiplicação): ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int prd = a * b;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"O produto da multiplicação é {prd}");

        }
    }
}