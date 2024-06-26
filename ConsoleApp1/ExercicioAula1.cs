using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios.NET
{
    class Exercicio1
    {
        public void ExercicioAula1()
        {
            // Exercício de entrada de dados em C#

            Console.WriteLine("\n===== Exercício de entrada de dados em C# =======\n\n");


            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos você tem na sua casa?");
            int badroom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço dos produtos:");
           double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2]);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine(name);
            Console.WriteLine(badroom);
            Console.WriteLine(price);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}
