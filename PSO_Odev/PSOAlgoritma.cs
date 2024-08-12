using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO_Odev
{
    internal class PSOAlgoritma
    {

        private Suru suru;
        private int boyut;
        private int jenerasyon;
        private double c1, c2;
        private Random random;
        public List<double> Yakınsamadeger { get;  set; }
        public List<double[]> PozisyonDegerleri { get; set; }  
        public PSOAlgoritma(int parcaciksayisi, int boyut, int jenerasyon, double c1, double c2)
        {
            suru = new Suru(parcaciksayisi, boyut);
            this.boyut = boyut;
            this.jenerasyon = jenerasyon;
            this.c1 = c1;
            this.c2 = c2;
            random = new Random();
            Yakınsamadeger = new List<double>();
            PozisyonDegerleri = new List<double[]>();
        }

        public void Surubasla()
        {
            foreach (var particle in suru.Parcacik)
            {
                for (int i = 0; i < boyut; i++)
                {
                    particle.Pozisyon[i] = random.NextDouble() * 9 - 4.5;  // -4.5  4.5 arası
                    particle.Hız[i] = random.NextDouble() * 2 - 1;  // -1  1 arası
                    particle.Bpozisyon[i] = particle.Pozisyon[i];
                }
                particle.Bdeger = ObjectiveFunction(particle.Pozisyon);
                if (particle.Bdeger < suru.GBdeger)
                {
                    suru.GBpozisyon = (double[])particle.Bpozisyon.Clone();
                    suru.GBdeger = particle.Bdeger;
                }
            }
        }

        public double ObjectiveFunction(double[] pozisyon)
        {
            double x = pozisyon[0];
            double y = pozisyon[1];
            double sonuc = Math.Pow(1.5 - x + x * y, 2) +
                            Math.Pow(2.25 - x + x * Math.Pow(y, 2), 2) +
                            Math.Pow(2.625 - x + x * Math.Pow(y, 3), 2);
            return sonuc;
        }

        public void Run()
        {

            for (int jen = 0; jen < jenerasyon; jen++)
            {
                foreach (var parcacik in suru.Parcacik)
                {
                    for (int i = 0; i < boyut; i++)
                    {
                        double r1 = random.NextDouble();
                        double r2 = random.NextDouble();
                        parcacik.Hız[i] = parcacik.Hız[i] +
                                           c1 * r1 * (parcacik.Bpozisyon[i] - parcacik.Pozisyon[i]) +
                                           c2 * r2 * (suru.GBpozisyon[i] - parcacik.Pozisyon[i]);

                        
                        if (parcacik.Hız[i] > 4.5) parcacik.Hız[i] = 4.5;
                        if (parcacik.Hız[i] < -4.5) parcacik.Hız[i] = -4.5;

                        parcacik.Pozisyon[i] += parcacik.Hız[i];

                        
                        if (parcacik.Pozisyon[i] > 4.5) parcacik.Pozisyon[i] = 4.5;
                        if (parcacik.Pozisyon[i] < -4.5) parcacik.Pozisyon[i] = -4.5;
                    }

                    double newValue = ObjectiveFunction(parcacik.Pozisyon);
                    if (newValue < parcacik.Bdeger)
                    {
                        parcacik.Bdeger = newValue;
                        parcacik.Bpozisyon = (double[])parcacik.Pozisyon.Clone();
                        if (newValue < suru.GBdeger)
                        {
                            suru.GBpozisyon = (double[])parcacik.Bpozisyon.Clone();
                            suru.GBdeger = newValue;
                        }
                    }
                }
                Yakınsamadeger.Add(suru.GBdeger);
               
                foreach (var parcacik in suru.Parcacik)
                {
                    PozisyonDegerleri.Add((double[])parcacik.Pozisyon.Clone());
                }

               

              
            
        }
        }

        public Suru Suru => suru;
    }
}
