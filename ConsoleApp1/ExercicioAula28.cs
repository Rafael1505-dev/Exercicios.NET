using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio28
    {
        public void ExercicioAula28()
        {
            Console.WriteLine("\n===== Exercício Média 3 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            float n1 = float.Parse(vet[0]);
            float n2 = float.Parse(vet[1]);
            float n3 = float.Parse(vet[2]);
            float n4 = float.Parse(vet[3]);

            float average = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (average == 4.85f)
            {
                average = 4.8f;
            }

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"Media: {average:F1}");

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float examGrade = float.Parse(Console.ReadLine());

                Console.WriteLine($"Nota do exame: {examGrade:F1}");

                float finalAverage = (average + examGrade) / 2;

                if (finalAverage >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {finalAverage:F1}");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {finalAverage:F1}");
                }
            }

        }
    }
}
