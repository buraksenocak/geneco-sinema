using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class muhasebe : Form
    {
        public muhasebe()
        {
            InitializeComponent();
        }

        private void muhasebe_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Enabled = false;
            bunifuTextBox2.Enabled = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ypaneli panel=new ypaneli();
            panel.Show();
            this.Hide();
        }
    }
}
