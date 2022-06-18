using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_6
    {
        public static void main()
        {
            Console.WriteLine("Luas : " + Circle.Luas);

            Circle.Radius = 100;
            Circle.Luas = Circle.Pi * Math.Pow(Circle.Radius, 2);
            Console.WriteLine("Radius lingkaran : " + Circle.Radius);
            Console.WriteLine("Luas lingkaran adalah " + Circle.Luas);
        }
    }

    class Circle
    {
        private static int radius;
        private static double pi = Math.PI;
        private static double luas;

        static Circle()
        {
            radius = 10;
            luas = pi * (radius * radius);
        }

        public static int Radius { get => radius; set => radius = value; }
        public static double Pi { get => pi; set => pi = value; }
        public static double Luas { get => luas; set => luas = value; }
    }
}
