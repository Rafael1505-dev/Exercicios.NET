using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio62
    {
        public void ExercicioAula62()
        {
            Console.WriteLine("\n===== Exercício Dividindo X por Y em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number = int.Parse(Console.ReadLine());
            string[] numbers;
            double number1, number2, divider;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i < number; i++)
            {
                numbers = Console.ReadLine().Split(' ');
                number1 = double.Parse(numbers[0]);
                number2 = double.Parse(numbers[1]);

                if (number2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divider = number1 / number2;
                    Console.WriteLine($"{divider:F1}");
                }

            }
        }
    }
}
