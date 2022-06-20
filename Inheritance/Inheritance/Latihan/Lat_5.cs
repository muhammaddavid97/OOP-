using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Latihan
{
    public class Lat_5
    {
        public static void main()
        {
            Student student = new Student("Muhammad david", "Cirebon Barat", "A2", 2015, 10.5);
            Console.WriteLine(student.displayData());
        }
    }

    class Person2
    {
        private string name;
        private string address;

        protected string Name { get => name; set => name = value; }
        protected string Address { get => address; set => address = value; }

        public Person2(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public virtual string displayData()
        {
            return $"Nama : {this.name} \n" +
                $"Alamat : {this.address}";
        }
    }

    class Student : Person2
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Fee { get => fee; set => fee = value; }

        public override string displayData()
        {
            return $"{base.displayData()} \n" +
                $"Program : {this.program} \n" +
                $"Year : {this.year} \n" +
                $"Fee : {this.fee}";
        }
    }
}
