using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ImplementationMultipleInterface
    {
        /*
         * Kelas dapat mengimplementasi lebih dari satu interface, dimana masing - masing interface dapat dipisahkan
         * menggunakan koma
         * 
         * Jika interface pertama dan kedua memiliki method yang sama maka kelas yang mengimplementasikan keduanya
         * dapat  mengimplementasikan method tersebut hanya satu kali.
         * 
         * JIka method yang sama pada kedua interface di implementasikan secara spesifik maka caranya kita harus
         * mendefinisikan method tersebut dengan nama dari interface masing - masing. kemudian untuk memanggil 
         * method tersebut harus menggunakan referensi dari interfacenya bukan referensi dari objek kelas 
         * yang mengimplementasikan interface tersebut.
         */

        public static void main()
        {
            Implementation implementation = new Implementation();

            implementation.TestPertama();
            implementation.TestKedua();
            implementation.sayHello();

            // membuat referensi dari tipe interface IPertama
            IPertama pertama = (IPertama) implementation;

            // membuat referensi dari tipe interface IKedua
            IKedua kedua = (IKedua) implementation;

            // memanggil method melalui referensi dari masing - masing interface
            pertama.name("jaenudin");
            kedua.name("david");
        }
    }

    interface IPertama
    {
        void TestPertama();
        void sayHello();
        void name(string name);
    }
    interface IKedua
    {
        void TestKedua();
        void sayHello();
        void name(string name);
    }

    class Implementation : IPertama, IKedua
    {
        public void TestPertama()
        {
            Console.WriteLine("Hello World");
        }

        public void TestKedua()
        {
            Console.WriteLine("Halo Dunia");
        }

        public void sayHello()
        {
            Console.WriteLine("Assalamualaikum lurr");
        }

       // implementasi method IPertama.name(string name)
       void IPertama.name(string name)
        {
            Console.WriteLine("Halo nama saya " + name);
        }

        // implementasi method IKedua.name(string name)
        void IKedua.name(string name) {
            Console.WriteLine("Halo lur arane isun " + name);
                
        }
    }
}
