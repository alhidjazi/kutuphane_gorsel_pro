
namespace de.pro
{
    partial class FrmUyeGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeGirisi));
            this.lblCikis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.mskTCno = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(285, 30);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(34, 13);
            this.lblCikis.TabIndex = 18;
            this.lblCikis.Text = "Çıkış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Üye Girişi";
            // 
            // btnİptal
            // 
            this.btnİptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnİptal.BackgroundImage")));
            this.btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnİptal.Location = new System.Drawing.Point(289, 4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(28, 23);
            this.btnİptal.TabIndex = 16;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            this.btnİptal.MouseEnter += new System.EventHandler(this.btnİptal_MouseEnter);
            this.btnİptal.MouseLeave += new System.EventHandler(this.btnİptal_MouseLeave);
            // 
            // mskTCno
            // 
            this.mskTCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTCno.Location = new System.Drawing.Point(142, 49);
            this.mskTCno.Mask = "00000000000";
            this.mskTCno.Name = "mskTCno";
            this.mskTCno.Size = new System.Drawing.Size(173, 26);
            this.mskTCno.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(256, 130);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(144, 127);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(87, 39);
            this.btnGirisYap.TabIndex = 13;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.MouseEnter += new System.EventHandler(this.btnGirisYap_MouseEnter);
            this.btnGirisYap.MouseLeave += new System.EventHandler(this.btnGirisYap_MouseLeave);
            // 
            // tbSifre
            // 
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSifre.Location = new System.Drawing.Point(139, 86);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(176, 26);
            this.tbSifre.TabIndex = 12;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı TC.no:";
            // 
            // FrmUyeGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(321, 172);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.mskTCno);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUyeGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUyeGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.MaskedTextBox mskTCno;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}