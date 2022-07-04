
namespace de.pro
{
    partial class FrmPersonelGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelGirisi));
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.mskPersonelTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblPerTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(255, 37);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(34, 13);
            this.lblCikis.TabIndex = 13;
            this.lblCikis.Text = "Çıkış";
            // 
            // btnİptal
            // 
            this.btnİptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnİptal.BackgroundImage")));
            this.btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(255, 3);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(33, 32);
            this.btnİptal.TabIndex = 11;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            this.btnİptal.MouseEnter += new System.EventHandler(this.btnİptal_MouseEnter);
            this.btnİptal.MouseLeave += new System.EventHandler(this.btnİptal_MouseLeave);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(111, 150);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(103, 33);
            this.btnGirisYap.TabIndex = 12;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.MouseEnter += new System.EventHandler(this.btnGirisYap_MouseEnter);
            this.btnGirisYap.MouseLeave += new System.EventHandler(this.btnGirisYap_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personel Girişi";
            // 
            // tbSifre
            // 
            this.tbSifre.BackColor = System.Drawing.Color.LightGray;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSifre.Location = new System.Drawing.Point(112, 110);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(135, 29);
            this.tbSifre.TabIndex = 9;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // mskPersonelTC
            // 
            this.mskPersonelTC.BackColor = System.Drawing.Color.LightGray;
            this.mskPersonelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskPersonelTC.Location = new System.Drawing.Point(111, 70);
            this.mskPersonelTC.Mask = "00000000000";
            this.mskPersonelTC.Name = "mskPersonelTC";
            this.mskPersonelTC.Size = new System.Drawing.Size(136, 29);
            this.mskPersonelTC.TabIndex = 8;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(60, 110);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 18);
            this.lblSifre.TabIndex = 6;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblPerTC
            // 
            this.lblPerTC.AutoSize = true;
            this.lblPerTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPerTC.Location = new System.Drawing.Point(1, 77);
            this.lblPerTC.Name = "lblPerTC";
            this.lblPerTC.Size = new System.Drawing.Size(107, 18);
            this.lblPerTC.TabIndex = 7;
            this.lblPerTC.Text = "Personel TC:";
            // 
            // FrmPersonelGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(290, 189);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.mskPersonelTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblPerTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.MaskedTextBox mskPersonelTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblPerTC;
    }
}