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
    public partial class filmler : Form
    {

        
        public filmler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void butonBoya()
        {
            BTNA1.BackColor = Color.Lime;
            BTNA1.ForeColor = Color.Black;
            BTNA2.BackColor = Color.Lime;
            BTNA2.ForeColor = Color.Black;
            BTNA3.BackColor = Color.Lime;
            BTNA3.ForeColor = Color.Black;
            BTNA4.BackColor = Color.Lime;
            BTNA4.ForeColor = Color.Black;
            BTNA5.BackColor = Color.Lime;
            BTNA5.ForeColor = Color.Black;
            BTNA6.BackColor = Color.Lime;
            BTNA6.ForeColor = Color.Black;
            BTNA7.BackColor = Color.Lime;
            BTNA7.ForeColor = Color.Black;
            BTNA8.BackColor = Color.Lime;
            BTNA8.ForeColor = Color.Black;
            BTNC1.BackColor = Color.Lime;
            BTNC1.ForeColor = Color.Black;
            BTNC2.BackColor = Color.Lime;
            BTNC2.ForeColor = Color.Black;
            BTNC3.BackColor = Color.Lime;
            BTNC3.ForeColor = Color.Black;
            BTNC4.BackColor = Color.Lime;
            BTNC4.ForeColor = Color.Black;
            BTNC5.BackColor = Color.Lime;
            BTNC5.ForeColor = Color.Black;
            BTNC6.BackColor = Color.Lime;
            BTNC6.ForeColor = Color.Black;
            BTNC7.BackColor = Color.Lime;
            BTNC7.ForeColor = Color.Black;
            BTNC8.BackColor = Color.Lime;
            BTNC8.ForeColor = Color.Black;
            BTNB1.BackColor = Color.Lime;
            BTNB1.ForeColor = Color.Black;
            BTNB2.BackColor = Color.Lime;
            BTNB2.ForeColor = Color.Black;
            BTNB3.BackColor = Color.Lime;
            BTNB3.ForeColor = Color.Black;
            BTNB4.BackColor = Color.Lime;
            BTNB4.ForeColor = Color.Black;
            BTNB5.BackColor = Color.Lime;
            BTNB5.ForeColor = Color.Black;
            BTNB6.BackColor = Color.Lime;
            BTNB6.ForeColor = Color.Black;
            BTNB7.BackColor = Color.Lime;
            BTNB7.ForeColor = Color.Black;
            BTNB8.BackColor = Color.Lime;
            BTNB8.ForeColor = Color.Black;
            BTND1.BackColor = Color.Lime;
            BTND1.ForeColor = Color.Black;
            BTND2.BackColor = Color.Lime;
            BTND2.ForeColor = Color.Black;
            BTND3.BackColor = Color.Lime;
            BTND3.ForeColor = Color.Black;
            BTND4.BackColor = Color.Lime;
            BTND4.ForeColor = Color.Black;
            BTND5.BackColor = Color.Lime;
            BTND5.ForeColor = Color.Black;
            BTND6.BackColor = Color.Lime;
            BTND6.ForeColor = Color.Black;
            BTND7.BackColor = Color.Lime;
            BTND7.ForeColor = Color.Black;
            BTND8.BackColor = Color.Lime;
            BTND8.ForeColor = Color.Black;
            BTNA1.Enabled = true;
            BTNA2.Enabled = true;
            BTNA3.Enabled = true;
            BTNA4.Enabled = true;
            BTNA5.Enabled = true;
            BTNA6.Enabled = true;
            BTNA7.Enabled = true;
            BTNA8.Enabled = true;
            BTNB1.Enabled = true;
            BTNB2.Enabled = true;
            BTNB3.Enabled = true;
            BTNB4.Enabled = true;
            BTNB5.Enabled = true;
            BTNB6.Enabled = true;
            BTNB7.Enabled = true;
            BTNB8.Enabled = true;
            BTNC1.Enabled = true;
            BTNC2.Enabled = true;
            BTNC3.Enabled = true;
            BTNC4.Enabled = true;
            BTNC5.Enabled = true;
            BTNC6.Enabled = true;
            BTNC7.Enabled = true;
            BTNC8.Enabled = true;
            BTND1.Enabled = true;
            BTND2.Enabled = true;
            BTND3.Enabled = true;
            BTND4.Enabled = true;
            BTND5.Enabled = true;
            BTND6.Enabled = true;
            BTND7.Enabled = true;
            BTND8.Enabled = true;
        }
        private void filmler_Load(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=sinemadb;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblfilm";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                bunifuDropdown1.Items.Add(dr["film_ad"]);
            }
            baglanti.Close();
            bunifuGroupBox1.Visible = false;
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Salon " + (bunifuDropdown1.SelectedIndex+1).ToString();
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            bunifuGroupBox1.Visible = false;
        }
        Odeme odeme=new Odeme();
        public string btn = "";
        public string filmadi = "";
        public string salonno = "";
        private void BTNA1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A1";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
            
        }

        private void BTNA2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A2";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNA3_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A3";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNA4_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A4";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNA5_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A5";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNA6_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A6";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNA7_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A7";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNA8_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "A8";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B1";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C2";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB3_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B3";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB4_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B4";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB5_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B5";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB6_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B6";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB7_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B7";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNB8_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "B8";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C1";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C2";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC3_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C3";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC4_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C4";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC5_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C5";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC6_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C6";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC7_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C7";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTNC8_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "C8";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D1";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D2";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND3_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D3";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND4_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D4";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND5_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D5";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND6_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D6";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND7_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D7";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void BTND8_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Lütfen Saat Seçiniz!");
            }
            else
            {
                filmadi = bunifuDropdown1.Text;
                salonno = label1.Text;
                btn = "D8";
                odeme.Show();
                this.Hide();
                odeme.bunifuTextBox1.Text = filmadi;
                odeme.bunifuTextBox2.Text = salonno;
                odeme.bunifuTextBox3.Text = btn;
                if (radioButton1.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    odeme.bunifuTextBox4.Text = radioButton4.Text;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            butonBoya();
            bunifuGroupBox1.Visible = true;
            SqlConnection baglanti = new SqlConnection("server =.; Initial Catalog = sinemadb; Integrated Security = SSPI");
            baglanti.Open();
            SqlCommand koltuk_Var_Mi1 = new SqlCommand("SELECT COUNT(*) FROM tblbiletkontrol WHERE (biletKoltuk=@bk AND biletSaat=@bs AND biletAd=@ba)", baglanti);
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            int filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA1.BackColor = Color.Red;
                BTNA1.ForeColor = Color.White;
                BTNA1.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA2.BackColor = Color.Red;
                BTNA2.ForeColor = Color.White;
                BTNA2.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA3.BackColor = Color.Red;
                BTNA3.ForeColor = Color.White;
                BTNA3.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA4.BackColor = Color.Red;
                BTNA4.ForeColor = Color.White;
                BTNA4.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA5.BackColor = Color.Red;
                BTNA5.ForeColor = Color.White;
                BTNA5.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA6.BackColor = Color.Red;
                BTNA6.ForeColor = Color.White;
                BTNA6.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA7.BackColor = Color.Red;
                BTNA7.ForeColor = Color.White;
                BTNA7.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA8.BackColor = Color.Red;
                BTNA8.ForeColor = Color.White;
                BTNA8.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB1.BackColor = Color.Red;
                BTNB1.ForeColor = Color.White;
                BTNB1.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB2.BackColor = Color.Red;
                BTNB2.ForeColor = Color.White;
                BTNB2.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB3.BackColor = Color.Red;
                BTNB3.ForeColor = Color.White;
                BTNB3.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB4.BackColor = Color.Red;
                BTNB4.ForeColor = Color.White;
                BTNB4.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB5.BackColor = Color.Red;
                BTNB5.ForeColor = Color.White;
                BTNB5.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB6.BackColor = Color.Red;
                BTNB6.ForeColor = Color.White;
                BTNB6.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB7.BackColor = Color.Red;
                BTNB7.ForeColor = Color.White;
                BTNB7.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
                BTNB8.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC1.BackColor = Color.Red;
                BTNC1.ForeColor = Color.White;
                BTNC1.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC2.BackColor = Color.Red;
                BTNC2.ForeColor = Color.White;
                BTNC2.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC3.BackColor = Color.Red;
                BTNC3.ForeColor = Color.White;
                BTNC3.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC4.BackColor = Color.Red;
                BTNC4.ForeColor = Color.White;
                BTNC4.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC5.BackColor = Color.Red;
                BTNC5.ForeColor = Color.White;
                BTNC5.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC6.BackColor = Color.Red;
                BTNC6.ForeColor = Color.White;
                BTNC6.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC7.BackColor = Color.Red;
                BTNC7.ForeColor = Color.White;
                BTNC7.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC8.BackColor = Color.Red;
                BTNC8.ForeColor = Color.White;
                BTNC8.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND1.BackColor = Color.Red;
                BTND1.ForeColor = Color.White;
                BTND1.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND2.BackColor = Color.Red;
                BTND2.ForeColor = Color.White;
                BTND2.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND3.BackColor = Color.Red;
                BTND3.ForeColor = Color.White;
                BTND3.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND4.BackColor = Color.Red;
                BTND4.ForeColor = Color.White;
                BTND4.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND5.BackColor = Color.Red;
                BTND5.ForeColor = Color.White;
                BTND5.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND6.BackColor = Color.Red;
                BTND6.ForeColor = Color.White;
                BTND6.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND7.BackColor = Color.Red;
                BTND7.ForeColor = Color.White;
                BTND7.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton1.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND8.BackColor = Color.Red;
                BTND8.ForeColor = Color.White;
                BTND8.Enabled = false;
            }
            koltuk_Var_Mi1.Parameters.Clear();

            baglanti.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            butonBoya();
            bunifuGroupBox1.Visible = true;
            SqlConnection baglanti = new SqlConnection("server =.; Initial Catalog = sinemadb; Integrated Security = SSPI");
            baglanti.Open();
            SqlCommand koltuk_Var_Mi1 = new SqlCommand("SELECT COUNT(*) FROM tblbiletkontrol WHERE (biletKoltuk=@bk AND biletSaat=@bs AND biletAd=@ba)", baglanti);
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            int filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA1.BackColor = Color.Red;
                BTNA1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA2.BackColor = Color.Red;
                BTNA2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA3.BackColor = Color.Red;
                BTNA3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA4.BackColor = Color.Red;
                BTNA4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA5.BackColor = Color.Red;
                BTNA5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA6.BackColor = Color.Red;
                BTNA6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA7.BackColor = Color.Red;
                BTNA7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA8.BackColor = Color.Red;
                BTNA8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB1.BackColor = Color.Red;
                BTNB1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB2.BackColor = Color.Red;
                BTNB2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB3.BackColor = Color.Red;
                BTNB3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB4.BackColor = Color.Red;
                BTNB4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB5.BackColor = Color.Red;
                BTNB5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB6.BackColor = Color.Red;
                BTNB6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB7.BackColor = Color.Red;
                BTNB7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC1.BackColor = Color.Red;
                BTNC1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC2.BackColor = Color.Red;
                BTNC2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC3.BackColor = Color.Red;
                BTNC3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC4.BackColor = Color.Red;
                BTNC4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC5.BackColor = Color.Red;
                BTNC5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC6.BackColor = Color.Red;
                BTNC6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC7.BackColor = Color.Red;
                BTNC7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC8.BackColor = Color.Red;
                BTNC8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND1.BackColor = Color.Red;
                BTND1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND2.BackColor = Color.Red;
                BTND2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND3.BackColor = Color.Red;
                BTND3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND4.BackColor = Color.Red;
                BTND4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND5.BackColor = Color.Red;
                BTND5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND6.BackColor = Color.Red;
                BTND6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND7.BackColor = Color.Red;
                BTND7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton2.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND8.BackColor = Color.Red;
                BTND8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();

            baglanti.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            butonBoya();
            bunifuGroupBox1.Visible = true;
            SqlConnection baglanti = new SqlConnection("server =.; Initial Catalog = sinemadb; Integrated Security = SSPI");
            baglanti.Open();
            SqlCommand koltuk_Var_Mi1 = new SqlCommand("SELECT COUNT(*) FROM tblbiletkontrol WHERE (biletKoltuk=@bk AND biletSaat=@bs AND biletAd=@ba)", baglanti);
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            int filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA1.BackColor = Color.Red;
                BTNA1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA2.BackColor = Color.Red;
                BTNA2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA3.BackColor = Color.Red;
                BTNA3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA4.BackColor = Color.Red;
                BTNA4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA5.BackColor = Color.Red;
                BTNA5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA6.BackColor = Color.Red;
                BTNA6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA7.BackColor = Color.Red;
                BTNA7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA8.BackColor = Color.Red;
                BTNA8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB1.BackColor = Color.Red;
                BTNB1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB2.BackColor = Color.Red;
                BTNB2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB3.BackColor = Color.Red;
                BTNB3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB4.BackColor = Color.Red;
                BTNB4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB5.BackColor = Color.Red;
                BTNB5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB6.BackColor = Color.Red;
                BTNB6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB7.BackColor = Color.Red;
                BTNB7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC1.BackColor = Color.Red;
                BTNC1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC2.BackColor = Color.Red;
                BTNC2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC3.BackColor = Color.Red;
                BTNC3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC4.BackColor = Color.Red;
                BTNC4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC5.BackColor = Color.Red;
                BTNC5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC6.BackColor = Color.Red;
                BTNC6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC7.BackColor = Color.Red;
                BTNC7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC8.BackColor = Color.Red;
                BTNC8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND1.BackColor = Color.Red;
                BTND1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND2.BackColor = Color.Red;
                BTND2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND3.BackColor = Color.Red;
                BTND3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND4.BackColor = Color.Red;
                BTND4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND5.BackColor = Color.Red;
                BTND5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND6.BackColor = Color.Red;
                BTND6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND7.BackColor = Color.Red;
                BTND7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton3.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND8.BackColor = Color.Red;
                BTND8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();

            baglanti.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            butonBoya();
            bunifuGroupBox1.Visible = true;
            SqlConnection baglanti = new SqlConnection("server =.; Initial Catalog = sinemadb; Integrated Security = SSPI");
            baglanti.Open();
            SqlCommand koltuk_Var_Mi1 = new SqlCommand("SELECT COUNT(*) FROM tblbiletkontrol WHERE (biletKoltuk=@bk AND biletSaat=@bs AND biletAd=@ba)", baglanti);
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            int filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            int saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA1.BackColor = Color.Red;
                BTNA1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA2.BackColor = Color.Red;
                BTNA2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA3.BackColor = Color.Red;
                BTNA3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA4.BackColor = Color.Red;
                BTNA4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA5.BackColor = Color.Red;
                BTNA5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA6.BackColor = Color.Red;
                BTNA6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA7.BackColor = Color.Red;
                BTNA7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "A8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNA8.BackColor = Color.Red;
                BTNA8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB1.BackColor = Color.Red;
                BTNB1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB2.BackColor = Color.Red;
                BTNB2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB3.BackColor = Color.Red;
                BTNB3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB4.BackColor = Color.Red;
                BTNB4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB5.BackColor = Color.Red;
                BTNB5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB6.BackColor = Color.Red;
                BTNB6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB7.BackColor = Color.Red;
                BTNB7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "B8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNB8.BackColor = Color.Red;
                BTNB8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC1.BackColor = Color.Red;
                BTNC1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC2.BackColor = Color.Red;
                BTNC2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC3.BackColor = Color.Red;
                BTNC3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC4.BackColor = Color.Red;
                BTNC4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC5.BackColor = Color.Red;
                BTNC5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC6.BackColor = Color.Red;
                BTNC6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC7.BackColor = Color.Red;
                BTNC7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "C8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTNC8.BackColor = Color.Red;
                BTNC8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D1");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND1.BackColor = Color.Red;
                BTND1.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D2");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND2.BackColor = Color.Red;
                BTND2.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D3");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND3.BackColor = Color.Red;
                BTND3.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D4");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND4.BackColor = Color.Red;
                BTND4.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D5");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND5.BackColor = Color.Red;
                BTND5.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D6");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND6.BackColor = Color.Red;
                BTND6.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D7");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND7.BackColor = Color.Red;
                BTND7.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();
            koltuk_Var_Mi1.Parameters.AddWithValue("@bk", "D8");
            koltuk_Var_Mi1.Parameters.AddWithValue("@bs", radioButton4.Text);
            koltuk_Var_Mi1.Parameters.AddWithValue("@ba", bunifuDropdown1.Text);
            filmVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            koltukVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            saatVarMi = (int)koltuk_Var_Mi1.ExecuteScalar();
            if (koltukVarMi > 0 && saatVarMi > 0 && filmVarMi > 0)
            {
                BTND8.BackColor = Color.Red;
                BTND8.ForeColor = Color.White;
            }
            koltuk_Var_Mi1.Parameters.Clear();

            baglanti.Close();
        }
    }
}
