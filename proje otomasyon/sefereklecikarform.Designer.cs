namespace proje_otomasyon
{
    partial class sefereklecikarform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sefernumarası = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otobustipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sefertarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferrlernereden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferlernereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereye = new System.Windows.Forms.ComboBox();
            this.nerden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iptal = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.geridon = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.TextBox();
            this.asdsad = new System.Windows.Forms.Label();
            this.ucret = new System.Windows.Forms.TextBox();
            this.yenikayit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.seferno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.seferid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sefernumarası,
            this.otobustipi,
            this.sefertarih,
            this.sid,
            this.sucret,
            this.nereden,
            this.snereye,
            this.seferrlernereden,
            this.seferlernereye,
            this.ssaat});
            this.dataGridView1.Location = new System.Drawing.Point(-2, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // sefernumarası
            // 
            this.sefernumarası.DataPropertyName = "s_no";
            this.sefernumarası.HeaderText = "Sefer Numarası";
            this.sefernumarası.Name = "sefernumarası";
            this.sefernumarası.ReadOnly = true;
            // 
            // otobustipi
            // 
            this.otobustipi.DataPropertyName = "otobustipi";
            this.otobustipi.HeaderText = "Otobüs Tipi";
            this.otobustipi.Name = "otobustipi";
            this.otobustipi.ReadOnly = true;
            // 
            // sefertarih
            // 
            this.sefertarih.DataPropertyName = "s_tarih";
            this.sefertarih.HeaderText = "Tarih";
            this.sefertarih.Name = "sefertarih";
            this.sefertarih.ReadOnly = true;
            // 
            // sid
            // 
            this.sid.DataPropertyName = "s_id";
            this.sid.HeaderText = "Sefer ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Visible = false;
            // 
            // sucret
            // 
            this.sucret.DataPropertyName = "s_ucret";
            this.sucret.HeaderText = "Sefer Ücreti";
            this.sucret.Name = "sucret";
            this.sucret.ReadOnly = true;
            // 
            // nereden
            // 
            this.nereden.DataPropertyName = "sehir";
            this.nereden.HeaderText = "Nereden";
            this.nereden.Name = "nereden";
            this.nereden.ReadOnly = true;
            // 
            // snereye
            // 
            this.snereye.DataPropertyName = "sehir2";
            this.snereye.HeaderText = "Nereye";
            this.snereye.Name = "snereye";
            this.snereye.ReadOnly = true;
            // 
            // seferrlernereden
            // 
            this.seferrlernereden.DataPropertyName = "s_nereye";
            this.seferrlernereden.HeaderText = "Column1";
            this.seferrlernereden.Name = "seferrlernereden";
            this.seferrlernereden.ReadOnly = true;
            this.seferrlernereden.Visible = false;
            // 
            // seferlernereye
            // 
            this.seferlernereye.DataPropertyName = "s_nereden";
            this.seferlernereye.HeaderText = "Column1";
            this.seferlernereye.Name = "seferlernereye";
            this.seferlernereye.ReadOnly = true;
            this.seferlernereye.Visible = false;
            // 
            // ssaat
            // 
            this.ssaat.DataPropertyName = "s_saat";
            this.ssaat.HeaderText = "Saat";
            this.ssaat.Name = "ssaat";
            this.ssaat.ReadOnly = true;
            // 
            // nereye
            // 
            this.nereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nereye.Enabled = false;
            this.nereye.FormattingEnabled = true;
            this.nereye.Items.AddRange(new object[] {
            "Seçiniz"});
            this.nereye.Location = new System.Drawing.Point(735, 229);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(121, 24);
            this.nereye.TabIndex = 1;
            // 
            // nerden
            // 
            this.nerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nerden.Enabled = false;
            this.nerden.FormattingEnabled = true;
            this.nerden.Items.AddRange(new object[] {
            "Seçiniz"});
            this.nerden.Location = new System.Drawing.Point(223, 276);
            this.nerden.Name = "nerden";
            this.nerden.Size = new System.Drawing.Size(121, 24);
            this.nerden.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saat";
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Purple;
            this.iptal.Enabled = false;
            this.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iptal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iptal.Location = new System.Drawing.Point(1033, 394);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(122, 35);
            this.iptal.TabIndex = 9;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Red;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnekle.Location = new System.Drawing.Point(879, 394);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(122, 35);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // cikar
            // 
            this.cikar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cikar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cikar.Location = new System.Drawing.Point(734, 394);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(122, 35);
            this.cikar.TabIndex = 11;
            this.cikar.Text = "Çıkar";
            this.cikar.UseVisualStyleBackColor = false;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.geridon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geridon.ForeColor = System.Drawing.SystemColors.Info;
            this.geridon.Location = new System.Drawing.Point(1187, 394);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(122, 35);
            this.geridon.TabIndex = 12;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = false;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // saat
            // 
            this.saat.Enabled = false;
            this.saat.Location = new System.Drawing.Point(735, 300);
            this.saat.MaxLength = 5;
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(144, 22);
            this.saat.TabIndex = 13;
            this.saat.TextChanged += new System.EventHandler(this.saat_TextChanged);
            this.saat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saat_KeyPress);
            // 
            // asdsad
            // 
            this.asdsad.AutoSize = true;
            this.asdsad.Location = new System.Drawing.Point(99, 407);
            this.asdsad.Name = "asdsad";
            this.asdsad.Size = new System.Drawing.Size(42, 17);
            this.asdsad.TabIndex = 14;
            this.asdsad.Text = "Ücret";
            // 
            // ucret
            // 
            this.ucret.Enabled = false;
            this.ucret.Location = new System.Drawing.Point(223, 407);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(252, 22);
            this.ucret.TabIndex = 15;
            this.ucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucret_KeyPress);
            // 
            // yenikayit
            // 
            this.yenikayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.yenikayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yenikayit.ForeColor = System.Drawing.SystemColors.Info;
            this.yenikayit.Location = new System.Drawing.Point(586, 394);
            this.yenikayit.Name = "yenikayit";
            this.yenikayit.Size = new System.Drawing.Size(122, 35);
            this.yenikayit.TabIndex = 16;
            this.yenikayit.Text = "Yeni Kayıt";
            this.yenikayit.UseVisualStyleBackColor = false;
            this.yenikayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sefer No";
            // 
            // seferno
            // 
            this.seferno.Enabled = false;
            this.seferno.Location = new System.Drawing.Point(223, 230);
            this.seferno.Name = "seferno";
            this.seferno.Size = new System.Drawing.Size(252, 22);
            this.seferno.TabIndex = 18;
            this.seferno.TextChanged += new System.EventHandler(this.seferno_TextChanged);
            this.seferno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seferno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sefer ID";
            // 
            // seferid
            // 
            this.seferid.Enabled = false;
            this.seferid.Location = new System.Drawing.Point(735, 358);
            this.seferid.Name = "seferid";
            this.seferid.Size = new System.Drawing.Size(144, 22);
            this.seferid.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(988, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Otobüs Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz",
            "2+1",
            "2+2"});
            this.comboBox1.Location = new System.Drawing.Point(1119, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // sefereklecikarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1393, 478);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.seferid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seferno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yenikayit);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.asdsad);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nerden);
            this.Controls.Add(this.nereye);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sefereklecikarform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Ekle Çıkar";
            this.Load += new System.EventHandler(this.sefereklecikarform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox nereye;
        private System.Windows.Forms.ComboBox nerden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.TextBox saat;
        private System.Windows.Forms.Label asdsad;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.Button yenikayit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox seferno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox seferid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sefernumarası;
        private System.Windows.Forms.DataGridViewTextBoxColumn otobustipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sefertarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereden;
        private System.Windows.Forms.DataGridViewTextBoxColumn snereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferrlernereden;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferlernereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssaat;
    }
}