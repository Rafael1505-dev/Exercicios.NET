using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio18
    {
        public void ExercicioAula18()
        {
            // Exercício Cédulas em C#

            Console.WriteLine("\n===== Exercício Cédulas em C# =======\n\n");
            Console.WriteLine("Informe abaixo o valor para se calcular as cédulas: ");
            
            int value = int.Parse(Console.ReadLine());

            int bankNoteOneHundred = value / 100;
            int bankNoteFifty = (value % 100)/50;
            int bankNoteTwenty = ((value % 100)%50)/20;
            int bankNoteTen = (((value % 100) % 50) % 20)/10;
            int bankNoteFive = ((((value % 100) % 50) % 20)%10)/5;
            int bankNoteTwo = (((((value % 100) % 50) % 20) % 10) %5)/2;
            int bankNoteOne = ((((((value % 100) % 50) % 20) % 10) % 5)%2)/1;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine(value);
            Console.WriteLine($"{bankNoteOneHundred} nota(s) de R$ 100,00");
            Console.WriteLine($"{bankNoteFifty} nota(s) de R$ 50,00");
            Console.WriteLine($"{bankNoteTwenty} nota(s) de R$ 20,00");
            Console.WriteLine($"{bankNoteTen} nota(s) de R$ 10,00");
            Console.WriteLine($"{bankNoteFive} nota(s) de R$ 5,00");
            Console.WriteLine($"{bankNoteTwo} nota(s) de R$ 2,00");
            Console.WriteLine($"{bankNoteOne} nota(s) de R$ 1,00");



        }
    }
}
