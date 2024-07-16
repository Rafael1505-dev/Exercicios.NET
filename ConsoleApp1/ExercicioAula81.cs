using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio81
    {
        public void ExercicioAula81()
        {
            Console.WriteLine("\n===== Exercício Vetores 5 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine()), counter = 0, sum = 0;
            double average = 0;
            int[] array = new int[indexArray];

            string[] vet = Console.ReadLine().Split(' ');

            array = Array.ConvertAll(vet, int.Parse);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                    counter++;
                }
            }

            average = (double)sum / counter;
            Console.WriteLine(average.ToString("F1"));
        }
    }
}
