using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio79
    {
        public void ExercicioAula79()
        {
            Console.WriteLine("\n===== Exercício Vetores 3 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine());
            int[] array1 = new int[indexArray];
            int[] array2 = new int[indexArray];
            int[] array3 = new int[indexArray];


            string[] vet = Console.ReadLine().Split(' ');
            array1 = Array.ConvertAll(vet, int.Parse);

            vet = Console.ReadLine().Split(' ');
            array2 = Array.ConvertAll(vet, int.Parse);

            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.Write(array3[i] + " ");
            }
        }
    }
}
