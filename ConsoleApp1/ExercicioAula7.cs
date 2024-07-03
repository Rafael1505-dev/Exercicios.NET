using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio7
    {
        public void ExercicioAula7()
        {
            // Exercício Cálculo Simples em C#

            Console.WriteLine("\n===== Exercício Cálculo Simples em C# =======\n\n");
            Console.WriteLine("Informe abaixo o cód da peça, a qtde e o valor unitário de cada peça: ");

            string[] part1 = Console.ReadLine().Split(' ');
            int idPart1 = int.Parse(part1[0]);
            int qty1 = int.Parse(part1[1]);
            double price1 = double.Parse(part1[2]);

            string[] part2 = Console.ReadLine().Split(' ');
            int idPart2 = int.Parse(part2[0]);
            int qty2 = int.Parse(part2[1]);
            double price2 = double.Parse(part2[2]);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"VALOR A PAGAR: R$ {((qty1 * price1) + (price2 * qty2)):F2}");
        }
    }
}
