using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio36
    {
        public void ExercicioAula36()
        {
            Console.WriteLine("\n===== Exercício DDD em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int dddNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            switch ( dddNumber )
            {
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                default: 
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }


        }
    }
}
