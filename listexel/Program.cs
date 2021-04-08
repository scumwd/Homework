using System;
using System.Collections.Generic;
using System.IO;

namespace exel
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Отём\Desktop\Sample - Superstore Sales (Excel).csv";
            List<string> list = new List<string>();
            List<string[]> arraysList = new List<string[]>();
            using (StreamReader sr = new StreamReader(path))
            {
                int count = 0;
                while (count < 150)
                {
                    count++;
                    list.Add(sr.ReadLine());
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                arraysList.Add(list[i].Split(';'));
            }

            arraysList = ListsPriority.SortPriority(arraysList);

            Output(arraysList);
        }

        public static void Output(List<string[]> list)
        {
            int maxLengthName = 0;
            int maxLengthOrderDate = 0;
            int maxLengthShipDate = 0;
            int maxLengthPriority = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][17].Length > maxLengthName)
                { maxLengthName = list[i][17].Length; }
                if (list[i][2].Length > maxLengthOrderDate)
                { maxLengthOrderDate = list[i][2].Length; }
                if (list[i][20].Length > maxLengthShipDate)
                { maxLengthShipDate = list[i][20].Length; }
                if (list[i][3].Length > maxLengthPriority)
                { maxLengthPriority = list[i][3].Length; }
            }

            var formatName = string.Format("{{0, -{0}}}|", maxLengthName);
            var formatOrderDate = string.Format("{{0, -{0}}}|", maxLengthOrderDate);
            var formatShipDate = string.Format("{{0, -{0}}}|", maxLengthShipDate);
            var formatPriority = string.Format("{{0, -{0}}}|", maxLengthPriority);
            bool a = true;

            for (int i = 0; i < 150; i++)
            {
                while (a == true)
                {
                    Console.Write(formatName, list[i][17]);
                    Console.Write(" ");
                    Console.Write(formatOrderDate, list[i][2]);
                    Console.Write(" ");
                    Console.Write(formatShipDate, list[i][20]);
                    Console.Write(" ");
                    Console.Write(formatPriority, list[i][3]);
                    a = false;
                }

                a = true;
                Console.WriteLine();
            }
        }
    }
    static class ListsPriority
    {
        public static List<string[]> SortPriority(List<string[]> list)
        {
            List<string[]> CriticalLists = new List<string[]>();
            List<string[]> HighLists = new List<string[]>();
            List<string[]> MediumLists = new List<string[]>();
            List<string[]> LowLists = new List<string[]>();
            List<string[]> NotSpecifiedLists = new List<string[]>();

            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i][3])
                {
                    case "Critical":
                        CriticalLists.Add(list[i]);
                        break;
                    case "High":
                        HighLists.Add(list[i]);
                        break;
                    case "Medium":
                        MediumLists.Add(list[i]);
                        break;
                    case "Low":
                        LowLists.Add(list[i]);
                        break;
                    case "Not Specified":
                        NotSpecifiedLists.Add(list[i]);
                        break;
                }
            }

            CriticalLists = DateSort.Sorting(CriticalLists);
            HighLists = DateSort.Sorting(HighLists);
            MediumLists = DateSort.Sorting(MediumLists);
            LowLists = DateSort.Sorting(LowLists);
            NotSpecifiedLists = DateSort.Sorting(NotSpecifiedLists);

            List<string[]> returnedList = CriticalLists;
            returnedList.AddRange(HighLists);
            returnedList.AddRange(MediumLists);
            returnedList.AddRange(LowLists);
            returnedList.AddRange(NotSpecifiedLists);

            return returnedList;
        }
    }
    static class DateSort
    {
        private static void Swap(List<string[]> list, int x, int y)
        {
            var temp = list[x];
            list[x] = list[y];
            list[y] = temp;
        }

        private static int Partition(List<string[]> list, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                var dateFirst = DateTime.Parse(list[i][2]);
                var dateSecond = DateTime.Parse(list[maxIndex][2]);
                if (dateFirst > dateSecond)
                {
                    pivot++;
                    Swap(list, pivot, i);
                }
            }

            pivot++;
            Swap(list, pivot, maxIndex);

            return pivot;
        }

        private static List<string[]> QuickSort(List<string[]> list, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return list;
            }

            int pivotIndex = Partition(list, minIndex, maxIndex);
            QuickSort(list, minIndex, pivotIndex - 1);
            QuickSort(list, pivotIndex + 1, maxIndex);

            return list;
        }

        public static List<string[]> Sorting(List<string[]> list)
        {
            QuickSort(list, 0, list.Count - 1);

            return list;
        }
    }
}