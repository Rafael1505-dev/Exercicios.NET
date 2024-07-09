using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio31
    {
        public void ExercicioAula31()
        {
            Console.WriteLine("\n===== Exercício Tempo de Jogo com Minutos em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string[] vet = Console.ReadLine().Split(' ');

            float startHour = float.Parse(vet[0]);
            float startMinute = float.Parse(vet[1]);
            float finishHour = float.Parse(vet[2]);
            float finishMinute = float.Parse(vet[3]);

            startHour *= 3600;
            startMinute *= 60;
            finishHour *= 3600;
            finishMinute *= 60;

            float SpendTime = ((finishHour + finishMinute) - (startHour + startMinute));
            int spendHour, spendMinute;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            if (SpendTime == 0)
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (SpendTime > 0)
            {
                spendHour = (int)(SpendTime / 3600);
                spendMinute = (int)((SpendTime % 3600) / 60);
                Console.WriteLine($"O JOGO DUROU {spendHour} HORA(S) E {spendMinute} MINUTO(S)");
            }
            else 
            {
                SpendTime = ((finishHour + finishMinute) - ((startHour + startMinute) - 86400));
                spendHour = (int)(SpendTime / 3600);
                spendMinute = (int)((SpendTime % 3600) / 60);
                Console.WriteLine($"O JOGO DUROU {spendHour} HORA(S) E {spendMinute} MINUTO(S)");
            }
        }
    }
}
