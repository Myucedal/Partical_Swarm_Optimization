namespace PSO_Odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbxparcacik = new System.Windows.Forms.ComboBox();
            this.cmbxjenerasyon = new System.Windows.Forms.ComboBox();
            this.cmbxC1 = new System.Windows.Forms.ComboBox();
            this.cmbxC2 = new System.Windows.Forms.ComboBox();
            this.btnbasla = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxparcacik
            // 
            this.cmbxparcacik.FormattingEnabled = true;
            this.cmbxparcacik.Location = new System.Drawing.Point(213, 30);
            this.cmbxparcacik.Name = "cmbxparcacik";
            this.cmbxparcacik.Size = new System.Drawing.Size(121, 21);
            this.cmbxparcacik.TabIndex = 0;
            // 
            // cmbxjenerasyon
            // 
            this.cmbxjenerasyon.FormattingEnabled = true;
            this.cmbxjenerasyon.Location = new System.Drawing.Point(213, 57);
            this.cmbxjenerasyon.Name = "cmbxjenerasyon";
            this.cmbxjenerasyon.Size = new System.Drawing.Size(121, 21);
            this.cmbxjenerasyon.TabIndex = 1;
            // 
            // cmbxC1
            // 
            this.cmbxC1.FormattingEnabled = true;
            this.cmbxC1.Location = new System.Drawing.Point(213, 84);
            this.cmbxC1.Name = "cmbxC1";
            this.cmbxC1.Size = new System.Drawing.Size(121, 21);
            this.cmbxC1.TabIndex = 2;
            // 
            // cmbxC2
            // 
            this.cmbxC2.FormattingEnabled = true;
            this.cmbxC2.Location = new System.Drawing.Point(213, 111);
            this.cmbxC2.Name = "cmbxC2";
            this.cmbxC2.Size = new System.Drawing.Size(121, 21);
            this.cmbxC2.TabIndex = 3;
            // 
            // btnbasla
            // 
            this.btnbasla.BackColor = System.Drawing.SystemColors.Info;
            this.btnbasla.Location = new System.Drawing.Point(213, 151);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(121, 27);
            this.btnbasla.TabIndex = 4;
            this.btnbasla.Text = "BAŞLAT";
            this.btnbasla.UseVisualStyleBackColor = false;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(404, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(481, 327);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(568, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "YAKINSAMA GRAFİĞİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 155);
            this.dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parçaçık Sayısı(N)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "JENERASYON SAYISI(G)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gbest için Ögr. Fakt.(C1)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pbest için Ögr. Fakt.(C2)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.cmbxC2);
            this.Controls.Add(this.cmbxC1);
            this.Controls.Add(this.cmbxjenerasyon);
            this.Controls.Add(this.cmbxparcacik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxparcacik;
        private System.Windows.Forms.ComboBox cmbxjenerasyon;
        private System.Windows.Forms.ComboBox cmbxC1;
        private System.Windows.Forms.ComboBox cmbxC2;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

