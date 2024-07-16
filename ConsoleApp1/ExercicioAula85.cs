using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio85
    {
        public void ExercicioAula85()
        {
            Console.WriteLine("\n===== Exercício Vetores 9 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine()), counterLess10 = 0, counterBetweenTenTwenty = 0, counterGreaterTwenty = 0;
            string[] productName = new string[indexArray];
            double[] purchasePrice = new double[indexArray];
            double[] sellingPrice = new double[indexArray];
            double[] profit = new double[indexArray];
            string[] vet = new string[indexArray];

            for (int i = 0; i < indexArray; i++)
            {
                vet = Console.ReadLine().Split(' ');
                productName[i] = vet[0];
                purchasePrice[i] = double.Parse(vet[1]);
                sellingPrice[i] = double.Parse(vet[2]);
            }

            for (int i = 0;i < indexArray; i++)
            {
                profit[i] = ((sellingPrice[i] - purchasePrice[i])/purchasePrice[i]) * 100;

                if (profit[i] < 10)
                {
                    counterLess10++;
                }
                else if (profit[i] > 20)
                {
                    counterGreaterTwenty++;
                }
                else
                {
                    counterBetweenTenTwenty++;
                }
            }

            Console.WriteLine($"Lucro abaixo de 10%: {counterLess10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {counterBetweenTenTwenty}");
            Console.WriteLine($"Lucro acima de 20%: {counterGreaterTwenty}");
            Console.WriteLine($"Valor total de compra: {purchasePrice.Sum():F2}");
            Console.WriteLine($"Valor total de venda: {sellingPrice.Sum():F2}");
            Console.WriteLine($"Lucro total: {(sellingPrice.Sum()-purchasePrice.Sum()):F2}");

        }
    }
}
