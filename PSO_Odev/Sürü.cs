using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO_Odev
{
    internal class Suru
    {
        public List<Parcacik> Parcacik { get; set; }
        public double[] GBpozisyon { get; set; }
        public double GBdeger { get; set; }

        public Suru(int parcacikSayisi, int boyut)
        {
            Parcacik = new List<Parcacik>();
            GBpozisyon = new double[boyut];
            GBdeger = double.MaxValue;
            for (int i = 0; i < parcacikSayisi; i++)
            {
                Parcacik.Add(new Parcacik(boyut));
            }
        }
    }
}
