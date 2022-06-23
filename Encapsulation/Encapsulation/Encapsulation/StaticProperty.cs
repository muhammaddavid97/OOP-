using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class StaticProperty
    {
        /*
         * Property dapat didefinikan dengan statis. property statis memiliki aturan sebagai berikut : 
         * 1. Acessor method tidak mengakses member kelas lain yang bersifat non-statis
         * 2. Property statis dapak diakses oleh method non-statis
         * 3. Property statis diakses menggunakan nama class nya bukan referensi
         */

        public static void main()
        {
            BangunDatar[] bangunDatars = new BangunDatar[]
            {
                new PersegiPanjang(10.4, 2.3),
                new Lingkaran(5.5)
            };

            foreach(var item in bangunDatars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class BangunDatar
    {
        public static double panjang { get; set; }
        public static double lebar { get; set; }
        public static double radius { get; set; }

        public virtual double hitungLuas()
        {
            return 0.0;
        }
        public virtual double hitungKeliling()
        {
            return 0.0;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        public PersegiPanjang(double panjang, double lebar)
        {
            BangunDatar.panjang = panjang;
            BangunDatar.lebar = lebar;
        }

        public override double hitungLuas()
        {
            return BangunDatar.panjang * BangunDatar.lebar;
        }

        public override double hitungKeliling()
        {
            return 2 * (BangunDatar.panjang + BangunDatar.lebar);
        }

        public override string? ToString()
        {
            return $"Panjang = {BangunDatar.panjang} \n" +
                $"Lebar = {BangunDatar.lebar} \n" +
                $"Luas persegi panjang = {this.hitungLuas()} \n" +
                $"Keliling persegi panjang = {this.hitungKeliling()}";
        }
    }

    class Lingkaran : BangunDatar
    {
        public Lingkaran(double radius)
        {
            BangunDatar.radius = radius;
        }

        public override double hitungLuas()
        {
            return Math.PI * (Math.Pow(BangunDatar.radius, 2));
        }

        public override double hitungKeliling()
        {
            return 2 * Math.PI * BangunDatar.radius;
        }

        public override string? ToString()
        {
            return $"Radius = {BangunDatar.radius} \n" +
                $"Luas lingkaran = {this.hitungLuas()} \n" +
                $"Keliling lingkaran = {this.hitungKeliling()}";
        }
    }
}
