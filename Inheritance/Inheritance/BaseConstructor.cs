using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseConstructor
    {
        /*
         * base adalah keyword yang digunakan untuk mengakses anggota (field atau method) milik kelas dasar
         * dari kelas turunan
         * 
         * 
         * syntax : 
         * class BaseClass {
         *     public BaseClass(){
         *         
         *     }
         *     
         *     public BaseClass(parameter){
         *     
         *     }
         * }
         * 
         * 
         *class DerivedClass : BaseClass{
         *  public DerivedClass : base(){
         *  
         *  }
         *  
         *  public DerivedClass : base(parameter){}
         *}
         *
         */

        public static void main()
        {
            // membuat instance kelas Person2 dengan objek tanpa parameter
            Person2 person1 = new Person2();
            Console.WriteLine(person1.ToString());

            // membuat instance kelas Person2 dengan objek parameter
            Person2 person2 = new Person2("endang soekamti", 21);
            Console.WriteLine(person2.ToString());

            // membuat instance kelas Dosen2 dengan objek tanpa parameter
            Dosen2 dosen1 = new Dosen2();
            Console.WriteLine(dosen1.ToString());

            // membuat instance kelas Dosen2 dengan objek parameter
            Dosen2 dosen2 = new Dosen2("yudha wijaya", 33, 210.000);
            Console.WriteLine(dosen2.ToString());
        }
    }

    class Person2
    {
        protected string name;
        protected int age;

        public Person2()
        {
            this.name = "supriyono";
            this.age = 52;
        }
        public Person2(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string? ToString()
        {
            return $"Nama : {this.name} \n" +
                $"Usia : {this.age}";
        }
    }

    class Dosen2: Person2
    {

        private double gaji;
        public Dosen2() : base()
        {

        }

        public Dosen2(string name, int age, double gaji) : base(name, age)
        {
            this.gaji = gaji;
        }

        public override string? ToString()
        {
            return $"Nama dosen : {this.name} \n" +
                $"Usia dosen : {this.age} \n" +
                $"Gaji : ${this.gaji}";
        }
    }
}
