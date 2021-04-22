using System;

namespace GetPrimeInHundreds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入筛选质数的范围");
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];

            isPrime[0] = false; isPrime[1] = false;
            for (int i = 2; i <= n; i++) { isPrime[i] = true; }

            for (int j = 2; j <= n; j++)
            {
                if (isPrime[j] == true)
                {
                    for (int m = 2; j * m <= n; m++) { isPrime[j * m] = false; }
                }
            }

            for (int j = 2; j <= n; j++) { if (isPrime[j] == true) { Console.Write("{0} ", j); } }
        }
    }
}
