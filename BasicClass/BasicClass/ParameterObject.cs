using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class ParameterObject
    {

        // passByRefference adalah kemampuan sebuah method untuk menerima argumen berupa variable reference dari suatu objek

        public static void main()
        {
            SegiEmpat5 se1, se2, se3, se4;
            bool hasil1, hasil2, hasil3;

            se1 = new SegiEmpat5(11, 21);
            se2 = new SegiEmpat5(12, 22);
            se3 = new SegiEmpat5(11, 21);

            // nilai data pada objek se4 akan sama dengan nilai data pada objek se3
            se4 = new SegiEmpat5(se1);

            hasil1 = se1.isObject(se2);
            hasil2 = se1.isObject(se3);
            hasil3 = se4.isObject(se1);

            if (hasil1)
            {
                Console.WriteLine("objek se1 sama dengan objek se2");
            }
            else
            {
                Console.WriteLine("objek se1 tidak sama dengan objek se3");
            }

            if (hasil2)
            {
                Console.WriteLine("objek se1 sama dengan objek se2");
            }
            else
            {
                Console.WriteLine("objek se1 tidak sama dengan objek se3");
            }

            if (hasil3)
            {
                Console.WriteLine("Objek se4  sama dengan objek se1");
            }
            else
            {
                Console.WriteLine("Objek se4 tidak sama dengan objek se1");
            }
        }
    }

    class SegiEmpat5
    {
        private double panjang;
        private double lebar;

        public SegiEmpat5(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        // mendefinisikan constructor dengan parameter berupa reference objek
        public SegiEmpat5(SegiEmpat5 obj)
        {
            this.panjang = obj.panjang;
            this.lebar = obj.lebar;
        }

        public double hitungLuas()
        {
            return this.panjang * this.lebar;
        }

        // mendeklarasikan method dengan parameter berupa referensi ke objek
        public bool isObject(SegiEmpat5 check)
        {
            if (check.panjang == this.panjang && check.lebar == this.lebar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
