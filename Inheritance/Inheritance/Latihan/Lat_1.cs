using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Latihan
{
    public class Lat_1
    {
        
        public static void main()
        {
            // mendefinisikan instance dari kelas BangunDatar
            BangunDatar bangunDatar = new BangunDatar(11, 11);
            Console.WriteLine(bangunDatar.Panjang);

            // mendefinisikan instance dari kelas PersegiPanjang
            PersegiPanjang persegiPanjang = new PersegiPanjang(10, 10);

            Console.WriteLine(persegiPanjang.ToString());
        }
    }

    class BangunDatar
    {
        private int panjang;
        private int lebar;

        public int Panjang { get => panjang; set => panjang = value; }
        public int Lebar { get => lebar; set => lebar = value; }

        public BangunDatar(int panjang, int lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        public PersegiPanjang(int panjang, int lebar) : base(panjang, lebar)
        {

        }

        public int getLuas()
        {
            return this.Panjang * this.Lebar;
        }

        public int getKeliling()
        {
            return 2 * (this.Panjang + this.Lebar);
        }

        public override string? ToString()
        {
            return $"Panjang = {this.Panjang} \n" +
                $"Lebar = {this.Lebar} \n" +
                $"Luas = {this.getLuas()} \n" +
                $"Keliling = {this.getKeliling()}";
        }
    }
}
