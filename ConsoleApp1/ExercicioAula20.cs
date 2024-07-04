using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio20
    {
        public void ExercicioAula20()
        {
            // Exercício Notas e Moedas em C#

            Console.WriteLine("\n===== Exercício Notas e Moedas em C# =======\n\n");
            Console.WriteLine("Informe abaixo o valor para se calcular as cédulas e moedas: ");

            decimal value = decimal.Parse(Console.ReadLine());

            int bankNoteOneHundred = (int)value / 100;
            value %= 100;
            int bankNoteFifty = (int)value / 50;
            value %= 50;
            int bankNoteTwenty = (int)value / 20;
            value %= 20;
            int bankNoteTen = (int)value / 10;
            value %= 10;
            int bankNoteFive = (int)value / 5;
            value %= 5;
            int bankNoteTwo = (int)value / 2;
            value %= 2;

            int bankCoinOne = (int)value / 1;
            value %= 1;
            int bankCoinFifty = (int)(value / 0.50m);
            value %= 0.50m;
            int bankCoinTwentyFive = (int)(value / 0.25m);
            value %= 0.25m;
            int bankCoinTen = (int)(value / 0.10m);
            value %= 0.10m;
            int bankCoinFive = (int)(value / 0.05m);
            value %= 0.05m;
            int bankCoinOneCents = (int)(value / 0.01m);
            
            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{bankNoteOneHundred} nota(s) de R$ 100.00");
            Console.WriteLine($"{bankNoteFifty} nota(s) de R$ 50.00");
            Console.WriteLine($"{bankNoteTwenty} nota(s) de R$ 20.00");
            Console.WriteLine($"{bankNoteTen} nota(s) de R$ 10.00");
            Console.WriteLine($"{bankNoteFive} nota(s) de R$ 5.00");
            Console.WriteLine($"{bankNoteTwo} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{bankCoinOne} moeda(s) de R$ 1.00");
            Console.WriteLine($"{bankCoinFifty} moeda(s) de R$ 0.50");
            Console.WriteLine($"{bankCoinTwentyFive} moeda(s) de R$ 0.25");
            Console.WriteLine($"{bankCoinTen} moeda(s) de R$ 0.10");
            Console.WriteLine($"{bankCoinFive} moeda(s) de R$ 0.05");
            Console.WriteLine($"{bankCoinOneCents} moeda(s) de R$ 0.01");



        }
    }
}
