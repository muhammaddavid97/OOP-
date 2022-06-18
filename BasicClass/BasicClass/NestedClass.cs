using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class NestedClass
    {
        /*
         * Nested class disebut juga inner class adalah class yang didefinisikan didalam block class lain 
         * inner class dapat mengenali semua field dan method milik class luar sekalipun bersifat private
         * akan tetapi field dan method milik inner class yang bersifat private tidak dapat diakses di class luar
         
         */

        public static void main()
        {
            // mendefinisikan instance dari objek Circle
            Circle circle = new Circle(10, Math.PI);

            Console.WriteLine("Radius kelas Circle : " + circle.Radius);
            Console.WriteLine("Luas dari kelas Circle = " + circle.getLuas());
            Console.WriteLine("Keliling dari kelas Circle = " + circle.getKeliling());

            // mendefinisikan instance dari objek LuasClass (Nested Class)
            Circle.LuasCircle luasCircle = new Circle.LuasCircle(new Circle(21, 3.14));

            Console.WriteLine("Radius dari kelas LuasCircle : " + luasCircle.Circle.Radius);
            Console.WriteLine("Luas dari kelas LuasCircle : " + luasCircle.getLuas());
            Console.WriteLine("Keliling dari kelas LuasCircle : " + luasCircle.getKeliling());

        }
    }

    // kelas bagian luar
    class Circle
    {
        private int radius;
        private double pi;

        public int Radius { get => radius; set => radius = value; }
        public double Pi { get => pi; set => pi = value; }

        // konstruktor kelas bagian luar
        public Circle(int radius, double pi)
        {
            this.radius = radius;
            this.pi = pi;
        }

        public double getLuas()
        {
            return this.Pi * Math.Pow(this.Radius, 2);
        }

        public double getKeliling()
        {
            return 2 * this.Pi * this.Radius;
        }

        // mendefinisikan class Dalam
        public class LuasCircle
        {

            private Circle circle;

            public Circle Circle { get => circle; set => circle = value; }

            public LuasCircle(Circle circle)
            {
                this.circle = circle;
            }
            public double getLuas()
            {
                return circle.Pi * (circle.Radius * circle.Radius);
            }

            public double getKeliling()
            {
                return 2 * circle.Pi * circle.Radius;
            }
        }
    }
}
