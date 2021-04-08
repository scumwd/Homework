using System;

namespace mylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>();
            intList.Add(7);
            intList.Add(45);
            Print(intList);
            int[] intArray = { 3, 4, 7, 6 };
            intList.AddRange(intArray);
            Print(intList);
            if (intList.Remove(7))
            {
                Console.WriteLine("Yra rabotaet");
            }
            else Console.WriteLine("Takoe chislo ne naideno");
            Print(intList);
            intList.RemoveAt(1);
            Print(intList);
            Console.WriteLine(intList.IndexOf(3));
            intList.Insert(4, 89);
            Print(intList);
            intList.SortInt();
            Print(intList);
            intList.ChangeMinInt();
            Print(intList);

        }
        public static void Print(List<int> intList)
        {
            Console.WriteLine();
            for (int i = 0; i < intList.i; i++)
                Console.WriteLine(intList.Listt[i]);
            Console.WriteLine();
        }
    }
    class List<T>
    {
        public T[] Listt = new T[1000];
        public int i = 0;
        public T Add(T n)
        {
            Listt[i] = n;
            i++;
            return Listt[i];
        }
        public T AddRange(T[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Listt[i] = array[j];
                i++;
            }
            return Listt[i];
        }
        public bool Remove(T n)
        {
            bool fin = false;
            for (int j = 0; j < i; j++)
            {
                if (object.Equals(Listt[j], n))
                {
                    Listt[j] = default(T);
                    fin = true;
                    break;
                }

                else
                    fin = false;
            }
            return fin;
        }
        public T RemoveAt(int j)
        {
            Listt[j] = default(T);
            return Listt[i];
        }
        public int IndexOf(T temp)
        {
            int fin=0;
            for (int j = 0; j < i; j++)
            {
                if (object.Equals(Listt[j], temp))
                {
                    fin = j;

                    break;
                }
                else fin = 0;

            }
            if (fin != 0)
                return fin;
            else
            {
                Console.WriteLine("here was no such entry");
                return 0;
            }
        }
        public T Insert(int j, T temp)
        {
            Listt[j] = temp;
            return Listt[i];
        }
        public T SortInt()
        {            
            T temp;
            for (int j = 0; j < i; j++)
            {
                for (int k = j + 1; k < i; k++)
                {
                    if (Convert.ToInt32(Listt[j]) > Convert.ToInt32(Listt[k]))
                    {
                        temp = Listt[j];
                        Listt[j] = Listt[k];
                        Listt[k] = temp;
                    }
                }
            }
            return Listt[i];
        }
        public T SortStr()
        {
            T temp;
            for (int j = 0; j < i; j++)
            {
                for (int k = j + 1; k < i; k++)
                {
                    if (Convert.ToString(Listt[j]).Length > Convert.ToString(Listt[k]).Length)
                    {
                        temp = Listt[j];
                        Listt[j] = Listt[k];
                        Listt[k] = temp;
                    }
                }
            }
            return Listt[i];
        }
        public T ChangeMinInt()
        {
            int indexmin=0;
            T min= default(T);
            for(int j=1;j<i;j++)
            {
                if (Convert.ToInt32(Listt[j]) < Convert.ToInt32(Listt[indexmin]))
                {
                    min = Listt[j];
                    indexmin = j;
                }
                    
            }
            int indexmax=0;
            T max= default(T);
            for (int j = 1; j < i; j++)
            {
                if (Convert.ToInt32(Listt[j]) > Convert.ToInt32(Listt[indexmax]))
                {
                    max = Listt[j];
                    indexmax = j;
                }

            }
            Listt[indexmin] = max;
            Listt[indexmax] = min;

            return Listt[i];
        }
        public T ChangeMinStr()
        {
            int indexmin = 0;
            T min = default(T);
            for (int j = 1; j < i; j++)
            {
                if (Convert.ToString(Listt[j]).Length < Convert.ToString(Listt[indexmin]).Length)
                {
                    min = Listt[j];
                    indexmin = j;
                }

            }
            int indexmax = 0;
            T max = default(T);
            for (int j = 1; j < i; j++)
            {
                if (Convert.ToString(Listt[j]).Length > Convert.ToString(Listt[indexmax]).Length)
                {
                    max = Listt[j];
                    indexmax = j;
                }

            }
            Listt[indexmin] = max;
            Listt[indexmax] = min;

            return Listt[i];
        }
    }
}
