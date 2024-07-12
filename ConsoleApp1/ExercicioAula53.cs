using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio53
    {
        public void ExercicioAula53()
        {
            Console.WriteLine("\n===== Exercício Intervalo 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int attempts = int.Parse(Console.ReadLine());
            int number, countIn = 0, counOut = 0;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i < attempts; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (10 <= number && number <= 20)
                {
                    countIn++;
                }
                else
                {
                    counOut++;
                }
            }
            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{counOut} out");

        }
    }
}
