using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio73
    {
        public void ExercicioAula73()
        {
            Console.WriteLine("\n===== Exercício Soma de Ímpares Consecutivos II em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int quantity = int.Parse(Console.ReadLine()), greater, smaller, sum = 0;
            string[] vet;
            


            for (int i = 0; i < quantity; i++)
            {
                vet = Console.ReadLine().Split(' ');
                greater = int.Parse(vet[0]);
                smaller = int.Parse(vet[1]);

                if ( smaller > greater )
                {
                    int temporary = greater;
                    greater = smaller;
                    smaller = temporary;
                }

                if(smaller %2  == 0)
                {
                    smaller++;
                }
                else
                {
                    smaller += 2;
                }

                for (int j = smaller; j < greater; j+=2)
                {
                    sum += j;
                }

                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
