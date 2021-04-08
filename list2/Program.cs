using System;
using System.Collections.Generic;

namespace list2
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string> { "dasdas", "asdsasadas", "dsad", "ds", "", "dsdsad" };
            
            foreach (string item in All_eq(strList))
                Console.WriteLine(item);
        }
        public static List<string> All_eq(List<string> strList)//почему метод доложен именно возвращать, а не быть просто void?
        {
            int max = FindMax(strList);
            for(int i= 0; i < strList.Count; i++)
            {
                while (strList[i].Length != max)
                    strList[i] += "_";
            }
            return strList;
        }
        public static int FindMax(List<string> strList)
        {
            int indexmax = 0;
            int max = strList[0].Length;
            for (int i = 1; i < strList.Count; i++)
            {
                if (strList[i].Length > strList[indexmax].Length)
                {
                    max = strList[i].Length;
                    indexmax = i;
                }
            }
            return max;
        }
    }
}
