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
    public partial class FrmPersonelGirisi : Form
    {
        public FrmPersonelGirisi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();

        //----------------doğrulama metodu---------
        private bool kullanicidogrula(string kTC, string kSifre)
        {
            var sorgu = from p in db.Tbl_personel
                        where p.PersonelTC == kTC
                         && p.PersonelSifre == kSifre
                        select p;
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
            if (mskPersonelTC.Text != "" && tbSifre.Text != "")
            {
                //SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_personel WHERE PersonelTC=@p1 And PersonelSifre=@p2", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", mskPersonelTC.Text);
                //komut.Parameters.AddWithValue("@p2", tbSifre.Text);
                //SqlDataReader dr = komut.ExecuteReader();
                //if (dr.Read())
                //{
                //    FrmTumİslem frm = new FrmTumİslem();
                //    frm.Show();
                //    this.Hide();
                //}
                if (kullanicidogrula(mskPersonelTC.Text, tbSifre.Text))
                {
                    FrmTumİslem frm = new FrmTumİslem();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girdiniz Bilgi Hatalıdır!!! Lütfen Tekrar Deneyin!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGirisYap_MouseEnter(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Green;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Transparent;
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
