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
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            this.Hide();
            d.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sefereklecikarform a = new sefereklecikarform();
            this.Hide();
            a.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
