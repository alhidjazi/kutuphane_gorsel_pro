
namespace de.pro
{
    partial class FrmBilgiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiGuncelle));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.mskTCno = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.tbDogumtarih = new System.Windows.Forms.TextBox();
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
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTCno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(266, 450);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 31);
            this.btnCikis.TabIndex = 52;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(119, 439);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 37);
            this.btnGuncelle.TabIndex = 51;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // mskTCno
            // 
            this.mskTCno.BackColor = System.Drawing.Color.Silver;
            this.mskTCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTCno.Location = new System.Drawing.Point(119, 9);
            this.mskTCno.Mask = "00000000000";
            this.mskTCno.Name = "mskTCno";
            this.mskTCno.Size = new System.Drawing.Size(166, 26);
            this.mskTCno.TabIndex = 50;
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.Color.Silver;
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(119, 224);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(121, 26);
            this.mskTelefon.TabIndex = 49;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.Color.Silver;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KIZ"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(119, 136);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbCinsiyet.TabIndex = 48;
            // 
            // tbDogumtarih
            // 
            this.tbDogumtarih.BackColor = System.Drawing.Color.Silver;
            this.tbDogumtarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDogumtarih.Location = new System.Drawing.Point(117, 179);
            this.tbDogumtarih.Name = "tbDogumtarih";
            this.tbDogumtarih.Size = new System.Drawing.Size(166, 26);
            this.tbDogumtarih.TabIndex = 46;
            // 
            // tbSoyad
            // 
            this.tbSoyad.BackColor = System.Drawing.Color.Silver;
            this.tbSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyad.Location = new System.Drawing.Point(119, 93);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(166, 26);
            this.tbSoyad.TabIndex = 45;
            // 
            // tbAd
            // 
            this.tbAd.BackColor = System.Drawing.Color.Silver;
            this.tbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAd.Location = new System.Drawing.Point(119, 50);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(166, 26);
            this.tbAd.TabIndex = 44;
            // 
            // tbAdres
            // 
            this.tbAdres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres.Location = new System.Drawing.Point(120, 353);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(166, 69);
            this.tbAdres.TabIndex = 43;
            // 
            // tbSifre
            // 
            this.tbSifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSifre.Location = new System.Drawing.Point(119, 310);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(166, 26);
            this.tbSifre.TabIndex = 47;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbEposta
            // 
            this.tbEposta.BackColor = System.Drawing.Color.Silver;
            this.tbEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEposta.Location = new System.Drawing.Point(119, 267);
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(166, 26);
            this.tbEposta.TabIndex = 42;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(59, 359);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(53, 16);
            this.lblAdres.TabIndex = 41;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(69, 312);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 16);
            this.lblSifre.TabIndex = 40;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(45, 269);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(66, 16);
            this.lblEposta.TabIndex = 39;
            this.lblEposta.Text = "E-posta:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(48, 226);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 16);
            this.lblTelefon.TabIndex = 38;
            this.lblTelefon.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(44, 140);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(67, 16);
            this.lblCinsiyet.TabIndex = 36;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(55, 97);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 16);
            this.lblSoyad.TabIndex = 35;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(36, 424);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(81, 54);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 16);
            this.lblAd.TabIndex = 34;
            this.lblAd.Text = "Ad:";
            // 
            // lblTCno
            // 
            this.lblTCno.AutoSize = true;
            this.lblTCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCno.Location = new System.Drawing.Point(57, 11);
            this.lblTCno.Name = "lblTCno";
            this.lblTCno.Size = new System.Drawing.Size(53, 16);
            this.lblTCno.TabIndex = 31;
            this.lblTCno.Text = "TC.no:";
            // 
            // FrmBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(300, 485);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.mskTCno);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.tbDogumtarih);
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
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTCno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilgiGuncelle";
            this.Load += new System.EventHandler(this.FrmBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MaskedTextBox mskTCno;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox tbDogumtarih;
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
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTCno;
    }
}