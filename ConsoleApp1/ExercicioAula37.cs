﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio37
    {
        public void ExercicioAula37()
        {
            Console.WriteLine("\n===== Exercício Mês em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int monthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }


        }
    }
}
