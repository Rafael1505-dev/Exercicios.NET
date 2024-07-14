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
                Console.WriteLine("43. Executar Exercicio 43");
                Console.WriteLine("44. Executar Exercicio 44");
                Console.WriteLine("45. Executar Exercicio 45");
                Console.WriteLine("46. Executar Exercicio 46");
                Console.WriteLine("47. Executar Exercicio 47");
                Console.WriteLine("48. Executar Exercicio 48");
                Console.WriteLine("49. Executar Exercicio 49");
                Console.WriteLine("50. Executar Exercicio 50");
                Console.WriteLine("51. Executar Exercicio 51");
                Console.WriteLine("52. Executar Exercicio 52");
                Console.WriteLine("53. Executar Exercicio 53");
                Console.WriteLine("54. Executar Exercicio 54");
                Console.WriteLine("55. Executar Exercicio 55");
                Console.WriteLine("56. Executar Exercicio 56");
                Console.WriteLine("57. Executar Exercicio 57");
                Console.WriteLine("58. Executar Exercicio 58");
                Console.WriteLine("59. Executar Exercicio 59");
                Console.WriteLine("60. Executar Exercicio 60");
                Console.WriteLine("61. Executar Exercicio 61");
                Console.WriteLine("62. Executar Exercicio 62");
                Console.WriteLine("63. Executar Exercicio 63");
                Console.WriteLine("64. Executar Exercicio 64");
                Console.WriteLine("65. Executar Exercicio 65");
                Console.WriteLine("66. Executar Exercicio 66");
                Console.WriteLine("67. Executar Exercicio 67");
                Console.WriteLine("68. Executar Exercicio 68");
                Console.WriteLine("69. Executar Exercicio 69");
                Console.WriteLine("70. Executar Exercicio 70");
                Console.WriteLine("71. Executar Exercicio 71");
                Console.WriteLine("72. Executar Exercicio 72");
                Console.WriteLine("73. Executar Exercicio 73");
                Console.WriteLine("74. Executar Exercicio 74");
                Console.WriteLine("75. Executar Exercicio 75");
                Console.WriteLine("76. Executar Exercicio 76");
                Console.WriteLine("77. Executar Exercicio 77");
                Console.WriteLine("78. Executar Exercicio 78");
                Console.WriteLine("79. Executar Exercicio 79");
                Console.WriteLine("80. Executar Exercicio 80");
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
                    case "43":
                        Exercicio43 exercicio43 = new Exercicio43();
                        exercicio43.ExercicioAula43();
                        break;
                    case "44":
                        Exercicio44 exercicio44 = new Exercicio44();
                        exercicio44.ExercicioAula44();
                        break;
                    case "45":
                        Exercicio45 exercicio45 = new Exercicio45();
                        exercicio45.ExercicioAula45();
                        break;
                    case "46":
                        Exercicio46 exercicio46 = new Exercicio46();
                        exercicio46.ExercicioAula46();
                        break;
                    case "47":
                        Exercicio47 exercicio47 = new Exercicio47();
                        exercicio47.ExercicioAula47();
                        break;
                    case "48":
                        Exercicio48 exercicio48 = new Exercicio48();
                        exercicio48.ExercicioAula48();
                        break;
                    case "49":
                        Exercicio49 exercicio49 = new Exercicio49();
                        exercicio49.ExercicioAula49();
                        break;
                    case "50":
                        Exercicio50 exercicio50 = new Exercicio50();
                        exercicio50.ExercicioAula50();
                        break;
                    case "51":
                        Exercicio51 exercicio51 = new Exercicio51();
                        exercicio51.ExercicioAula51();
                        break;
                    case "52":
                        Exercicio52 exercicio52 = new Exercicio52();
                        exercicio52.ExercicioAula52();
                        break;
                    case "53":
                        Exercicio53 exercicio53 = new Exercicio53();
                        exercicio53.ExercicioAula53();
                        break;
                    case "54":
                        Exercicio54 exercicio54 = new Exercicio54();
                        exercicio54.ExercicioAula54();
                        break;
                    case "55":
                        Exercicio55 exercicio55 = new Exercicio55();
                        exercicio55.ExercicioAula55();
                        break;
                    case "56":
                        Exercicio56 exercicio56 = new Exercicio56();
                        exercicio56.ExercicioAula56();
                        break;
                    case "57":
                        Exercicio57 exercicio57 = new Exercicio57();
                        exercicio57.ExercicioAula57();
                        break;
                    case "58":
                        Exercicio58 exercicio58 = new Exercicio58();
                        exercicio58.ExercicioAula58();
                        break;
                    case "59":
                        Exercicio59 exercicio59 = new Exercicio59();
                        exercicio59.ExercicioAula59();
                        break;
                    case "60":
                        Exercicio60 exercicio60 = new Exercicio60();
                        exercicio60.ExercicioAula60();
                        break;
                    case "61":
                        Exercicio61 exercicio61 = new Exercicio61();
                        exercicio61.ExercicioAula61();
                        break;
                    case "62":
                        Exercicio62 exercicio62 = new Exercicio62();
                        exercicio62.ExercicioAula62();
                        break;
                    case "63":
                        Exercicio63 exercicio63 = new Exercicio63();
                        exercicio63.ExercicioAula63();
                        break;
                    case "64":
                        Exercicio64 exercicio64 = new Exercicio64();
                        exercicio64.ExercicioAula64();
                        break;
                    case "65":
                        Exercicio65 exercicio65 = new Exercicio65();
                        exercicio65.ExercicioAula65();
                        break;
                    case "66":
                        Exercicio66 exercicio66 = new Exercicio66();
                        exercicio66.ExercicioAula66();
                        break;
                    case "67":
                        Exercicio67 exercicio67 = new Exercicio67();
                        exercicio67.ExercicioAula67();
                        break;
                    case "68":
                        Exercicio68 exercicio68 = new Exercicio68();
                        exercicio68.ExercicioAula68();
                        break;
                    case "69":
                        Exercicio69 exercicio69 = new Exercicio69();
                        exercicio69.ExercicioAula69();
                        break;
                    case "70":
                        Exercicio70 exercicio70 = new Exercicio70();
                        exercicio70.ExercicioAula70();
                        break;
                    case "71":
                        Exercicio71 exercicio71 = new Exercicio71();
                        exercicio71.ExercicioAula71();
                        break;
                    case "72":
                        Exercicio72 exercicio72 = new Exercicio72();
                        exercicio72.ExercicioAula72();
                        break;
                    case "73":
                        Exercicio73 exercicio73 = new Exercicio73();
                        exercicio73.ExercicioAula73();
                        break;
                    case "74":
                        Exercicio74 exercicio74 = new Exercicio74();
                        exercicio74.ExercicioAula74();
                        break;
                    case "75":
                        Exercicio75 exercicio75 = new Exercicio75();
                        exercicio75.ExercicioAula75();
                        break;
                    case "76":
                        Exercicio76 exercicio76 = new Exercicio76();
                        exercicio76.ExercicioAula76();
                        break;
                    /*case "77":
                        Exercicio77 exercicio77 = new Exercicio77();
                        exercicio77.ExercicioAula77();
                        break;
                    case "78":
                        Exercicio78 exercicio78 = new Exercicio78();
                        exercicio78.ExercicioAula78();
                        break;
                    case "79":
                        Exercicio79 exercicio79 = new Exercicio79();
                        exercicio79.ExercicioAula79();
                        break;
                    case "80":
                        Exercicio80 exercicio80 = new Exercicio80();
                        exercicio80.ExercicioAula80();
                        break;*/
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