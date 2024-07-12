using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio52
    {
        public void ExercicioAula52()
        {
            Console.WriteLine("\n===== Exercício Soma de Impares Consecutivos I em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int min, max; 
            int sumOddNumbers = 0;

            if (number1 > number2)
            {
                min = number2;
                max = number1;
            }
            else
            {
                min = number1;
                max = number2;
            }

            min++;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    sumOddNumbers += i;
                }
            }

            Console.WriteLine(sumOddNumbers);

        }
    }
}
