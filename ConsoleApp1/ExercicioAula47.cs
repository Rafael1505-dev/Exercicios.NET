using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio47
    {
        public void ExercicioAula47()
        {
            Console.WriteLine("\n===== Exercício Idades em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int age = 0;
            int ageSum = 0;
            int counter = 0;
            double ageAverage = 0;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            while (age >= 0)
            {
                age = int.Parse(Console.ReadLine());

                if (age > 0)
                {
                    ageSum += age;
                    counter++;
                }
                
            }

            ageAverage = (double) ageSum / counter;

            Console.WriteLine(ageAverage.ToString("F2"));
        }
    }
}
