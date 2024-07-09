using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio29
    {
        public void ExercicioAula29()
        {
            Console.WriteLine("\n===== Exercício Coordenadas de um Ponto em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if (x == y && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)    
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) 
            {
                Console.WriteLine("Q2");
            }
            else if (x > 0 && y < 0) 
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            

        }
    }
}
