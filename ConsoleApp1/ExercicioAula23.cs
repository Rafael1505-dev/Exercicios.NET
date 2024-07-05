using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio23
    {
        public void ExercicioAula23()
        {
            Console.WriteLine("\n===== Exercício Lanche em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            int item = int.Parse(vet[0]);
            int quantity = int.Parse(vet[1]);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            switch (item)
            {
                case 1:
                    double buyValue = 4 * quantity;
                    Console.WriteLine($"Total: R$ {buyValue:F2}");
                    break;
                case 2:
                    buyValue = 4.5 * quantity;
                    Console.WriteLine($"Total: R$ {buyValue:F2}");
                    break;
                case 3:
                    buyValue = 5 * quantity;
                    Console.WriteLine($"Total: R$ {buyValue:F2}");
                    break;
                case 4:
                    buyValue = 2 * quantity;
                    Console.WriteLine($"Total: R$ {buyValue:F2}");
                    break;
                case 5:
                    buyValue = 1.5 * quantity;
                    Console.WriteLine($"Total: R$ {buyValue:F2}");
                    break;
            }

        }
    }
}
