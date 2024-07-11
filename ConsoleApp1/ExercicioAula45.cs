using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio45
    {
        public void ExercicioAula45()
        {
            Console.WriteLine("\n===== Exercício Validação de Nota em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int counter = 0;
            double gradeSum = 0;
            double gradeAverage = 0;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            while (counter < 2)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade > 10 || grade < 0) 
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    gradeSum += grade;
                    counter++;
                }
            }

            gradeAverage = gradeSum/2.0;

            Console.WriteLine($"media = {gradeAverage:F2}");


        }
    }
}
