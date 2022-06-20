using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Latihan
{
    public class Lat_4
    {
        public static void main()
        {
            PersegiPanjang3[] persegiPanjang3 = new PersegiPanjang3[]
            {
                new PersegiPanjang3(10.5, 11.5),
                new PersegiPanjang3(5, 3.5),
                new PersegiPanjang3(5.5, 4.5)
            };

            Lingkaran3[] lingkaran3 = new Lingkaran3[]
            {
                new Lingkaran3(11.5),
                new Lingkaran3(5.5),
                new Lingkaran3(10.5)
            };

            // menampilkan data dari kelas PersegiPanjang3
            foreach(var item in persegiPanjang3)
            {
                Console.WriteLine(item.ToString());
            }

            // menampilkan data dari kelas Lingkaran3
            foreach(var item in lingkaran3)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class BangunDatar3
    {
        protected double panjang;
        protected double lebar;
        protected double radius;

        public BangunDatar3(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        public BangunDatar3(double radius)
        {
            this.radius = radius;
        }

        // override
        public virtual double getLuas()
        {
            return 0.0;
        }

        // override
        public virtual double getKeliling()
        {
            return 0.0;
        }
    }

    class PersegiPanjang3 : BangunDatar3
    {
        public PersegiPanjang3(double panjang, double lebar) : base(panjang, lebar)
        {

        }

        // override
        public override double getLuas()
        {
            return this.panjang * this.lebar;
        }

        // override

        public override double getKeliling()
        {
            return 2 * (this.panjang + this.lebar);
        }

        public override string? ToString()
        {
            return $"Panjang : {this.panjang} \n" +
                $"Lebar : {this.lebar} \n" +
                $"Luas persegi panjang : {this.getLuas()} \n" +
                $"Keliling persegi panjang : {this.getKeliling()}";
        }
    }

    class Lingkaran3 : BangunDatar3
    {
        public Lingkaran3(double radius) : base(radius)
        {

        }

        // override 
        public override double getLuas()
        {
            return Math.PI * (Math.Pow(this.radius, 2));
        }

        // override 

        public override double getKeliling()
        {
            return 2 * Math.PI * this.radius;
        }

        public override string? ToString()
        {
            return $"Luas lingkaran : {this.getLuas()} \n" +
                $"Keliling lingkaran : {this.getKeliling()}";
        }
    }
}
