using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio40
    {
        public void ExercicioAula40()
        {
            Console.WriteLine("\n===== Exercício Pares entre Cinco Números em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());

            int counterEven = 0;

            if (number1 % 2 == 0)
            {
                counterEven++;
            }

            if (number2 % 2 == 0)
            {
                counterEven++;
            }

            if (number3 % 2 == 0)
            {
                counterEven++;
            }

            if (number4 % 2 == 0)
            {
                counterEven++;
            }

            if (number5 % 2 == 0)
            {
                counterEven++;
            }

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{counterEven} valores pares");
        }
    }
}
