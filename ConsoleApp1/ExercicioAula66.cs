using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio66
    {
        public void ExercicioAula66()
        {
            Console.WriteLine("\n===== Exercício Quadrado e ao Cubo em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");


            int quatity = int.Parse(Console.ReadLine());
            int j;

            for (int i = 1; i <= quatity; i++)
            {
                j = i;
                Console.WriteLine($"{j} {Math.Pow(j,2)} {Math.Pow(j,3)}");
            }

        }
    }
}
