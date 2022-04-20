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

namespace SinemaOtomasyon
{
    public partial class ypaneli : Form
    {
        public ypaneli()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            fekleme fekleme = new fekleme();
            fekleme.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            pekleme pekleme = new pekleme();
            pekleme.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            muhasebe muhasebe = new muhasebe();
            this.Hide();
            muhasebe.Show();
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=sinemadb;Integrated Security=True");
            baglanti.Open();
            string kayit = "SELECT COUNT(biletAdet) FROM tblbiletkontrol";
            SqlCommand ekle = new SqlCommand(kayit, baglanti);
            int count = (int)ekle.ExecuteScalar();
            muhasebe.bunifuTextBox1.Text=count.ToString();
            kayit = "SELECT SUM(biletToplam) FROM tblbiletkontrol";
            ekle = new SqlCommand(kayit, baglanti);
            count = (int)ekle.ExecuteScalar();
            muhasebe.bunifuTextBox2.Text = count.ToString();
            baglanti.Close();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            yonetici y=new yonetici();
            this.Hide();
            y.Show();
        }
    }
}
