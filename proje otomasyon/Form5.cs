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
    public partial class Form5 : Form
    {
       
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader oku;
        DataSet ds = new DataSet();
        OleDbDataAdapter da;
        BindingSource bs = new BindingSource();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (baglan.State==ConnectionState.Closed)
            {
                baglan.Open();
            }
            da = new OleDbDataAdapter("select * from islem", baglan);
            da.Fill(ds, "islem");
            bs.DataSource = ds.Tables["islem"];
            dataGridView1.DataSource = bs;
            tbislemadi. DataBindings.Add("Text", bs, "islemadi");
            tbislemislemid.DataBindings.Add("Text", bs, "i_id");
            tbislemkno. DataBindings.Add("Text", bs, "koltukno");
            tbislemsno. DataBindings.Add("Text", bs, "islemseferno");
            tbislemsoyadi.DataBindings.Add("Text", bs, "islemsoyadi");
            tbislemtc.DataBindings.Add("Text", bs, "tcislem");

            
            
            
            //datagridvievin clickine o an ki satırın işlem id si tutulup sil butonuna basılıp silme işlemi yapılacak

        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Silmek İstediğinizden Eminmisiniz??", "Bilet Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim==DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglan;
                cmd.CommandText=("delete from islem where i_id=@i_id");
                cmd.Parameters.AddWithValue("@i_id", tbislemislemid.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıdınız Silinmiştir");
                ds.Clear();
                string tutkomut = "select * from islem";
                OleDbDataAdapter da3 = new OleDbDataAdapter(tutkomut, baglan);
                da3.Fill(ds, "islem");
                bs.DataSource = ds.Tables["islem"];
                dataGridView1.DataSource = bs;
            }
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            musterigirisi a = new musterigirisi();
            this.Hide();
            a.Show();
        }
    }
}
