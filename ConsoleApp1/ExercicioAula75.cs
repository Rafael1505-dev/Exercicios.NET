using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio75
    {
        public void ExercicioAula75()
        {
            Console.WriteLine("\n===== Exercício Sequência Lógica 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');
            int number = int.Parse(vet[0]);
            int interval = int.Parse(vet[1]);

            
            for (int i = 1; i <= interval; i++) 
            {
                Console.Write(i);

                if (i % number == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }

            }


        }
    }
}
