using System;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio96
    {
        public void ExercicioAula96()
        {
            Console.WriteLine("\n===== Exercício Matriz em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int line = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[line, column];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] array = Console.ReadLine().Split(' ');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = int.Parse(array[j]);
                }
            }

            int numberSearch = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i, j] == numberSearch)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        if (j < column - 1)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }
                        if (i < line - 1)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}