using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proje_otomasyon
{
    public partial class Form1 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut;
        OleDbDataReader oku;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnkgiris_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = "select * from kullanici where k_kadi=@kadi and k_sifre=@sifre";
            komut.Parameters.AddWithValue("@kadi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Hoşgeldiniz");
                anamenu a = new anamenu();
                this.Hide();
                a.Show();
            }
            else
                MessageBox.Show("Kullanıcı ya da Şifre Yanlış");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (baglan.State==ConnectionState.Closed)
            {
                baglan.Open();
                
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayitol_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            this.Hide();
            b.Show();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           


        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            musterigirisi abc = new musterigirisi();
            this.Hide();
            abc.Show();
        }
    }
}
