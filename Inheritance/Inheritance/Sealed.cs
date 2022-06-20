using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sealed
    {
        /*
         * Sealed adalah keyword yang dijadikan sebagai modifier pada class atau method. dimana sealed memiliki 
         * fungsi sebagai berikut : 
         *  1. ketika diterapkan ke dalam method sealed mencegah agar method yang dideklarasikan di kelas dasar
         *     tidak dapat di override oleh kelas turunannya
         *  2. ketika di terpkan pada class sealed mencegah agar class tersebut tidak dapat diturunkan menjadi 
         *     kelas baru
         
         */

        public static void main()
        {
            C2 c2 = new C2();

            c2.F2();
            c2.F1();
        }
    }

    class A2
    {
        public virtual void F1()
        {
            Console.WriteLine("A.F1");
        }

        public virtual void F2()
        {
            Console.WriteLine("A.F2");
        }
    }

    class B2 : A2
    {
        // sealed method

        // F1 method tidak dapat di override oleh kelas turunannya
        sealed public override void F1()
        {
            Console.WriteLine("B.F2");
        }

        public override void F2()
        {
            Console.WriteLine("B.F2");
        }
    }

    class C2 : B2
    {
        // error, karena method ini didefinisikan sebagai sealed method di kelas dasar.
        /*public override void F1()
        {

        }*/

        public override void F2()
        {
            Console.WriteLine("C.F2");
        }
    }
}
