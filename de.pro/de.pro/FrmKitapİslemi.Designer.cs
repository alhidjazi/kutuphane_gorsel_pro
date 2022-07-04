
namespace de.pro
{
    partial class FrmKitapİslemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapİslemi));
            this.mskBarkod = new System.Windows.Forms.MaskedTextBox();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblAra = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.tbYayinEvi = new System.Windows.Forms.TextBox();
            this.tbTuru = new System.Windows.Forms.TextBox();
            this.tbAra = new System.Windows.Forms.TextBox();
            this.tbKayitYapanP = new System.Windows.Forms.TextBox();
            this.tbSayfa = new System.Windows.Forms.TextBox();
            this.tbYazar = new System.Windows.Forms.TextBox();
            this.tbKitapAd = new System.Windows.Forms.TextBox();
            this.tbİd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskBarkod
            // 
            this.mskBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskBarkod.Location = new System.Drawing.Point(535, 37);
            this.mskBarkod.Mask = "k-100";
            this.mskBarkod.Name = "mskBarkod";
            this.mskBarkod.Size = new System.Drawing.Size(113, 29);
            this.mskBarkod.TabIndex = 35;
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(710, 34);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(34, 13);
            this.lblCikis.TabIndex = 34;
            this.lblCikis.Text = "Çıkış";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(16, 291);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(42, 20);
            this.lblAra.TabIndex = 33;
            this.lblAra.Text = "Ara:";
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(638, 283);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 36);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseEnter += new System.EventHandler(this.btnSil_MouseEnter);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(518, 283);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 36);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseEnter += new System.EventHandler(this.btnEkle_MouseEnter);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(395, 283);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 36);
            this.btnGuncelle.TabIndex = 30;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseEnter += new System.EventHandler(this.btnGuncelle_MouseEnter);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            // 
            // btnListele
            // 
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(275, 283);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(102, 36);
            this.btnListele.TabIndex = 29;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            this.btnListele.MouseEnter += new System.EventHandler(this.btnListele_MouseEnter);
            this.btnListele.MouseLeave += new System.EventHandler(this.btnListele_MouseLeave);
            // 
            // btnİptal
            // 
            this.btnİptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnİptal.BackgroundImage")));
            this.btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnİptal.Location = new System.Drawing.Point(713, 5);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(28, 25);
            this.btnİptal.TabIndex = 28;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            this.btnİptal.MouseEnter += new System.EventHandler(this.btnİptal_MouseEnter);
            this.btnİptal.MouseLeave += new System.EventHandler(this.btnİptal_MouseLeave);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Location = new System.Drawing.Point(699, 230);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(39, 36);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            this.btnTemizle.MouseEnter += new System.EventHandler(this.btnTemizle_MouseEnter);
            this.btnTemizle.MouseLeave += new System.EventHandler(this.btnTemizle_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 241);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Yeni",
            "Eski"});
            this.cmbDurum.Location = new System.Drawing.Point(535, 177);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 32);
            this.cmbDurum.TabIndex = 25;
            // 
            // tbYayinEvi
            // 
            this.tbYayinEvi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYayinEvi.Location = new System.Drawing.Point(534, 128);
            this.tbYayinEvi.Name = "tbYayinEvi";
            this.tbYayinEvi.Size = new System.Drawing.Size(176, 31);
            this.tbYayinEvi.TabIndex = 23;
            // 
            // tbTuru
            // 
            this.tbTuru.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTuru.Location = new System.Drawing.Point(534, 79);
            this.tbTuru.Name = "tbTuru";
            this.tbTuru.Size = new System.Drawing.Size(176, 31);
            this.tbTuru.TabIndex = 22;
            // 
            // tbAra
            // 
            this.tbAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAra.ForeColor = System.Drawing.Color.Black;
            this.tbAra.Location = new System.Drawing.Point(64, 286);
            this.tbAra.Name = "tbAra";
            this.tbAra.Size = new System.Drawing.Size(185, 31);
            this.tbAra.TabIndex = 24;
            this.tbAra.TextChanged += new System.EventHandler(this.tbAra_TextChanged);
            // 
            // tbKayitYapanP
            // 
            this.tbKayitYapanP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbKayitYapanP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKayitYapanP.Location = new System.Drawing.Point(173, 225);
            this.tbKayitYapanP.Name = "tbKayitYapanP";
            this.tbKayitYapanP.Size = new System.Drawing.Size(176, 31);
            this.tbKayitYapanP.TabIndex = 21;
            // 
            // tbSayfa
            // 
            this.tbSayfa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSayfa.Location = new System.Drawing.Point(173, 178);
            this.tbSayfa.Name = "tbSayfa";
            this.tbSayfa.Size = new System.Drawing.Size(176, 31);
            this.tbSayfa.TabIndex = 20;
            // 
            // tbYazar
            // 
            this.tbYazar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYazar.Location = new System.Drawing.Point(173, 131);
            this.tbYazar.Name = "tbYazar";
            this.tbYazar.Size = new System.Drawing.Size(176, 31);
            this.tbYazar.TabIndex = 19;
            // 
            // tbKitapAd
            // 
            this.tbKitapAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKitapAd.Location = new System.Drawing.Point(173, 83);
            this.tbKitapAd.Name = "tbKitapAd";
            this.tbKitapAd.Size = new System.Drawing.Size(239, 31);
            this.tbKitapAd.TabIndex = 18;
            // 
            // tbİd
            // 
            this.tbİd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbİd.Enabled = false;
            this.tbİd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbİd.Location = new System.Drawing.Point(173, 34);
            this.tbİd.Name = "tbİd";
            this.tbİd.Size = new System.Drawing.Size(46, 31);
            this.tbİd.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(604, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Temizle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(450, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(426, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yayın Evi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(468, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(447, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Barkod:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kayıt yapan P:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sayfa sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // FrmKitapİslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(749, 574);
            this.Controls.Add(this.mskBarkod);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.tbYayinEvi);
            this.Controls.Add(this.tbTuru);
            this.Controls.Add(this.tbAra);
            this.Controls.Add(this.tbKayitYapanP);
            this.Controls.Add(this.tbSayfa);
            this.Controls.Add(this.tbYazar);
            this.Controls.Add(this.tbKitapAd);
            this.Controls.Add(this.tbİd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKitapİslemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapİslemi";
            this.Load += new System.EventHandler(this.FrmKitapİslemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskBarkod;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox tbYayinEvi;
        private System.Windows.Forms.TextBox tbTuru;
        private System.Windows.Forms.TextBox tbAra;
        private System.Windows.Forms.TextBox tbKayitYapanP;
        private System.Windows.Forms.TextBox tbSayfa;
        private System.Windows.Forms.TextBox tbYazar;
        private System.Windows.Forms.TextBox tbKitapAd;
        private System.Windows.Forms.TextBox tbİd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}