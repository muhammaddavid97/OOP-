using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    public class Suv : Car
    {
        private double sewa;
        private double biayaSupir;

        public double Sewa { get => sewa; set => sewa = value; }
        public double BiayaSupir { get => biayaSupir; set => biayaSupir = value; }

        public Suv(string nopol, int tahun, string type, double sewa, double biayaSupir) : base(nopol, tahun, type)
        {
            this.sewa = sewa;
            this.biayaSupir = biayaSupir;
            TotalPendapatan = this.sewa + this.biayaSupir;
        }

        // override
        public override double totalPendapatan()
        {
            return this.TotalPendapatan;
        }

        public override string? ToString()
        {
            return $"No Polisi : {this.NoPolisi} \n" +
                $"Tahun : {this.Tahun} \n" +
                $"Type : {this.Type} \n" +
                $"Sewa : {this.sewa}\n" +
                $"Supir : {this.biayaSupir}\n" +
                $"Total Pendapatan : {this.TotalPendapatan}";
        }
    }
}
