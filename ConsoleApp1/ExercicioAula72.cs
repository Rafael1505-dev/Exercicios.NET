using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio72
    {
        public void ExercicioAula72()
        {
            Console.WriteLine("\n===== Exercício Divisores I em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++) 
            {
                if(quantity % i == 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }

        }
    }
}
