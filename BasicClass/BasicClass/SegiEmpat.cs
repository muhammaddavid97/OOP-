using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{

    // class adalah pola atau blueprint yang merepresentasikan suatu objek tertentu.
    public class SegiEmpat
    {
        // Data atau field adalah merepresentasikan suatu variable yang didefinisikan didalam class
        // field digunakan untuk menyimpan sebuah nilai.
        public double panjang;
        public double lebar;
    }

    // membuat kelas utama
    class DemoKelas
    {
        public static void main()
        {
            // instansiasi adalah proses yang menggambarkan pembuatan suatu objek.
            // reference adalah variable yang menunjuk ke suatu objek tertentu
            // keyword new digunakan ketika objek akan dibuat.

            // mendefinisikan instance dari kelas SegiEmpat
            SegiEmpat se = new SegiEmpat();

            se.panjang = 10;
            se.lebar = 12;

            double luas = 0;

            luas = se.panjang * se.lebar;

            Console.WriteLine("Luas segiempat adalah " + luas);


        }
    }
}
