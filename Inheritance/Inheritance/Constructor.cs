using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Constructor
    {
        /*
         * Dalam suatu hierarki kelas, konstruktor yang pertama kali dipanggil pada saat pembuatan objek 
         * dari kelas turunannya adalah konstruktor dasar
         */

        public static void main()
        {
            Console.WriteLine("Ketika objek dari kelas A dibuat");
            A a = new A();

            Console.WriteLine("Ketika objek dari kelas B dibuat");
            B b = new B();

            Console.WriteLine("Ketika objek dari kelas C dibuat");
            C c = new C();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("konstruktor milik kelas A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("konstruktor milik kelas B");
        }
    }

    class C: B
    {
        public C()
        {
            Console.WriteLine("konstruktor milik kelas C");
        }
    }
}
