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
    public partial class Form3 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        double kontrolharf;
        double kontroldeger =72;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled =  ssaat.Enabled = sseferno.Enabled = uucret.Enabled = nnereye.Enabled = nnerden.Enabled = false;
            if (baglan.State==ConnectionState.Closed)
            {
                baglan.Open();

            }
            komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = "select * from iller order by id asc";//illeri ıd göre artan sıralamaya yarar
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                nnerden.Items.Add(oku["sehir"]);
                nnereye.Items.Add(oku["sehir"]);
               
                
            }
            string seferseckomut = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden"; 
            OleDbDataAdapter da = new OleDbDataAdapter(seferseckomut, baglan);
            da.Fill(ds, "seferler");
            bs.DataSource = ds.Tables["seferler"];
            dataGridView1.DataSource = bs;
            //dateTimePicker1.DataBindings.Add("SelectedValues", bs, "s_tarih");
            ssaat.DataBindings.Add("Text", bs, "s_saat");
            uucret.DataBindings.Add("Text", bs, "s_ucret");
            sseferno.DataBindings.Add("Text", bs, "s_no");
            nnerden.DataBindings.Add("SelectedIndex", bs, "s_nereden");
            nnereye.DataBindings.Add("SelectedIndex", bs, "s_nereye");
           

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            anamenu a = new anamenu();
            this.Hide();
            a.Show();

        }

        private void iptal_Click(object sender, EventArgs e)
        {
          
            tamam.Enabled = iptal.Enabled = false;
            comboBox1.Enabled = ssaat.Enabled = sseferno.Enabled = uucret.Enabled = nnereye.Enabled = nnerden.Enabled = dateTimePicker1.Enabled = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string seferno;
        private void duzenle_Click(object sender, EventArgs e)
        {
           comboBox1.Enabled= ssaat.Enabled = sseferno.Enabled = uucret.Enabled = nnereye.Enabled = nnerden.Enabled=dateTimePicker1.Enabled = true;
            tamam.Enabled = iptal.Enabled = true;
            seferno = sseferno.Text;
            comboBox1.SelectedIndex = 0;

        }
        bool degerkontrol(TextBox t, string alan)
        {
            if (string.IsNullOrEmpty(t.Text)) //boş mu dolumu??
            {
                MessageBox.Show(alan + " için değer giriniz");
                return false;
            }
            return true;
        }
        bool degerkontrol2(ComboBox c, string yer)
        {
            if (c.SelectedIndex <= 0)
            {
                MessageBox.Show(yer + " seçmediniz");
                return false;

            }
            return true;

        }
        bool degerkontrol3(DateTimePicker dt, string yer2)
        {
            if (string.IsNullOrEmpty(dt.Text))
            {
                MessageBox.Show(yer2 + "için tarih giriniz");
                return false;
            }
            return true;
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            if (kontrolharf > 24)
            {
                MessageBox.Show("Yanlış Saat Değeri Girdiniz");
                return;
            }
            bool b, c, d, f, g, h,j;
            b = degerkontrol(sseferno, "Sefer numarası");
            c = degerkontrol(ssaat, "Saat");
            d = degerkontrol3(dateTimePicker1, "Tarih");
            f = degerkontrol(uucret, "Ücret");
            if (b == false || c == false || d == false || f == false)
            {
                return;
            }
            g = degerkontrol2(nnerden, "Nereden");
            h = degerkontrol2(nnereye, "Nereye");
            j = degerkontrol2(comboBox1, "Otobüstipi");
            if (g == false || h == false ||j==false)
            {
                return;

            }

            OleDbCommand kontrol = new OleDbCommand();
            kontrol.Connection = baglan;
            kontrol.CommandText = "select s_no from seferler where s_no = @s_no";
            kontrol.Parameters.AddWithValue("@s_no", sseferno.Text);
            OleDbDataReader dre = kontrol.ExecuteReader();

            if (dre.Read() && !dre["s_no"].ToString().Equals(seferno))//değer varsa anlamında
            {
               


                    MessageBox.Show("Girdiğiniz sefer numarası kullanılmaktadır");
                    return;
                
            }
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.Connection = baglan;
            guncelle.CommandText = "update seferler set s_no=@s_no ,s_tarih=@s_tarih,s_saat=@s_saat,s_ucret=@s_ucret,s_nereden=@s_nereden,s_nereye=@s_nereye,otobustipi=@otobustipi where s_no=@s_no1";
            guncelle.Parameters.Add("@s_no", sseferno.Text);
            guncelle.Parameters.Add("@s_tarih", dateTimePicker1.Text);
            guncelle.Parameters.Add("@s_saat", ssaat.Text);
            guncelle.Parameters.Add("@s_ucret", uucret.Text);
            guncelle.Parameters.Add("@s_nereden",nnerden.SelectedIndex);
            guncelle.Parameters.Add("@s_nereye",nnereye.SelectedIndex );
            guncelle.Parameters.AddWithValue("@otobustipi", comboBox1.SelectedItem);
            guncelle.Parameters.Add("@s_no1", seferno);
            
            guncelle.ExecuteNonQuery();
            kontrolharf = Convert.ToDouble(ssaat.Text);
         
            MessageBox.Show("Verileriniz güncellenmiştir");
            ds.Clear();
            string a = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden";
            OleDbDataAdapter da = new OleDbDataAdapter(a, baglan);
            da.Fill(ds, "seferler");

            comboBox1.Enabled = ssaat.Enabled = sseferno.Enabled = uucret.Enabled = nnereye.Enabled = nnerden.Enabled = dateTimePicker1.Enabled = false;
            tamam.Enabled = iptal.Enabled = false;

        }

        private void ssaat_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void ssaat_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void uucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sseferno_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
