using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio42
    {
        public void ExercicioAula42()
        {
            Console.WriteLine("\n===== Exercício Seis Números Ímpares em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int numberOdd = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i < 6; i++)
            {
                if (numberOdd % 2 == 1)
                {
                    Console.WriteLine(numberOdd);
                    numberOdd += 1;
                }
                else
                {
                    i--;
                    numberOdd += 1;
                }

            }

        }
    }
}
