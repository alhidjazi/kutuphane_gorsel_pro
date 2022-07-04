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
    public partial class FrmBilgiGuncelle : Form
    {
        public FrmBilgiGuncelle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        public string TCNo;
        public string ID;

        private void FrmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            mskTCno.Text = TCNo;
            lblID.Text = ID;
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Uyeler WHERE UyeTC=@p1", bgl.sqlbaglntisi());
            komut.Parameters.AddWithValue("@p1", mskTCno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblID.Text = dr[0].ToString();
                tbAd.Text = dr[2].ToString();
                tbSoyad.Text = dr[3].ToString();
                cmbCinsiyet.Text = dr[4].ToString();
                tbDogumtarih.Text = dr[5].ToString();
                mskTelefon.Text = dr[6].ToString();
                tbEposta.Text = dr[7].ToString();
                tbSifre.Text = dr[8].ToString();
                tbAdres.Text = dr[9].ToString();
            }
            bgl.sqlbaglntisi().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("UPDATE Tbl_Uyeler SET UyeAd=@p1, UyeSoyad=@p2, UyeCinsiyet=@p3, UyeDogumtarih=@p4, UyeTelefon=@p5, UyeEposta=@p6, UyeSifre=@p7, UyeAdres=@p8 WHERE UyeTC=@p9", bgl.sqlbaglntisi());
            //komut.Parameters.AddWithValue("@p1", tbAd.Text);
            //komut.Parameters.AddWithValue("@p2", tbSoyad.Text);
            //komut.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
            //komut.Parameters.AddWithValue("@p4", tbDogumtarih.Text);
            //komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
            //komut.Parameters.AddWithValue("@p6", tbEposta.Text);
            //komut.Parameters.AddWithValue("@p7", tbSifre.Text);
            //komut.Parameters.AddWithValue("@p8", tbAdres.Text);
            //komut.Parameters.AddWithValue("@p9", mskTCno.Text);
            //komut.ExecuteNonQuery();
            //bgl.sqlbaglntisi().Close();
            //---------Entity metodu ile -------------
            int deger = Convert.ToInt32(lblID.Text);
            var degisken = db.Tbl_Uyeler.Find(deger);
            degisken.UyeAd = tbAd.Text;
            degisken.UyeSoyad = tbSoyad.Text;
            degisken.UyeCinsiyet = cmbCinsiyet.Text;
            degisken.UyeDogumtarih = tbDogumtarih.Text;
            degisken.UyeTelefon = mskTelefon.Text;
            degisken.UyeSifre = tbSifre.Text;
            degisken.UyeEposta = tbEposta.Text;
            degisken.UyeAdres = tbAdres.Text;
            degisken.UyeTC = mskTCno.Text;
            db.SaveChanges();
            MessageBox.Show("Bilgiler güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Red;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Transparent;
        }
    }
}
