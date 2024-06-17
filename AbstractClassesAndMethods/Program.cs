namespace AbstractClassesAndMethods
{
    abstract class Shape
    {
        // abstract method with no body
        public abstract void GetArea();
    }

    class Circle : Shape
    {
        const double PI = Math.PI;
        public double radius;
        public Circle(double circleRadius)
        {
            radius = circleRadius;
        }
        // override the abstract method declared in the parent class
        public override void GetArea()
        {
            double area = PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area} squared units");
        }
    }

    class Rectangle : Shape
    {
        public double length;
        public double breadth;

        public Rectangle (double rectangleLength, double rectangleBreadth)
        {
            length = rectangleLength;
            breadth = rectangleBreadth;
        }
        // override the abstract method declared in the parent class
        public override void GetArea()
        {
            double area = length * breadth;
            Console.WriteLine($"The area of the rectangle is {area} squared units");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create instances of circle and rectangle
            Circle circle = new Circle(7.0);
            Rectangle rectangle = new Rectangle(10, 7);

            circle.GetArea();
            rectangle.GetArea();
        }
    }
}
