using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio7
    {
        public void ExercicioAula7()
        {
            // Exercício Salário em C#

            Console.WriteLine("\n===== Exercício Salário em C# =======\n\n");
            Console.WriteLine("Informe abaixo o número do funcionário, a quantidade de horas trabalhadas e seu salário/hora: ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double salary = b * c;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"Funcionário = {a}");
            Console.WriteLine($"Seu salário é = U$ {salary:F2}");
        }
    }
}
