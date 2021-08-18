using System;

namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int k = 2;
            int nums = 30;
            int[] numsArr = new int[30];

            for (int i = 0; i < nums; i++)
            {
                if (i == j)
                {
                    numsArr[i] = 0;
                    j = j + k;
                    k++;
                } else
                {
                    numsArr[i] = 1;
                }
            }
            foreach (var num in numsArr) {
                Console.WriteLine(num);
            }
        }
    }
}
