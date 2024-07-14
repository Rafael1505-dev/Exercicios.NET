using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio74
    {
        public void ExercicioAula74()
        {
            Console.WriteLine("\n===== Exercício Sequência de Números e Soma em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');
            int greater = int.Parse(vet[0]);
            int smaller = int.Parse(vet[1]);
            int sum = 0;

            while (greater > 0 && smaller > 0)
            {


                if (smaller > greater)
                {
                    int temporary = greater;
                    greater = smaller;
                    smaller = temporary;
                }
                

                for (int j = smaller; j <= greater; j++)
                {
                    Console.Write(j.ToString() + " ");
                    sum += j;
                }

                Console.WriteLine("Sum=" + sum);
                sum = 0;

                vet = Console.ReadLine().Split(' ');
                greater = int.Parse(vet[0]);
                smaller = int.Parse(vet[1]);

            }
        }



    }

}
