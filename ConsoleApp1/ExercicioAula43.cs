using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio43
    {
        public void ExercicioAula43()
        {
            Console.WriteLine("\n===== Exercício Senha Fixa em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            int password = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO DO EXERCÍCIO =======\n\n");

            while (password != 2002)
            {
                Console.WriteLine("Senha Invalida");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
