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
    public partial class Frmİstatistikler : Form
    {
        public Frmİstatistikler()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        private void Frmİstatistikler_Load(object sender, EventArgs e)
        {

            //------Kitap Sayısı-----------

            //SqlCommand komut = new SqlCommand("select count(*) from Tbl_Kitaplar", bgl.sqlbaglntisi());
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    lblKitapSayisi.Text = dr[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblKitapSayisi.Text = db.Tbl_Kitaplar.Count().ToString();

            //-------Personel Sayısı--------
            //SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_personel", bgl.sqlbaglntisi());
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    lblPersonelSyisi.Text = dr2[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblPersonelSyisi.Text = db.Tbl_personel.Count().ToString();


            //---------Üye Sayısı----------
            //SqlCommand komut3 = new SqlCommand("select count (*) from Tbl_Uyeler", bgl.sqlbaglntisi());
            //SqlDataReader dr3 = komut3.ExecuteReader();
            //while (dr3.Read())
            //{
            //    lblUyeSayisi.Text = dr3[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblUyeSayisi.Text = db.Tbl_Uyeler.Count().ToString();

            //--------Emanet'te Kitap Sayısı------------
            //SqlCommand komut4 = new SqlCommand("select count(*) from Tbl_EmanetKitaplar", bgl.sqlbaglntisi());
            //SqlDataReader dr4 = komut4.ExecuteReader();
            //while (dr4.Read())
            //{
            //    lblAnlikOkuyanSyisi.Text = dr4[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblAnlikOkuyanSyisi.Text = db.Tbl_EmanetKitaplar.Count().ToString();

            //---------İade Kitap Sayısı----------
            //SqlCommand komut5 = new SqlCommand("select count(*) from Tbl_İade", bgl.sqlbaglntisi());
            //SqlDataReader dr5 = komut5.ExecuteReader();
            //while (dr5.Read())
            //{
            //    lblİadeKitap.Text = dr5[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblİadeKitap.Text = db.Tbl_İade.Count().ToString();

            //-----------Kayıp Kitaplar-------------
            //SqlCommand komut6 = new SqlCommand("select count (*) from Tbl_Kayip_Kitap", bgl.sqlbaglntisi());
            //SqlDataReader dr6 = komut6.ExecuteReader();
            //while (dr6.Read())
            //{
            //    lblKayipKitapsayisi.Text = dr6[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblKayipKitapsayisi.Text = db.Tbl_Kayip_kitap.Count().ToString();

            //------------Müsait Kitaplar--------------
            //SqlCommand komut7 = new SqlCommand("Select count(*) from Tbl_İade", bgl.sqlbaglntisi());
            //SqlDataReader dr7 = komut7.ExecuteReader();
            //while (dr7.Read())
            //{
            //    lblMusaitkitapsayisi.Text = dr7[0].ToString();
            //}
            //bgl.sqlbaglntisi().Close();
            //-------------Entitu metodu ile-------------------------
            lblMusaitkitapsayisi.Text = db.Tbl_İade.Count().ToString();
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
