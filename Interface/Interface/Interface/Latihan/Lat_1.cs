using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            Person[] persons = new Person[] {
                new Students("A2", 3.54, "Muhammad", "David", 21),
                new Students("A1", 2.54, "Rizky", "Ramadhani",17),
                new Students("A3", 4.00, "Ezra", "Jaenudin", 12),
                new Dosen("Universitas Indonesia", "Matematika Diskrit", "Dadan", "Kurniawan", 32),
                new Dosen("Stikom Cirebon", "Logika Informatika", "Jaenudin", "Soleh", 29)
            };

            Person person = new Person(persons);

            foreach(var item in person.sortData())
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Menampilkan data berdasarkan nama ");
            Console.WriteLine(person.searchDataByName("Ezra Jaenudin").ToString());
        }
    }

    // mendefinisikan interface
    interface IGetData
    {
        Person[] sortData();
        Person searchDataByName(string name);
    }

    // mendefinisikan kelas dasar
    class Person : IGetData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private Person[] persons;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(Person[] persons) {
            this.persons = persons;
        }

        // mengimplementasikan method dari Interface
        public Person[] sortData()
        {
            for (int i = 0; i < this.persons.Length - 1; i++)
            {
                int temp = i;

                for (int j = i + 1; j < this.persons.Length; j++)
                {
                    if (this.persons[j].Age < this.persons[temp].Age)
                    {
                        temp = j;
                    }
                }

                Person swapp = this.persons[i];
                this.persons[i] = this.persons[temp];
                this.persons[temp] = swapp;
            }

            return this.persons;
        }
        public Person searchDataByName(string name)
        {
            for (int i = 0; i < this.persons.Length; i++)
            {
                if (name == string.Concat(this.persons[i].FirstName, " ", this.persons[i].LastName))
                {
                    return this.persons[i];
                }
            }

            return null;
        }
        public override string? ToString()
        {
            return $"Nama lengkap : {this.FirstName} {this.LastName} \n" +
                $"Usia : {this.Age}";
        }
    }

    class Students : Person
    {
        public string Program { get; set; }
        public double ScoreTest { get; set; }

        private Person[] persons;
        public Students(string program, double scoreTest, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.Program = program;
            this.ScoreTest = scoreTest;
        }

        public Students(Person[] persons) : base(persons)
        {
            this.persons = persons;
        }
        public override string? ToString()
        {
            return $"Nama lengkap : {this.FirstName} {this.LastName} \n" +
                $"Usia : {this.Age} \n" +
                $"Program : {this.Program} \n" +
                $"SCore Test : {this.ScoreTest}";
        }
    }

    class Dosen : Person
    {
        public string Universitas { get; set; }
        public string Matkul { get; set; }

        public Dosen(string universitas, string matkul, string firstName, string lastName, int age) : base(firstName, lastName, age){
            this.Universitas = universitas;
            this.Matkul = matkul;
        }

        public override string? ToString()
        {
            return $"Nama lengkap : {this.FirstName} {this.LastName} \n" +
                $"Usia : {this.Age} \n" +
                $"Universitas : {this.Universitas} \n" +
                $"Mata Kuliah : {this.Matkul}";
        }
    }
}
