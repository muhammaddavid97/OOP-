using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class ReadWriteOnly
    {
        /*
         * Suatu property dapat dijadikan sebagai read only (hanya dapat dibaca) dan write only (hanya dapat ditulis)
         * 
         * Propery Read-Only adalah property yang hanya dapat dibaca nilainya tanpa diisi nilainya berarti kita harus
         * menghilangkan method set.
         * 
         * Property Write-Ony adalah property yang hanya dapat diisi nilainya atau ditulis tanpa dibaca berarti kita harus
         * menghilangkan method get.
         */

        public static void main()
        {
            Person2 person2 = new Person2("ijon", "simbolon");

            person2.printData();

            // menampilkan method read-only 
            Console.WriteLine("Fullname : " + person2.FullName);

            // error, karena property ini bersifat read-only
            // person2.FullName = "muhammad david"; 

            // mengubah data melalui property
            person2.Firstname = "david";
            person2.Lastname = "jhon schapp";

            // error, karena property ini bersifat write-only
           // Console.WriteLine("Nama depan : " + person2.Firstname);
        }
    }

    class Person2
    {
        private string firstname;
        private string lastname;

        public Person2(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        private string fullName()
        {
            return string.Concat(this.firstname, " ", this.lastname);
        }

        // mendefinisikan method write-only
        public string Firstname { set { this.firstname = value; } }

        public string Lastname { set { this.lastname = value; } }

        // mendefinisikan method read-only
        public string FullName { get { return this.fullName(); } }

        public void printData()
        {
            Console.WriteLine("FirstName : " + this.firstname);
            Console.WriteLine("LastName : " + this.lastname);
        }
    }
}
