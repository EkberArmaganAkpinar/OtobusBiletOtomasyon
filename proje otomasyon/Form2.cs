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
    public partial class Form2 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        public Form2()
        {
            InitializeComponent();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void Kaydet_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı Adı Giriniz");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Şifre Giriniz");
                return;
            }
            
            OleDbCommand kontrolet = new OleDbCommand();
            kontrolet.Connection = baglan;
            kontrolet.CommandText = "select k_kadi from kullanici where k_kadi=@k_kadi";
            kontrolet.Parameters.AddWithValue("@k_kadi", textBox1.Text);
            oku = kontrolet.ExecuteReader();
            if (oku.Read())//boş mu dolu mu
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı kullanılmaktadır");
                return;
            }

            komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = "insert into kullanici(k_kadi,k_sifre) values(@kadi,@sifre)";
            komut.Parameters.AddWithValue("@kadi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Tamamlanmıştır");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();

            }
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }
    }
}
