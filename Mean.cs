using System;
using System.IO;
using System.Threading.Tasks;

namespace mean
{
    class CreateProblems
    {
        public static async Task WriteProblems()
        {
            for(int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                int[] meanArr = new int[10];
                for(int j = 0; j < 10; j++) 
                {
                    int nextValue = rand.Next(1, 101);
                    meanArr[j] = nextValue;
                }
                int sum = 0;
                for(int k = 0; k < 10; k++)
                {
                    sum += meanArr[k];
                }
                double mean = (double)sum / 10;
                string instructions = "Find the mean of the following data set:\n";
                string meanArrString = string.Join(", ", meanArr);
                string problemNumber = $"## Problem {i + 1}\n";
                string problemArea = "\n\n";
                string problemBreak = "---\n";
                string problemSolution = $"Solution: {mean}\n\n";
                using (StreamWriter w = File.AppendText("mean.md"))
                {
                    w.WriteLine(problemNumber);
                    w.WriteLine(instructions);
                    w.WriteLine(meanArrString);
                    w.WriteLine(problemArea);
                    w.WriteLine(problemBreak);
                }
                using (StreamWriter ww = File.AppendText("mean-sol.md"))
                {
                    ww.WriteLine(problemNumber);
                    ww.WriteLine(problemSolution);
                    ww.WriteLine(problemBreak);
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
