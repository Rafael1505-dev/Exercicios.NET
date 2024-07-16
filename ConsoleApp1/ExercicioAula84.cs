using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio84
    {
        public void ExercicioAula84()
        {
            Console.WriteLine("\n===== Exercício Vetores 8 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine());
            double[] arrayHeight = new double[indexArray];
            string[] arraySex = new string[indexArray];
            string[] vet = new string[indexArray];
            double[] femaleHeight = new double[indexArray];

            for (int i = 0; i < indexArray; i++)
            {
                vet = Console.ReadLine().Split(' ');
                arrayHeight[i] = double.Parse(vet[0]);
                arraySex[i] = vet[1];

                if (vet[1] == "F")
                {
                    femaleHeight[i] = double.Parse(vet[0]);
                }
            }

            double[] femaleHeights = arrayHeight.Where((height, index) => arraySex[index] == "F").ToArray();

            double femaleHeightAverage = 0;
            if (femaleHeights.Length > 0)
            {
                femaleHeightAverage = femaleHeights.Average();
            }

            // Saída dos resultados
            Console.WriteLine($"\nMenor altura = {arrayHeight.Min()}");
            Console.WriteLine($"Maior altura = {arrayHeight.Max()}");
            Console.WriteLine($"Média das alturas das mulheres = {femaleHeightAverage:F2}");
            Console.WriteLine($"Número de homens = {arraySex.Count(s => s == "M")}");


        }
    }
}
