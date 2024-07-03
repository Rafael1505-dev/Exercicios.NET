using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio13
    {
        public void ExercicioAula13()
        {
            // Exercício Salário com Bônus em C#

            Console.WriteLine("\n===== Exercício Salário com Bônus em C# =======\n\n");
            Console.WriteLine("Informe abaixo o nome, salário e quantidade de vendas efetuadas no mês para o cálculo do holerite mensal: ");

            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sales = double.Parse(Console.ReadLine());

            double commission = sales * 0.15;

            salary = salary + commission;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"TOTAL = R$ {salary:F2}");
        }
    }
}
