using POO.NET06;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;


namespace POO.NET06
{
    public class ProgramPOO6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício que calcula a conversão de moedas em C# =======\n\n");

            double dolar, valueConverter;

            CultureInfo culture = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            dolar = double.Parse(Console.ReadLine(), culture);

            Console.Write("Quantos dólares você vai comprar? ");
            valueConverter = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine($"Valor a ser pago em reais = {CurrencyConverterEx6.Converter(dolar,valueConverter).ToString("F2",culture)}");
        }
    }
}