using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            Person[] persons = new Person[] {
                new Student("muhammad david", "sende", "A2", 2013, 5.5),
                new Student("eko yulanto", "bulak", "A1", 2018, 10.5),
                new Staff("ijon simbolon", "junjang", "smpn 1 arjawinangun", 10.500),
                new Staff("erik chandra", "winong", "sman 1 sende", 11.000)
            };

            foreach(var item in persons)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public Person() { }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }

    class Student : Person
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

        public override string? ToString()
        {
            return $"Name Student: {this.name} \n" +
                $"Address Student : {this.address} \n" +
                $"Year : {this.year} \n" +
                $"Program : {this.program} \n" +
                $"Fee : {this.fee}";
        }
    }

    class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string School { get => school; set => school = value; }
        public double Pay { get => pay; set => pay = value; }

        public override string? ToString()
        {
            return $"Name Staff: {this.name} \n" +
                $"Address Staff : {this.address} \n" +
                $"School : {this.school} \n" +
                $"Pay : {this.pay}";
        }
    }
}
