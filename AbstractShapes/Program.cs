using System;
using System.Drawing;
namespace AbstractShapes
{
    class Program
    {
        public class Shape
        {
            private Point origin;
            public Point Origin{ get{ return origin; } set{ origin = value;} }

            public override string ToString()
            {
                return String.Format("The origin of this shape is {0}.", origin.ToString());
            }

            public Shape(int x, int y)
            {
                this.Origin = new Point(x, y);
            }
        }

        public class Square : Shape
        {
            private Size size;
            public Size Size { get { return size; } set { size = value; } }

            public Point OppOrigin()
            {
                return Point.Add(Origin, Size);
            }

            public override string ToString()
            {
                Point opposite = OppOrigin();
                return String.Format("The origin for this square is {0} and the opposite point is {1}", Origin.ToString(), opposite.ToString() );
            }

            public Square(int side, int x, int y) : base(x, y)
            {
                this.Size = new Size(side, side);
            }
        }   

        public class Rectangle : Square
        {

            public override string ToString()
            {
                Point opposite = OppOrigin();
                return String.Format("The origin for this rectangle is {0} and the opposite point is {1}", Origin.ToString(), opposite.ToString());
            }

            public Rectangle(int len, int wid, int x, int y) : base(len, x, y)
            {
                this.Size = new Size(len, wid);
            }
        }

        public class Circle : Shape
        {
            private double radius;
            public double Radius { get { return radius; } set { radius = value; } }

            public override string ToString()
            {
                double area = GetArea();
                return String.Format("The origin for this circle is {0} and the area is {1}", Origin.ToString(), area);
            }

            public double GetArea()
            {
                double subTotal = 3.14 * Radius;
                return subTotal * subTotal;
            }

            public Circle(double radius, int x, int y) : base(x, y)
            {
                this.Radius = radius;
            }
        }

        static void Main(string[] args)
        {
            Shape newShape = new Shape(1, 4);
            Console.WriteLine(newShape.ToString());

            Console.WriteLine("*****");

            Square newSquare = new Square(20, 1, 4);
            Console.WriteLine(newSquare.ToString());

            Console.WriteLine("*****");

            Rectangle newRect = new Rectangle(20, 30, 1, 4);
            Console.WriteLine(newRect.ToString());

            Console.WriteLine("*****");

            Circle newCirc = new Circle(20, 1, 4);
            Console.WriteLine(newCirc.ToString());

            Console.ReadLine();
        }
    }
}


/*
 
    Point
    -x
    -y

    Shape
    -origin

    Square
    -origin
    -side

    Rectangle
    -origin
    -second point

    Circle
    -origin
    -radius

     
     */