using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio51
    {
        public void ExercicioAula51()
        {
            Console.WriteLine("\n===== Exercício Números Ímpares em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 1; i <= number; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
