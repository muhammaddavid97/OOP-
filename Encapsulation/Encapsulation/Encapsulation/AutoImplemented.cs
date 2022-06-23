using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class AutoImplemented
    {
        /*
         * Property pada class dapat di definisikan tanpa implementasi.sehingga property seperti ini 
         * membutuhkan alokasi memory untuk menyimpan data yang ditampung property.
         * 
         * Pada property AutoImplemented kita tidak perlu mendifinisikan data secara eksplisit.
         
         */

        public static void main()
        {
            Person3 person3 = new Person3("muhammad", "david");

            Console.WriteLine(person3.ToString());
        }
    }

    class Person3
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person3(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string? ToString()
        {
            return $"Nama lengkap : {this.firstName} {this.lastName}";
        }
    }
}
