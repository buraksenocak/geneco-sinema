using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using System.Data.SqlClient;

namespace SinemaOtomasyon
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM tblpersonel where p_kadi=@personeladi AND p_sifre=@personelsifre";
            con = new SqlConnection("server=.; Initial Catalog=sinemadb;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@personeladi", bunifuTextBox1.Text);
            cmd.Parameters.AddWithValue("@personelsifre", bunifuTextBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            filmler filmler =new filmler();
            if (dr.Read())
            {
                filmler.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            yonetici yonetici = new yonetici();
            this.Hide();
            yonetici.Show();
        }
    }
}
