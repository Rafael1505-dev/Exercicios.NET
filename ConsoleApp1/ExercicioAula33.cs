using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio33
    {
        public void ExercicioAula33()
        {
            Console.WriteLine("\n===== Exercício Imposto de Renda em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            double salary = double.Parse(Console.ReadLine());
            double tax;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if (salary >= 0 && salary <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salary > 2000 && salary <= 3000)
            {
                salary -= 2000;
                tax = salary * 0.08;
                Console.WriteLine($"R$ {tax:F2}");
            }
            else if (salary > 3000 && salary <= 4500)
            {
                tax = 1000 * 0.08;
                salary -= 3000;
                tax += (salary * 0.18);
                Console.WriteLine($"R$ {tax:F2}");
            }
            else
            {
                tax = 1000 * 0.08;
                tax += (1500 * 0.18);
                salary -= 4500;
                tax += (salary * 0.28);
                Console.WriteLine($"R$ {tax:F2}");
            }


        }
    }
}
