using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio50
    {
        public void ExercicioAula50()
        {
            Console.WriteLine("\n===== Exercício Lanche em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(valores[0]);
                int golsGremio = int.Parse(valores[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter = vitoriasInter + 1;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio = vitoriasGremio + 1;
                }
                else
                {
                    empates = empates + 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int total = vitoriasGremio + vitoriasInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}
