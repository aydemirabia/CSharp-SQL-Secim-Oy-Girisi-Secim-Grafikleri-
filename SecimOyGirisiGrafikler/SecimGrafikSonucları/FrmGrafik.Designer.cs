
namespace SecimGrafikSonucları
{
    partial class FrmGrafik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBeta = new System.Windows.Forms.Label();
            this.lblOpsilon = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressOps = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBeta = new System.Windows.Forms.ProgressBar();
            this.progressZ = new System.Windows.Forms.ProgressBar();
            this.progressY = new System.Windows.Forms.ProgressBar();
            this.progressX = new System.Windows.Forms.ProgressBar();
            this.comboboxSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 22);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "PARTİLER";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(506, 208);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lblBeta);
            this.groupBox2.Controls.Add(this.lblOpsilon);
            this.groupBox2.Controls.Add(this.lblY);
            this.groupBox2.Controls.Add(this.lblZ);
            this.groupBox2.Controls.Add(this.lblX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.progressOps);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBeta);
            this.groupBox2.Controls.Add(this.progressZ);
            this.groupBox2.Controls.Add(this.progressY);
            this.groupBox2.Controls.Add(this.progressX);
            this.groupBox2.Controls.Add(this.comboboxSehir);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(377, 233);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(28, 18);
            this.lblBeta.TabIndex = 17;
            this.lblBeta.Text = "00";
            // 
            // lblOpsilon
            // 
            this.lblOpsilon.AutoSize = true;
            this.lblOpsilon.Location = new System.Drawing.Point(376, 277);
            this.lblOpsilon.Name = "lblOpsilon";
            this.lblOpsilon.Size = new System.Drawing.Size(28, 18);
            this.lblOpsilon.TabIndex = 16;
            this.lblOpsilon.Text = "00";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(377, 148);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(28, 18);
            this.lblY.TabIndex = 15;
            this.lblY.Text = "00";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(377, 189);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(28, 18);
            this.lblZ.TabIndex = 14;
            this.lblZ.Text = "00";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(376, 104);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(28, 18);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(352, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Oy Sayısı: ";
            // 
            // progressOps
            // 
            this.progressOps.Location = new System.Drawing.Point(159, 272);
            this.progressOps.Maximum = 300;
            this.progressOps.Name = "progressOps";
            this.progressOps.Size = new System.Drawing.Size(157, 23);
            this.progressOps.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "OPSİLON PARTİ:";
            // 
            // progressBeta
            // 
            this.progressBeta.Location = new System.Drawing.Point(159, 228);
            this.progressBeta.Maximum = 300;
            this.progressBeta.Name = "progressBeta";
            this.progressBeta.Size = new System.Drawing.Size(157, 23);
            this.progressBeta.TabIndex = 9;
            // 
            // progressZ
            // 
            this.progressZ.Location = new System.Drawing.Point(159, 184);
            this.progressZ.Maximum = 300;
            this.progressZ.Name = "progressZ";
            this.progressZ.Size = new System.Drawing.Size(157, 23);
            this.progressZ.TabIndex = 8;
            // 
            // progressY
            // 
            this.progressY.Location = new System.Drawing.Point(159, 143);
            this.progressY.Maximum = 300;
            this.progressY.Name = "progressY";
            this.progressY.Size = new System.Drawing.Size(157, 23);
            this.progressY.TabIndex = 7;
            // 
            // progressX
            // 
            this.progressX.Location = new System.Drawing.Point(159, 99);
            this.progressX.Maximum = 300;
            this.progressX.Name = "progressX";
            this.progressX.Size = new System.Drawing.Size(157, 23);
            this.progressX.TabIndex = 6;
            // 
            // comboboxSehir
            // 
            this.comboboxSehir.FormattingEnabled = true;
            this.comboboxSehir.Location = new System.Drawing.Point(130, 36);
            this.comboboxSehir.Name = "comboboxSehir";
            this.comboboxSehir.Size = new System.Drawing.Size(187, 26);
            this.comboboxSehir.TabIndex = 5;
            this.comboboxSehir.SelectedIndexChanged += new System.EventHandler(this.comboboxSehir_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "BETA PARTİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Z PARTİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y PARTİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "X PARTİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞEHİR:";
            // 
            // FrmGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGrafik";
            this.Text = "Seçim Grafikleri";
            this.Load += new System.EventHandler(this.FrmGrafik_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBeta;
        private System.Windows.Forms.ProgressBar progressZ;
        private System.Windows.Forms.ProgressBar progressY;
        private System.Windows.Forms.ProgressBar progressX;
        private System.Windows.Forms.ComboBox comboboxSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressOps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblOpsilon;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label7;
    }
}