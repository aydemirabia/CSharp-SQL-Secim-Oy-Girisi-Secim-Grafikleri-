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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=RABIA-AYDEMIR;Initial Catalog=SecimBilgileri;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblsecim (sehiradi, xparti, yparti, zparti, betaparti, opsilonparti) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSehir.Text);
            komut.Parameters.AddWithValue("@p2", txtX.Text);
            komut.Parameters.AddWithValue("@p3", txtY.Text);
            komut.Parameters.AddWithValue("@p4", txtZ.Text);
            komut.Parameters.AddWithValue("@p5", txtBeta.Text);
            komut.Parameters.AddWithValue("@p6", txtOpsilon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişiniz Gerçekleşti.");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik frm = new FrmGrafik();
            frm.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
