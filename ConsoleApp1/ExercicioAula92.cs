using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio92
    {
        public void ExercicioAula92()
        {
            Console.WriteLine("\n===== Exercício Matriz 7 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int line, column, rotateQueue;
            string[] dataEntry;
            int[,] matrix;

            line = int.Parse(Console.ReadLine());
            column = int.Parse(Console.ReadLine());

            matrix = new int[line, column];

            for (int i = 0; i < line; i++)
            {
                dataEntry = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = int.Parse(dataEntry[j]);
                }
            }

            rotateQueue = int.Parse(Console.ReadLine());

            rotateQueue = rotateQueue - 1;
            
            int lastQueue = matrix[rotateQueue, (column - 1)];

            for (int j = (column - 1);  j > 0; j--)
            {
                matrix[rotateQueue, j] = matrix[rotateQueue, j - 1];
            }

            matrix[rotateQueue, 0] = lastQueue;

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
