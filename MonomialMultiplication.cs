using System;
using System.IO;
using System.Threading.Tasks;

namespace csApp
{
    class WriteProblems 
    {
        public static async Task CreateProblems()
        {
            Random rnd = new Random();
            for(int i = 0; i < 100; i++)
            {
                int coeffOne = rnd.Next(1, 101);                
                int coeffTwo = rnd.Next(1, 101);                
                int constantOne = rnd.Next(1, 101);

                string problemnumber = $"## Problem {i + 1}\n";

                string problem = $"Simplify: {coeffOne}x({coeffTwo}x + {constantOne})";
                string linebreak = "\n\n";
                string lineend = "---\n";
                using (StreamWriter w = File.AppendText("monomials.md"))
                    {
                        w.WriteLine(problemnumber);
                        w.WriteLine(problem);
                        w.WriteLine(linebreak);
                        w.WriteLine(lineend);
                    }
            }
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            WriteProblems.CreateProblems();
        }
    }
}
