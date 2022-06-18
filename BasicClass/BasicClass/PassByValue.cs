using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class PassByValue
    {
        // pass by value => kemampuan yang dimiliki suatu method untuk melewati argumen berdasarkan
        // tipe nilainya. sehingga perubahan yang terjadi pada parameter tidak akan mempengaruhi nilai 
        // pada argumen
        
        public static void main()
        {
            Example exam = new Example();

            int bil1 = 10, bil2 = 20;

            Console.WriteLine("Sebelum nilai ditukar");
            Console.WriteLine("bil1 : " + bil1);
            Console.WriteLine("bil2 : " + bil2);

            exam.tukarNilai(bil1, bil2);

            // karena a dan bil1 dan b dan bil2 merupakan dua variable yang berbeda
            // maka masing masing menempati alamat memori yang terpisah.
            // sehingga perubahan nilai pada variable a tidak mempengaruhi variable bil1
            // begitu juga dengan variable b dan bil2
            Console.WriteLine("setelah nilai ditukar");
            Console.WriteLine("bil1 : " + bil1);
            Console.WriteLine("bil2 : " + bil2);

        }
    }

    class Example
    {
        public void tukarNilai(int a, int b)
        {
            int swapp = a;
            a = b;
            b = swapp;

            Console.WriteLine("\nNilai di dalam Method");
            Console.WriteLine("a  = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine();
        }
    }
}
