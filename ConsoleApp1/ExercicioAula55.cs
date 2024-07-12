using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio55
    {
        public void ExercicioAula55()
        {
            Console.WriteLine("\n===== Exercício Par ou Ímpar em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");


            int attempts = int.Parse(Console.ReadLine());
            int number;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i < attempts; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    if (number > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("NULL");
                    }
                }
                else
                {
                    if (number > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else 
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
