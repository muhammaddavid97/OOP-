using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class Static
    {
        /*
         * static adalah keyword yang digunakan untuk mendefinisikan method atau field pada class
         * agar field atau method tersebut menjadi milik class bukan milik instance.
         * sehingga method atau field yang dideklarasikan dengan static dapat diakses menggunakan
         * nama class nya tanpa harus membuat objek.
         * 
         * beberapa aturan yang perlu diperhatikan pada saat mendefinisikan method static
         * method static hanya dapat memanggil method yang juga static
         * method static hanya dapat mengakses data yang bersifat static
         * method static tidak dapat di inject melalui referensi this.
         */

        public static void main()
        {
            Console.WriteLine("Panjang : " + SegiEmpat6.Panjang);
            Console.WriteLine("Lebar : " + SegiEmpat6.Lebar);
            Console.WriteLine("Luas : " + SegiEmpat6.getLuas());
            Console.WriteLine("Keliling : " + SegiEmpat6.getKeliling());

            SegiEmpat6.Panjang = 10;
            SegiEmpat6.Lebar = 5;

            Console.WriteLine("Panjang : " + SegiEmpat6.Panjang);
            Console.WriteLine("Lebar : " + SegiEmpat6.Lebar);
            Console.WriteLine("Luas : " + SegiEmpat6.getLuas());
            Console.WriteLine("Keliling : " + SegiEmpat6.getKeliling());
        }
    }

    class SegiEmpat6
    {
        private static int panjang;
        private static int lebar;
        private int sisi;

        public static int Panjang { get => panjang; set => panjang = value; }
        public static int Lebar { get => lebar; set => lebar = value; }

        // Konstruktor static adalah konstruktor yang didefinisikan dengan menggunakan static. konstruktor static
        // dipanggil secara otomatis pada saat kelas dipanggil, sebelum konstraktor normal dipanggil.
        // konstruktor static hanya dapat dipanggil sekali ketika kelas digunakan.
        // konstruktor static tidak memiliki access modifier sehingga tidak dapat dipanggil secara eksplisit.
        static SegiEmpat6()
        {
            panjang = 11;
            lebar = 12;
        }

        // konstruktor normal
        public SegiEmpat6(int sisi)
        {
            this.sisi = sisi;
        }

        public static int getLuas()
        {
            return Panjang * Lebar;
        }

        public static int getKeliling()
        {
            return 2 * (Panjang + Lebar);
        }

        public int getLuasSisi()
        {
            return this.sisi * this.sisi;
        }
    }
}
