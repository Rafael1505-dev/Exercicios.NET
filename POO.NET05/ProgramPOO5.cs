using POO.NET05;
using System;
using System.ComponentModel;
using System.Globalization;


namespace POO.NET05
{
    public class ProgramPOO5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício que calcula a nota final do aluno em C# =======\n\n");

            CultureInfo culture = CultureInfo.InvariantCulture;

            StudentEx5 student = new StudentEx5();

            Console.Write("Nome do aluno: ");
            student.name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            student.firstgrade = double.Parse(Console.ReadLine(), culture);
            student.secondgrade = double.Parse(Console.ReadLine(), culture);
            student.thirdgrade = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("NOTA FINAL = " + student.FinalGrade().ToString("F2",culture));
            
            if(student.ResultFinal() == true )
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {student.RestResultGrade().ToString("F2", culture)} PONTOS");
            }
        }
    }
}