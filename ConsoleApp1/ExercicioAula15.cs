using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio15
    {
        public void ExercicioAula15()
        {
            // Exercício Área em C#

            Console.WriteLine("\n===== Exercício Área em C# =======\n\n");
            Console.WriteLine("Informe abaixo os três dados para calcular as áreas propostas do exercício: ");

            string[] treeNumbers = Console.ReadLine().Split(' ');
            double a = double.Parse(treeNumbers[0]);
            double b = double.Parse(treeNumbers[1]);
            double c = double.Parse(treeNumbers[2]);
            const double pi = 3.14159;

            double triangleArea = ((a * c) / 2);
            double circleArea = pi * Math.Pow(c,2);
            double trapezoidArea = ((a + b) * c) / 2.0;
            double squareArea = Math.Pow(b,2);
            double rectangleArea = a * b;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"TRIANGULO: {triangleArea:F3}");
            Console.WriteLine($"CIRCULO: {circleArea:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezoidArea:F3}");
            Console.WriteLine($"QUADRADO: {squareArea:F3}");
            Console.WriteLine($"RETANGULO: {rectangleArea:F3}");

        }
    }
}
