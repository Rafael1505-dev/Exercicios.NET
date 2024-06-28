using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio2
    {
        public void ExercicioAula2()
        {
            // Exercício Área do Círculo em C#

            Console.WriteLine("\n===== Exercício Área do Círculo em C# =======\n\n");

            const double pi = 3.14159;

            Console.WriteLine("Considerando que o valor de PI é uma constante, informe abaixo o valor do raio para calcular a área do círculo: ");

            double radio = double.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            double area = pi * Math.Pow(radio,2);

            Console.WriteLine($"A área do circulo é A={area:F4}");

        }
    }
}
