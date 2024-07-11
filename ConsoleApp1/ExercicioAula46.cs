using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio46
    {
        public void ExercicioAula46()
        {
            Console.WriteLine("\n===== Exercício Tipo de Combustível em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int fuel = 0;
            int counterFuelAlcohol = 0;
            int counterFuelGasoline = 0;
            int counterFuelDiesel = 0;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            while (fuel != 4)
            {
                fuel = int.Parse(Console.ReadLine());

                switch (fuel)
                {
                    case 1: counterFuelAlcohol++; break;
                    case 2: counterFuelGasoline++; break;
                    case 3: counterFuelDiesel++;   break;
                    default: break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {counterFuelAlcohol}");
            Console.WriteLine($"Gasolina: {counterFuelGasoline}");
            Console.WriteLine($"Diesel: {counterFuelDiesel}");
        }
    }
}
