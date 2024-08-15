using POO.NET08;
using System;
using System.Globalization;

namespace POO.NET08
{
    public class ProgramPOO8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício pensionato em C# =======\n\n");

            Console.Write("Quantos quartos serão alugados? ");
            int number = int.Parse(Console.ReadLine());

            GuestEx8[] vectorRooms = new GuestEx8[10];
            

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                vectorRooms[room] = new GuestEx8(name, email, room);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < vectorRooms.Length; i++)
            {
                if (vectorRooms[i] != null)
                {
                    Console.WriteLine(vectorRooms[i]);
                }
            }
        }
    }
}