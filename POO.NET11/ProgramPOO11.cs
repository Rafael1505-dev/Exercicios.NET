using POO.NET11.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace POO.NET11
{
    public class ProgramPOO11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício de Produtos com Herança e Polimorfismo em C# =======\n\n");

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            List<ProductEx11> list = new List<ProductEx11>();


            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (choice == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProductEx11 impProdt = new ImportedProductEx11(name, price, customFee);

                    list.Add(impProdt);

                }
                else if (choice == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    UsedProductEx11 usedProdt = new UsedProductEx11(name, price,manufactureDate);

                    list.Add(usedProdt);
                }
                else
                {
                    ProductEx11 prodt = new ProductEx11(name, price);
                    list.Add(prodt);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (ProductEx11 lt in list)
            {
                Console.WriteLine(lt.PriceTag());
            }
        }
    }
}
