using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio87
    {
        public void ExercicioAula87()
        {
            Console.WriteLine("\n===== Exercício Matriz 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int lineColumn = int.Parse(Console.ReadLine());
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

            for (int i = 0;i < lineColumn; i++)
            {
                int sum = 0;
                for (int j = 0;j < lineColumn; j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
