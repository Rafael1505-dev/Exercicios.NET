using System;
using System.Globalization;

namespace Exercicios.NET
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            // Exercício de entrada de dados em C#
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Menu =====");
                Console.WriteLine("1. Executar Exercicio 1");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Exercicio1 exercicio1 = new Exercicio1();
                        exercicio1.ExercicioAula1();
                        break;
                    case "0":
                        return; // Sai do programa
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }    
}