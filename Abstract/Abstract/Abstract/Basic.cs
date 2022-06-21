using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Basic
    {
        /*
         * Class Abstract adalah kelas yang didalamnya berisi method - method abstract tetapi di dalam class 
         * abstract kita diperbolehkan mendefinisikan method non abstract
         * 
         * Class Abstract tidak dapat di instansiasi ini berarti bahwa kita tidak dapat membuat objek dari
         * kelas abstract akan tetapi pada class abstract masih dapat membuat referensi. 
         * 
         * Setiap class turunan dari class abstract wajib meng override method yang didefinisikan didalam class 
         * abstract
         * 
         * Method Abstract adalah method yang didefinisikan didalam class abstract dimana method ini tidak 
         * di implementasi hanya berupa deklarasi method nya saja
         */

        public static void main()
        {

            // membuat instance dari kelas Abstract 
            Abstract abstracts; 

            // abstracts = new Abstract(); error karena class abstract tidak di izinkan membuat objek

            // membuat instance dari kelas NonAbstract
            NonAbstract nonAbstract = new NonAbstract();

            // referensi abstract dapat menunjuk ke objek kelas turunannya
            abstracts = nonAbstract;

            abstracts.Test1();
            abstracts.Test2();
        }
    }

    abstract class Abstract
    {
        // mendefinisikan method abstract
        public abstract void Test1();

        // mendefinisikan method non abstract
        public void Test2()
        {
            Console.WriteLine("Method non abstract");
        }
    }

    class NonAbstract : Abstract
    {
        // override method abstract
        public override void Test1()
        {
            Console.WriteLine("Implementasi method Test1");
        }
    }
}
