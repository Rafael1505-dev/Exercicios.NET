using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio9
    {
        public void ExercicioAula9()
        {
            // Exercício distância entre dois veículos em C#

            Console.WriteLine("\n===== Exercício Distância entre dois veículos em C# =======\n\n");
            Console.WriteLine("Informe abaixo a distância entre os carros X e Y: ");

            int distance = int.Parse(Console.ReadLine());
            int totalTime = 2 * distance;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{totalTime} minutos");
        }
    }
}
