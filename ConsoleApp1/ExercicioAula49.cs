using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio49
    {
        public void ExercicioAula49()
        {
            Console.WriteLine("\n===== Exercício Várias Notas Com Validação em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int option = 1;
            
            while (option == 1)
            {

                int counter = 0;
                double gradeSum = 0;
                double gradeAverage = 0;


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

                gradeAverage = gradeSum / 2.0;

                Console.WriteLine($"media = {gradeAverage:F2}");


                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    option = int.Parse(Console.ReadLine());

                    if(option == 1 || option == 2)
                    {
                        break;
                    }

                } while(true);

                    

            }
        }
    }
}
