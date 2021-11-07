namespace proje_otomasyon
{
    partial class Form3
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
            this.duzenle = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.geridon = new System.Windows.Forms.Button();
            this.ssaat = new System.Windows.Forms.TextBox();
            this.uucret = new System.Windows.Forms.TextBox();
            this.sseferno = new System.Windows.Forms.TextBox();
            this.nnerden = new System.Windows.Forms.ComboBox();
            this.nnereye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column8,
            this.Column7,
            this.Column6,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // duzenle
            // 
            this.duzenle.BackColor = System.Drawing.Color.Yellow;
            this.duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duzenle.Location = new System.Drawing.Point(834, 352);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(98, 53);
            this.duzenle.TabIndex = 1;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = false;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // tamam
            // 
            this.tamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.tamam.Enabled = false;
            this.tamam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tamam.Location = new System.Drawing.Point(957, 352);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(98, 53);
            this.tamam.TabIndex = 2;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.iptal.Enabled = false;
            this.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iptal.Location = new System.Drawing.Point(1078, 352);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(98, 53);
            this.iptal.TabIndex = 3;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(64)))));
            this.geridon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geridon.Location = new System.Drawing.Point(1194, 352);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(98, 53);
            this.geridon.TabIndex = 4;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = false;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // ssaat
            // 
            this.ssaat.Location = new System.Drawing.Point(159, 244);
            this.ssaat.MaxLength = 5;
            this.ssaat.Name = "ssaat";
            this.ssaat.Size = new System.Drawing.Size(245, 22);
            this.ssaat.TabIndex = 6;
            this.ssaat.TextChanged += new System.EventHandler(this.ssaat_TextChanged);
            this.ssaat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssaat_KeyPress);
            // 
            // uucret
            // 
            this.uucret.Location = new System.Drawing.Point(159, 295);
            this.uucret.MaxLength = 3;
            this.uucret.Name = "uucret";
            this.uucret.Size = new System.Drawing.Size(245, 22);
            this.uucret.TabIndex = 7;
            this.uucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uucret_KeyPress);
            // 
            // sseferno
            // 
            this.sseferno.Location = new System.Drawing.Point(159, 339);
            this.sseferno.Name = "sseferno";
            this.sseferno.Size = new System.Drawing.Size(245, 22);
            this.sseferno.TabIndex = 8;
            this.sseferno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sseferno_KeyPress);
            // 
            // nnerden
            // 
            this.nnerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nnerden.FormattingEnabled = true;
            this.nnerden.Items.AddRange(new object[] {
            "Seçiniz"});
            this.nnerden.Location = new System.Drawing.Point(856, 181);
            this.nnerden.Name = "nnerden";
            this.nnerden.Size = new System.Drawing.Size(121, 24);
            this.nnerden.TabIndex = 10;
            // 
            // nnereye
            // 
            this.nnereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nnereye.FormattingEnabled = true;
            this.nnereye.Items.AddRange(new object[] {
            "Seçiniz"});
            this.nnereye.Location = new System.Drawing.Point(856, 244);
            this.nnereye.Name = "nnereye";
            this.nnereye.Size = new System.Drawing.Size(121, 24);
            this.nnereye.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nereye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nereden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sefer No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ücret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Saat";
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Location = new System.Drawing.Point(45, 194);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(41, 17);
            this.Tarih.TabIndex = 18;
            this.Tarih.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Otobüs Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz",
            "2+1",
            "2+2"});
            this.comboBox1.Location = new System.Drawing.Point(856, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "s_no";
            this.Column1.HeaderText = "Sefer Numarası";
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "s_nereye";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "s_nereden";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "s_saat";
            this.Column8.HeaderText = "Saat";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "otobustipi";
            this.Column7.HeaderText = "OtobüsTipi";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "s_ucret";
            this.Column6.HeaderText = "Ücret";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sehir";
            this.Column4.HeaderText = "Nereye";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sehir2";
            this.Column3.HeaderText = "Nereden";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "s_tarih";
            this.Column5.HeaderText = "Tarih";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "s_id";
            this.Column2.HeaderText = "Sefer ID";
            this.Column2.Name = "Column2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1327, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nnereye);
            this.Controls.Add(this.nnerden);
            this.Controls.Add(this.sseferno);
            this.Controls.Add(this.uucret);
            this.Controls.Add(this.ssaat);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.TextBox ssaat;
        private System.Windows.Forms.TextBox uucret;
        private System.Windows.Forms.TextBox sseferno;
        private System.Windows.Forms.ComboBox nnerden;
        private System.Windows.Forms.ComboBox nnereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}