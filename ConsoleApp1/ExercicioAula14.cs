using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio14
    {
        public void ExercicioAula14()
        {
            // Exercício Esfera em C#

            Console.WriteLine("\n===== Exercício Esfera em C# =======\n\n");
            Console.WriteLine("Informe abaixo o raio para calcular o volume da esfera: ");

            const double pi = 3.14159;
            double radio = double.Parse(Console.ReadLine());


            double volume = ((4 / 3.0) * pi * Math.Pow(radio, 3));

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"VOLUME = {volume:F3}");

        }
    }
}
