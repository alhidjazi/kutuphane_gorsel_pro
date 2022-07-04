
namespace de.pro
{
    partial class FrmUyeDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeDetay));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskKSayi = new System.Windows.Forms.MaskedTextBox();
            this.mskBarkod = new System.Windows.Forms.MaskedTextBox();
            this.tbKitapYazari = new System.Windows.Forms.TextBox();
            this.dtpİade = new System.Windows.Forms.DateTimePicker();
            this.tbKitapAd = new System.Windows.Forms.TextBox();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmanetAl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTarihGuncelle = new System.Windows.Forms.Button();
            this.tbTemizle = new System.Windows.Forms.Button();
            this.btnİade = new System.Windows.Forms.Button();
            this.lblTarihGuncelle = new System.Windows.Forms.Label();
            this.lblEmanetAl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(298, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 171);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emanet Bilgileri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(613, 148);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(298, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 98);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Olive;
            this.groupBox2.Controls.Add(this.mskKSayi);
            this.groupBox2.Controls.Add(this.mskBarkod);
            this.groupBox2.Controls.Add(this.tbKitapYazari);
            this.groupBox2.Controls.Add(this.dtpİade);
            this.groupBox2.Controls.Add(this.tbKitapAd);
            this.groupBox2.Controls.Add(this.dtpTeslim);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnEmanetAl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnTarihGuncelle);
            this.groupBox2.Controls.Add(this.tbTemizle);
            this.groupBox2.Controls.Add(this.btnİade);
            this.groupBox2.Controls.Add(this.lblTarihGuncelle);
            this.groupBox2.Controls.Add(this.lblEmanetAl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(922, 119);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // mskKSayi
            // 
            this.mskKSayi.Enabled = false;
            this.mskKSayi.Location = new System.Drawing.Point(191, 57);
            this.mskKSayi.Mask = "1";
            this.mskKSayi.Name = "mskKSayi";
            this.mskKSayi.Size = new System.Drawing.Size(23, 20);
            this.mskKSayi.TabIndex = 20;
            // 
            // mskBarkod
            // 
            this.mskBarkod.Enabled = false;
            this.mskBarkod.Location = new System.Drawing.Point(83, 56);
            this.mskBarkod.Mask = "k000";
            this.mskBarkod.Name = "mskBarkod";
            this.mskBarkod.Size = new System.Drawing.Size(53, 20);
            this.mskBarkod.TabIndex = 20;
            // 
            // tbKitapYazari
            // 
            this.tbKitapYazari.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbKitapYazari.Enabled = false;
            this.tbKitapYazari.Location = new System.Drawing.Point(308, 25);
            this.tbKitapYazari.Name = "tbKitapYazari";
            this.tbKitapYazari.Size = new System.Drawing.Size(129, 20);
            this.tbKitapYazari.TabIndex = 14;
            // 
            // dtpİade
            // 
            this.dtpİade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpİade.Location = new System.Drawing.Point(563, 54);
            this.dtpİade.Name = "dtpİade";
            this.dtpİade.Size = new System.Drawing.Size(111, 20);
            this.dtpİade.TabIndex = 18;
            // 
            // tbKitapAd
            // 
            this.tbKitapAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbKitapAd.Enabled = false;
            this.tbKitapAd.Location = new System.Drawing.Point(83, 24);
            this.tbKitapAd.Name = "tbKitapAd";
            this.tbKitapAd.Size = new System.Drawing.Size(161, 20);
            this.tbKitapAd.TabIndex = 15;
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Enabled = false;
            this.dtpTeslim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpTeslim.Location = new System.Drawing.Point(564, 23);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(109, 20);
            this.dtpTeslim.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(310, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 20);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "00";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(276, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Barkod:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(147, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sayı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgilerini Düzen!!!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(248, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yazar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmanetAl
            // 
            this.btnEmanetAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmanetAl.BackgroundImage")));
            this.btnEmanetAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmanetAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmanetAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetAl.Location = new System.Drawing.Point(830, 82);
            this.btnEmanetAl.Name = "btnEmanetAl";
            this.btnEmanetAl.Size = new System.Drawing.Size(32, 29);
            this.btnEmanetAl.TabIndex = 17;
            this.btnEmanetAl.UseVisualStyleBackColor = true;
            this.btnEmanetAl.Click += new System.EventHandler(this.btnEmanetAl_Click);
            this.btnEmanetAl.MouseEnter += new System.EventHandler(this.btnEmanetAl_MouseEnter);
            this.btnEmanetAl.MouseLeave += new System.EventHandler(this.btnEmanetAl_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kitap Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(470, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "İade Tarih:";
            // 
            // btnTarihGuncelle
            // 
            this.btnTarihGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTarihGuncelle.BackgroundImage")));
            this.btnTarihGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTarihGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTarihGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihGuncelle.Location = new System.Drawing.Point(600, 85);
            this.btnTarihGuncelle.Name = "btnTarihGuncelle";
            this.btnTarihGuncelle.Size = new System.Drawing.Size(25, 25);
            this.btnTarihGuncelle.TabIndex = 16;
            this.btnTarihGuncelle.UseVisualStyleBackColor = true;
            this.btnTarihGuncelle.Click += new System.EventHandler(this.btnTarihGuncelle_Click);
            this.btnTarihGuncelle.MouseEnter += new System.EventHandler(this.btnTarihGuncelle_MouseEnter);
            this.btnTarihGuncelle.MouseLeave += new System.EventHandler(this.btnTarihGuncelle_MouseLeave);
            // 
            // tbTemizle
            // 
            this.tbTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTemizle.BackgroundImage")));
            this.tbTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTemizle.Location = new System.Drawing.Point(851, 26);
            this.tbTemizle.Name = "tbTemizle";
            this.tbTemizle.Size = new System.Drawing.Size(35, 30);
            this.tbTemizle.TabIndex = 16;
            this.tbTemizle.UseVisualStyleBackColor = true;
            this.tbTemizle.Click += new System.EventHandler(this.tbTemizle_Click);
            this.tbTemizle.MouseEnter += new System.EventHandler(this.tbTemizle_MouseEnter);
            this.tbTemizle.MouseLeave += new System.EventHandler(this.tbTemizle_MouseLeave);
            // 
            // btnİade
            // 
            this.btnİade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnİade.BackgroundImage")));
            this.btnİade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnİade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİade.Location = new System.Drawing.Point(881, 82);
            this.btnİade.Name = "btnİade";
            this.btnİade.Size = new System.Drawing.Size(35, 30);
            this.btnİade.TabIndex = 16;
            this.btnİade.UseVisualStyleBackColor = true;
            this.btnİade.Click += new System.EventHandler(this.btnİade_Click);
            this.btnİade.MouseEnter += new System.EventHandler(this.btnİade_MouseEnter);
            this.btnİade.MouseLeave += new System.EventHandler(this.btnİade_MouseLeave);
            // 
            // lblTarihGuncelle
            // 
            this.lblTarihGuncelle.AutoSize = true;
            this.lblTarihGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihGuncelle.Location = new System.Drawing.Point(458, 87);
            this.lblTarihGuncelle.Name = "lblTarihGuncelle";
            this.lblTarihGuncelle.Size = new System.Drawing.Size(129, 20);
            this.lblTarihGuncelle.TabIndex = 10;
            this.lblTarihGuncelle.Text = "Tarihi Güncelle";
            this.lblTarihGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmanetAl
            // 
            this.lblEmanetAl.AutoSize = true;
            this.lblEmanetAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmanetAl.Location = new System.Drawing.Point(732, 87);
            this.lblEmanetAl.Name = "lblEmanetAl";
            this.lblEmanetAl.Size = new System.Drawing.Size(92, 20);
            this.lblEmanetAl.TabIndex = 10;
            this.lblEmanetAl.Text = "Emanet Al";
            this.lblEmanetAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(456, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teslim Tarih:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbPer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblYas);
            this.groupBox1.Controls.Add(this.lblTCNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 306);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(18, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Personel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(21, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefon:";
            // 
            // tbPer
            // 
            this.tbPer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPer.Enabled = false;
            this.tbPer.Location = new System.Drawing.Point(103, 219);
            this.tbPer.Name = "tbPer";
            this.tbPer.Size = new System.Drawing.Size(129, 20);
            this.tbPer.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(50, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "AdSoyad:";
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(252, 13);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(29, 30);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(99, 75);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(74, 20);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(91, 170);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(107, 18);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "00000000000";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(95, 128);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(23, 15);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "00";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.Location = new System.Drawing.Point(99, 29);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(119, 20);
            this.lblTCNo.TabIndex = 0;
            this.lblTCNo.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC.No:";
            // 
            // FrmUyeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(927, 436);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUyeDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUyeDetay";
            this.Load += new System.EventHandler(this.FrmUyeDetay_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskKSayi;
        private System.Windows.Forms.MaskedTextBox mskBarkod;
        private System.Windows.Forms.TextBox tbKitapYazari;
        private System.Windows.Forms.DateTimePicker dtpİade;
        private System.Windows.Forms.TextBox tbKitapAd;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmanetAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tbTemizle;
        private System.Windows.Forms.Button btnİade;
        private System.Windows.Forms.Label lblEmanetAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTarihGuncelle;
        private System.Windows.Forms.Label lblTarihGuncelle;
    }
}