using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class ReturnObject
    {
        public static void main()
        {
            Person[] persons = new Person[]
            {
                new Person("afif", 32, "dokter"),
                new Person("yusuf", 13, "pelajar")
            };

            foreach(var item in persons)
            {
                Console.WriteLine(item.ToString());
            }

            Person person = new Person();
            Console.WriteLine(person.printPerson().ToString());
        }
    }
    class Person
    {
        private string fullName;
        private int age;
        private string jobs;

        public Person(string fullName, int age, string jobs)
        {
            this.fullName = fullName;
            this.age = age;
            this.jobs = jobs;
        }

        public Person() { }

        // mendefinisikan method yang mengembalikan tipe objek 
        public Person printPerson()
        {
            Person person;

            person = new Person("jony", 21, "dosen");

            return person;
        }

        public override string? ToString()
        {
            return $"Nama lengkap : {this.fullName} \n" +
                $"Usia : {this.age} \n" +
                $"Jobs : {this.jobs}";
        }

        
    }
}
