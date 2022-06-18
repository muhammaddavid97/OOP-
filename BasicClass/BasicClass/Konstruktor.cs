using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class Konstruktor
    {
        /*
         * Constructor adalah method yang memiliki nama yang sama persis dengan class 
         * Constructor adalah method yang dipanggil pertama kali ketika objek dibuat 
         * Constructor mengembalikan nilai object dari kelas yang sedan di instansiasi.
         * Jika suatu class tidak mendefinisikan constructor secara implisit maka C#
         * akan membuat default constructor (constructor tidak berparameter).
         
         */

        public static void main()
        {
            Rectangle re = new Rectangle();

            re.cetakLuas();
            Console.WriteLine("Keliling segitiga : " + re.cetakKeliling());
        }
    }

    class Rectangle
    {
        public double alas;
        public double tinggi;
        public double luas;
        public double keliling;

        // mendeklarasikan constructor 
        public Rectangle()
        {
            alas = 10;
            tinggi = 10;
        }

        public void cetakLuas()
        {
            luas = (0.5) * (alas * tinggi);

            Console.WriteLine("Luas : " + luas);
        }

        public double cetakKeliling()
        {
            keliling = 2 * (alas + tinggi);

            return keliling;
        }
    }
}
