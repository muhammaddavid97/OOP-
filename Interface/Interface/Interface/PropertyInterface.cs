using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class PropertyInterface
    {
        /*
         * Interface juga dapat berisi property abstract, yaitu property yang tidak memiliki implementasi.
         * 
         * Property ini nantinya akan di override oleh kelas yang mengimplementasikan interface bersangkutan.
         
         */

        public static void main()
        {
            Karyawan karyawan = new Karyawan();

            karyawan.NIP = "14515212";
            karyawan.FullName = "Muhammad david";
            karyawan.Address = "Cirebon";
            karyawan.Age = 15;

            Console.WriteLine("Nama lengkap : " + karyawan.FullName);
            Console.WriteLine("NIP : " + karyawan.NIP);
            Console.WriteLine("Usia  : " + (karyawan.Age));
            Console.WriteLine("Alamat : " + karyawan.Address);
        }
    }

    interface IKaryawan
    {
        public string NIP { set; get; }
        public string FullName { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }
    }

    public class Karyawan : IKaryawan
    {
        private string nip;
        private string fullName;
        private int age;
        private string address;

        // implementasi property interface
        public string NIP { get => nip; set => nip = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }

    }
}
