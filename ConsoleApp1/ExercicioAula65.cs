using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio65
    {
        public void ExercicioAula65()
        {
            Console.WriteLine("\n===== Exercício PUM em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int quatity = int.Parse(Console.ReadLine());
            int j = 1;

            for (int i = 0; i < quatity; i++)
            {              
                Console.WriteLine($"{j++} {j++} {j++} PUM");
                j++;
            }


        }
    }
}
