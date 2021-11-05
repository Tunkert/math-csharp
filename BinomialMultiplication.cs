using System;
using System.IO;
using System.Threading.Tasks;

namespace binomialMultiplication
{
    class CreateProblem
    {
	public static async Task WriteProblems()
	{
	    Random rand = new Random();
	    for (int i = 0; i < 100; i++)
	    {
		int coeffOne = rand.Next(1, 101);
		int coeffTwo = rand.Next(1, 101);
		int constOne = rand.Next(1, 101);
		int constTwo = rand.Next(1, 101);

		string problemNumber = $"## Problem {i + 1}\n";
		string problem = $"Multiply ({coeffOne}x + {constOne})({coeffTwo}x + {constTwo})\n\n";
		string problemBreak = "---\n\n";
		string solution = $"Solution: {coeffOne * coeffTwo}x^2 + {coeffOne * constTwo + coeffTwo * constOne}x + {constOne * constTwo}\n\n";
		using (StreamWriter w = File.AppendText("binomial-multiplication.md"))
		{
		    w.WriteLine(problemNumber);
		    w.WriteLine(problem);
		    w.WriteLine(problemBreak);
		}
		using (StreamWriter wa = File.AppendText("binomial-multiplication-sol.md"))
		{
		    wa.WriteLine(problemNumber);
		    wa.WriteLine(solution);
		    wa.WriteLine(problemBreak);
		}
	    }
	}
    }
    class Program
    {
        static void Main(string[] args)
        {
	    CreateProblem.WriteProblems();
        }
    }
}
