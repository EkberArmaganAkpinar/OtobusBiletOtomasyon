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
    public partial class Form4 : Form
    {
          
        public Form4()
        {
            InitializeComponent();
        }
        
        int deger2 = biletalduzenle.deger;
        public static string kno;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\otobus.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader oku;
        public static DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        int guncellemi;
       
      
        private void Form4_Load(object sender, EventArgs e)
        {  
            if (baglan.State==ConnectionState.Closed)
            {
                baglan.Open();
            }
            ds.Clear();
            string sec= "select islem.*,musteri.m_cinsiyet from islem,musteri where islem.tcislem=musteri.m_tc and islem.islemseferno='"+biletalduzenle.snotut+"' order by koltukno asc";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sec, baglan);
            adapter.Fill(ds,"cekcek");
            int kno=999;
            int cinsiyet=2;

            int z = 0;



            if (deger2 == 1)
            {

                int ust = 100; int sol = 10;
              

                    for (int i = 0; i < 30; i++)
                    {



                        Button btn = new Button();
                        btn.Text = (i + 1).ToString();
                        btn.Top = ust;
                        btn.Left = sol;
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.MiddleCenter;//yazının tam ortasında çıkması için
                        btn.Size = new Size(45, 45);

                    for (int j = 0; j < ds.Tables["cekcek"].Rows.Count; j++)
                    {
                        if (ds.Tables["cekcek"].Rows[j]["koltukno"].ToString().Equals((i + 1).ToString()))
                        {
                            if (bool.Parse(ds.Tables["cekcek"].Rows[j]["m_cinsiyet"].ToString())==true)
                            {
                                cinsiyet = 0;
                                break;
                            }
                            else
                            {
                                cinsiyet = 1;
                                break;
                            }
                        }
                    }
                    if(cinsiyet==0)
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bay.png");//kodla butonun arka planını değiştirdik
                    else if(cinsiyet==1)
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bayan.png");//kodla butonun arka planını değiştirdik
                    else
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bos.png");//kodla butonun arka planını değiştirdik

                    cinsiyet = 2;

                    btn.BackgroundImageLayout = ImageLayout.Zoom;//resmi ortalar

                        if (sol == 10)
                        {
                            sol = sol + 200;

                        }
                        else if (sol == 210)
                        {
                            sol = sol + 80;

                        }
                        else if (sol == 290)
                        {
                            ust = ust + 60;
                            sol = 10;
                        }
                        btn.Click += new EventHandler(biletsatis);
                        Controls.Add(btn);
                    } 
                

            }
            else if (deger2 == 2)
            {
                int ust = 100; int sol = 10;
                for (int i = 0; i < 30; i++)
                {

                    Button btn = new Button();
                    btn.Text = (i + 1).ToString();
                    btn.Top = ust;
                    btn.Left = sol;
                    btn.ForeColor = Color.Black;
                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.MiddleCenter;//yazının tam ortasında çıkması için
                    btn.Size = new Size(45, 45);
                    for (int j = 0; j < ds.Tables["cekcek"].Rows.Count; j++)
                    {
                        if (ds.Tables["cekcek"].Rows[j]["koltukno"].ToString().Equals((i + 1).ToString()))
                        {
                            if (bool.Parse(ds.Tables["cekcek"].Rows[j]["m_cinsiyet"].ToString()) == true)
                            {
                                cinsiyet = 0;
                                btn.BackColor = Color.White;
                                break;
                            }
                            else
                            {
                                cinsiyet = 1;
                                btn.BackColor = Color.White;
                                break;
                            }
                        }
                    }
                    guncellemi = cinsiyet;
                    if (cinsiyet == 0)
                    {
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bay.png");//kodla butonun arka planını değiştirdik
                        
                    }
                    else if (cinsiyet == 1)
                    {
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bayan.png");//kodla butonun arka planını değiştirdik
                       
                    }
                    else
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bos.png");//kodla butonun arka planını değiştirdik

                    cinsiyet = 2;
                   
                    btn.BackgroundImageLayout = ImageLayout.Zoom;//resmi ortalar

                    if (sol == 10)
                    {
                        sol = sol + 70;

                    }
                    else if (sol == 80)
                    {
                        sol = sol + 140;

                    }
                    else if (sol == 220)
                    {
                        sol = sol + 70;
                    }
                    else if (sol == 290)
                    {
                        ust = ust + 60;
                        sol = 10;
                    }
                    btn.Click += new EventHandler(biletsatis);
                    Controls.Add(btn);

                }




            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            biletalduzenle a = new biletalduzenle();
            this.Hide();
            a.Show();
        }

        public void biletsatis(object sender, EventArgs e) 
        {   
            Button b = (Button)sender;

            for (int i = 0; i < ds.Tables["cekcek"].Rows.Count; i++)
            {
                if(((int.Parse(b.Text))==int.Parse(ds.Tables["cekcek"].Rows[i]["koltukno"].ToString())))
                {  MessageBox.Show("Koltuk Dolu");
                return;
                }
            }
            
            kno = b.Text;
                messagebox mesajci = new messagebox();
                mesajci.mesageboxs("Erkek", "Kadın", "Ciniyet Seçiniz");
                mesajci.ShowDialog();

                if (mesajci.deger == 1)
                {
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bay.png");
                }
                else if (mesajci.deger == 2)
                {
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bayan.png");
                }
                else
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bos.png");
                /*koltuknı burda*/
                this.Hide();

            }
        }
    }


