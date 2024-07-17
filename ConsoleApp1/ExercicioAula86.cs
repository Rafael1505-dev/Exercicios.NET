using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio86
    {
        public void ExercicioAula86()
        {
            Console.WriteLine("\n===== Exercício Matriz 1 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int line, column;
            string[] dataEntry = Console.ReadLine().Split(' ');
            int[,] matrix;

            line = int.Parse(dataEntry[0]);
            column = int.Parse(dataEntry[1]);

            matrix = new int[line, column];

            for (int i = 0;  i < line; i++)
            {
                dataEntry = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++)
                {
                    matrix[i,j] = int.Parse(dataEntry[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0;i < line; i++)
            {
                for (int j = 0;j < column; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }
        }
    }
}
