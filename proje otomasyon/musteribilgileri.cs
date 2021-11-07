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
using System.Net.Mail;
namespace proje_otomasyon
{
    public partial class musteribilgileri : Form
    {
        string kno2 = Form4.kno;
        string cins2 = messagebox.cins;
        string snotut2 = biletalduzenle.snotut;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader oku;
        public static DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        bool cinsata2 = messagebox.cinsata;
        int tab = 0;
        
        public musteribilgileri()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            this.Hide();
            a.Show();
        }

        private void musteribilgileri_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            tbsefer.Text = snotut2;
            tbcinsiyet.Text = cins2;
            tbkno.Text = kno2;
            komut.Connection = baglan;
            tab = 0;
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool degerkontrol(TextBox t,string alan)
        {
            if (string.IsNullOrEmpty(t.Text)) //boş mu dolumu??
            {
                MessageBox.Show(alan + " için değer giriniz");
                return false;
            }
            return true;
        }
         
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OleDbCommand kontrol = new OleDbCommand();
            kontrol.Connection = baglan;
            kontrol.CommandText = "select m_tc from musteri where m_tc = @m_tc";
            kontrol.Parameters.AddWithValue("@m_tc", tbtc.Text);
            OleDbDataReader dre = kontrol.ExecuteReader();

            if (dre.Read())//değer varsa anlamında
            {
                MessageBox.Show("Girdiğiniz TC numarası kullanılmaktadır");
                return;

            }

            if (tbtc.Text.Length < 11)
            {
                MessageBox.Show("TC Numarası 11 haneden az olamaz ");
                return;

            }
            if (tbtelefon.Text.Length < 11)
            {
                MessageBox.Show("Telefon Numarası 11 haneden az olamaz");
                return;
  }
             bool b, c, d, f,g,h,j,k;
             b = degerkontrol(tbadi, "Adı");
             c= degerkontrol(tbsoyadi, "Soyadı");
             d=degerkontrol(tbcinsiyet, "Cinsiyet");
             f=degerkontrol(tbkno, "Koltuk Numarası");
             g = degerkontrol(tbmail, "E Mail Adresi");
             h = degerkontrol(tbsefer, "Sefer No");
             j = degerkontrol(tbtc, "TC Numarası");
             k = degerkontrol(tbtelefon, "Telefon Numarası");
             if (b==false||c==false||d==false||f==false||g==false||h==false||j==false||k==false)
             {
                return;
             }






             if (tab==0)
             {


                 komut.Connection = baglan;
                 komut.CommandText = ("insert into musteri(m_adi,m_soyadi,m_tc,m_cinsiyet,m_mail,m_telefon) values (@m_adi,@m_soyadi,@m_tc,@m_cinsiyet,@m_mail,@m_telefon)");
                 komut.Parameters.AddWithValue("@m_adi", tbadi.Text);
                 komut.Parameters.AddWithValue("@m_soyadi", tbsoyadi.Text);
                 komut.Parameters.AddWithValue("@m_tc", tbtc.Text);
                 komut.Parameters.AddWithValue("@m_cinsiyet", cinsata2);
                 komut.Parameters.AddWithValue("@m_mail", tbmail.Text);
                 komut.Parameters.AddWithValue("@m_telefon", tbtelefon.Text);
                 komut.ExecuteNonQuery();


                 OleDbDataReader dr;
                 OleDbCommand komut2 = new OleDbCommand();
                 komut2.Connection = baglan;
                 komut2.CommandText = ("select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden and seferler.s_no ='" + snotut2 + "'  ");
                 dr = komut2.ExecuteReader();

                 if (dr.Read())
                 {
                     adi.Text += " " + tbadi.Text;
                     soyadi.Text += " " + tbsoyadi.Text;
                     sefernumarasi.Text += " " + tbsefer.Text;
                     nereden.Text += " " + dr["sehir"].ToString();
                     nereye.Text += " " + dr["sehir2"].ToString();
                     tarih.Text += " " + dr["s_tarih"].ToString();
                     saat.Text += " " + dr["s_saat"].ToString();


                 }

             } tab = 1;
	         tabControl1.SelectedIndex += 1;
        }
        public void gonder(String gonderenMail, String aliciMail, String konu, String icerik, String sifre)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress(gonderenMail);
            ePosta.To.Add(aliciMail);
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential(gonderenMail, sifre);
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;//güvenlik
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (Exception ex)
            {
                kontrol = false;
                MessageBox.Show("Bağlantınızı Kontrol Ediniz");
                return;
            }
        }
        private void btnmail_Click(object sender, EventArgs e)
        {
            
            gonder("ekber_9855@hotmail.com", tbmail.Text, "Zetro turizm", "Biletiniz Alınmıştır Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz", "291098");
        
            OleDbCommand eklemek = new OleDbCommand();
            eklemek.Connection = baglan;
            eklemek.CommandText = ("insert into islem(islemseferno,tcislem,koltukno,islemadi,islemsoyadi) values (@islemseferno,@tcislem,@koltukno,@islemadi,@islemsoyadi) ");
            eklemek.Parameters.AddWithValue("@islemseferno", tbsefer.Text);
            eklemek.Parameters.AddWithValue("@tcislem", tbtc.Text);
            eklemek.Parameters.AddWithValue("@koltukno", tbkno.Text);
            eklemek.Parameters.AddWithValue("@islemadi", tbadi.Text);
            eklemek.Parameters.AddWithValue("islemsoyadi", tbsoyadi.Text);
            eklemek.ExecuteNonQuery();
            MessageBox.Show("Biletiniz alınıp Mailiniz Gönderilmiştir");
            musterigirisi c = new musterigirisi();
            this.Hide();
            c.Show();

           


            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnyazdir_Click(object sender, EventArgs e)
        {   string sec = "select * from islem";
            OleDbDataAdapter da = new OleDbDataAdapter(sec,baglan);
            da.Fill(ds, "islem");
            
            
            Form6 f = new Form6();
            this.Hide();
            f.Show();
        }

        private void tbadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tbsoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tbtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbtelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
