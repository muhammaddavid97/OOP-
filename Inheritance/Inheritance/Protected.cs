using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Protected
    {
        /*
         * Protected adalah salah satu tipe akses dimana data atau method yang dideklarasikan dengan tipe protected
         * hanya dapat diakses pada kelas itu sendiri dan kelas kelas lain yang merupakan turunannya.
         * 
         * 
         * Kelas lain yang bukan turunannya tidak dapat mengakses data atau method yang bersifat protected
         */

        public static void main()
        {
            // membuat instance dari kelas Person
            Person person = new Person();

            // person.displayName(); => error, karena method ini bersifat protected sehingga tidak dapat di akses.

            // membuat instance dari kelas Dosen
            Dosen dosen = new Dosen("wawan junardu");
            Console.WriteLine(dosen.ToString());

            // membuat instance dari kelas Student
            Student student = new Student("Kiki fatmawati");
            Console.WriteLine(student.ToString());
        }
    }

    class Person
    {
        protected string name;
        protected string Name { get => name; set => name = value; }

        protected void displayName()
        {
            Console.WriteLine("Nama : " + this.name);
        }
    }

    class Dosen : Person
    {
        public Dosen(string name)
        {
            this.name = name;
        }

        public override string? ToString()
        {
            return $"Nama Dosen : {Name}";
        }
    }

    class Student : Dosen
    {
        public Student(string name) : base(name)
        {
            this.name = name;
        }

        public override string? ToString()
        {
            return $"Nama Students : {Name}";
        }
    }
}
