using System;

namespace HW3.SimpleFactory
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

    // 工厂接口
    interface IShapeFactory 
    {
        Shape CreateShape(double[] args);
    }

    // 矩形工厂
    class RectangleFactory : IShapeFactory
    {
        public Shape CreateShape(double[] args)
        {
            if (args == null || args.Length < 2)
                throw new ArgumentException("Requires [width, height]");

            return new Rectangle(args[0], args[1]);
        }
    }

    // 正方形工厂
    class SquareFactory : IShapeFactory
    {
        public Shape CreateShape(double[] args)
        {
            if (args == null || args.Length < 1)
                throw new ArgumentException("Requires [edgeLength]");

            return new Square(args[0]);
        }
    }

    // 三角形工厂
    class TriangleFactory : IShapeFactory
    {
        public Shape CreateShape(double[] args)
        {
            if (args == null || args.Length < 3)
                throw new ArgumentException("Requires [a, b, c]");

            return new Triangle(args[0], args[1], args[2]);
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            try
            {
                // 初始化工厂
                var factories = new Dictionary<string, IShapeFactory>
                {
                    { "rectangle", new RectangleFactory() },
                    { "square", new SquareFactory() },
                    { "triangle", new TriangleFactory() }
                };

                // 测试用例
                TestShapeCreation(factories["rectangle"], new[] { 3.0, 4.0 });  // 面积12
                TestShapeCreation(factories["square"], new[] { 5.0 });          // 面积25
                TestShapeCreation(factories["triangle"], new[] { 3.0, 4.0, 5.0 }); // 面积6

                // 测试异常情况
                // TestShapeCreation(factories["triangle"], new[] { 1.0, 1.0, 3.0 }); // 会抛出异常
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void TestShapeCreation(IShapeFactory factory, double[] parameters)
        {
            var shape = factory.CreateShape(parameters);
            Console.WriteLine($"Created {shape.GetType().Name}, Area: {shape.GetArea():F2}");
        }
    }
}