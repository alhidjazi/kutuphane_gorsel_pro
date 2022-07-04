
namespace de.pro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblkutuphaneciGirisi = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblHakkimizda = new System.Windows.Forms.Label();
            this.lblUyeİslem = new System.Windows.Forms.Label();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnPersomel = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hayal Kütüphanesine Hoşgeldiniz";
            // 
            // lblkutuphaneciGirisi
            // 
            this.lblkutuphaneciGirisi.AutoSize = true;
            this.lblkutuphaneciGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkutuphaneciGirisi.Location = new System.Drawing.Point(215, 187);
            this.lblkutuphaneciGirisi.Name = "lblkutuphaneciGirisi";
            this.lblkutuphaneciGirisi.Size = new System.Drawing.Size(133, 48);
            this.lblkutuphaneciGirisi.TabIndex = 14;
            this.lblkutuphaneciGirisi.Text = "Kütüphaneci \r\n       Girişi";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(349, 40);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(34, 13);
            this.lblCikis.TabIndex = 12;
            this.lblCikis.Text = "Çıkış";
            // 
            // lblHakkimizda
            // 
            this.lblHakkimizda.AutoSize = true;
            this.lblHakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHakkimizda.Location = new System.Drawing.Point(247, 253);
            this.lblHakkimizda.Name = "lblHakkimizda";
            this.lblHakkimizda.Size = new System.Drawing.Size(101, 18);
            this.lblHakkimizda.TabIndex = 13;
            this.lblHakkimizda.Text = "Hakkımızda:";
            // 
            // lblUyeİslem
            // 
            this.lblUyeİslem.AutoSize = true;
            this.lblUyeİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeİslem.Location = new System.Drawing.Point(62, 188);
            this.lblUyeİslem.Name = "lblUyeİslem";
            this.lblUyeİslem.Size = new System.Drawing.Size(99, 24);
            this.lblUyeİslem.TabIndex = 11;
            this.lblUyeİslem.Text = "Üye Girişi";
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.BackgroundImage")));
            this.btnHakkimizda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHakkimizda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHakkimizda.Location = new System.Drawing.Point(348, 248);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(33, 32);
            this.btnHakkimizda.TabIndex = 9;
            this.btnHakkimizda.UseVisualStyleBackColor = true;
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            this.btnHakkimizda.MouseEnter += new System.EventHandler(this.btnHakkimizda_MouseEnter);
            this.btnHakkimizda.MouseLeave += new System.EventHandler(this.btnHakkimizda_MouseLeave);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(350, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(31, 32);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // btnPersomel
            // 
            this.btnPersomel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersomel.BackgroundImage")));
            this.btnPersomel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersomel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersomel.Location = new System.Drawing.Point(222, 91);
            this.btnPersomel.Name = "btnPersomel";
            this.btnPersomel.Size = new System.Drawing.Size(110, 88);
            this.btnPersomel.TabIndex = 8;
            this.btnPersomel.UseVisualStyleBackColor = true;
            this.btnPersomel.Click += new System.EventHandler(this.btnPersomel_Click);
            this.btnPersomel.MouseEnter += new System.EventHandler(this.btnPersomel_MouseEnter);
            this.btnPersomel.MouseLeave += new System.EventHandler(this.btnPersomel_MouseLeave);
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Location = new System.Drawing.Point(58, 91);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(103, 88);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            this.btnGiris.MouseEnter += new System.EventHandler(this.btnGiris_MouseEnter);
            this.btnGiris.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(386, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblkutuphaneciGirisi);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblHakkimizda);
            this.Controls.Add(this.lblUyeİslem);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnPersomel);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkutuphaneciGirisi;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblHakkimizda;
        private System.Windows.Forms.Label lblUyeİslem;
        private System.Windows.Forms.Button btnHakkimizda;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnPersomel;
        private System.Windows.Forms.Button btnGiris;
    }
}

