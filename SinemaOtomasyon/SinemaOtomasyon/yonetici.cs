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
    public partial class yonetici : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public yonetici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 personel = new Form1();
            this.Hide();
            personel.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblyonetici where y_kadi=@yoneticiadi AND y_sifre=@yoneticisifre";
            con = new SqlConnection("server=.; Initial Catalog=sinemadb;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@yoneticiadi", bunifuTextBox1.Text);
            cmd.Parameters.AddWithValue("@yoneticisifre", bunifuTextBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            ypaneli panel = new ypaneli();
            if (dr.Read())
            {
                panel.Show();
                this.Hide();
            }
            else
            {
                bunifuTextBox1.Text = "";
                bunifuTextBox2.Text = "";
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!!!");
            }
            con.Close();
        }
    }
}
