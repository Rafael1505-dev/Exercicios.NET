using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio91
    {
        public void ExercicioAula91()
        {
            Console.WriteLine("\n===== Exercício Matriz 6 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int lineColumn = int.Parse(Console.ReadLine()), choiceLine, choiceColumn;
            double[,] matrix;
            string[] dataEntry;
            double sum = 0;


            matrix = new double[lineColumn, lineColumn];

            for (int i = 0; i < lineColumn; i++)
            {
                dataEntry = Console.ReadLine().Split(' ');
                for (int j = 0; j < lineColumn; j++)
                {
                    matrix[i, j] = double.Parse(dataEntry[j]);
                }
            }

            for (int i = 0; i < lineColumn; i++)
            {
                for (int j = 0; j < lineColumn; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"SOMA DOS POSITIVOS: {sum:F1}");

            choiceLine = int.Parse(Console.ReadLine());

            for (int i = choiceLine; i < (choiceLine + 1); i++)
            {
                Console.Write($"LINHA ESCOLHIDA: ");
                for (int j = 0; j < lineColumn; j++)
                {
                    Console.Write($"{matrix[i, j]:F1} ");
                }
                Console.WriteLine();
            }

            choiceColumn = int.Parse(Console.ReadLine());

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < lineColumn; i++)
            {
                for (int j = choiceColumn; j < (choiceColumn + 1); j++)
                {
                    Console.Write($"{matrix[i, j]:F1} ");
                }
            }

            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < lineColumn; i++)
            {
                for (int j = 0; j < lineColumn; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrix[i, j]:F1} ");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA:");

            for (int i = 0; i < lineColumn; i++)
            {
                for (int j = 0; j < lineColumn; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = Math.Pow(matrix[i, j], 2);
                    }

                    Console.Write($"{matrix[i, j]:F1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
