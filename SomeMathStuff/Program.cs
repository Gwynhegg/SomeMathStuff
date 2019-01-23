using System;

namespace SomeMathStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure firstCircle = new Circle(5);
            firstCircle.calculate_perimeter();
            firstCircle.calculate_area();
            Figure anotherShape = new Triangle(3, 4, 5);
            anotherShape.calculate_area();
            anotherShape.calculate_perimeter();
            anotherShape = new Square(6, 6);
            anotherShape.calculate_area();
            anotherShape.calculate_perimeter();
            Console.ReadKey();
        }
    }

    abstract class Figure
    {
        public abstract void calculate_perimeter();
        public abstract void calculate_area();
    }

    class Circle : Figure
    {
        int r;
        public Circle(int n)
        {
            r = n;
        }
        public override void calculate_perimeter()
        {
            Console.WriteLine("Perimeter of Circle = "+ (2 * Math.PI * r));
        }
        public override void calculate_area()
        {
            Console.WriteLine("Area of Circle = "+(Math.PI*Math.Pow(r,2)));
        }
    }

    class Square : Figure
    {
        int x, y;
        public Square(int a, int b)
        {
            x = a;
            y = b;
        }
        public override void calculate_perimeter()
        {
            if (x == y) Console.WriteLine("Perimeter of Square = " + (2 * (x + y)));
            else Console.WriteLine("Perimeter of Quadrangle = " + (2 * (x + y)));
        }
        public override void calculate_area()
        {
            if (x == y) Console.WriteLine("Area of Square = " + (x * y));
            else Console.WriteLine("Area of Quadrangle = " + (x * y));
        }
    }
    class Triangle : Figure
    {
        int x, y, z;
        public Triangle(int a,int b,int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public override void calculate_perimeter()
        {
            Console.WriteLine("Perimeter of Triangle = " + (x + y + z));
        }
        public override void calculate_area()
        {
            double p = (x + y + z) / 2;
            Console.WriteLine("Area of Triangle = "+(Math.Sqrt(p*(p-x)*(p-y)*(p-z))));
        }

    }
}
