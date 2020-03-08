using System;

namespace project6
{
abstract class Shape
{
   public abstract double Area();
   public abstract bool Judge();
}
class Square : Shape
{
      private double edge;
        public Square(double edge)
        {
            this.edge = edge;
        }
      public double Edge
        {
            get { return edge; }
            set { edge = value; }
        }
      public override bool Judge()
        {
            return edge > 0;
        }
      public override double Area()
        {
            if (Judge())
                return edge * edge;
            else
                return  0;
        }
}
class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public override bool Judge()
        {
            return length!=width&&length>0&&width>0;
        }
        public override double Area()
        {
            if (Judge())
                return length * width;
            else
                return 0;
        }
    }
class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public override bool Judge()
        {
            return a>0&&b>0&&c>0&&a+b>c&&a+c>b&&b+c>a;
        }
        public override double Area()
        {
            if (Judge())
            {
                double p = (a + b + c)/2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                return 0;
        }
    }
 class Factory
    {
        public Shape Produce(int number)
        {
            Random i = new Random();
            switch (number)
            {
                case 0:return new Square(i.Next(1, 10));
                case 1:return new Rectangle(i.Next(1, 10), i.Next(1, 10));
                case 2:return new Triangle(i.Next(1, 10), i.Next(1, 10), i.Next(1, 10));
                default: return null;
            }
        }

    }
class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int random;
            Shape produce;
            Factory myFactory = new Factory();
            for (int i = 0; i < 10; i++)
            {
                random = new Random().Next(0, 3);
                produce = myFactory.Produce(random);
                if (produce.Area()!= 0)
                {
                    total += produce.Area();
                }
            Console.WriteLine($"第{i+1}次面积是: {total}");
            }
            Console.WriteLine($"总面积是: {total}");
        }
    }
}
