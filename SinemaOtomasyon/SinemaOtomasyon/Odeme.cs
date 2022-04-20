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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server =.; Initial Catalog = sinemadb; Integrated Security = SSPI");
        
        private void Odeme_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["filmler"];
            filmler flm = new filmler();
            bunifuTextBox1.Enabled = false;
            bunifuTextBox2.Enabled = false;
            bunifuTextBox3.Enabled = false;
            bunifuTextBox4.Enabled = false;
            bunifuTextBox1.Text = ((filmler)f).filmadi;
            bunifuTextBox2.Text = ((filmler)f).salonno;
            bunifuTextBox3.Text = ((filmler)f).btn;
        }
        public string Get_Form1Text()
        {
            return bunifuTextBox3.Text;
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked&&!radioButton2.Checked)
            {
                MessageBox.Show("Ödeme ücreti seçiniz!");
            }
            else
            {
                string sorgu = "INSERT INTO tblbiletkontrol (biletAdet,biletToplam,biletAd,biletKoltuk,biletSaat) VALUES (@ba,@bt,@bad,@bk,@bs)";
                SqlCommand cmd = new SqlCommand(sorgu,conn);
                SqlDataReader dr;
                if (radioButton1.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@bt", 15);
                    cmd.Parameters.AddWithValue("@ba", 1);
                    cmd.Parameters.AddWithValue("@bad", bunifuTextBox1.Text);
                    cmd.Parameters.AddWithValue("@bk", bunifuTextBox3.Text);
                    cmd.Parameters.AddWithValue("@bs", bunifuTextBox4.Text);
                }
                else if (radioButton2.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@bt", 25);
                    cmd.Parameters.AddWithValue("@ba", 1);
                    cmd.Parameters.AddWithValue("@bad", bunifuTextBox1.Text);
                    cmd.Parameters.AddWithValue("@bk", bunifuTextBox3.Text);
                    cmd.Parameters.AddWithValue("@bs", bunifuTextBox4.Text);
                }
                conn.Open();
                dr=cmd.ExecuteReader();
                conn.Close();
                this.Hide();
                filmler flm = new filmler();
                this.Hide();
                flm.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filmler flm = new filmler();
            this.Hide();
            flm.Show();
        }
    }
}
