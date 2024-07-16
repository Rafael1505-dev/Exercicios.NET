using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio83
    {
        public void ExercicioAula83()
        {
            Console.WriteLine("\n===== Exercício Vetores 7 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine());
            double[] arrayGradeAverage = new double[indexArray];
            string[] arrayName = new string[indexArray];
            string[] vet = new string[indexArray];

            for (int i = 0; i < indexArray; i++)
            {
                vet = Console.ReadLine().Split(' ');
                arrayGradeAverage[i] = (double.Parse(vet[1]) + double.Parse(vet[2]))/2.0;

                if (arrayGradeAverage[i] >= 6)
                {
                    arrayName[i] = vet[0];
                }
            }

            string[] arrayNameApprove = arrayName.Where(s => !string.IsNullOrEmpty(s)).ToArray();


            Console.WriteLine("Alunos aprovados:");

            for(int i = 0;i < arrayNameApprove.Length;i++)
            {
                Console.WriteLine(arrayNameApprove[i]);
            }
        }
    }
}
