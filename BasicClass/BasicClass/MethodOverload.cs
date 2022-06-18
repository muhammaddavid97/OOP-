using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class MethodOverload
    {
        // method overload adalah method yang dideklarasikan lebih dari dua ata lebih dengan nama yang sama 
        // akan tetapi memiliki parameter yang berbeda.
        // Proses overload tidak dapat dilakukan hanya dengan membedakan tipe data kembalian method.
        // hal ini dapat mengakibatkan kesalahan program.

        // constructor overload adalah constructor yang dideklarasikan lebih dari dua akan tetapi parameter nya berbeda
        public static void main()
        {
            SegiEmpat4 se4 = new SegiEmpat4();
            SegiEmpat4 se42 = new SegiEmpat4(100);

            Console.WriteLine("luas bangun pertama : " + se4.hitungLuas(12, 11));
            Console.WriteLine("Luas bangun kedua : " + se4.hitungLuas(10.5, 5.5));

            Console.WriteLine("Luas Bujur Sangkar 1: " + se42.hitungBujurSangkar());
        }
    }

    class SegiEmpat4
    {
        private int panjang;
        private int lebar;

        public SegiEmpat4(int panjang, int lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        // constructor overload
        public SegiEmpat4(int sisi)
        {
            this.panjang = this.lebar = sisi;
        }

        public SegiEmpat4() : this(11, 21) { }

        public int hitungLuas(int p, int l)
        {
            int luas = 0;
            this.panjang = p;
            this.lebar = l;

            luas = this.panjang * this.lebar;

            return luas;
        }

        //overload 
        public double hitungLuas(double p, double l)
        {
            double luas = 0.0;

            this.panjang = (int)p;
            this.lebar = (int)l;

            luas = this.panjang * this.lebar;

            return luas;
        }

        public double hitungBujurSangkar()
        {
            double luas = 0;
            luas = (this.panjang * this.lebar);

            return luas;
        }
    }
}
