using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PSO_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            int parcaciksayisi = int.Parse(cmbxparcacik.Text);
            int jenerasyon = int.Parse(cmbxjenerasyon.Text);
            double c1 = double.Parse(cmbxC1.Text);
            double c2 = double.Parse(cmbxC2.Text);
            int boyutlar = 2;

            PSOAlgoritma pso = new PSOAlgoritma(parcaciksayisi, boyutlar, jenerasyon, c1, c2);
            pso.Surubasla();
            pso.Run();



            Yakınsamagrafihiciz(pso.Yakınsamadeger);
            Datagridwiewdoldur(pso.PozisyonDegerleri, parcaciksayisi);
        }
        
        private void Yakınsamagrafihiciz(List<double> Yakınsamadeger)
        {
            chart1.Series.Clear();
            var series = new Series("Yakınsama")
            {
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < Yakınsamadeger.Count; i++)
            {
                series.Points.AddXY(i, Yakınsamadeger[i]);
            }

            chart1.Series.Add(series);
        }
        private void Datagridwiewdoldur(List<double[]> pozisyonDegerleri, int parcacikSayisi)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

 
            dataGridView1.Columns.Add("Jenerasyon", "Jenerasyon");
            for (int p = 0; p < parcacikSayisi; p++)
            {
                for (int i = 0; i < pozisyonDegerleri[0].Length; i++)
                {
                    dataGridView1.Columns.Add($"P{p + 1}_X{i + 1}", $"P{p + 1}_X{i + 1}");
                }
            }


            int jenerasyonSayisi = pozisyonDegerleri.Count / parcacikSayisi;
            for (int jen = 0; jen < jenerasyonSayisi; jen++)
            {
                var row = new List<string> { jen.ToString() };
                for (int p = 0; p < parcacikSayisi; p++)
                {
                    int index = jen * parcacikSayisi + p;
                    row.AddRange(pozisyonDegerleri[index].Select(x => x.ToString()).ToArray());
                }
                dataGridView1.Rows.Add(row.ToArray());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
