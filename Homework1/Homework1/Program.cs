using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string s;
            Console.WriteLine("请输入第一个操作数");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.WriteLine("请输入第二个操作数");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.WriteLine("请输入操作符");
            Console.WriteLine("操作符:+,-,*,/");

            switch (Console.ReadLine())
            {
                case "+":
                    c = a + b;
                    Console.WriteLine("相加结果是" + c);
                    break;
                case "-":
                    c = a - b;
                    Console.WriteLine("相减结果是" + c);
                    break;
                case "*":
                    c = a * b;
                    Console.WriteLine("相乘结果是" + c);
                    break;
                case "/":
                    c = a / b;
                    int d = a % b;
                    Console.WriteLine("相除结果是" + c + " 余数为" + d);
                    break;
            }

            Console.Write("计算结束，按回车键结束程序");
            Console.ReadKey();
        }
    }
}