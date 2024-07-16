using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio80
    {
        public void ExercicioAula80()
        {
            Console.WriteLine("\n===== Exercício Vetores 4 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int indexArray = int.Parse(Console.ReadLine());
            double sum = 0, avarage = 0; 

            double[] array = new double[indexArray];
            string[] vet = Console.ReadLine().Split(' ');
            

            array = Array.ConvertAll(vet, double.Parse);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            avarage = sum / array.Length;

            Console.WriteLine(avarage.ToString("F3"));

            for (int i = 0;i < array.Length; i++)
            {

                if (array[i] < avarage)
                {
                    Console.WriteLine(array[i].ToString("F1"));
                }
            }
        }
    }
}
