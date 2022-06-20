using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MultipleInheritance
    {
        // MultipleInheritance adalah Proses penurunan kelas dimana kelas turunan dapat mewarisi lebih dari 
        // satu kelas dasar

       public static void main()
        {
            D1 d1 = new D1();

            d1.A2 = 10;
            d1.B2 = 20;
            d1.C2 = 30;
            d1.D2 = 40;

            Console.WriteLine("a = " + d1.A2);
            Console.WriteLine("b = " + d1.B2);
            Console.WriteLine("c = " + d1.C2);
            Console.WriteLine("d = " + d1.D2);
        }
    }

    class A1
    {
        private int A;

        public int A2 { get => A; set => A = value; }
    }

    class B1 : A1
    {
        private int B;

        public int B2 { get => B; set => B = value; }
    }

    class C1 : B1
    {
        private int C;

        public int C2 { get => C; set => C = value; }
    }

    class D1 : C1
    {
        private int D;
        public int D2 { get => D; set => D = value; }
    }
}
