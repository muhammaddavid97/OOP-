using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            // membuat objek dari kelas Lingkaran
            Lingkaran lingkaran = new Lingkaran(5.5);

            // membuat objek dari kelas PersegiPanjang 
            PersegiPanjang persegiPanjang = new PersegiPanjang(10.5, 2.5);

            // membuat referensi dari interface IBangunDatar

            // casting ke type interface 
            IBangunDatar bangunDatar = (IBangunDatar)lingkaran; 

            Console.WriteLine("Luas lingkaran : " + bangunDatar.hitungLuas());
            Console.WriteLine("Luas lingkaran : " + lingkaran.ToString());

        }
    }

    interface IBangunDatar
    {
        double hitungLuas();
    }

    class Lingkaran : IBangunDatar
    {
        public double Radius { get; set; }

        public Lingkaran(double radius)
        {
            this.Radius = radius;
        }

        public double hitungLuas()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }

        public override string? ToString()
        {
            return $"Radius : {this.Radius} \n" +
                $"Luas lingkaran : {this.hitungLuas()}";
        }
    }

    class PersegiPanjang : IBangunDatar
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }

        public PersegiPanjang(double panjang, double lebar)
        {
            this.Panjang = panjang;
            this.Lebar = lebar;
        }

        public double hitungLuas()
        {
            return this.Panjang * this.Lebar;
        }

        public override string? ToString()
        {
            return $"Panjang : {this.Panjang} \n" +
                $"Lebar : {this.Lebar} \n" +
                $"Luas persegi panjang : {this.hitungLuas()}";
        }
    }
}
