using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio11
    {
        public void ExercicioAula11()
        {
            // Exercício Média dos alunos em C#

            Console.WriteLine("\n===== Exercício Média dos Alunos em C# =======\n\n");
            Console.WriteLine("Informe abaixo as notas dos alunos para o cálculo da média: ");

            double gradeA = double.Parse(Console.ReadLine());
            double gradeB = double.Parse(Console.ReadLine());

            double average = (((gradeA * 0.35) + (gradeB * 0.75)) / 1.1);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"MEDIA = {average:F5}");
        }
    }
}
