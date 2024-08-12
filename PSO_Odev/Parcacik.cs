using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO_Odev
{
    internal class Parcacik
    {
        public double[] Pozisyon { get; set; }
        public double[] Hız { get; set; }
        public double[] Bpozisyon { get; set; }
        public double Bdeger { get; set; }

        public Parcacik(int boyut)
        {
            Pozisyon = new double[boyut];
            Hız = new double[boyut];
            Bpozisyon = new double[boyut];
        }

    }
}
