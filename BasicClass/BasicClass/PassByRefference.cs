using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class PassByRefference
    {
        // passbyRefference adalah kemampuan method untuk melewati parameter berdasarkan reference nya
        // sehingga method tersebut menjadikan parameter sebagai referensi.

        /*
         * karena yang disalin adalah referensinya bukan nilai yang ditunjuk dari referensi tersebut
         * maka referensi dari argumen dan referensi dari parameter akan merujuk ke alamat memori yang sama
         * sehingga perubahan pada parameter akan mempengaruhi perubahan pada argumen 
         */

        public static void main()
        {
            Example2 example = new Example2();
            int bil1 = 21, bil2 = 43;

            Console.WriteLine("Sebelum nilai ditukar");
            Console.WriteLine("bil1 : " + bil1);
            Console.WriteLine("bil2 : " + bil2);

            example.tukarBilangan(ref bil1, ref bil2);

            Console.WriteLine("setelah nilai ditukar");
            Console.WriteLine("bil1 : " + bil1);
            Console.WriteLine("bil2 : " + bil2);
        }
    }

    class Example2
    {

        // ref adalah keyword yang berfungsi untuk mengubah tipe nilai menjadi referensi
        public void tukarBilangan(ref int a, ref int b)
        {
            int swapp = a;
            a = b;
            b = swapp;

            Console.WriteLine("\nNilai di dalam parameter");
            Console.WriteLine("a  = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine();
        }
    }
}
