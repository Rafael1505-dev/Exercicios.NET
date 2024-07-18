using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.NET
{
    class Exercicio93
    {
        public void ExercicioAula93()
        {
            Console.WriteLine("\n===== Exercício Simples de entrada de dados Curso 2 em C# =======\n\n");
            Console.WriteLine("Informe abaixo as informações do exercício: ");

            string product1 = "Computador";
            string product2 = "Mesa de escritório";
            byte age = 30;
            int code = 5290;
            char gender = 'M';
            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine($@"

                                Produtos:
                                {product1}, cujo preço é $ {price1:F2}
                                {product2}, cujo preco é $ {price2:F2}
                                Registro: {age} anos de idade, código {code} e gênero: {gender}
                                Medida com oito casas decimais: {measure:F8}
                                Arredondado (três casas decimais): {measure:F3}
                                Separador decimal invariant culture: {measure:F3}

                                ");

        }
    }
}
