using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_otomasyon
{
    public partial class musterigirisi : Form
    {
        public musterigirisi()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            biletalduzenle a = new biletalduzenle();
            this.Hide();
            a.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            this.Hide();
            d.Show();


        }
    }
}
