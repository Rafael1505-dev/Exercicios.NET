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
                Console.WriteLine("2. Executar Exercicio 2");
                Console.WriteLine("3. Executar Exercicio 3");
                Console.WriteLine("4. Executar Exercicio 4");
                Console.WriteLine("5. Executar Exercicio 5");
                Console.WriteLine("6. Executar Exercicio 6");
                Console.WriteLine("7. Executar Exercicio 7");
                Console.WriteLine("8. Executar Exercicio 8");
                Console.WriteLine("9. Executar Exercicio 9");
                Console.WriteLine("10. Executar Exercicio 10");
                Console.WriteLine("11. Executar Exercicio 11");
                Console.WriteLine("12. Executar Exercicio 12");
                Console.WriteLine("13. Executar Exercicio 13");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Exercicio1 exercicio1 = new Exercicio1();
                        exercicio1.ExercicioAula1();
                        break;
                    case "2":
                        Exercicio2 exercicio2 = new Exercicio2();
                        exercicio2.ExercicioAula2();
                        break;
                    case "3":
                        Exercicio3 exercicio3 = new Exercicio3();
                        exercicio3.ExercicioAula3();
                        break;
                    case "4":
                        Exercicio4 exercicio4 = new Exercicio4();
                        exercicio4.ExercicioAula4();
                        break;
                    case "5":
                        Exercicio5 exercicio5 = new Exercicio5();
                        exercicio5.ExercicioAula5();
                        break;
                    case "6":
                        Exercicio6 exercicio6 = new Exercicio6();
                        exercicio6.ExercicioAula6();
                        break;
                    case "7":
                        Exercicio7 exercicio7 = new Exercicio7();
                        exercicio7.ExercicioAula7();
                        break;
                    case "8":
                        Exercicio8 exercicio8 = new Exercicio8();
                        exercicio8.ExercicioAula8();
                        break;
                    case "9":
                        Exercicio9 exercicio9 = new Exercicio9();
                        exercicio9.ExercicioAula9();
                        break;
                    case "10":
                        Exercicio10 exercicio10 = new Exercicio10();
                        exercicio10.ExercicioAula10();
                        break;
                    case "11":
                        Exercicio11 exercicio11 = new Exercicio11();
                        exercicio11.ExercicioAula11();
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