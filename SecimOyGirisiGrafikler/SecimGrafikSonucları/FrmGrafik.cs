using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecimGrafikSonucları
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=RABIA-AYDEMIR;Initial Catalog=SecimBilgileri;Integrated Security=True");

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            // şehir adlarını combobox'a cekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sehiradi from tblsecim", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboboxSehir.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(xparti), sum(yparti), sum(zparti), sum(betaparti), sum(opsilonparti) from tblsecim", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["PARTİLER"].Points.AddXY("X", dr2[0]);
                chart1.Series["PARTİLER"].Points.AddXY("Y", dr2[1]);
                chart1.Series["PARTİLER"].Points.AddXY("Z", dr2[2]);
                chart1.Series["PARTİLER"].Points.AddXY("Beta", dr2[3]);
                chart1.Series["PARTİLER"].Points.AddXY("Opsilon", dr2[4]);

            }
            baglanti.Close();
        }

        private void comboboxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from tblsecim where sehiradi = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", comboboxSehir.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                progressX.Value = int.Parse(dr2[2].ToString());
                progressY.Value = int.Parse(dr2[3].ToString());
                progressZ.Value = int.Parse(dr2[4].ToString());
                progressBeta.Value = int.Parse(dr2[5].ToString());
                progressOps.Value = int.Parse(dr2[6].ToString());

                lblX.Text = dr2[2].ToString();
                lblY.Text = dr2[3].ToString();
                lblZ.Text = dr2[4].ToString();
                lblBeta.Text = dr2[5].ToString();
                lblOpsilon.Text = dr2[6].ToString();
            }
            baglanti.Close();
        }
    }
}
