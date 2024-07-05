using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio24
    {
        public void ExercicioAula24()
        {
            Console.WriteLine("\n===== Exercício Múltiplos em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if (b % a == 0 || a % b == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");

        }
    }
}
