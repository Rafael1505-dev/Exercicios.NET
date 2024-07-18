using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio94
    {
        public void ExercicioAula94()
        {
            Console.WriteLine("\n===== Exercício Positivo e Negativo Curso 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int number = int.Parse(Console.ReadLine());

            if(number >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else 
            {

                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
