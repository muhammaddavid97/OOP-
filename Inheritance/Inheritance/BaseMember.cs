using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseMember
    {
        public static void main()
        {
            Lingkaran lingkaran = new Lingkaran(21);
            Console.WriteLine(lingkaran.ToString());

            PersegiPanjang persegiPanjang = new PersegiPanjang(11, 10);
            Console.WriteLine(persegiPanjang.ToString());
        }
    }

    class BangunDatar
    {
        private int panjang;
        private int lebar;
        private int radius;

        public BangunDatar(int panjang, int lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        public BangunDatar(int radius)
        {
            this.radius = radius;
        }

        public virtual double getLuasPersegiPanjang()
        {
            double luas = this.panjang * this.lebar;

            return luas;
        }

        public virtual double getLuasLingkaran()
        {
            double luas = Math.PI * (Math.Pow(this.radius, 2));

            return luas;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        public PersegiPanjang(int panjang, int lebar) : base(panjang, lebar)
        {

        }

        public override double getLuasPersegiPanjang()
        {
            // base digunakan untuk mengakses method yang dimiliki oleh kelas dasar
            return base.getLuasPersegiPanjang();
        }

        public override string? ToString()
        {
            return $"Luas persegi panjang : {this.getLuasPersegiPanjang()}";
        }
    }

    class Lingkaran : BangunDatar
    {
        public Lingkaran(int radius) : base(radius)
        {
            
        }
        public override double getLuasLingkaran()
        {
            // base digunakan untuk mengakses method yang dimiliki oleh kelas dasar
            return base.getLuasLingkaran();
        }

        public override string? ToString()
        {
            return $"Luas Lingkaran : {this.getLuasLingkaran()}";
        }
    }
}
