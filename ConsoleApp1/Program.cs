﻿using System;
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