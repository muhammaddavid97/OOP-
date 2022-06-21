using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Latihan
{
    public class Lat_1
    {        
        public static void main()
        {
            SegiEmpat segiEmpat1, segiEmpat2;

            // membuat instance dari kelas PersegiPanjang
            PersegiPanjang persegiPanjang = new PersegiPanjang(10.2, 5.5);
            segiEmpat1 = persegiPanjang;

            Console.WriteLine(segiEmpat1.ToString());

            // membuat instance dari kelas Lingkaran
            Lingkaran lingkaran = new Lingkaran(5.5);
            segiEmpat2 = lingkaran;

            Console.WriteLine(segiEmpat2.ToString());
        }
    }

    abstract class SegiEmpat
    {
        public abstract double getLuas();
        public abstract double getKeliling();
    }

    class PersegiPanjang : SegiEmpat
    {
        private double panjang;
        private double lebar;

        public PersegiPanjang(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        public override double getLuas()
        {
            return this.panjang * this.lebar;
        }

        public override double getKeliling()
        {
            return 2 * (this.panjang * this.lebar);
        }

        public override string? ToString()
        {
            return $"Panjang = {this.panjang} \n" +
                $"Lebar = {this.lebar} \n" +
                $"Luas Persegi Panjang = {this.getLuas()} \n" +
                $"Keliling Persegi Panjang = {this.getKeliling()}";
        }
    }

    class Lingkaran : SegiEmpat
    {
        private double radius;

        public Lingkaran(double radius)
        {
            this.radius = radius;
        }

        public override double getLuas()
        {
            return Math.PI * (Math.Pow(this.radius, 2));
        }

        public override double getKeliling()
        {
            return 2 * Math.PI * this.radius;
        }

        public override string? ToString()
        {
            return $"Radius = {this.radius} \n" +
                $"Luas Lingkaran : {this.getLuas()} \n" +
                $"Keliling Lingkaran : {this.getKeliling()}";
        }
    }
}
