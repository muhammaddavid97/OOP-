using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_3
    {
        public static void main()
        {
            Bilangan bil = new Bilangan();

            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Sebelum elemen array ditukar");
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }

            bil.tukarBilangan(nums);

            Console.WriteLine("Setelah elemen array ditukar");
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Bilangan
    {
        // params => keyword yang digunakan untuk passing argumen lebih dari satu
        // artinya parameter yang didefinisikan dengan params dapat menerima4 argumen lebih dari satu
        public void tukarBilangan(int[] bil)
        {
            Console.WriteLine("Menampilkan isi array ");

            // proses pertukaran elemen array
            int indeksAwal = 0;
            int indeksAkhir = bil.Length - 1;

            while (bil[indeksAwal] != bil[indeksAkhir])
            {
                int swapp = bil[indeksAwal];
                bil[indeksAwal] = bil[indeksAkhir];
                bil[indeksAkhir] = swapp;

                indeksAwal += 1;
                indeksAkhir -= 1;
            }

            foreach(var item in bil)
            {
                Console.WriteLine(item);
            }
        }
    }
}
