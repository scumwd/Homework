using System;
using System.Collections.Generic;

namespace kr13._04_3_
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Dictionary<char, int>[] array = new Dictionary<char, int>[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = new Dictionary<char, int>();
                array[i].Add('a', rnd.Next(1,10));
                array[i].Add('b', rnd.Next(1, 10));
                array[i].Add('c', rnd.Next(1, 10));
                array[i].Add('d', rnd.Next(1, 10));
                array[i].Add('e', rnd.Next(1, 10));
            }
            MaxDct(array);
            
        }
        public static void MaxDct(Dictionary<char, int>[] array)
        {
            Dictionary<char, int> fin = new Dictionary<char, int>(5);
            for(int i = 0; i < 5; i++)
            {
                foreach (char c in array[i].Keys)
                    foreach (char k in array[i + 1].Keys)
                        if (c == k)
                        {
                            if (array[i][c] > array[i + 1][k])
                                fin.Add(c, array[i][c]);
                            else fin.Add(c, array[i + 1][k]);
                        }    

                                    
            }
            foreach (KeyValuePair<char, int> keyValue in fin)
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
        }
    }
}
