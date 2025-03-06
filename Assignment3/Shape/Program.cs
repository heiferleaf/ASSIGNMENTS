using System;


namespace HW2.Shape
{
    // 抽象形状类
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // 矩形实现
    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Width and height must be positive");

            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }

    // 正方形实现
    class Square : Shape
    {
        public double EdgeLength { get; }

        public Square(double edgeLength)
        {
            if (edgeLength <= 0)
                throw new ArgumentException("Edge length must be positive");

            EdgeLength = edgeLength;
        }

        public override double GetArea() => EdgeLength * EdgeLength;
    }

    // 三角形实现
    class Triangle : Shape
    {
        private readonly double[] _edges = new double[3];

        public Triangle(double a, double b, double c)
        {
            ValidateEdges(a, b, c);
            _edges[0] = a;
            _edges[1] = b;
            _edges[2] = c;
        }

        private static void ValidateEdges(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All edges must be positive");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Invalid triangle edges");
        }

        public override double GetArea()
        {
            double s = (_edges.Sum()) / 2;
            return Math.Sqrt(s * (s - _edges[0]) * (s - _edges[1]) * (s - _edges[2]));
        }
    }
}