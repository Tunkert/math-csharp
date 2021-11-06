using System;
using System.IO;
using System.Threading.Tasks;

namespace polynomialAddition
{
    class CreateProblems
    {
	public static async Task WriteProblems()
	{
	    Random rand = new Random();

	    for(int i = 0; i < 100; i++)
	    {
		int coeffOne = rand.Next(1, 11);
		int coeffTwo = rand.Next(1, 11);
		int constOne = rand.Next(1, 11);
		int constTwo = rand.Next(1, 11);
		int powerOne = rand.Next(1, 5);
		int powerTwo = rand.Next(1, 5);

		string problemNumber = $"<h3>Problem {i + 1}</h3>";
		string problem = $"<p>Simplify: ({coeffOne}x<sup>{powerOne}</sup> + {constOne}) + ({coeffTwo}x<sup>{powerTwo}</sup> + {constTwo})</p>";
		string problemBreak = "<hr />";
		string solution = "";

		if (powerOne == powerTwo)
		{
		    if (coeffOne == 1)
		    {
			solution = $"<p>{coeffOne + coeffTwo}x + {constOne + constTwo}";
		    }
		    else
		    {
			solution = $"<p>{coeffOne + coeffTwo}x<sup>{powerOne}</sup> + {constOne + constTwo}";
		    }
		}
		else
		{
		    if (powerOne > powerTwo && powerTwo != 1)
		    {
			solution = $"<p>{coeffOne}x<sup>{powerOne}</sup> + {coeffTwo}x<sup>{powerTwo}</sup> + {constOne + constTwo}";
		    }
		    else if (powerOne > powerTwo && powerTwo == 1)
		    {
			solution = $"<p>{coeffOne}x<sup>{powerOne}</sup> + {coeffTwo}x + {constOne + constTwo}";
		    }
		    else if (powerOne < powerTwo && powerOne != 1)
		    {
			solution = $"<p>{coeffTwo}x<sup>{powerTwo}</sup> + {coeffOne}x<sup>{powerOne}</sup> + {constOne + constTwo}";
		    }
		    else
		    {
			solution = $"<p>{coeffTwo}x<sup>{powerTwo}</sup> + {coeffOne}x + {constOne + constTwo}";
		    }
		}
		using (StreamWriter w = File.AppendText("polynomial-addition.html"))
		{
		    w.WriteLine(problemNumber);
		    w.WriteLine(problem);
		    w.WriteLine(problemBreak);
		}
		using (StreamWriter wa = File.AppendText("polynomial-addition-sol.html"))
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
	    CreateProblems.WriteProblems();
        }
    }
}
