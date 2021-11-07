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
    public partial class biletalduzenle : Form
    {
        public static int deger = 0;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        public static string snotut;
        public biletalduzenle()
        {
            InitializeComponent();
        }

        public void biletalduzenle_Load(object sender, EventArgs e)
        {   
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();

            }
            string seferseckomut = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden";//seferler tablasonun tümü ve iller tablasunun sehir alanını çeker as sehir demek datagridde adını değiştirir
            OleDbDataAdapter da = new OleDbDataAdapter(seferseckomut, baglan);
            da.Fill(ds, "seferler");
            bs.DataSource = ds.Tables["seferler"];
            dataGridView1.DataSource = bs;
           // seferid.DataBindings.Add("Text", bs, "s_id");
            sefferno.DataBindings.Add("Text", bs, "s_no");
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



            ds.Clear();
            string sec = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden and iller1.sehir like  '%"+textBox1.Text+"%'";// like anlamı gibi olan
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            da.Fill(ds, "seferler");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            musterigirisi a = new musterigirisi();
            this.Hide();
            a.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            string sec = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden and iller.sehir like  '%" + textBox2.Text + "%'";// like anlamı gibi olan
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            da.Fill(ds, "seferler");
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {   
            if (radioButton1.Checked==false&&radioButton2.Checked==false)
            {
                MessageBox.Show("Herhangi Bir Otobüs Tipi Seçili Değil");
                return;
            }
            snotut = sefferno.Text;
            Form4 b = new Form4();
            this.Hide();
            b.Show();
          
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            deger = 1;
            ds.Clear();
            string sec = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden and seferler.otobustipi ='"+radioButton1.Text+"'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            da.Fill(ds, "seferler");
            
            

        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            deger = 2;
            ds.Clear();
            string sec = "select seferler.*,iller.sehir as sehir,iller1.sehir as sehir2 FROM iller,iller1,seferler WHERE iller.id = seferler.s_nereye and iller1.id = seferler.s_nereden and seferler.otobustipi ='" + radioButton2.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            da.Fill(ds, "seferler");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void dataGridView1_Click(object sender, EventArgs e)
        {
            snotut = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!=08) // Geriye doğru silme tuşu ASCII kodu 78
            {

                if (!char.IsUpper(e.KeyChar) || !char.IsDigit(e.KeyChar)) // Girilen karakter büyük harf değilse yazmaz
                {
                    e.Handled = true;
                } 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 08) // Geriye doğru silme tuşu ASCII kodu 78
            {

                if (!char.IsUpper(e.KeyChar) || !char.IsDigit(e.KeyChar)) // Girilen karakter büyük harf değilse yazmaz
                {
                    e.Handled = true;
                }
            }
        }

     


      

     
    }
}
