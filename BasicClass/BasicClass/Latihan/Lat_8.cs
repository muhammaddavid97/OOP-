using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_8
    {
        public static void main()
        {
            // mendefinisikan instance dari kelas Person2
            Person2[] listPersons = new Person2[]
            {
                new Person2("jajang", "nurjaman", 31),
                new Person2("erik", "thohir", 12),
                new Person2("jokowi", "karminas",5)
            };

            // mendefinisikan instance dari inner kelas SortingClass
            Person2.SortingPerson2 sortingPerson2 = new Person2.SortingPerson2(listPersons);

            foreach(var item in sortingPerson2.sortingData())
            {
                Console.WriteLine($"Nama lengkap : {item.FirstName} {item.LastName}");
                Console.WriteLine($"Usia : {item.Age}");
            }
        }
    }

    // mendefinisikan class luar
    class Person2
    {
        private string firstName;
        private string lastName;
        private int age;

        // mendefinisikan constructor outter class
        public Person2(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        // mendefinisikan inner class
        public class SortingPerson2
        {
            private Person2[] person2;

            public SortingPerson2(Person2[] person2)
            {
                this.person2 = person2;
            }

            // method ini akan melakukan sorting data berdasarkan usia
            public Person2[] sortingData()
            {
                int len = this.person2.Length;

                for (int i = 0; i < len - 1; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (this.person2[j].Age < this.person2[i].Age)
                        {
                            Person2 swapp = this.person2[i];
                            this.person2[i] = this.person2[j];
                            this.person2[j] = swapp;
                        }
                    }
                }

                return this.person2;
            }

        }
    }
}
