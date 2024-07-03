using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio12
    {
        public void ExercicioAula12()
        {
            // Exercício Média de três notas em C#

            Console.WriteLine("\n===== Exercício Média de três notas em C# =======\n\n");
            Console.WriteLine("Informe abaixo as três notas tiradas pelo aluno: ");

            double gradeA = double.Parse(Console.ReadLine());
            double gradeB = double.Parse(Console.ReadLine());
            double gradeC = double.Parse(Console.ReadLine());

            double average = (((gradeA * 0.2) + (gradeB * 0.3) + (gradeC * 0.5))/ 1.0);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"MEDIA = {average:F1}");
        }
    }
}
