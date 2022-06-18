using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class Methods
    {
        // mendeklarasikan method utama 
        public static void main()
        {
            SegiEmpat2 se2 = new SegiEmpat2();

            se2.panjang = 10;
            se2.lebar = 15;

            se2.cetakLuas();

            // menampung method return ke dalam variable
            double keliling = se2.cetakKeliling();

            Console.WriteLine("Keliling segiempat : " + keliling);

            Rectangle2 re2 = new Rectangle2();

            re2.cetakLuas(11, 10);
            Console.WriteLine("keliling segitiga : " + re2.cetakKeliling(11, 10));
        }
    }

    class SegiEmpat2
    {
        public double panjang;
        public double lebar;

        /*
         * method adalah fungsi yang didefinisikan didalam class digunakan untuk melakukan 
         *tugas spesifik tertentu.
         *method dibagi menjadi 2 : 
         *  1. method tanpa nilai balik adalah method yang tidak mengembalikan nilai ditandai dengan keyword void
         *  2. method dengan nilai balik adalah method yang mengembalikan nilai.
         
         */

        // mendeklarasikan method void
        public void cetakLuas()
        {
            double luas;

            luas = panjang * lebar;

            Console.WriteLine("Luas segiempat : " + luas);
        }

        // mendeklarasikan method return
        public double cetakKeliling()
        {
            double keliling;

            keliling = 2 * (panjang + lebar);

            return keliling;
        }
    }

    class Rectangle2
    {
        public double alas;
        public double tinggi;
        public double luas;
        public double keliling;

        /*
         * parameter adalah nilai yang dimasukan ke dalam body method
         * parameter dibagi menjadi 2 : 
         *  1. parameter formal adalah parameter yang digunakan dalam pendefinisian method 
         *  2. parameter aktual atau argumen adalah parameter yang disertakan pada saat pemanggilan method
         
         */
        public void cetakLuas(double a, double t)
        {
            alas = a;
            tinggi = t;

            luas = (0.5) * (alas * tinggi);

            Console.WriteLine("Luas segitiga : " + luas);
        }

        public double cetakKeliling(double a, double t)
        {
            alas = a;
            tinggi = t;

            keliling = 2 * (alas + tinggi);

            return keliling;
        }
    }
}
