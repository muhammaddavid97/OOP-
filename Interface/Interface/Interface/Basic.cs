using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Basic
    {
        /*
         * Interface adalah Suatu tipe yang didalamnya berisi semua method yang bersifat abstract kemudian method
         * method tersebut harus di implementasikan / override pada kelas yang mengimplementasikan interface yang bersangkutan
         *
         * Interface tidak mengizinkan kita untuk membuat objek serta semua method didalamnya wajib didefinisikan 
         * sebagai abstract.
         * 
         * Method didalam interface secara implisit akan bersifat abstract oleh compiler C# sehingga tidak perlu
         * menyertakan keyword abstract.
         */

        public static void main()
        {
            // membuat objek dari kelas PersegiPanjang
            PersegiPanjang persegiPanjang = new PersegiPanjang(11.2, 21.5);
            Console.WriteLine(persegiPanjang.ToString());

            // membuat objek dari kelas Lingkaran
            Lingkaran lingkaran = new Lingkaran(5.5);
            Console.WriteLine(lingkaran.ToString());
        }
    }

    // mendefinisikan interface
    interface IBangunDatar
    {
        double HitungLuas();
        double HitungKeliling();
    }

    class PersegiPanjang : IBangunDatar
    {
        private double panjang;
        private double lebar;

        public PersegiPanjang(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        public double Panjang { get => panjang; set => panjang = value; }
        public double Lebar { get => lebar; set => lebar = value; }

        // implementasi method interface
        public double HitungLuas()
        {
            return this.panjang * this.lebar;
        }

        public double HitungKeliling()
        {
            return 2 * (this.panjang + this.lebar);
        }

        public override string? ToString()
        {
            return $"Panjang = {this.panjang} \n" +
                $"Lebar = {this.lebar} \n" +
                $"Luas persegi panjang = {this.HitungLuas()} \n" +
                $"Keliling persegi panjang = {this.HitungKeliling()}";
        }
    }

    class Lingkaran : IBangunDatar
    {
        private double radius;

        public Lingkaran(double radius)
        {
            this.radius = radius;
        }
        public double Radius { get => radius; set => radius = value; }

        public double HitungLuas()
        {
            return Math.PI * (Math.Pow(this.radius, 2));
        }

        public double HitungKeliling()
        {
            return 2 * Math.PI * (this.radius);
        }

        public override string? ToString()
        {
            return $"Radius = {this.radius} \n" +
                $"Luas lingkaran = {this.HitungLuas()} \n" +
                $"Keliling lingkaran = {this.HitungKeliling()}";
        }
    }
}
