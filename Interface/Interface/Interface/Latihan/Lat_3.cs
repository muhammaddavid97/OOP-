using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Latihan
{
    public class Lat_3
    {
        public static void main()
        {
            GeometricObject[] geometricObjects = new GeometricObject[]
            {
                new Circle(10.5),
                new Circle(5.5),
                new Rectangle(4.5, 2.5),
                new Rectangle(3.5, 2.0)
            };

            // membuat referensi dari kelas SubClass
            Circle.SubClass subClass = new Circle.SubClass(geometricObjects);

            foreach(var item in subClass.sortData())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    interface GeometricObject
    {
        double getArea();
        double getPerimeter();
    }

    class Circle : GeometricObject
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * (Math.Pow(this.radius, 2));
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }

        public override string? ToString()
        {
            return $"Radius = {this.radius} \n" +
                $"Luas lingkaran = {this.getArea()} \n" +
                $"Keliling lingkaran = {this.getPerimeter()}";
        }

        public class SubClass
        {
            private GeometricObject[] geometricObjects1;

            public SubClass(GeometricObject[] geometricObjects1)
            {
                this.geometricObjects1 = geometricObjects1;
            }

            public GeometricObject[] sortData()
            {
                for (int i = 0; i < this.geometricObjects1.Length - 1; i++)
                {
                    for (int j = i + 1; j < this.geometricObjects1.Length; j++)
                    {
                        if (this.geometricObjects1[j].getArea() < this.geometricObjects1[i].getArea() && this.geometricObjects1[j].getPerimeter() < this.geometricObjects1[i].getPerimeter())
                        {
                            GeometricObject swapp = this.geometricObjects1[i];
                            this.geometricObjects1[i] = this.geometricObjects1[j];
                            this.geometricObjects1[j] = swapp;
                        }
                    }
                }

                return this.geometricObjects1;
            }
        }
    }

    class Rectangle : GeometricObject
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public double getArea()
        {
            return this.width * this.length;
        }

        public double getPerimeter()
        {
            return 2 * (this.width + this.length);
        }

        public override string? ToString()
        {
            return $"Panjang = {this.length} \n" +
                $"Lebar = {this.width} \n" +
                $"Luas persegi panjang = {this.getArea()} \n" +
                $"Keliling persegi panjang = {this.getPerimeter()}";
        }
    }
}
