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
    public partial class FrmUyeGirisi : Form
    {
        public FrmUyeGirisi()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        //----------Entity modeli--------------------------------------
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayitOl frm = new FrmUyeKayitOl();
            frm.Show();
            this.Hide();
        }
        //-------Entity metodu ile ama önce bir metod oluşturduk doğrulasın diye----------
        private bool kullanicidogrula(string kTC, string kSifre)
        {
            var sorgu = from u in db.Tbl_Uyeler
                        where u.UyeTC == kTC
                         && u.UyeSifre == kSifre
                        select u;
            if (sorgu.Any())
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (mskTCno.Text != "" && tbSifre.Text != "")
            {
                //SqlCommand komut = new SqlCommand("select * from Tbl_Uyeler where UyeTC=@p1 and UyeSifre=@p2", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", mskTCno.Text);
                //komut.Parameters.AddWithValue("@p2", tbSifre.Text);
                //SqlDataReader dr = komut.ExecuteReader();
                //if (dr.Read())
                //{
                //    FrmUyeDetay frm = new FrmUyeDetay();
                //    frm.tc = mskTCno.Text;
                //    frm.Show();
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("Hatalı Bir Bilgi Girdiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //bgl.sqlbaglntisi().Close();
                //-------Entity metodu ile----------
                if (kullanicidogrula(mskTCno.Text, tbSifre.Text))
                {
                    FrmUyeDetay frm = new FrmUyeDetay();
                    frm.tc = mskTCno.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Bilgi Girdiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
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

        private void btnGirisYap_MouseEnter(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Green;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Transparent;
        }
    }
}
