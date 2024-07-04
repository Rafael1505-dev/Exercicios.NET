using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio19
    {
        public void ExercicioAula19()
        {
            // Exercício Idade em Dias em C#

            Console.WriteLine("\n===== Exercício Idade em Dias em C# =======\n\n");
            Console.WriteLine("Informe abaixo valor para calcular a idade no exercício: ");

            int age = int.Parse(Console.ReadLine());

            int year = age / 365;
            int month = (age % 365)/30;
            int days = (age % 365)%30;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");


            Console.WriteLine($"{year} ano(s)");
            Console.WriteLine($"{month} mes(es)");
            Console.WriteLine($"{days} dia(s)");

        }
    }
}
