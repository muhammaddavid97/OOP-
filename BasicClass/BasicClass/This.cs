using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class This
    {
        // this adalah keyword yang digunakan untuk mengakses field, constructor atau method pada object saat ini
        // keyword this dapat membedakan antara field dan parameter agar parameter tidak menimpa field milik object
        
        public static void main()
        {
            People people = new People("Muhammad", "David", 21);
            
            Console.WriteLine(people.printPeople());
        }
    }

    class People
    {
        public string firstName;
        public string lastName;
        public int age;

        public People(string firstName, string lastName, int age)
        {
            // this digunakan untuk mengakses field pada object saat ini
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string printPeople()
        {
            return $"Nama lengkap : {this.firstName} {this.lastName} \n" +
                $"Usia : {this.age}";
        }
   }
}
