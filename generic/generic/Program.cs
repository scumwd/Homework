using System;
//Ибнеев Артем
namespace generic
{
    class Number<T>
    {
        public T num { get; set; }

        public Number<T> Add(Number<T> n)
        {
            dynamic a = this.num;
            dynamic b = n.num;
            if (a is string)
            {
                dynamic c = Convert.ToInt32(a) + Convert.ToInt32(b);
                this.num = c.ToString();
                return this;
            }
            else
            {
                this.num = a + b;
                return this;
            }
        }

        public Number<T> Sub(Number<T> n)
        {
            dynamic a = this.num;
            dynamic b = n.num;
            if (a is string)
            {
                a = Convert.ToInt32(a);
                b = Convert.ToInt32(b);
                if (a - b < 0)
                {
                    throw NotNaturalNumberException();
                }
                else
                {
                    dynamic c = Convert.ToInt32(a) - Convert.ToInt32(b);
                    this.num = c.ToString();
                    return this;
                }
            }
            else
            {
                if (a - b < 0)
                {
                    throw NotNaturalNumberException();
                }
                else
                {
                    this.num = a - b;
                    return this;
                }
            }
        }

        public int CompareTo(Number<T> n)
        {
            dynamic a = this.num;
            dynamic b = n.num;

            if (a is string)
            {
                a = Convert.ToInt32(a);
                b = Convert.ToInt32(b);
                if (a == b)
                {
                    return 0;
                }
                else
                {
                    return a > b ? 1 : -1;
                }
            }
            else
            {
                if (a == b)
                {
                    return 0;
                }
                else
                {
                    return a > b ? 1 : -1;
                }
            }
        }

        public static Exception NotNaturalNumberException()
        {
            Exception n = new Exception("Число не натуральное");
            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
