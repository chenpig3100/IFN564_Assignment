using System;
using System.Diagnostics;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            OptionA optionA = new OptionA();
            OptionB optionB = new OptionB();

            string[] A = new string[1000];
            int n = 0;
            string customer;

            for (int i = n; i < A.Length; i++)
            {
                customer = i.ToString();
                optionB.InsertOptionB(A, ref n, customer);
            }

            stopwatch.Start();
            optionB.DeleteOptionB(A,ref n, "999");
            optionB.InsertOptionB(A, ref n, "999");
            stopwatch.Stop();

            stopwatch.Reset();

            stopwatch.Start();
            optionB.DeleteOptionB(A,ref n, "555");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

            optionB.InsertOptionB(A, ref n, "555");
            stopwatch.Reset();

            stopwatch.Start();
            optionB.DeleteOptionB(A,ref n, "0");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

        }
    }

    public class OptionA
    {
        public void InsertOptionA(string[] A,ref int n, string new_customer)
        {
            if ( n < A.Length)
            {
                A[n] = new_customer;
                n++;
            } else
            {
                Console.WriteLine("The array is already full.");
            }
        }
        public int SearchOptionA(string[] A, int n, string customer)
        {
            for (int i = 0; i <　A.Length; i++)
            {
                if (A[i] == customer ) { return i; }
            }
            return -1;
        }
        public void DeletOptionA(string[] A,ref int n, string customer)
        {
            int i = 0;
            while ( i < n && A[i] != customer)
            {
                i++;
            }
            if ( i == n )
            {
                Console.WriteLine("This customer is not in the array.");
            } else
            {
                while ( i < n - 1 )
                {
                    A[i] = A[i + 1];
                    i++;
                }
                n--;
            }
        }
    }

    public class OptionB
    {
        public void InsertOptionB(string[] A,ref int n, string new_customer)
        {
            if (n < A.Length)
            {
                int i = 0;
                while (i < n && A[i].CompareTo(new_customer) < 0)
                {
                    i++;
                }
                int j = n - 1;
                while (j >= i)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[i] = new_customer;
                n++;
            } else
            {
                Console.WriteLine("The array is already full.");
            }
        }
        public int SearchOptionB(string[] A, int n, string customer)
        {
            int i = 0, r = n - 1;
            while (i <= r)
            {
                int m = (i + r) / 2;
                if (A[m] == customer)
                {
                    return m;
                } else if (A[m].CompareTo(customer) > 0){
                    r = m - 1;
                } else
                {
                    i = m + 1;
                }
            }
            return -1;
        }
        public void DeleteOptionB(string[] A,ref int n, string customer)
        {
            int i = 0, r = n - 1;
            while (i <= r)
            {
                int m = (i + r) / 2;
                if (A[m] == customer)
                {
                    while (m < n -1)
                    {
                        A[m] = A[m + 1];
                        m++;
                    }
                    n--;
                    return;
                } else if (A[m].CompareTo(customer) > 0)
                {
                    r = m - 1;
                } else
                {
                    i = m + 1;
                }
            }
            Console.WriteLine("This customer is not in the array.");
        }
    }
}

/*
stopwatch.Start();
            optionA.InsertOptionA(A, ref n, "0");
            stopwatch.Stop();

            stopwatch.Reset();

            stopwatch.Start();
            optionA.InsertOptionA(A, ref n, "1");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            for (int i = n; i < A.Length - 2; i++)
            {
                customer = i.ToString();
                optionA.InsertOptionA(A,ref n, customer);
            }

            stopwatch.Start();
            optionA.InsertOptionA(A, ref n, "999");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);
*/

/*
            stopwatch.Start();
            optionA.SearchOptionA(A, n, "999");
            stopwatch.Stop();

            stopwatch.Reset();

            stopwatch.Start();
            optionA.SearchOptionA(A, n, "0");
            stopwatch.Stop();
            Console.WriteLine("The position is: {0}", optionA.SearchOptionA(A, n, "0"));
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            optionA.SearchOptionA(A, n, "999");
            stopwatch.Stop();
            Console.WriteLine("The position is: {0}", optionA.SearchOptionA(A, n, "999"));
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);
*/

/*
            stopwatch.Start();
            optionA.DeletOptionA(A,ref n, "999");
            optionA.InsertOptionA(A, ref n, "999");
            stopwatch.Stop();

            stopwatch.Reset();

            stopwatch.Start();
            optionA.DeletOptionA(A, ref n, "999");
            stopwatch.Stop();
            optionA.InsertOptionA(A, ref n, "999");
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            optionA.DeletOptionA(A, ref n, "0");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);
*/

/*
            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                optionB.InsertOptionB(A, ref n, "1000");
                optionB.DeleteOptionB(A, ref n, "1000");

            }
            stopwatch.Stop();
            stopwatch.Reset();
            

            stopwatch.Start();
            optionB.InsertOptionB(A, ref n, "0");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            for (int i = n; i < A.Length - 1; i++)
            {
                customer = i.ToString();
                optionB.InsertOptionB(A, ref n, customer);
            }

            stopwatch.Start();
            optionB.InsertOptionB(A, ref n, "999");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);
*/
/*
            for (int i = n; i < A.Length; i++)
            {
                customer = i.ToString();
                optionB.InsertOptionB(A, ref n, customer);
            }

            stopwatch.Start();
            optionB.SearchOptionB(A, n, "0");
            stopwatch.Stop();

            stopwatch.Reset();

            stopwatch.Start();
            optionB.SearchOptionB(A, n, "555");
            stopwatch.Stop();
            Console.WriteLine("The position is: {0}", optionB.SearchOptionB(A, n, "555"));
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            optionB.SearchOptionB(A, n, "1000");
            stopwatch.Stop();
            Console.WriteLine("The position is: {0}", optionB.SearchOptionB(A, n, "1000"));
            Console.WriteLine("Time elapsed: {0} ms", stopwatch.Elapsed.TotalMilliseconds);
*/