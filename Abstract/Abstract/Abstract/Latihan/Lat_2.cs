using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            Shape shape1, shape2;

            Circle[] circles1 = new Circle[]
            {
                new Circle(10.5),
                new Circle(2.5),
                new Circle(1.0)
            };


            Circle.SubClassCircle subClassCircle = new Circle.SubClassCircle(circles1);

            foreach(var item in subClassCircle.sortingData())
            {
                Console.WriteLine($"Color : {item.Color}");
                Console.WriteLine($"Filled : {item.Filled}");
                Console.WriteLine($"Radius : {item.Radius}");
                Console.WriteLine($"Luas lingkaran : {item.getArea()}");
                Console.WriteLine($"Keliling lingkaran : {item.getPerimeter()}");
            }

            Rectangle rectangle = new Rectangle("blue", true, 10.2, 10.5);
            shape2 = rectangle;

            Console.WriteLine(shape2.ToString());
        }
    }

    abstract class Shape
    {
        protected string color = "red";
        protected bool filled = true;

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public abstract double getArea();
        public abstract double getPerimeter();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;   
        }

        public Circle(string color, bool filled, double radius)
        {
            this.color = color;
            this.filled = filled;
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double getArea()
        {
            return Math.PI * (Math.Pow(this.radius, 2));
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }


        // mendefinisikan inner class
        public class SubClassCircle
        {
            private Circle[] circles;

            public SubClassCircle(Circle[] circles)
            {
                this.circles = circles;
            }

            public Circle[] sortingData()
            {
                for (int i = 0; i < this.circles.Length - 1; i++)
                {
                    int temp = i;

                    for (int j = i + 1; j < this.circles.Length; j++)
                    {
                        if (this.circles[j].getArea() < this.circles[temp].getPerimeter() && this.circles[j].getPerimeter() < this.circles[temp].getPerimeter())
                        {
                            temp = j;
                        }
                    }

                    Circle swapp = this.circles[i];
                    this.circles[i] = this.circles[temp];
                    this.circles[temp] = swapp;
                }

                return this.circles;
            }
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle(string color, bool filled, double width, double length)
        {
            this.color = color;
            this.filled = filled;
            this.width = width;
            this.length = length;
        }

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        public override double getArea()
        {
            return this.width * this.length;
        }

        public override double getPerimeter()
        {
            return 2 * (this.width + this.length);
        }

        public override string? ToString()
        {
            return $"Shape : {this.color} and {this.filled} \n" +
                $"Width = {this.width} \n" +
                $"Length = {this.length} \n" +
                $"Area Rectangle = {this.getArea()} \n" +
                $"Perimeter Rectangle = {this.getPerimeter()}";
        }
    }
}
