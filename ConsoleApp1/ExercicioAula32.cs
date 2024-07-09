using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio32
    {
        public void ExercicioAula32()
        {
            Console.WriteLine("\n===== Exercício Animal em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string classification = Console.ReadLine();
            string speciesType = Console.ReadLine();
            string dietType = Console.ReadLine();


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");


            if (classification == "vertebrado")
            {
                if (speciesType == "ave")
                {
                    if (dietType == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (dietType == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (speciesType == "inseto")
                {
                    if (dietType == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (dietType == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }


        }
    }
}
