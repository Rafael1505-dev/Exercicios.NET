using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio30
    {
        public void ExercicioAula30()
        {
            Console.WriteLine("\n===== Exercício Lanche em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            double[] vetNumber = Array.ConvertAll(vet, double.Parse);

            Array.Sort(vetNumber, (a, b) => b.CompareTo(a));

            double A = vetNumber[0];
            double B = vetNumber[1];
            double C = vetNumber[2];


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if(A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(A,2) == (Math.Pow(B,2) + Math.Pow(C,2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(A, 2) > (Math.Pow(B, 2) + Math.Pow(C, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(A, 2) < (Math.Pow(B, 2) + Math.Pow(C, 2))) 
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == C || B == C || A == B) 
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
