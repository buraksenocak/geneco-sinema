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
    public partial class pekleme : Form
    {
        public pekleme()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=sinemadb;Integrated Security=True");
            baglanti.Open();
            string kayit = "insert into tblpersonel (p_kadi,p_sifre) values (@padi,@psifre)";
            SqlCommand ekle = new SqlCommand(kayit, baglanti);
            ekle.Parameters.AddWithValue("@padi", bunifuTextBox1.Text);
            ekle.Parameters.AddWithValue("@psifre", bunifuTextBox2.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi!");
            bunifuTextBox1.Text = "";
            bunifuTextBox2.Text = "";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ypaneli panel=new ypaneli();
            panel.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=sinemadb;Integrated Security=True");
            baglanti.Open();
            string kayit = "DELETE FROM tblpersonel p_kadi=@padi,p_sifre=@psifre)";
            SqlCommand ekle = new SqlCommand(kayit, baglanti);
            ekle.Parameters.AddWithValue("@padi", bunifuTextBox1.Text);
            ekle.Parameters.AddWithValue("@psifre", bunifuTextBox2.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi!");
            bunifuTextBox1.Text = "";
            bunifuTextBox2.Text = "";
        }
    }
}
