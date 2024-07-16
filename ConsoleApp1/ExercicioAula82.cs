using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio82
    {
        public void ExercicioAula82()
        {
            Console.WriteLine("\n===== Exercício Vetores 6 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine());
            int[] arrayAge = new int[indexArray];
            string[] arrayName = new string[indexArray];
            string[] vet = new string[indexArray];

            for (int i = 0; i < indexArray;  i++)
            {
                vet = Console.ReadLine().Split(' ');
                arrayName[i] = vet[0];
                arrayAge[i] = int.Parse(vet[1]);
            }

            Console.WriteLine($"Pessoa mais velha: {arrayName[Array.IndexOf(arrayAge, arrayAge.Max())]}");
        }
    }
}
