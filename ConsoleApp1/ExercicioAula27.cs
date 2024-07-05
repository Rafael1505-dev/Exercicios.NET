using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio27
    {
        public void ExercicioAula27()
        {
            Console.WriteLine("\n===== Exercício Intervalo em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if(value < 0.0 || value > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (value <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (value <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (value <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (value <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
