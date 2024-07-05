using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio26
    {
        public void ExercicioAula26()
        {
            Console.WriteLine("\n===== Exercício Aumento de Salário em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            double salary = double.Parse(Console.ReadLine());
            double percent;

            if (salary <= 400.0)
            {
                percent = 15.0;
            }
            else if (salary <= 800.0)
            {
                percent = 12.0;
            }
            else if (salary <= 1200.0)
            {
                percent = 10.0;
            }
            else if (salary <= 2000.0)
            {
                percent = 7.0;
            }
            else
            {
                percent = 4.0;
            }

            double readjustment = salary * percent / 100.0;
            double newSalary = salary + readjustment;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");


            Console.WriteLine("Novo salario: " + newSalary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + readjustment.ToString("F2"));
            Console.WriteLine("Em percentual: " + percent.ToString("F0") + " %");
        }
    }
}
