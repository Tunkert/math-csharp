using System;
using System.IO;
using System.Threading.Tasks;

namespace averageRateOfChange
{
    class CreateProblems
    {
        public void WriteProblems()
        {
            Random rand = new Random();

            for(int i = 0; i < 100; i++)
            {
                int coeffOne = rand.Next(1, 11);
                int coeffTwo = rand.Next(1, 11);
                int lowerRange = rand.Next(-100, 101);
                int upperRange = rand.Next(-100, 101);
                while (lowerRange > upperRange)
                {
                    lowerRange = rand.Next(-100, 101);
                    upperRange = rand.Next(-100, 101);
                }
                int powerOne = rand.Next(1, 4);
                int powerTwo = rand.Next(1, 4);
                while (powerOne == powerTwo)
                {
                    powerOne = rand.Next(1, 4);
                    powerTwo = rand.Next(1, 4);
                }
                double upperStart = coeffOne * Math.Pow(upperRange, powerOne);
                double upperEnd = coeffTwo * Math.Pow(upperRange, powerTwo);
                double lowerStart = coeffOne * Math.Pow(lowerRange, powerOne);
                double lowerEnd = coeffTwo * Math.Pow(lowerRange, powerTwo);
                double upperValue = upperStart + upperEnd;
                double lowerValue = lowerStart + lowerEnd;
                double solution = (upperValue - lowerValue) / (upperRange - lowerRange);
                string problemNumber = $"<h3>Problem {i + 1}</h3>";
                string problem = $"<p>Consider the function: f(x) = " +
                $"{coeffOne}x<sup>{powerOne}</sup> + {coeffTwo}x<sup>{powerTwo} " +
                $"</sup> over the range [{lowerRange}, {upperRange}]. What " +
                "is the average rate of change over this interval?</p>";
                string averageRateOfChange = $"<p>Solution: {solution}</p>";

                using (StreamWriter w = File.AppendText("average-rate-of-change.html"))
                {
                    w.WriteLine(problemNumber);
                    w.WriteLine(problem);
                }
                using (StreamWriter wa = File.AppendText("average-rate-of-change-sol.html"))
                {
                    wa.WriteLine(problemNumber);
                    wa.WriteLine(problem);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cp = new CreateProblems();
            cp.WriteProblems();
        }
    }
}
