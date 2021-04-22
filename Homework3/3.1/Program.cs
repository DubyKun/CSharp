using System;

namespace _3._1
{
    interface Shape
    {
        double getArea();
    }
    public class Square : Shape
    {
        public double a;
        public Square()
        {
            a = 0;
        }
        public Square(double length)
        {
            a = length;
        }

        public double getArea()
        {
            if (a <= 0)
            {
                Console.WriteLine("这不是一个合法的正方形");
                return 0;
            }
            else
            {
                return a * a;
            }
        }
    }

    public class Rectangle : Square
    {
        public double b;

        public Rectangle()
        {
            a = 0; b = 0;
        }
        public Rectangle(double length)
        {
            a = length;
            b = length;
        }
        public Rectangle(double length, double width)
        {
            a = length;
            b = width;
        }

        new public double getArea()
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("该长方形不合法");
                return 0;
            }
            else
            {
                return a * b;
            }
        }

    }

    public class Triangle : Rectangle
    {
        public double c = 0;
        public Triangle()
        {
            a = 0; b = 0; c = 0;
        }
        public Triangle(double l1)
        {
            a = l1; b = l1; c = l1;
        }
        public Triangle(double l1, double l2)
        {
            a = l1; b = l2; c = Math.Sqrt(a * a + b * b);
        }
        public Triangle(double l1, double l2, double l3)
        {
            a = l1; b = l2; c = l3;
        }

        new public double getArea()
        {
            if (a + b < c || a + c < b || b + c < a || a * b * c <= 0)
            {
                Console.WriteLine("该三角形不合法");
                return 0;
            }
            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}