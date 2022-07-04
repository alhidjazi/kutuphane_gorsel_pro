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
    public partial class FrmEmanetİslemi : Form
    {
        public FrmEmanetİslemi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        void listele()
        {
            //--------Emanetler Tablosu-----------
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_EmanetKitaplar", bgl.sqlbaglntisi());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //---------Entity metodu ile-------
            dataGridView1.DataSource = db.Tbl_EmanetKitaplar.ToList();
            //---------------Gizleme İşlemi-------------------------------------------
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            //--------Kitaplar Tablosu-----------
            //DataTable dt2 = new DataTable();
            //SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Kitaplar", bgl.sqlbaglntisi());
            //da2.Fill(dt2);
            //dataGridView2.DataSource = dt2;
            //-------Entity metodu ile-----------------------
            dataGridView2.DataSource = db.Tbl_Kitaplar.ToList();
            //-------------------Gizleme İşlemi-----------------------------------
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            //--------Uyeler Tablosu-----------
            //DataTable dt3 = new DataTable();
            //SqlDataAdapter da3 = new SqlDataAdapter("select * from Tbl_Uyeler", bgl.sqlbaglntisi());
            //da3.Fill(dt3);
            //dataGridView3.DataSource = dt3;
            //---------Entity metodu ile----------------------
            dataGridView3.DataSource = db.Tbl_Uyeler.ToList();
            //------------------Gizleme İşlemi------------------------------
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[4].Visible = false;
            dataGridView3.Columns[5].Visible = false;
            dataGridView3.Columns[7].Visible = false;
            dataGridView3.Columns[8].Visible = false;
            dataGridView3.Columns[10].Visible = false;
        }
        void temizle()
        {
            tbID.Clear();
            mskTC.Clear();
            tbAdSoyad.Clear();
            dtpYas.Text = "";
            mskTelefon.Clear();
            mskBarkod.Clear();
            tbKitapAd.Clear();
            tbYazar.Clear();
            mskKitapSayi.Clear();
            dtpTeslimTarih.Text = "";
            dtpİadeTarih.Text = "";
            tbTeslimEdenPer.Clear();
            tbAra.Clear();
            mskTC.Focus();
        }

        private void FrmEmanetİslemi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbAdSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dtpYas.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskBarkod.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tbKitapAd.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tbYazar.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskKitapSayi.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            dtpTeslimTarih.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            dtpİadeTarih.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            tbTeslimEdenPer.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            //tbID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            tbKitapAd.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            mskBarkod.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            tbYazar.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            tbTeslimEdenPer.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            mskTC.Text = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
            tbAdSoyad.Text = dataGridView3.Rows[secilen].Cells[2].Value.ToString();
            mskTelefon.Text = dataGridView3.Rows[secilen].Cells[6].Value.ToString();
            dtpYas.Text = dataGridView3.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "")
            {
                //SqlCommand komut = new SqlCommand("insert into Tbl_EmanetKitaplar(EmanetTC,EmanetAdSoyad,EmanetYas,EmanetTelefon,EmanetKBarkod,EmanetKAd,EmanetKYazar,EmanetKSayi,EmanetKTeslim,İade,EmanetTeslimEdilenPer) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", mskTC.Text);
                //komut.Parameters.AddWithValue("@p2", tbAdSoyad.Text);
                //komut.Parameters.AddWithValue("@p3", dtpYas.Text);
                //komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                //komut.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut.Parameters.AddWithValue("@p7", tbYazar.Text);
                //komut.Parameters.AddWithValue("@p8", mskKitapSayi.Text);
                //komut.Parameters.AddWithValue("@p9", dtpTeslimTarih.Text);
                //komut.Parameters.AddWithValue("@p10", dtpİadeTarih.Text);
                //komut.Parameters.AddWithValue("@p11", tbTeslimEdenPer.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //-------Entity metodu ile---------
                Tbl_EmanetKitaplar ek = new Tbl_EmanetKitaplar();
                ek.EmanetTC = mskTC.Text;
                ek.EmanetAdSoyad = tbAdSoyad.Text;
                ek.EmanetYas = dtpYas.Text;
                ek.EmanetTelefon = mskTelefon.Text;
                ek.EmanetKBarkod = mskBarkod.Text;
                ek.EmanetKAd = tbKitapAd.Text;
                ek.EmanetKYazar = tbYazar.Text;
                ek.EmanetKSayi = short.Parse(mskKitapSayi.Text);
                ek.EmanetKTeslim = dtpTeslimTarih.Text;
                ek.İade = dtpİadeTarih.Text;
                ek.EmanetTeslimEdilenPer = tbTeslimEdenPer.Text;
                db.Tbl_EmanetKitaplar.Add(ek);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Emanet Teslim Edildi!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnİadeEt_Click(object sender, EventArgs e)
        {
            //------------boş kaydetmesin diye if koşuluyla oluşturdum------------------
            if (mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "")
            {
                //------------silme işlemi aynı anda yapılıyor----------------
                //SqlCommand komut1 = new SqlCommand("delete from Tbl_EmanetKitaplar where EmanetID=@p1", bgl.sqlbaglntisi());
                //komut1.Parameters.AddWithValue("@p1", tbID.Text);
                //komut1.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                if (tbID.Text != "")
                {
                    int deger = Convert.ToInt32(tbID.Text);
                    var degisken = db.Tbl_EmanetKitaplar.Find(deger);
                    db.Tbl_EmanetKitaplar.Remove(degisken);
                    db.SaveChanges();
                }
                //-------------------------------------------------------------------
                //SqlCommand komut2 = new SqlCommand("insert into Tbl_İade(İadeTC,İadeAdSoyad,İadeYas,İadeTelefon,İadeKBarkod,İadeKAd,İadeKYazar,İadeKSayi,İadeKTeslim,İadeKreturnTarih,personel) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.sqlbaglntisi());
                //komut2.Parameters.AddWithValue("@p1", mskTC.Text);
                //komut2.Parameters.AddWithValue("@p2", tbAdSoyad.Text);
                //komut2.Parameters.AddWithValue("@p3", dtpYas.Text);
                //komut2.Parameters.AddWithValue("@p4", mskTelefon.Text);
                //komut2.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut2.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut2.Parameters.AddWithValue("@p7", tbYazar.Text);
                //komut2.Parameters.AddWithValue("@p8", mskKitapSayi.Text);
                //komut2.Parameters.AddWithValue("@p9", dtpTeslimTarih.Text);
                //komut2.Parameters.AddWithValue("@p10", dtpİadeTarih.Text);
                //komut2.Parameters.AddWithValue("@p11", tbTeslimEdenPer.Text);
                //komut2.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //----------Entity metodu ile------
                Tbl_İade i = new Tbl_İade();
                i.İadeTC = mskTC.Text;
                i.İadeAdSoyad = tbAdSoyad.Text;
                i.İadeYas = dtpYas.Text;
                i.İadeTelefon = mskTelefon.Text;
                i.İadeKBarkod = mskBarkod.Text;
                i.İadeKAd = tbKitapAd.Text;
                i.İadeKYazar = tbYazar.Text;
                i.İadeKSayi = short.Parse(mskKitapSayi.Text);
                i.İadeKTeslim = dtpTeslimTarih.Text;
                i.İadeKreturnTarih = dtpİadeTarih.Text;
                i.personel = tbTeslimEdenPer.Text;
                db.Tbl_İade.Add(i);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Emanet İade Edildi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen Önce Bir Emanet Seçiniz!!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "")
            {
                //SqlCommand komut = new SqlCommand("delete from Tbl_EmanetKitaplar where EmanetID=@p1", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbID.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //---------Entity metodu ile--------
                int deger = Convert.ToInt32(tbID.Text);
                var degisken = db.Tbl_EmanetKitaplar.Find(deger);
                db.Tbl_EmanetKitaplar.Remove(degisken);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Emanet Silindi!!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Secili bir Alan Yok Lütfen Listedeki Bir Emanet Seciniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "")
            {
                //SqlCommand komut = new SqlCommand("update Tbl_EmanetKitaplar set EmanetTC=@p1,EmanetAdSoyad=@p2,EmanetYas=@p3,EmanetTelefon=@p4,EmanetKBarkod=@p5,EmanetKAd=@p6,EmanetKYazar=@p7,EmanetKSayi=@p8,EmanetKTeslim=@p9,İade=@p10,EmanetTeslimEdilenPer=@p11 where EmanetID=@p12", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", mskTC.Text);
                //komut.Parameters.AddWithValue("@p2", tbAdSoyad.Text);
                //komut.Parameters.AddWithValue("@p3", dtpYas.Text);
                //komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                //komut.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut.Parameters.AddWithValue("@p7", tbYazar.Text);
                //komut.Parameters.AddWithValue("@p8", mskKitapSayi.Text);
                //komut.Parameters.AddWithValue("@p9", dtpTeslimTarih.Text);
                //komut.Parameters.AddWithValue("@p10", dtpİadeTarih.Text);
                //komut.Parameters.AddWithValue("@p11", tbTeslimEdenPer.Text);
                //komut.Parameters.AddWithValue("@p12", tbID.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //---------Entity metodu ile---------
                int deger = Convert.ToInt32(tbID.Text);
                var degisken = db.Tbl_EmanetKitaplar.Find(deger);
                degisken.EmanetTC = mskTC.Text;
                degisken.EmanetAdSoyad = tbAdSoyad.Text;
                degisken.EmanetYas = dtpYas.Text;
                degisken.EmanetTelefon = mskTelefon.Text;
                degisken.EmanetKBarkod = mskBarkod.Text;
                degisken.EmanetKAd = tbKitapAd.Text;
                degisken.EmanetKYazar = tbYazar.Text;
                degisken.EmanetKSayi = short.Parse(mskKitapSayi.Text);
                degisken.EmanetKTeslim = dtpTeslimTarih.Text;
                degisken.İade = dtpİadeTarih.Text;
                degisken.EmanetTeslimEdilenPer = tbTeslimEdenPer.Text;
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Emanet Bilgileri Güncellendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Listeden bir Emanet Seciniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKayip_Click(object sender, EventArgs e)
        {
            if (mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "")
            {
                //-------------önce Emanet Listesinde silip-----------
                //SqlCommand komut = new SqlCommand("delete from Tbl_EmanetKitaplar where EmanetID=@p1", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbID.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //-----Entity metodu ile----------
                int deger = Convert.ToInt32(tbID.Text);
                var degisken = db.Tbl_EmanetKitaplar.Find(deger);
                db.Tbl_EmanetKitaplar.Remove(degisken);
                db.SaveChanges();
                listele();
                //-------------sonra kayıp listesine eklenecek---------
                //SqlCommand komut2 = new SqlCommand("insert into Tbl_Kayip_kitap(KayipTC,KayipAdSoyad,KayipYas,KayipTelefon,KayipBarkod,Kitaplar,KayipKYazar,KayipKSayi,KayipTeslimTarih,KayipİadeTarih,KayipTeslimPer) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.sqlbaglntisi());
                //komut2.Parameters.AddWithValue("@p1", mskTC.Text);
                //komut2.Parameters.AddWithValue("@p2", tbAdSoyad.Text);
                //komut2.Parameters.AddWithValue("@p3", dtpYas.Text);
                //komut2.Parameters.AddWithValue("@p4", mskTelefon.Text);
                //komut2.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut2.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut2.Parameters.AddWithValue("@p7", tbYazar.Text);
                //komut2.Parameters.AddWithValue("@p8", mskKitapSayi.Text);
                //komut2.Parameters.AddWithValue("@p9", dtpTeslimTarih.Text);
                //komut2.Parameters.AddWithValue("@p10", dtpİadeTarih.Text);
                //komut2.Parameters.AddWithValue("@p11", tbTeslimEdenPer.Text);
                //komut2.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //---------Entity metodu ile-----------
                Tbl_Kayip_kitap k = new Tbl_Kayip_kitap();
                k.KayipTC = mskTC.Text;
                k.KayipAdSoyad = tbAdSoyad.Text;
                k.KayipYas = dtpYas.Text;
                k.KayipTelefon = mskTelefon.Text;
                k.KayipBarkod = mskBarkod.Text;
                k.Kitaplar = tbKitapAd.Text;
                k.KayipKYazar = tbYazar.Text;
                k.KayipKSayi = short.Parse(mskKitapSayi.Text);
                k.KayipTeslimTarih = dtpTeslimTarih.Text;
                k.KayipİadeTarih = dtpİadeTarih.Text;
                k.KayipTeslimPer = tbTeslimEdenPer.Text;
                db.Tbl_Kayip_kitap.Add(k);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Kayıp işlemi gerçeklendi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Emanet Listesinden Seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbAra_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_EmanetKitaplar WHERE KitapAd=@p1", bgl.sqlbaglntisi());
            //komut.Parameters.AddWithValue("@p1", tbAra.Text);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //----------Entity metodu ile---------
            string aranan = tbAra.Text;
            var s = from k in db.Tbl_EmanetKitaplar
                    where k.EmanetAdSoyad.Contains(aranan)
                    select k;
            dataGridView1.DataSource = s.ToList();
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

        private void btnListele_MouseEnter(object sender, EventArgs e)
        {
            btnListele.BackColor = Color.Green;
        }

        private void btnListele_MouseLeave(object sender, EventArgs e)
        {
            btnListele.BackColor = Color.Transparent;
        }

        private void btnGuncelle_MouseEnter(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = Color.Green;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = Color.Transparent;
        }

        private void btnSil_MouseEnter(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Green;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Transparent;
        }

        private void btnİadeEt_MouseEnter(object sender, EventArgs e)
        {
            btnİadeEt.BackColor = Color.Green;
        }

        private void btnİadeEt_MouseLeave(object sender, EventArgs e)
        {
            btnİadeEt.BackColor = Color.Transparent;
        }

        private void btnTeslimEt_MouseEnter(object sender, EventArgs e)
        {
            btnTeslimEt.BackColor = Color.Green;
        }

        private void btnTeslimEt_MouseLeave(object sender, EventArgs e)
        {
            btnTeslimEt.BackColor = Color.Transparent;
        }

        private void btnKayip_MouseEnter(object sender, EventArgs e)
        {
            btnKayip.BackColor = Color.Green;
        }

        private void btnKayip_MouseLeave(object sender, EventArgs e)
        {
            btnKayip.BackColor = Color.Transparent;
        }

        private void btnTemizle_MouseEnter(object sender, EventArgs e)
        {
            btnTemizle.BackColor = Color.Green;
        }

        private void btnTemizle_MouseLeave(object sender, EventArgs e)
        {
            btnTemizle.BackColor = Color.Transparent;
        }
    }
}
