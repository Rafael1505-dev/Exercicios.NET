using System;
using System.Collections.Generic;
using System.IO;

namespace POO.NET16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício com Ditconary em C# =======\n\n");


            Dictionary<String,int> dic = new Dictionary<String,int>();
            

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine().Trim();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (dic.ContainsKey(name))
                        {
                            dic[name] += votes;
                        }
                        else
                        {
                            dic.Add(name, votes);
                        }
                    }

                    foreach (KeyValuePair<String, int> pair in dic)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}