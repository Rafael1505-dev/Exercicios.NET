using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio76
    {
        public void ExercicioAula76()
        {
            Console.WriteLine("\n===== Exercício Número Primo em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                int x = int.Parse(Console.ReadLine());
                int metade = x / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++)
                {
                    if (x % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    Console.WriteLine(x + " nao eh primo");
                }
            }
        }
    }
}
