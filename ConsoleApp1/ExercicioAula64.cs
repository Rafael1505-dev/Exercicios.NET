using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio64
    {
        public void ExercicioAula64()
        {
            Console.WriteLine("\n===== Exercício Resto da Divisão em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int greater, smaller;

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

            for (int i = smaller +1; i < greater; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
