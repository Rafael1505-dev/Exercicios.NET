using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio77
    {
        public void ExercicioAula77()
        {
            Console.WriteLine("\n===== Exercício Vetores 1 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine());
            double[] array = new double[indexArray];

            string[] vet  = Console.ReadLine().Split(' ');

            array = Array.ConvertAll(vet, double.Parse);

            double maxNumber = array.Max();
            int indexMaxNumber = Array.IndexOf(array,maxNumber);

            Console.WriteLine(maxNumber.ToString("F1"));
            Console.WriteLine(indexMaxNumber.ToString());


        }
    }
}
