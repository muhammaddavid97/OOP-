using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    public class Car
    {
        public string NoPolisi { get; set; }
        public int Tahun {get; set; }
        public string Type { get; set; }
        public double TotalPendapatan { get; set; }

        public Car(string nopol, int tahun, string type)
        {
            this.NoPolisi = nopol;
            this.Tahun = tahun;
            this.Type = type;
        }

        public Car()
        {

        }
        public virtual double totalPendapatan() { return this.TotalPendapatan;  }
    }
}
