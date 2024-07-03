using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio16
    {
        public void ExercicioAula16()
        {
            // Exercício O Maior em C#

            Console.WriteLine("\n===== Exercício O Maior em C# =======\n\n");
            Console.WriteLine("Informe abaixo o maior entre dois números: ");

            string[] treeNumbers = Console.ReadLine().Split(' ');
            int a = int.Parse(treeNumbers[0]);
            int b = int.Parse(treeNumbers[1]);
            int c = int.Parse(treeNumbers[2]);

            int greaterAB = (a + b + Math.Abs(a - b)) / 2;
            int greaterABC = (greaterAB + c + Math.Abs(greaterAB - c)) / 2;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{greaterABC} eh o maior");

        }
    }
}
