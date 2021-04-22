using System;

namespace GetParameterInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string SNum = Console.ReadLine();
            int num = int.Parse(SNum);

            if (num / 2 != 0)
            {
                int i = 2;
                while (i != num)
                {
                    if (num % i == 0)
                    {
                        Console.Write("{0} ", i);
                        if (num == 2) { Console.Write("{0} ", num); } else { num /= i; Console.Write("{0} ", i); }
                    }
                    else { i++; }
                }
            }

        }
    }
}
