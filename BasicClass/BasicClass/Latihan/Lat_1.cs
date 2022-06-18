using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            SegiEmpat[] segiEmpats = new SegiEmpat[4];

            // instansiasi objek dari kelas SegiEmpat

            for (int j = 0; j < segiEmpats.Length; j++)
            {
                segiEmpats[j] = new SegiEmpat();
            }

            segiEmpats[0].panjang = 10;
            segiEmpats[0].lebar = 5;

            segiEmpats[1].panjang = 11;
            segiEmpats[1].lebar = 2;

            segiEmpats[2].panjang = 1;
            segiEmpats[2].lebar = 3;

            segiEmpats[3].panjang = 20;
            segiEmpats[3].lebar = 22;

            // menghitung luas segiempat
            for(int i = 0; i < segiEmpats.Length; i++)
            {
                segiEmpats[i].luas = segiEmpats[i].panjang * segiEmpats[i].lebar;
            }

            // melakukan sorting data berdasarkan luas 
            for (int k = 0; k < segiEmpats.Length - 1; k++)
            {
                int temp = k;
                for (int z = k + 1; z < segiEmpats.Length; z++)
                {
                    // jika nilai luas pada elemen pertama lebih besar dibandingkan dengan nilai luas setelahnya
                    // maka ubah variable temp
                    if (segiEmpats[temp].luas > segiEmpats[z].luas)
                    {
                        temp = z;
                    }
                }

                // tukarkan nilai luas 
                double swapp = segiEmpats[k].luas;
                segiEmpats[k].luas = segiEmpats[temp].luas;
                segiEmpats[temp].luas = swapp;
            }

            Console.WriteLine("Menampilkan luas segiempat");

            int incre = 0;
            foreach(var item in segiEmpats)
            {
                Console.WriteLine("Luas segiempat " + (incre + 1) + " = " + item.luas);
                incre++;
            }
        }
    }

    class SegiEmpat
    {
        public double panjang;
        public double lebar;
        public double luas;
    }
}
