using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { 3.2, 4.6, 1.8, 2.1 };
            Console.WriteLine(StdDev(nums));         
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
