using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public class PrivateModifier
    {
        // private adalah access modifier dimana method atau field yang dideklarasikan dengan private
        // hanya dapat diakses di class saat ini sehingga tidak dapat diakses di luar kelas saat ini.

        public static void main()
        {
            SegiEmpat3 se3 = new SegiEmpat3(12, 11);

            Console.WriteLine("Luas : " + se3.hitungLuas());
            Console.WriteLine("Keliling : " + se3.hitungKeliling());
        }
    }

    class SegiEmpat3
    {
        private int panjang;
        private int lebar;
    
        public SegiEmpat3(int panjang, int lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        public double hitungLuas()
        {
            return this.panjang * this.lebar;
        }

        public double hitungKeliling()
        {
            return 2 * (this.panjang + this.lebar);
        }
    }
}
