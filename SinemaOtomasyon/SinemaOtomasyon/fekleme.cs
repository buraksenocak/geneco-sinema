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
    public partial class fekleme : Form
    {
        public fekleme()
        {
            InitializeComponent();
        }
        
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=sinemadb;Integrated Security=True");
            baglanti.Open();
            string kayit = "insert into tblfilm (film_ad) values (@fad)";
            SqlCommand ekle = new SqlCommand(kayit, baglanti);
            ekle.Parameters.AddWithValue("@fad", bunifuTextBox1.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Eklendi!");
            bunifuTextBox1.Text = "";
            
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
            string kayit = "DELETE FROM tblfilm WHERE film_ad=@fad";
            SqlCommand ekle = new SqlCommand(kayit, baglanti);
            ekle.Parameters.AddWithValue("@fad", bunifuTextBox1.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Silindi!");
            bunifuTextBox1.Text = "";
        }
    }
}
