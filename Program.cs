using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program calculates the standard deviation of a sample.");
            Console.WriteLine("To do this the user, you, must enter the number of values and each value.");
            Console.WriteLine("How many values do you want to enter? ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            double[] nums = new double[arrayLength];
            for ( int index = 0; index < arrayLength; index++ )
            {   
                Console.WriteLine("What is the next value you want to enter? ");
                nums[index] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("The standard deviation for the sample is " + StdDev(nums));         
        }

        static double StdDev(double[] nums)
        {
            double sum = 0.0;
            int i;
            for ( i = 0; i < nums.Length; i++ )
            {
                sum += nums[i];
            }
            double mean = sum / i;
            double varianceSum = 0.0;
            for ( int x = 0; x < nums.Length; x++ )
            {
                varianceSum += Math.Pow(nums[x] - mean, 2);
            }
            double variance = varianceSum / (nums.Length - 1);
            double standardDev = Math.Pow(variance, 0.5);
            return standardDev;
        }
    }
}
