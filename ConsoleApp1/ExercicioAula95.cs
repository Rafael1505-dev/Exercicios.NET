using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio95
    {
        public void ExercicioAula95()
        {
            Console.WriteLine("\n===== Exercício Par ou Impar em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else 
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
