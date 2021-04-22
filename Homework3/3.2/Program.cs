using System;

namespace _3._2
{
    interface Shape { public int getArea(); }

    class Square : Shape
    {
        int a;
        Square(int length)
        {
            this.a = length;
        }

        public int getArea()
        {
            return a * a;
        }
    }

    class Rectangle : Shape
    {
        int a, b;

        Rectangle(int a, int b)
        {
            this.a = a; this.b = b;
        }

        public int getArea()
        {
            return a * b;
        }
    }

    class Triangle : Shape
    {
        int a, b;
        Triangle(int height, int length)
        {
            this.a = height; this.b = length;
        }

        public int getArea()
        {
            return a * b / 2;
        }
    }

    class ShapeFactory
    {
        public Shape GetShape(String shapeType)
        {
            Random ran = new Random();
            int RandKey = ran.Next(2, 20);
            switch (shapeType) { 
            case "Square":
                return new Square(RandKey);
            case "Rectangle":
                return new Rectangle(RandKey, RandKey);
            case "Triangle":
                return new Triangle(RandKey, RandKey);
            default:
                Console.WriteLine("不合法的类型");
                return null;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                ShapeFactory fac = new ShapeFactory();
                Shape shape1 = fac.GetShape("Square");
            }
        }
    }
}