using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Basic
    {
        /*
         * inheritance adalah salah satu karakteristik yang dimiliki oleh konsep pemrograman berorientasi objek
         * yang bekerja dengan cara melakukan proses penurunan kelas.
         * 
         * 
         * Kelas yang diturunkan disebut kelas anak (derived class) sedangkan kelas yang mewarisi disebut kelas induk (base class)
         * 
         * 
         * kelas anak dapat mewarisi sifat yang dimiliki oleh kelas induk seperti mengakses field atau method akan
         * tetapi kita dapat mendeklarasikan sifat sifat baru ke dalam kelas turunannya seperti menambahkan field atau method
         * yang tidak dideklarasikan di class parent nya sehingga sifatnya dapat lebih spesifik.
         
         */

        public static void main()
        {
            Harimau harimau = new Harimau();

            harimau.NamaHewan = "Macan kumbang";
            harimau.Suara = "meraum meraum";
            harimau.Jenis = "karnivora";

            harimau.soundAnimal();
            Console.WriteLine("Jenis hewan : " + harimau.Jenis);
        }
    }

    class Hewan
    {
        private string namaHewan;
        private string suara;
        public string NamaHewan { get => namaHewan; set => namaHewan = value; }
        public string Suara { get => this.suara; set => this.suara = value; }

        public void soundAnimal()
        {
            Console.WriteLine($"Nama hewan {NamaHewan} \n Suara hewan : {Suara}");
        }
    }

    class Harimau : Hewan
    {
        private string jenis;
        public string Jenis { get => jenis; set => jenis = value; }
    }
}
