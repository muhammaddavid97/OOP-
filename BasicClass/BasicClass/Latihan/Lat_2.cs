using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            Students[] students = new Students[]
            {
                new Students("agus", "yudhoyono", 32),
                new Students("izal", "ramli", 15),
                new Students("bambang", "sutejo", 23),
                new Students("kurniawan", "meiga", 11),
                new Students("opie", "kumis", 19)
            };

            // sorting data berdasarkan usia
            for (int i = 0; i < students.Length - 1; i++)
            {
                int temp = i; // menampung elemen terkecil

                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[j].Age < students[temp].Age)
                    {
                        temp = j;
                    }
                }

                int swapp = students[i].Age;
                students[i].Age = students[temp].Age;
                students[temp].Age = swapp;
            }

            Console.WriteLine("menampilkan data array : ");
            
            foreach(var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Students
    {
        private string firstName;
        private string lastName;
        private int age;

        public Students(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public int Age { get => age; set => age = value; }

        public override string? ToString()
        {
            return $"Nama lengkap : {this.firstName} {this.lastName} \n" +
                $"Usia : {this.age}";
        }
    }
}
