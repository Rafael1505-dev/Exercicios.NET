using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio25
    {
        public void ExercicioAula25()
        {
            Console.WriteLine("\n===== Exercício Tempo de Jogo em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            int startHour = int.Parse(vet[0]);
            int finishHour = int.Parse(vet[1]);

            int result = 0;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if (startHour == finishHour) 
            { 
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }else if (startHour > finishHour)
            {
                result = ((24 - startHour) + finishHour);
                Console.WriteLine($"O JOGO DUROU {result} HORA(S)");
            }else
            {
                result = (finishHour - startHour);
                Console.WriteLine($"O JOGO DUROU {result} HORA(S)");
            }

        }
    }
}
