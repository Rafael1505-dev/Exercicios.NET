using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio17
    {
        public void ExercicioAula17()
        {
            // Exercício Distância entre dois pontos em C#

            Console.WriteLine("\n===== Exercício Distância entre dois pontos em C# =======\n\n");
            Console.WriteLine("Informe abaixo os valores para calcular a distância entre dois pontos: ");

            string[] twoNumbers = Console.ReadLine().Split(' ');
            double x1 = double.Parse(twoNumbers[0]);
            double y1 = double.Parse(twoNumbers[1]);

            twoNumbers = Console.ReadLine().Split(' ');

            double x2 = double.Parse(twoNumbers[0]);
            double y2 = double.Parse(twoNumbers[1]);

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine(distance.ToString("F4"));

        }
    }
}
