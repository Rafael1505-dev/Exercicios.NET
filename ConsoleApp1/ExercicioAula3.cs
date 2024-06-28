using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio3
    {
        public void ExercicioAula3()
        {
            // Exercício de entrada de dados em C#

            Console.WriteLine("\n===== Exercício de soma simples em C# =======\n\n");


            Console.WriteLine("Entre os valores que devem ser somados:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"SOMA = {a + b}");

        }
    }

}