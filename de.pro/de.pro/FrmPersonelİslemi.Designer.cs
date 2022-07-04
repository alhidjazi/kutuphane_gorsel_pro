
namespace de.pro
{
    partial class FrmPersonelİslemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelİslemi));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbEposta = new System.Windows.Forms.TextBox();
            this.tbAra = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblAra = new System.Windows.Forms.Label();
            this.lblTemizle = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblDogum = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatAppearance.BorderSize = 3;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(530, 235);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(45, 30);
            this.btnSil.TabIndex = 67;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseEnter += new System.EventHandler(this.btnSil_MouseEnter);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnEkle.FlatAppearance.BorderSize = 3;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(367, 235);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(52, 30);
            this.btnEkle.TabIndex = 66;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseEnter += new System.EventHandler(this.btnEkle_MouseEnter);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnGuncelle.FlatAppearance.BorderSize = 3;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(429, 235);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 30);
            this.btnGuncelle.TabIndex = 65;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseEnter += new System.EventHandler(this.btnGuncelle_MouseEnter);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            // 
            // btnListele
            // 
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnListele.FlatAppearance.BorderSize = 3;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(265, 235);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(91, 30);
            this.btnListele.TabIndex = 64;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            this.btnListele.MouseEnter += new System.EventHandler(this.btnListele_MouseEnter);
            this.btnListele.MouseLeave += new System.EventHandler(this.btnListele_MouseLeave);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(658, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(31, 29);
            this.btnCikis.TabIndex = 63;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Location = new System.Drawing.Point(657, 235);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(31, 29);
            this.btnTemizle.TabIndex = 62;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            this.btnTemizle.MouseEnter += new System.EventHandler(this.btnTemizle_MouseEnter);
            this.btnTemizle.MouseLeave += new System.EventHandler(this.btnTemizle_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 238);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(434, 63);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(161, 31);
            this.mskTelefon.TabIndex = 60;
            // 
            // mskTC
            // 
            this.mskTC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(434, 24);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(161, 31);
            this.mskTC.TabIndex = 59;
            // 
            // dtpDogum
            // 
            this.dtpDogum.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpDogum.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogum.Location = new System.Drawing.Point(131, 187);
            this.dtpDogum.Name = "dtpDogum";
            this.dtpDogum.Size = new System.Drawing.Size(164, 31);
            this.dtpDogum.TabIndex = 58;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(133, 141);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 33);
            this.cmbCinsiyet.TabIndex = 57;
            // 
            // tbSoyad
            // 
            this.tbSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyad.Location = new System.Drawing.Point(133, 101);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(162, 31);
            this.tbSoyad.TabIndex = 55;
            // 
            // tbAd
            // 
            this.tbAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAd.Location = new System.Drawing.Point(133, 57);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(162, 31);
            this.tbAd.TabIndex = 54;
            // 
            // tbSifre
            // 
            this.tbSifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSifre.Location = new System.Drawing.Point(433, 149);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(101, 31);
            this.tbSifre.TabIndex = 53;
            // 
            // tbEposta
            // 
            this.tbEposta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEposta.Location = new System.Drawing.Point(433, 106);
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(214, 31);
            this.tbEposta.TabIndex = 56;
            // 
            // tbAra
            // 
            this.tbAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAra.Location = new System.Drawing.Point(64, 235);
            this.tbAra.Name = "tbAra";
            this.tbAra.Size = new System.Drawing.Size(190, 31);
            this.tbAra.TabIndex = 52;
            this.tbAra.TextChanged += new System.EventHandler(this.tbAra_TextChanged);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbId.Location = new System.Drawing.Point(133, 13);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 31);
            this.tbId.TabIndex = 51;
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(657, 36);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(34, 13);
            this.lblCikis.TabIndex = 49;
            this.lblCikis.Text = "Çıkış";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(16, 240);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(42, 20);
            this.lblAra.TabIndex = 48;
            this.lblAra.Text = "Ara:";
            // 
            // lblTemizle
            // 
            this.lblTemizle.AutoSize = true;
            this.lblTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemizle.Location = new System.Drawing.Point(584, 239);
            this.lblTemizle.Name = "lblTemizle";
            this.lblTemizle.Size = new System.Drawing.Size(75, 20);
            this.lblTemizle.TabIndex = 47;
            this.lblTemizle.Text = "Temizle:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(381, 153);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 20);
            this.lblSifre.TabIndex = 46;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblDogum
            // 
            this.lblDogum.AutoSize = true;
            this.lblDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogum.Location = new System.Drawing.Point(11, 192);
            this.lblDogum.Name = "lblDogum";
            this.lblDogum.Size = new System.Drawing.Size(120, 20);
            this.lblDogum.TabIndex = 45;
            this.lblDogum.Text = "Doğum Tarihi:";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(356, 110);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(77, 20);
            this.lblEposta.TabIndex = 44;
            this.lblEposta.Text = "E-posta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cinsiyet:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(359, 68);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(74, 20);
            this.lblTelefon.TabIndex = 42;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(67, 106);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(64, 20);
            this.lblSoyad.TabIndex = 41;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(372, 27);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(61, 20);
            this.lblTC.TabIndex = 40;
            this.lblTC.Text = "TC.no:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(95, 63);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(36, 20);
            this.lblad.TabIndex = 50;
            this.lblad.Text = "Ad:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(98, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 20);
            this.lblId.TabIndex = 39;
            this.lblId.Text = "ID:";
            // 
            // FrmPersonelİslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(695, 518);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.dtpDogum);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbEposta);
            this.Controls.Add(this.tbAra);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.lblTemizle);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblDogum);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelİslemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelİslemi";
            this.Load += new System.EventHandler(this.FrmPersonelİslemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbEposta;
        private System.Windows.Forms.TextBox tbAra;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Label lblTemizle;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblDogum;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblId;
    }
}