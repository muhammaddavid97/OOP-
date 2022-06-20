using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Latihan
{
    public class Lat_3
    {
        public static void main()
        {
            Dosen dosen = new Dosen("Muhammad yusuf", 26, "Sende", 1000000.0, 500000.0);
            Console.WriteLine(dosen.ToString());
        }
    }

    class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }

    class Students : Person
    {
        private string address;
        public string Address { get => address; set => address = value; }
    }

    class Dosen : Students
    {
        private double gajiPokok;
        private double tunjangan;

        public Dosen(string name, int age, string address, double gajiPokok, double tunjangan) {
            Name = name;
            Age = age;
            Address = address;
            this.gajiPokok = gajiPokok;
            this.tunjangan = tunjangan;
        }

        public double totalGaji()
        {
            return this.gajiPokok + this.tunjangan;
        }

        public override string? ToString()
        {
            return $"Nama dosen : {Name} \n" +
                $"Usia : {Age} \n" +
                $"Alamat : {Address} \n" +
                $"Gaji Pokok : {this.gajiPokok} \n" +
                $"Tunjangan : {this.tunjangan} \n" +
                $"Total Gaji : {this.totalGaji()}";
        }
    }
}
