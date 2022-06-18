using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_4
    {
        public static void main()
        {
            Person p = new Person();
            string nama = "david";

            Console.WriteLine("sebelum diubah");
            Console.WriteLine("Nama : " + nama);
            
            p.ubahNama(nama);

            Console.WriteLine("setelah diubah");
            Console.WriteLine("Nama : " + nama);
        }
    }

    class Person
    {
        public void ubahNama(string name)
        {
            name = "yusuf";

            Console.WriteLine("Tampil nama : ");
            Console.WriteLine("Nama saya : " + name);
        }
    }
}
