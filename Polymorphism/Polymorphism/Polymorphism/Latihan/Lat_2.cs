using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(5.5, "red", false),
                new Circle(3.2, "blue", true),
                new Circle(1.4, "yellow", false)
            };

            // membuat instance dari inner class kelas Circle
            Circle.SubClassCircle subClassCircle = new Circle.SubClassCircle(shapes);

            // GET
            Console.WriteLine("Menampilkan data secara terurut");
            foreach(var item in subClassCircle.sortData())
            {
                Console.WriteLine($"Color {item.Color}");
                Console.WriteLine($"Filled : {item.Filled}");
                Console.WriteLine($"Luas lingkaran : {item.getArea()}");
                Console.WriteLine($"Keliling lingkaran : {item.getPerimeter()}");
            }

            // Search 
            Console.WriteLine("Mencari dan menampilkan data berdasarkan warna");
            Console.WriteLine($"Color {subClassCircle.searchData("blue").Color}");
            Console.WriteLine($"Filled : {subClassCircle.searchData("blue").Filled}");
            Console.WriteLine($"Luas lingkaran : {subClassCircle.searchData("blue").getArea()}");
            Console.WriteLine($"Keliling lingkaran : {subClassCircle.searchData("blue").getPerimeter()}");

        }
    }

    abstract class Shape
    {
        protected string color;
        protected bool filled;

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public abstract double getArea();
        public abstract double getPerimeter();
    }

    class Circle : Shape
    {
        private double radius = 1.0;

        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
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
            private Shape[] shapes;

            public SubClassCircle(Shape[] shapes)
            {
                this.shapes = shapes;
            }

            // method to sort data
            public Shape[] sortData()
            {
                int len = this.shapes.Length;

                for (int i = 0; i < len - 1; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (this.shapes[j].getArea() < this.shapes[i].getArea() && this.shapes[j].getPerimeter() < this.shapes[i].getPerimeter())
                        {
                           Shape temp = this.shapes[i];
                           this.shapes[i] = this.shapes[j];
                           this.shapes[j] = temp;
                        }
                    }
                }

                return this.shapes;
            }

            // method to search data
            public Shape searchData(string targets)
            {

                for (int i = 0; i < this.shapes.Length; i++)
                {
                    if (targets == this.shapes[i].Color)
                    {
                        return this.shapes[i];
                    }
                }

                return null;
            }
        }
    }

    class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle(double width, double length, string color, bool filled)
        {
            this.width = width;
            this.length = length;
            this.color = color;
            this.filled = filled;
        }

        public override double getArea()
        {
            return this.width * this.length;
        }

        public override double getPerimeter()
        {
            return 2 * (this.width + this.length);
        }
    }
}
