using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Property
    {
        /*
         * Property adalah Penghubung antara data dan method dengan nama khusus yaitu set dan get.
         * 
         * Method set dan get didefinisikan didalam property yang disebut sebagai method acessor
         * 
         * Data didalam kelas itu idealnya bersifat private agar data tidak sembarang di akses secara langsung
         * diluar kelasnya akan tetapi data tersebut diakses melalui method acessor.
         */

        public static void main()
        {
            Person[] people = new Person[]{ 
                new Students("muhammad", "david", 23, "A1", 2015),
                new Person("Sulistya", "Wati", 13),
                new Dosen("Stikom Cirebon", "Jaringan Komputer", "Edi", "Rahmayadi", 33)
            };

            Person.SubClassPerson subClassPerson = new Person.SubClassPerson(people);
            
            Console.WriteLine("Menampilkan seluruh data");
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("Mencari dan menampilkan data berdasarkan nama");
            Console.WriteLine(subClassPerson.searchDataByName("Edi Rahmayadi"));
        }
       
    }

    class Person {

        private string firstName;
        private string lastName;
        private int age;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string? ToString()
        {
            return $"Nama legnkap : {this.firstName} {this.lastName} \n" +
                $"Usia : {this.age}";
        }

        // mendefinisikan inner class
        public class SubClassPerson
        {
            private Person[] persons;

            public SubClassPerson(Person[] persons)
            {
                this.persons = persons;
            }

            public Person searchDataByName(string targetName)
            {
                int len = persons.Length;

                for (int i = 0; i < len; i++)
                {
                    if (targetName == string.Concat(this.persons[i].firstName, " ", this.persons[i].lastName))
                    {
                        return persons[i];
                    }
                }

                return null;
            }
        }
    }

    class Students : Person
    {
        private string program;
        private int year;

        public Students(string firstName, string lastName, int age, string program, int year) : base(firstName, lastName, age)
        {
            this.program = program;
            this.year = year;
        }

        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }

        public override string? ToString()
        {
            return $"Nama lengkap murid: {FirstName} {LastName} \n" +
                $"Usia : {Age} \n" +
                $"Program : {this.program} \n" +
                $"Year : {this.year}";
        }
    }

    class Dosen : Person
    {
        private string universitas;
        private string matkul;

        public string Universitas { get => universitas; set => universitas = value; }
        public string Matkul { get => matkul; set => matkul = value; }

        public Dosen(string universitas, string matkul, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.universitas = universitas;
            this.matkul = matkul;
        }

        public override string? ToString()
        {
            return $"Nama lengkap dosen: {FirstName} {LastName} \n" +
                $"Usia : {Age} \n" +
                $"Universitas : {this.universitas} \n" +
                $"Mata kuliah : {this.matkul}";
        }
    }
}
