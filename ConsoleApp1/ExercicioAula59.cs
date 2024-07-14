using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio59
    {
        public void ExercicioAula59()
        {
            Console.WriteLine("\n===== Exercício Experiências em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int quantity = int.Parse(Console.ReadLine()), number, sumTotal = 0, sumRabbit = 0, sumMouse = 0, sumFrog = 0;
            string[] vet;
            char animal;
            double percentRabbit = 0.0, percentMouse = 0.0, percentFrog = 0.0;


            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            for (int i = 0; i < quantity; i++)
            {
                vet = Console.ReadLine().Split(' ');
                number = int.Parse(vet[0]);
                animal = char.Parse(vet[1]);

                sumTotal += number;

                if(animal == 'C')
                {
                    sumRabbit += number;
                }
                else if (animal == 'R')
                {
                    sumMouse += number;
                }
                else
                {
                    sumFrog += number;
                }
            }

            percentRabbit = ((double)sumRabbit / sumTotal) * 100;
            percentMouse = ((double)sumMouse / sumTotal) * 100;
            percentFrog = (
                (double)sumFrog / sumTotal) * 100;

            Console.WriteLine($"Total: {sumTotal} cobaias");
            Console.WriteLine($"Total de coelhos: {sumRabbit}");
            Console.WriteLine($"Total de ratos: {sumMouse}");
            Console.WriteLine($"Total de sapos: {sumFrog}");
            Console.WriteLine($"Percentual de coelhos: {percentRabbit:F2} %");
            Console.WriteLine($"Percentual de ratos: {percentMouse:F2} %");
            Console.WriteLine($"Percentual de sapos: {percentFrog:F2} %");
        }
    }
}
