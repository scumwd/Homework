using System;
//Ибнеев Артем 11-012
namespace Interface
{
    interface INumber
    {
        public dynamic Num { get; set; }

        INumber Add(INumber n);
        INumber Sub(INumber n);
        int CompareTo(INumber n);
    }

    class SimpleLongNumber : INumber
    {
        public dynamic Num { get; set; }

        public INumber Add(INumber n)
        {
            return Num + n.Num;
        }

        public int CompareTo(INumber n)
        {
            if (n.Num < Num) return 1;
            else if (n.Num > Num) return -1;
            else return 0;
        }

        public INumber Sub(INumber n)
        {
            if (this.Num - n.Num < 0)
            {
                throw NotNaturalNumberException();
            }
            else
            {
                this.Num -= n.Num;
                return this;
            }
        }
        public static Exception NotNaturalNumberException()
        {
            Exception n = new ("Число должно быть натуральным");
            return n;
        }
    }

        class VeryLongNumber : INumber
    {
        public dynamic Num { get; set; }

        public INumber Add(INumber n)
        {
            return Num + n.Num;
        }

        public int CompareTo(INumber n)
        {
            if (n.Num < Num) return 1;
            else if (n.Num > Num) return -1;
            else return 0;
        }

        public INumber Sub(INumber n)
        {
            if (this.Num - n.Num < 0)
            {
                throw NotNaturalNumberException();
            }
            else
            {
                this.Num -= n.Num;
                return this;
            }
        }
        public static Exception NotNaturalNumberException()
        {
            Exception n = new ();
            return n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            INumber[] array = new INumber[] { 46546, 1321, 465, 648, 4564664, 5432 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += SimpleLongNumber.Add(array[i]);
            }
        }
    }
}
