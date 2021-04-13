using System;
using System.Collections.Generic;
//Ибнеев Артем 11-012
namespace kr13._04_2_
{
    class Program
    {
        public static Random rnd = new();
        static void Main()
        {
            int n = 10;            
            List<double> num = new List<double>();
            for(int i = 0; i < n; i++)
            {
                num.Add(rnd.NextDouble()*50);
            }
            foreach (double item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<double> num1 = new();
            for(int i = 0; i < n; i++)
            {
                num1.Add(Sum(num, i));
            }
            foreach (double item in num1)
            {
                Console.WriteLine(item);
            }

        }
        public static double Sum(List<double> num, int i)
        {
            double sum = 0;
            for (int j = 0; j < i + 1; j++)
                sum += num[j];
            return sum;
        }
    }
}
