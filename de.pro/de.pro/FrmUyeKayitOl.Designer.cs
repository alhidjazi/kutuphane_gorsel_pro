
namespace de.pro
{
    partial class FrmUyeKayitOl
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
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnKayitYap = new System.Windows.Forms.Button();
            this.mskTCno = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbEposta = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTCno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDogum
            // 
            this.dtpDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogum.Location = new System.Drawing.Point(125, 182);
            this.dtpDogum.Name = "dtpDogum";
            this.dtpDogum.Size = new System.Drawing.Size(120, 26);
            this.dtpDogum.TabIndex = 31;
            // 
            // btnİptal
            // 
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(206, 442);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(86, 37);
            this.btnİptal.TabIndex = 30;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            this.btnİptal.MouseEnter += new System.EventHandler(this.btnİptal_MouseEnter);
            this.btnİptal.MouseLeave += new System.EventHandler(this.btnİptal_MouseLeave);
            // 
            // btnKayitYap
            // 
            this.btnKayitYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitYap.Location = new System.Drawing.Point(109, 442);
            this.btnKayitYap.Name = "btnKayitYap";
            this.btnKayitYap.Size = new System.Drawing.Size(86, 37);
            this.btnKayitYap.TabIndex = 29;
            this.btnKayitYap.Text = "Kayıt Yap";
            this.btnKayitYap.UseVisualStyleBackColor = true;
            this.btnKayitYap.Click += new System.EventHandler(this.btnKayitYap_Click);
            this.btnKayitYap.MouseEnter += new System.EventHandler(this.btnKayitYap_MouseEnter);
            this.btnKayitYap.MouseLeave += new System.EventHandler(this.btnKayitYap_MouseLeave);
            // 
            // mskTCno
            // 
            this.mskTCno.BackColor = System.Drawing.Color.Silver;
            this.mskTCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTCno.Location = new System.Drawing.Point(124, 12);
            this.mskTCno.Mask = "00000000000";
            this.mskTCno.Name = "mskTCno";
            this.mskTCno.Size = new System.Drawing.Size(166, 26);
            this.mskTCno.TabIndex = 28;
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.Color.Silver;
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(124, 227);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(121, 26);
            this.mskTelefon.TabIndex = 27;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.Color.Silver;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KIZ"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(124, 139);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbCinsiyet.TabIndex = 26;
            // 
            // tbSoyad
            // 
            this.tbSoyad.BackColor = System.Drawing.Color.Silver;
            this.tbSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyad.Location = new System.Drawing.Point(124, 96);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(166, 26);
            this.tbSoyad.TabIndex = 24;
            // 
            // tbAd
            // 
            this.tbAd.BackColor = System.Drawing.Color.Silver;
            this.tbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAd.Location = new System.Drawing.Point(124, 53);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(166, 26);
            this.tbAd.TabIndex = 23;
            // 
            // tbAdres
            // 
            this.tbAdres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres.Location = new System.Drawing.Point(125, 356);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(166, 69);
            this.tbAdres.TabIndex = 25;
            // 
            // tbSifre
            // 
            this.tbSifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSifre.Location = new System.Drawing.Point(124, 313);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(166, 26);
            this.tbSifre.TabIndex = 22;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbEposta
            // 
            this.tbEposta.BackColor = System.Drawing.Color.Silver;
            this.tbEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEposta.Location = new System.Drawing.Point(124, 270);
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(166, 26);
            this.tbEposta.TabIndex = 21;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(64, 362);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(53, 16);
            this.lblAdres.TabIndex = 20;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(74, 315);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 16);
            this.lblSifre.TabIndex = 19;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(50, 272);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(66, 16);
            this.lblEposta.TabIndex = 18;
            this.lblEposta.Text = "E-posta:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(53, 229);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 16);
            this.lblTelefon.TabIndex = 17;
            this.lblTelefon.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(49, 143);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(67, 16);
            this.lblCinsiyet.TabIndex = 15;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(60, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 16);
            this.lblSoyad.TabIndex = 14;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(86, 57);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 16);
            this.lblAd.TabIndex = 13;
            this.lblAd.Text = "Ad:";
            // 
            // lblTCno
            // 
            this.lblTCno.AutoSize = true;
            this.lblTCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCno.Location = new System.Drawing.Point(62, 14);
            this.lblTCno.Name = "lblTCno";
            this.lblTCno.Size = new System.Drawing.Size(53, 16);
            this.lblTCno.TabIndex = 12;
            this.lblTCno.Text = "TC.no:";
            // 
            // FrmUyeKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(306, 487);
            this.Controls.Add(this.dtpDogum);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKayitYap);
            this.Controls.Add(this.mskTCno);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbEposta);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTCno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUyeKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUyeKayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnKayitYap;
        private System.Windows.Forms.MaskedTextBox mskTCno;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbEposta;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTCno;
    }
}