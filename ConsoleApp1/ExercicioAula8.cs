using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio8
    {
        public void ExercicioAula8()
        {
            // Exercício Consumo em C#

            Console.WriteLine("\n===== Exercício Consumo em C# =======\n\n");
            Console.WriteLine("Informe abaixo a dist. percorrida em Km e o total de combustível em Lt: ");

            int distance = int.Parse(Console.ReadLine());
            double totalGasoline = double.Parse(Console.ReadLine());

            double consume = distance/totalGasoline;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{consume:F3} km/l");
        }
    }
}
