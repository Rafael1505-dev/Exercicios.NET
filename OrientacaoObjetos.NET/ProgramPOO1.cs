using System;

namespace OrientacaoObjetos.NET
{
    public class ProgramPOO1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício que aponta a pessoa mais velha em C# =======\n\n");

            PersonEx1 person1, person2, oldPerson;

            person1 = new PersonEx1();
            person2 = new PersonEx1();


            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.name = Console.ReadLine();
            Console.Write("Idade: ");
            person1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person2.name = Console.ReadLine();
            Console.Write("Idade: ");
            person2.age = int.Parse(Console.ReadLine());

            oldPerson = PersonEx1.CompareWeight(person1, person2);

            Console.WriteLine($"Pessoa mais velha: {oldPerson.name}");

        }
    }
}