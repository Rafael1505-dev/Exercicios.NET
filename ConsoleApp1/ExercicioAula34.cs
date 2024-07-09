using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio34
    {
        public void ExercicioAula34()
        {
            Console.WriteLine("\n===== Exercício Sort Simples em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            int[] vetNumber = Array.ConvertAll(vet, int.Parse);

            int[] sortNumber = new int[vetNumber.Length];

            vetNumber.CopyTo(sortNumber, 0);
                
            Array.Sort(vetNumber);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine(vetNumber[0]);
            Console.WriteLine(vetNumber[1]);
            Console.WriteLine(vetNumber[2]);
            Console.WriteLine("");
            Console.WriteLine(sortNumber[0]);
            Console.WriteLine(sortNumber[1]);
            Console.WriteLine(sortNumber[2]);



        }
    }
}
