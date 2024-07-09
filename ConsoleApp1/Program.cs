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
                Console.WriteLine("14. Executar Exercicio 14");
                Console.WriteLine("15. Executar Exercicio 15");
                Console.WriteLine("16. Executar Exercicio 16");
                Console.WriteLine("17. Executar Exercicio 17");
                Console.WriteLine("18. Executar Exercicio 18");
                Console.WriteLine("19. Executar Exercicio 19");
                Console.WriteLine("20. Executar Exercicio 20");
                Console.WriteLine("21. Executar Exercicio 21");
                Console.WriteLine("22. Executar Exercicio 22");
                Console.WriteLine("23. Executar Exercicio 23");
                Console.WriteLine("24. Executar Exercicio 24");
                Console.WriteLine("25. Executar Exercicio 25");
                Console.WriteLine("26. Executar Exercicio 26");
                Console.WriteLine("27. Executar Exercicio 27");
                Console.WriteLine("28. Executar Exercicio 28");
                Console.WriteLine("29. Executar Exercicio 29");
                Console.WriteLine("30. Executar Exercicio 30");
                Console.WriteLine("31. Executar Exercicio 31");
                Console.WriteLine("32. Executar Exercicio 32");
                Console.WriteLine("33. Executar Exercicio 33");
                Console.WriteLine("34. Executar Exercicio 34");
                Console.WriteLine("35. Executar Exercicio 35");
                Console.WriteLine("36. Executar Exercicio 36");
                Console.WriteLine("37. Executar Exercicio 37");
                Console.WriteLine("38. Executar Exercicio 38");
                Console.WriteLine("39. Executar Exercicio 39");
                Console.WriteLine("40. Executar Exercicio 40");
                Console.WriteLine("41. Executar Exercicio 41");
                Console.WriteLine("42. Executar Exercicio 42");
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
                    case "12":
                        Exercicio12 exercicio12 = new Exercicio12();
                        exercicio12.ExercicioAula12();
                        break;
                    case "13":
                        Exercicio13 exercicio13 = new Exercicio13();
                        exercicio13.ExercicioAula13();
                        break;
                    case "14":
                        Exercicio14 exercicio14 = new Exercicio14();
                        exercicio14.ExercicioAula14();
                        break;
                    case "15":
                        Exercicio15 exercicio15 = new Exercicio15();
                        exercicio15.ExercicioAula15();
                        break;
                    case "16":
                        Exercicio16 exercicio16 = new Exercicio16();
                        exercicio16.ExercicioAula16();
                        break;
                    case "17":
                        Exercicio17 exercicio17 = new Exercicio17();
                        exercicio17.ExercicioAula17();
                        break;
                    case "18":
                        Exercicio18 exercicio18 = new Exercicio18();
                        exercicio18.ExercicioAula18();
                        break;
                    case "19":
                        Exercicio19 exercicio19 = new Exercicio19();
                        exercicio19.ExercicioAula19();
                        break;
                    case "20":
                        Exercicio20 exercicio20 = new Exercicio20();
                        exercicio20.ExercicioAula20();
                        break;
                    case "21":
                        Exercicio21 exercicio21 = new Exercicio21();
                        exercicio21.ExercicioAula21();
                        break;
                    case "22":
                        Exercicio22 exercicio22 = new Exercicio22();
                        exercicio22.ExercicioAula22();
                        break;
                    case "23":
                        Exercicio23 exercicio23 = new Exercicio23();
                        exercicio23.ExercicioAula23();
                        break;
                    case "24":
                        Exercicio24 exercicio24 = new Exercicio24();
                        exercicio24.ExercicioAula24();
                        break;
                    case "25":
                        Exercicio25 exercicio25 = new Exercicio25();
                        exercicio25.ExercicioAula25();
                        break;
                    case "26":
                        Exercicio26 exercicio26 = new Exercicio26();
                        exercicio26.ExercicioAula26();
                        break;
                    case "27":
                        Exercicio27 exercicio27 = new Exercicio27();
                        exercicio27.ExercicioAula27();
                        break;
                    case "28":
                        Exercicio28 exercicio28 = new Exercicio28();
                        exercicio28.ExercicioAula28();
                        break;
                    case "29":
                        Exercicio29 exercicio29 = new Exercicio29();
                        exercicio29.ExercicioAula29();
                        break;
                    case "30":
                        Exercicio30 exercicio30 = new Exercicio30();
                        exercicio30.ExercicioAula30();
                        break;
                    case "31":
                        Exercicio31 exercicio31 = new Exercicio31();
                        exercicio31.ExercicioAula31();
                        break;
                    case "32":
                        Exercicio32 exercicio32 = new Exercicio32();
                        exercicio32.ExercicioAula32();
                        break;
                    case "33":
                        Exercicio33 exercicio33 = new Exercicio33();
                        exercicio33.ExercicioAula33();
                        break;
                    case "34":
                        Exercicio34 exercicio34 = new Exercicio34();
                        exercicio34.ExercicioAula34();
                        break;
                    case "35":
                        Exercicio35 exercicio35 = new Exercicio35();
                        exercicio35.ExercicioAula35();
                        break;
                    case "36":
                        Exercicio36 exercicio36 = new Exercicio36();
                        exercicio36.ExercicioAula36();
                        break;
                    case "37":
                        Exercicio37 exercicio37 = new Exercicio37();
                        exercicio37.ExercicioAula37();
                        break;
                    case "38":
                        Exercicio38 exercicio38 = new Exercicio38();
                        exercicio38.ExercicioAula38();
                        break;
                    case "39":
                        Exercicio39 exercicio39 = new Exercicio39();
                        exercicio39.ExercicioAula39();
                        break;
                    case "40":
                        Exercicio40 exercicio40 = new Exercicio40();
                        exercicio40.ExercicioAula40();
                        break;
                    case "41":
                        Exercicio41 exercicio41 = new Exercicio41();
                        exercicio41.ExercicioAula41();
                        break;
                    case "42":
                        Exercicio42 exercicio42 = new Exercicio42();
                        exercicio42.ExercicioAula42();
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