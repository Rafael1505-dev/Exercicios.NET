
using System.Globalization;

namespace POO.NET15
{
    public class ProgramPOO15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício com conjuntos em C# =======\n\n");

            HashSet<int> courseA = new HashSet<int> ();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int number = int.Parse(Console.ReadLine());
            int student;

            for (int i = 0; i < number; i++)
            {
                student = int.Parse(Console.ReadLine());
                courseA.Add(student);
            }

            Console.Write("How many students for course B? ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                student = int.Parse(Console.ReadLine());
                courseB.Add(student);
            }

            Console.Write("How many students for course C? ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                student = int.Parse(Console.ReadLine());
                courseC.Add(student);
            }

            HashSet<int> allCourse = new HashSet<int>(courseA);

            allCourse.UnionWith(courseB);
            allCourse.UnionWith(courseC);


            Console.WriteLine("Total Students: " + allCourse.Count);
        }
    }
}
