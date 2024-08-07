using POO.NET03;
using System;
using System.Globalization;


namespace POO.NET02
{
    public class ProgramPOO3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício que calcula informações de um retângulo em C# =======\n\n");

            CultureInfo culture = CultureInfo.InvariantCulture;

            RectangleEx3 rectangle = new RectangleEx3();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            rectangle.width = double.Parse(Console.ReadLine(), culture);
            rectangle.height = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine($"AREA = {rectangle.Area().ToString("F2", culture)}");
            Console.WriteLine($"PERÍMETRO = {rectangle.Perimeter().ToString("F2", culture)}");
            Console.WriteLine($"DIAGONAL = {rectangle.Diagonal().ToString("F2",culture)}");

        }
    }
}