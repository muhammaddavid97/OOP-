using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Basic
    {
        /*
         * Polymorphism dalam pemrograman berorientasi objek polymorphism memilik arti banyak bentuk
         * yaitu kemampuan suatu objek (lebih tepatnya referensi) untuk mengungkap banyak hal melalui 
         * satu cara yang sama.
         * 
         * Dalam hal ini polymorphism mengizinkan kita untuk mendefinisikan satu referensi dengan tipe 
         * kelas dasar lalu referensi tersebut dapat menunjuk ke semua objek kelas turunan yang berbeda.
         */

        public static void main()
        {
            Bunglon bunglon;

            bunglon = new Daun();
            bunglon.ubahWarna();

            bunglon = new Pohon();
            bunglon.ubahWarna();

        }
    }

    abstract class Bunglon
    {
        public abstract void ubahWarna();
    }

    class Daun : Bunglon
    {
        public override void ubahWarna()
        {
            Console.WriteLine("Hijau");
        }
    }

    class Pohon : Bunglon
    {
        public override void ubahWarna()
        {
            Console.WriteLine("Coklat");
        }
    }
}
