using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio35
    {
        public void ExercicioAula35()
        {
            Console.WriteLine("\n===== Exercício Triângulo em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            float triangleA = float.Parse(vet[0]);
            float triangleB = float.Parse(vet[1]);
            float triangleC = float.Parse(vet[2]);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if (((triangleA + triangleB) > triangleC) && ((triangleA + triangleC) > triangleB) && ((triangleC + triangleB) > triangleA))
            {
                float perimeter = triangleA + triangleB + triangleC;
                Console.WriteLine($"Perimetro = {perimeter:F1}");
            }
            else
            {
                float area = ((triangleA + triangleB) * triangleC) / 2;
                Console.WriteLine($"Area = {area:F1}");
            }

        }
    }
}
