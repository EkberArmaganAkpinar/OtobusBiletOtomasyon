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
    public partial class sefereklecikarform : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        
        
        public sefereklecikarform()
        {
            InitializeComponent();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            seferno.Clear();
            nerden.SelectedIndex = 0;
            nereye.SelectedIndex = 0;
            saat.Clear();
            ucret.Clear();
            comboBox1.Enabled = seferno.Enabled = nerden.Enabled = nereye.Enabled = ucret.Enabled = saat.Enabled = dateTimePicker1.Enabled = iptal.Enabled = btnekle.Enabled = cikar.Enabled = false;
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            anamenu a = new anamenu();
            this.Hide();
            a.Show();
        }

        private void sefereklecikarform_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();

            }
            comboBox1.SelectedIndex = 0;
            komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = "select * from iller order by id asc";//illeri ıd göre artan sıralamaya yarar
            
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                nerden.Items.Add(oku["sehir"]);
                nereye.Items.Add(oku["sehir"]);
            }
            
            
            string seferseckomut = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden";
            OleDbDataAdapter  da = new OleDbDataAdapter(seferseckomut, baglan);
            da.Fill(ds,"seferler");
            bs.DataSource = ds.Tables["seferler"];
            dataGridView1.DataSource = bs;
            seferid.DataBindings.Add("Text", bs, "s_id");
            comboBox1.Enabled=  iptal.Enabled = btnekle.Enabled =dateTimePicker1.Enabled = false;
            
           



       
               
           
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
         bool degerkontrol2(ComboBox c, string yer)
         {
             if (c.SelectedIndex<=0)
             {
                 MessageBox.Show(yer +  " seçmediniz");
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


        private void ekle_Click(object sender, EventArgs e)
         {
             if (string.IsNullOrEmpty(saat.Text))
             {
                 MessageBox.Show("Saat İçin Alan Giriniz");
                 return;
             }
             else
             {

                 double saattut1 = Convert.ToDouble(saat.Text);
                 if (saattut1 > 2400)
                 {
                     MessageBox.Show("Saat Değeri 24 ten büyük olamaz");
                     return;
                 }
             }

             bool b, c, d, f,g,h,j;

             b = degerkontrol(seferno, "Sefer numarası");
             c= degerkontrol(saat, "Saat");
             d=degerkontrol3(dateTimePicker1, "Tarih");
             f=degerkontrol(ucret, "Ücret");
             if (b==false||c==false||d==false||f==false)
             {
                return;
             }
             g = degerkontrol2(nerden, "Nereden");
             h = degerkontrol2(nereye, "Nereye");
             j = degerkontrol2(comboBox1, "Otobüs tipi");
             if (g==false||h==false||j==false)
             {
                 return;
                 
             }
            
            
            
            OleDbCommand kontrol =new OleDbCommand();
            kontrol.Connection=baglan;
            kontrol.CommandText="select s_no from seferler where s_no = @s_no";
            kontrol.Parameters.AddWithValue("@s_no", seferno.Text);
            OleDbDataReader dre=kontrol.ExecuteReader();

            if (dre.Read())//değer varsa anlamında
            {
                MessageBox.Show("Girdiğiniz sefer numarası kullanılmaktadır");
                return;
                
            }
            
            OleDbCommand ekle = new OleDbCommand();
            ekle.Connection = baglan;
            ekle.CommandText=("insert into seferler(s_no,s_nereden,s_nereye,s_saat,s_tarih,s_ucret,otobustipi) values (@s_no,@s_nereden,@s_nereye,@s_saat,@s_tarih,@s_ucret,@otobustipi)");
            ekle.Parameters.AddWithValue("@s_no", seferno.Text);
            ekle.Parameters.AddWithValue("@s_nereden", nerden.SelectedIndex);
            ekle.Parameters.AddWithValue("@s_nereye", nereye.SelectedIndex);
            ekle.Parameters.AddWithValue("@s_saat", saat.Text);
            ekle.Parameters.AddWithValue("@s_tarih", dateTimePicker1.Text);
            ekle.Parameters.AddWithValue("@s_ucret", ucret.Text);
            ekle.Parameters.AddWithValue("@otobustipi", comboBox1.SelectedItem);

            ekle.ExecuteNonQuery();
            MessageBox.Show("Kaydınız yapılmıştır");
            ds.Clear();
            string eklekomut = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden";
            OleDbDataAdapter da2 = new OleDbDataAdapter(eklekomut, baglan);
            da2.Fill(ds, "seferler");
            bs.DataSource = ds.Tables["seferler"];
            dataGridView1.DataSource = bs;
           // seferno.Enabled = nerden.Enabled = nereye.Enabled = ucret.Enabled = saat.Enabled = tarih.Enabled = false;
           comboBox1.Enabled    = seferno.Enabled = nerden.Enabled = nereye.Enabled = ucret.Enabled = saat.Enabled = dateTimePicker1.Enabled = iptal.Enabled =btnekle.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = seferno.Enabled = nerden.Enabled = nereye.Enabled = ucret.Enabled = saat.Enabled = dateTimePicker1.Enabled = iptal.Enabled = btnekle.Enabled = true;
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Çıkarmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim==DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "delete from seferler where s_id=@s_id";
                cmd.Parameters.AddWithValue("@s_id",seferid.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kaydınız silinmiştir");
                ds.Clear();
                string tutkomut = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden";
                OleDbDataAdapter da3 = new OleDbDataAdapter(tutkomut, baglan);
                da3.Fill(ds,"seferler");
                bs.DataSource = ds.Tables["seferler"];
                dataGridView1.DataSource = bs;



             
            }
        }

        private void seferno_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void saat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void seferno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void saat_TextChanged(object sender, EventArgs e)
        {

        }
            
        }
    }

