using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio63
    {
        public void ExercicioAula63()
        {
            Console.WriteLine("\n===== Exercício Múltiplos de 13 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int greater, smaller, sumTotal = 0;

            if (x > y)
            {
                greater = x;
                smaller = y;
            }
            else
            {
                greater = y;
                smaller = x;
            }

            for (int i = smaller; i <= greater; i++) 
            {
                if (i % 13 != 0)
                {
                    sumTotal += i;
                }
            }

            Console.WriteLine(sumTotal.ToString());
        }
    }
}
