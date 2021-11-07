namespace proje_otomasyon
{
    partial class musteribilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.tbtelefon = new System.Windows.Forms.TextBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbkno = new System.Windows.Forms.TextBox();
            this.tbcinsiyet = new System.Windows.Forms.TextBox();
            this.tbsefer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saat = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.sefernumarasi = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.Label();
            this.nereden = new System.Windows.Forms.Label();
            this.nereye = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.Label();
            this.btnmail = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1278, 658);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnyazdir);
            this.tabPage1.Controls.Add(this.tbmail);
            this.tabPage1.Controls.Add(this.tbtelefon);
            this.tabPage1.Controls.Add(this.tbtc);
            this.tabPage1.Controls.Add(this.tbsoyadi);
            this.tabPage1.Controls.Add(this.tbadi);
            this.tabPage1.Controls.Add(this.tbkno);
            this.tabPage1.Controls.Add(this.tbcinsiyet);
            this.tabPage1.Controls.Add(this.tbsefer);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1270, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbmail
            // 
            this.tbmail.Location = new System.Drawing.Point(873, 110);
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(241, 22);
            this.tbmail.TabIndex = 17;
            // 
            // tbtelefon
            // 
            this.tbtelefon.Location = new System.Drawing.Point(873, 33);
            this.tbtelefon.MaxLength = 11;
            this.tbtelefon.Name = "tbtelefon";
            this.tbtelefon.Size = new System.Drawing.Size(241, 22);
            this.tbtelefon.TabIndex = 16;
            this.tbtelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtelefon_KeyPress);
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(224, 393);
            this.tbtc.MaxLength = 11;
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(239, 22);
            this.tbtc.TabIndex = 15;
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtc_KeyPress);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(224, 306);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(239, 22);
            this.tbsoyadi.TabIndex = 14;
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyadi_KeyPress);
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(224, 238);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(239, 22);
            this.tbadi.TabIndex = 13;
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadi_KeyPress);
            // 
            // tbkno
            // 
            this.tbkno.Enabled = false;
            this.tbkno.Location = new System.Drawing.Point(224, 164);
            this.tbkno.Name = "tbkno";
            this.tbkno.Size = new System.Drawing.Size(239, 22);
            this.tbkno.TabIndex = 12;
            // 
            // tbcinsiyet
            // 
            this.tbcinsiyet.Enabled = false;
            this.tbcinsiyet.Location = new System.Drawing.Point(224, 95);
            this.tbcinsiyet.Name = "tbcinsiyet";
            this.tbcinsiyet.Size = new System.Drawing.Size(239, 22);
            this.tbcinsiyet.TabIndex = 11;
            // 
            // tbsefer
            // 
            this.tbsefer.Enabled = false;
            this.tbsefer.Location = new System.Drawing.Point(224, 34);
            this.tbsefer.Name = "tbsefer";
            this.tbsefer.Size = new System.Drawing.Size(239, 22);
            this.tbsefer.TabIndex = 10;
            this.tbsefer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "E-Mail ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(682, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "TC Numarası";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sefer Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cinsiyet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proje_otomasyon.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(1167, 556);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje_otomasyon.Properties.Resources.back_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 549);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnmail);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1270, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bilet Çıkarma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.sefernumarasi);
            this.groupBox1.Controls.Add(this.adi);
            this.groupBox1.Controls.Add(this.nereden);
            this.groupBox1.Controls.Add(this.nereye);
            this.groupBox1.Controls.Add(this.soyadi);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Location = new System.Drawing.Point(625, 146);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(37, 17);
            this.saat.TabIndex = 9;
            this.saat.Text = "Saat";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(622, 87);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(41, 17);
            this.tarih.TabIndex = 8;
            this.tarih.Text = "Tarih";
            // 
            // sefernumarasi
            // 
            this.sefernumarasi.AutoSize = true;
            this.sefernumarasi.Location = new System.Drawing.Point(619, 37);
            this.sefernumarasi.Name = "sefernumarasi";
            this.sefernumarasi.Size = new System.Drawing.Size(106, 17);
            this.sefernumarasi.TabIndex = 7;
            this.sefernumarasi.Text = "Sefer Numarası";
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(23, 18);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(28, 17);
            this.adi.TabIndex = 6;
            this.adi.Text = "Adı";
            // 
            // nereden
            // 
            this.nereden.AutoSize = true;
            this.nereden.Location = new System.Drawing.Point(23, 111);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(63, 17);
            this.nereden.TabIndex = 3;
            this.nereden.Text = "Nereden";
            // 
            // nereye
            // 
            this.nereye.AutoSize = true;
            this.nereye.Location = new System.Drawing.Point(23, 167);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(54, 17);
            this.nereye.TabIndex = 4;
            this.nereye.Text = "Nereye";
            // 
            // soyadi
            // 
            this.soyadi.AutoSize = true;
            this.soyadi.Location = new System.Drawing.Point(23, 61);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(51, 17);
            this.soyadi.TabIndex = 5;
            this.soyadi.Text = "Soyadı";
            // 
            // btnmail
            // 
            this.btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmail.Location = new System.Drawing.Point(486, 423);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(360, 91);
            this.btnmail.TabIndex = 0;
            this.btnmail.Text = "Onayla ve Mail Gönder";
            this.btnmail.UseVisualStyleBackColor = true;
            this.btnmail.Click += new System.EventHandler(this.btnmail_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proje_otomasyon.Properties.Resources.back_icon2;
            this.pictureBox3.Location = new System.Drawing.Point(6, 542);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnyazdir
            // 
            this.btnyazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyazdir.Location = new System.Drawing.Point(754, 238);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(360, 91);
            this.btnyazdir.TabIndex = 18;
            this.btnyazdir.Text = "Alınan Biletleri Göster";
            this.btnyazdir.UseVisualStyleBackColor = true;
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // musteribilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 664);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musteribilgileri";
            this.Text = "5";
            this.Load += new System.EventHandler(this.musteribilgileri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.TextBox tbtelefon;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbkno;
        private System.Windows.Forms.TextBox tbcinsiyet;
        private System.Windows.Forms.TextBox tbsefer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label sefernumarasi;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.Label nereden;
        private System.Windows.Forms.Label nereye;
        private System.Windows.Forms.Label soyadi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnyazdir;
    }
}