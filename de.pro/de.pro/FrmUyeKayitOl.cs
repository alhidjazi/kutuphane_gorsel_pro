using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace de.pro
{
    public partial class FrmUyeKayitOl : Form
    {
        public FrmUyeKayitOl()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        void temizle()
        {
            mskTCno.Clear();
            tbAd.Clear();
            tbSoyad.Clear();
            tbAdres.Clear();
            tbSifre.Clear();
            cmbCinsiyet.Text = "";
            dtpDogum.Text = "";
            mskTelefon.Clear();
            tbEposta.Clear();
        }
        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            if (mskTCno.Text != "" && tbAd.Text != "" && tbSoyad.Text != "" && cmbCinsiyet.Text != "" && dtpDogum.Text != "" && mskTelefon.Text != "" && tbEposta.Text != "" && tbSifre.Text != "" && tbAdres.Text != "")
            {
                //SqlCommand komut = new SqlCommand("insert into Tbl_Uyeler(UyeTC,UyeAd,UyeSoyad,UyeCinsiyet,UyeDogumtarih,UyeTelefon,UyeEposta,UyeSifre,UyeAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", mskTCno.Text);
                //komut.Parameters.AddWithValue("@p2", tbAd.Text);
                //komut.Parameters.AddWithValue("@p3", tbSoyad.Text);
                //komut.Parameters.AddWithValue("@p4", cmbCinsiyet.Text);
                //komut.Parameters.AddWithValue("@p5", dtpDogum.Text);
                //komut.Parameters.AddWithValue("@p6", mskTelefon.Text);
                //komut.Parameters.AddWithValue("@p7", tbEposta.Text);
                //komut.Parameters.AddWithValue("@p8", tbSifre.Text);
                //komut.Parameters.AddWithValue("@p9", tbAdres.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //-----------Entity metodu ile-------------
                Tbl_Uyeler u = new Tbl_Uyeler();
                u.UyeTC = mskTCno.Text;
                u.UyeAd = tbAd.Text;
                u.UyeSoyad = tbSoyad.Text;
                u.UyeCinsiyet = cmbCinsiyet.Text;
                u.UyeDogumtarih = dtpDogum.Text;
                u.UyeTelefon = mskTelefon.Text;
                u.UyeEposta = tbEposta.Text;
                u.UyeSifre = tbSifre.Text;
                u.UyeAdres = tbAdres.Text;
                db.Tbl_Uyeler.Add(u);
                db.SaveChanges();
                temizle();
                MessageBox.Show("Kayıt Gerçekleştirdi!!!" + tbSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKayitYap_MouseEnter(object sender, EventArgs e)
        {
            btnKayitYap.BackColor = Color.Green;
        }

        private void btnKayitYap_MouseLeave(object sender, EventArgs e)
        {
            btnKayitYap.BackColor = Color.Transparent;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnİptal_MouseEnter(object sender, EventArgs e)
        {
            btnİptal.BackColor = Color.Red;
        }

        private void btnİptal_MouseLeave(object sender, EventArgs e)
        {
            btnİptal.BackColor = Color.Transparent;
        }
    }
}
