using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class PropertyOverride
    {
        public static void main() {
            BangunDatar2[] bangunDatar2s = new BangunDatar2[]
            {
                new PersegiPanjang2(10.5, 1.5),
                new PersegiPanjang2(5.5, 2.5),
                new Lingkaran2(5.5)
            };

            foreach(var item in bangunDatar2s)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("Luas = " + item.Luas);
                Console.WriteLine("Keliling = " + item.Keliling);
            }
        }
    }

    abstract class BangunDatar2
    {
        public abstract double Luas { get; }
        public abstract double Keliling { get; }
    }

    class PersegiPanjang2 : BangunDatar2
    {
        private double panjang;
        private double lebar;
        public PersegiPanjang2(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }
        public override double Luas { get { return this.panjang * this.lebar; } }
        public override double Keliling { get { return 2 * (this.panjang + this.lebar); } }

        public override string? ToString()
        {
            return $"Panjang = {this.panjang} \n" +
                $"Lebar = {this.lebar}";
        }
    }

    class Lingkaran2 : BangunDatar2
    {
        private double radius;
        public Lingkaran2(double radius)
        {
            this.radius = radius;
        }

        public override double Luas { get { return Math.PI * (Math.Pow(this.radius, 2)); } }
        public override double Keliling { get { return 2 * Math.PI * this.radius; } }

        public override string? ToString()
        {
            return $"Radius = {this.radius}";
        }
    }
}
