using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio38
    {
        public void ExercicioAula38()
        {
            Console.WriteLine("\n===== Exercício Números Positivos em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());
            double number5 = double.Parse(Console.ReadLine());
            double number6 = double.Parse(Console.ReadLine());

            int counter = 0;

            if (number1 > 0)
            {
                counter++;
            }

            if (number2 > 0)
            {
                counter++;
            }

            if (number3 > 0)
            {
                counter++;
            }

            if (number4 > 0)
            {
                counter++;
            }

            if (number5 > 0)
            {
                counter++;
            }

            if (number6 > 0)
            {
                counter++;
            }


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{counter} valores positivos");

        }
    }
}
