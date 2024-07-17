using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio89
    {
        public void ExercicioAula89()
        {
            Console.WriteLine("\n===== Exercício Matriz 4 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int lineColumn = int.Parse(Console.ReadLine()), sum = 0;
            int[,] matrix;
            string[] dataEntry;

            matrix = new int[lineColumn, lineColumn];

            for (int i = 0; i < lineColumn; i++)
            {
                dataEntry = Console.ReadLine().Split(' ');
                for (int j = 0; j < lineColumn; j++)
                {
                    matrix[i, j] = int.Parse(dataEntry[j]);
                }
            }

            for (int i = 0; i < lineColumn; i++)
            {
                for (int j = 0; j < lineColumn; j++)
                {
                    if (i < j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
