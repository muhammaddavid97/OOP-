using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    public class Angkot : Car
    {
        private double hargaTiket;
        private int totalPenumpang;

        public double HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public int TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }

        public Angkot(string nopol, int tahun, string type, double hargaTiket, int totalPenumpang) : base(nopol, tahun, type)
        {
            this.hargaTiket = hargaTiket;
            this.totalPenumpang = totalPenumpang;
            TotalPendapatan = this.hargaTiket * this.totalPenumpang;
        }

        //override
        public override double totalPendapatan()
        {
            return this.TotalPendapatan;
        }

        public override string? ToString()
        {
            return $"No Polisi : {this.NoPolisi} \n" +
                $"Tahun : {this.Tahun} \n" +
                $"Type : {this.Type} \n" +
                $"Harga Tiket : {this.hargaTiket} \n" +
                $"Total Penumpang : {this.totalPenumpang} \n" +
                $"Total Pendapatan : {this.TotalPendapatan}";
        }
    }
}
