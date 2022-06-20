using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            PersegiPanjang2[] persegiPanjang2 = new PersegiPanjang2[]
            {
                new PersegiPanjang2(21, 11),
                new PersegiPanjang2(22, 12),
                new PersegiPanjang2(23, 13)
            };

            foreach(var item in persegiPanjang2)
            {
                Console.WriteLine("Luas Persegi Panjang : " + item.getLuas());
                Console.WriteLine("Keliling Persegi Panjang : " + item.getKeliling());
            }

            Balok[] balok = new Balok[]
            {
                new Balok(21, 11, 10),
                new Balok(22, 12, 11),
                new Balok(23, 13, 12)
            };

            foreach(var item in balok)
            {
                Console.WriteLine("Volume : " + item.getVolume());
            }
        }
    }

    class SegiEmpat
    {
        protected int panjang;
        protected int lebar;

        public SegiEmpat(int panjang, int lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }
    }

    class PersegiPanjang2 : SegiEmpat
    {
        public PersegiPanjang2(int panjang, int lebar) : base(panjang, lebar)
        {

        }

        public double getLuas()
        {
            double luas = 0.0;
            luas = this.panjang * this.lebar;

            return luas;
        }

        public double getKeliling()
        {
            double keliling;
            keliling = 2 * (this.panjang + this.lebar);

            return keliling;
        }
    }

    class Balok : PersegiPanjang2
    {
        private int tinggi;

        public Balok(int panjang, int lebar, int tinggi) : base(panjang, lebar)
        {
            this.tinggi = tinggi;
        }

        public double getVolume()
        {
            double volume;
            volume = this.panjang * this.lebar * this.tinggi;

            return volume;
        }
    }
}
