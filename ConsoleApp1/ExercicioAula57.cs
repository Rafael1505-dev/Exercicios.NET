using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio57
    {
        public void ExercicioAula57()
        {
            Console.WriteLine("\n===== Exercício Médias Ponderadas em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");
            int attempts = int.Parse(Console.ReadLine());
            string[] numbers;
            double number1, number2, number3, average;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i < attempts; i++)
            {
                numbers = Console.ReadLine().Split(' ');
                number1 = double.Parse(numbers[0]);
                number2 = double.Parse(numbers[1]);
                number3 = double.Parse(numbers[2]);

                average = (number1 * 2 + number2 * 3 + number3 * 5)/10;
                Console.WriteLine($"{average:F1}");

            }
        }
    }
}
