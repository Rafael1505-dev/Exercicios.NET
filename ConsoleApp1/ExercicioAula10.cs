using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio10
    {
        public void ExercicioAula10()
        {
            // Exercício dGasto de Combustível em C#

            Console.WriteLine("\n===== Exercício Gasto de Combustível em C# =======\n\n");
            Console.WriteLine("Informe abaixo o tempo gasto na viagem e em seguida, a velocidade média efetuada: ");

            int spedTime = int.Parse(Console.ReadLine());
            int midVelocity = int.Parse(Console.ReadLine());

            double result = ((spedTime * midVelocity)/12.0);

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            Console.WriteLine(String.Format("{0:F3}", result));
        }
    }
}
