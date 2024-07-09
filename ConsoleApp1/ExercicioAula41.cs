using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio41
    {
        public void ExercicioAula41()
        {
            Console.WriteLine("\n===== Exercício Pares, Ímpares, Positivos e Negativos em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());

            int counterEven = 0;
            int counterOdd = 0;
            int counterPositive = 0;
            int counterNegative = 0;

            if (number1 % 2 == 0)
            {
                counterEven++;
            }
            else
            {
                counterOdd++;
            }

            if (number1 > 0)
            {
                counterPositive++;
            }
            else if (number1 < 0)
            {
                counterNegative++;
            }

            if (number2 % 2 == 0)
            {
                counterEven++;
            }
            else
            {
                counterOdd++;
            }

            if (number2 > 0)
            {
                counterPositive++;
            }
            else if (number2 < 0)
            {
                counterNegative++;
            }

            if (number3 % 2 == 0)
            {
                counterEven++;
            }
            else
            {
                counterOdd++;
            }

            if (number3 > 0)
            {
                counterPositive++;
            }
            else if (number3 < 0)
            {
                counterNegative++;
            }

            if (number4 % 2 == 0)
            {
                counterEven++;
            }
            else
            {
                counterOdd++;
            }

            if (number4 > 0)
            {
                counterPositive++;
            }
            else if (number4 < 0)
            {
                counterNegative++;
            }

            if (number5 % 2 == 0)
            {
                counterEven++;
            }
            else
            {
                counterOdd++;
            }

            if (number5 > 0)
            {
                counterPositive++;
            }
            else if (number5 < 0)
            {
                counterNegative++;
            }


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{counterEven} valor(es) par(es)");
            Console.WriteLine($"{counterOdd} valor(es) impar(es)");
            Console.WriteLine($"{counterPositive} valor(es) positivo(s)");
            Console.WriteLine($"{counterNegative} valor(es) negativo(s)");


        }
    }
}
