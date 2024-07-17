using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio90
    {
        public void ExercicioAula90()
        {
            Console.WriteLine("\n===== Exercício Matriz 5 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int line, column;
            string[] dataEntry = Console.ReadLine().Split(' ');
            int[,] matrix1, matrix2, matrix3;

            line = int.Parse(dataEntry[0]);
            column = int.Parse(dataEntry[1]);

            matrix1 = new int[line, column];
            matrix2 = new int[line, column];
            matrix3 = new int[line, column];


            for (int i = 0; i < line; i++)
            {
                dataEntry = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++)
                {
                    matrix1[i, j] = int.Parse(dataEntry[j]);
                }
            }

            for (int i = 0; i < line; i++)
            {
                dataEntry = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = int.Parse(dataEntry[j]);
                }
            }

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
