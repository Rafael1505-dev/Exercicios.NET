using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio58
    {
        public void ExercicioAula58()
        {
            Console.WriteLine("\n===== Exercício Maior e Posição em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number, maxValue = 0, position = 0;

            for (int i = 1;i <= 100;i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number > maxValue) 
                {
                    maxValue = number;
                    position = i;
                }
            }

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");
            Console.WriteLine(maxValue.ToString());
            Console.WriteLine(position.ToString());

        }
    }
}
