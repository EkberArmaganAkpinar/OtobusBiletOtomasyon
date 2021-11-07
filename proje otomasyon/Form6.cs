using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace proje_otomasyon
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ReportDataSource rsd = new ReportDataSource("DataSet1", musteribilgileri.ds.Tables["islem"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rsd);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            musteribilgileri a = new musteribilgileri();
            a.Show();
            this.Hide();
            
        }
        
    }
}
