using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio48
    {
        public void ExercicioAula48()
        {
            Console.WriteLine("\n===== Exercício Soma de Pares Consecutivos em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number = int.Parse(Console.ReadLine());
            int counterEven = 0;
            int evenNumberSum = 0;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            while (number > 0)
            {
                while (counterEven < 5)
                {
                    if (number % 2 != 0)
                    {
                        number++;
                    }

                    evenNumberSum += number;
                    number += 2;
                    counterEven++;
                }

                Console.WriteLine(evenNumberSum);

                number = int.Parse(Console.ReadLine());
            }

        }
    }
}
