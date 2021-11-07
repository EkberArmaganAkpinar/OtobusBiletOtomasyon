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
    public partial class messagebox : Form
    {
        public messagebox()
        {
            InitializeComponent();

        }
        public int deger = 0;
        public static string cins;
        public static bool cinsata;
        public void mesageboxs(string erkek, string kadın, string mesaj)
        {
            button1.Text = erkek;
            button2.Text = kadın;
            label1.Text = mesaj;

        }
        public void button1_Click(object sender, EventArgs e)
        {
            deger = 1;
            this.Hide();
            cins = button1.Text;
            cinsata = true;
            musteribilgileri a = new musteribilgileri();
            this.Hide();
            a.Show();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            deger = 2;
            this.Hide();
            cins = button2.Text;
            cinsata = false;
            musteribilgileri a = new musteribilgileri();
            this.Hide();
            a.Show();
        }

        private void messagebox_Load(object sender, EventArgs e)
        {

        }

        private void messagebox_FormClosed(object sender, FormClosedEventArgs e)
        {
            musterigirisi z = new musterigirisi();
            z.Show();
            this.Hide();
        }
        

        
    }
}
