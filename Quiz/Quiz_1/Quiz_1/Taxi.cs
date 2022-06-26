using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    public class Taxi : Car
    {
        private int order;
        private double orderPerKM;
        private int totalKM;
        private double bonus;

        public int Order { get => order; set => order = value; }
        public double OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public double Bonus { get => bonus; set => bonus = value; }

        public Taxi(string nopol, int tahun, string type, int order, double orderPerKM, int totalKM, double bonus) : base(nopol, tahun, type)
        {
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            TotalPendapatan = (this.order * this.bonus) + (this.orderPerKM * this.totalKM);
        }

        public override double totalPendapatan()
        {
            return this.TotalPendapatan;
        }

        public override string? ToString()
        {
            return $"No Polisi : {this.NoPolisi} \n" +
                $"Tahun : {this.Tahun} \n" +
                $"Type : {this.Type} \n" +
                $"Order : {this.Order} \n" +
                $"Order Per KM : {this.orderPerKM} \n" +
                $"Total KM : {this.totalKM} \n" +
                $"Bonus : {this.bonus} \n" +
                $"Total Pendapatan : {this.TotalPendapatan}";
        }
    }
}
