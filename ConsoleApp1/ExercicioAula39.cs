using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio39
    {
        public void ExercicioAula39()
        {
            Console.WriteLine("\n===== Exercício Positivos e Média em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());
            double number5 = double.Parse(Console.ReadLine());
            double number6 = double.Parse(Console.ReadLine());

            int counter = 0;
            double average = 0;

            if (number1 > 0)
            {
                counter++;
                average += number1;
            }

            if (number2 > 0)
            {
                counter++;
                average += number2;
            }

            if (number3 > 0)
            {
                counter++;
                average += number3;
            }

            if (number4 > 0)
            {
                counter++;
                average += number4;
            }

            if (number5 > 0)
            {
                counter++;
                average += number5;
            }

            if (number6 > 0)
            {
                counter++;
                average += number6;
            }

            average = (average / counter);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{counter} valores positivos");
            Console.WriteLine(average.ToString("F1"));

        }
    }
}
