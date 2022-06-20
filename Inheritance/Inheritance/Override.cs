using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Override
    {
        /*
         * Override adalah proses dimana sebuah method yang didefinisikan di kelas dasar dapat di modifikasi
         * atau diperbarui sifatnya didalam kelas turunan.
         * 
         * Dalam proses override method yang didefinisikan didalam class turunan harus memiliki nama dan parameter 
         * yang sama seperti yang didefinisikan di dalam class dasar.
         */

        public static void main()
        {
            KelasTurunan kelasTurunan = new KelasTurunan();

            kelasTurunan.test();
        }
    }

    class KelasDasar
    {
        // override

        // virtual adalah keyword yang didefinisikan pada method kelas dasar
        // agar method tersebut dapat di override di dalam kelas turunannya.

        public virtual void test()
        {
            Console.WriteLine("Method ini milik kelas dasar ");
        }
    }

    class KelasTurunan : KelasDasar
    {
        // override

        // override adalah keyword yang didefinisikan pada method kelas turunan
        // agar dapat melakukan proses override

        public override void test()
        {
            Console.WriteLine("Method ini milik kelas turunan");
        }
    }
}
