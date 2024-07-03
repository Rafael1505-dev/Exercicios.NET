using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio5
    {
        public void ExercicioAula5()
        {
            // Exercício Diferença em C#

            Console.WriteLine("\n===== Exercício Diferença em C# =======\n\n");
            Console.WriteLine("Informe abaixo quatro valores para calcular o produto (Multiplicação) e a diferença entre eles: ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int prd = (a * b) - (c * d);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"A diferença é {prd}");

        }
    }
}
