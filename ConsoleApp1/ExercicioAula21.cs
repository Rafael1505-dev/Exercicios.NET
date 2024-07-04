using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio21
    {
        public void ExercicioAula21()
        {
            // Exercício Tempo de um Evento em C#

            Console.WriteLine("\n===== Exercício Tempo de um Evento em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do evento: ");

            string[] startDay = Console.ReadLine().Split(' ');
            string[] startHour = Console.ReadLine().Split(':');
            string[] finishDay = Console.ReadLine().Split(' ');
            string[] finishHour = Console.ReadLine().Split(':');

            int numberStartDay = int.Parse(startDay[1]);
            numberStartDay = numberStartDay * 24 * 3600;

            int hourStarHour = int.Parse(startHour[0]);
            hourStarHour = hourStarHour * 3600;

            int hourStarMinute = int.Parse(startHour[1]);
            hourStarMinute = hourStarMinute * 60;

            int hourStarSeconds = int.Parse(startHour[2]);

            int numberFinishDay = int.Parse(finishDay[1]);
            numberFinishDay = numberFinishDay * 24 * 3600;

            int hourFinishHour = int.Parse(finishHour[0]);
            hourFinishHour = hourFinishHour * 3600;

            int hourFinishMinute = int.Parse(finishHour[1]);
            hourFinishMinute = hourFinishMinute * 60;

            int hourFinishSeconds = int.Parse(finishHour[2]);

            int totalTime = ((numberFinishDay + hourFinishHour + hourFinishMinute + hourFinishSeconds) - (numberStartDay + hourStarHour + hourStarMinute + hourStarSeconds));

            int totalDays = totalTime / 86400;
            totalTime %= 86400;

            int totalHour = totalTime / 3600;
            totalTime %= 3600;

            int totalMinute = totalTime / 60;
            totalTime %= 60;

            int totalSeconds = totalTime;

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine($"{totalDays} dia(s)");
            Console.WriteLine($"{totalHour} hora(s)");
            Console.WriteLine($"{totalMinute} minuto(s)");
            Console.WriteLine($"{totalSeconds} segundo(s)");


        }
    }
}
