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
    public partial class FrmGecmisEmanet : Form
    {
        public FrmGecmisEmanet()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        void listele()
        {
            //------------İade Listeleme için-----------
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_İade", bgl.sqlbaglntisi());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //----------Entity metodu ile---------
            dataGridView1.DataSource = db.Tbl_İade.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            //------------Kayip Listeleme için-----------
            //DataTable dt2 = new DataTable();
            //SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Kayip_Kitap", bgl.sqlbaglntisi());
            //da2.Fill(dt2);
            //dataGridView2.DataSource = dt2;
            //--------Entity metodu ile-------
            dataGridView2.DataSource = db.Tbl_Kayip_kitap.ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.Columns[12].Visible = false;
        }

        private void FrmGecmisEmanet_Load(object sender, EventArgs e)
        {
            listele();
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
            mskTC.Focus();
            tbAra.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnİadeEt_Click(object sender, EventArgs e)
        {

            if (/*tbID.Text != "" &&*/ mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "" && tbTeslimEdenPer.Text != "")
            {
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
                //-------------Entity metodu ile---------
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
                MessageBox.Show("İade Başaralıyla Edildi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bir Emanet seciniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKayip_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "" && tbTeslimEdenPer.Text != "")
            {
                //-------------önce kayıp listesine eklenecek---------
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
                //-------------Entity metodu ile---------
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
                //-----------sonra iade listesinden silenecek---------- 
                //SqlCommand komut1 = new SqlCommand("delete from Tbl_İade where İadeID=@p1", bgl.sqlbaglntisi());
                //komut1.Parameters.AddWithValue("@p1", tbID.Text);
                //komut1.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //--------Entity metodu ile-------
                int deger = Convert.ToInt32(tbID.Text);
                var degisken = db.Tbl_İade.Find(deger);
                db.Tbl_İade.Remove(degisken);
                db.SaveChanges();
                listele();
                temizle();

                MessageBox.Show("Kayıp listelerine Eklendi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Emanet Listesinden seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "" && tbTeslimEdenPer.Text != "")
            {
                //-----------iade listesinden silme işlemi------------
                //SqlCommand komut1 = new SqlCommand("delete from Tbl_İade where İadeID=@p1", bgl.sqlbaglntisi());
                //komut1.Parameters.AddWithValue("@p1", tbID.Text);
                //komut1.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //-------------Entity metodu ile---------
                if (tbID.Text != "")
                {
                    int deger1 = Convert.ToInt32(tbID.Text);
                    var degisken1 = db.Tbl_İade.Find(deger1);
                    db.Tbl_İade.Remove(degisken1);
                    db.SaveChanges();
                    listele();
                    temizle();
                    MessageBox.Show("Silindi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                listele();
                temizle();
                MessageBox.Show("Silindi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && mskTC.Text != "" && tbAdSoyad.Text != "" && dtpYas.Text != "" && mskTelefon.Text != "" && mskBarkod.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && mskKitapSayi.Text != "" && dtpTeslimTarih.Text != "" && dtpİadeTarih.Text != "" && tbTeslimEdenPer.Text != "")
            {
                //-------------iade bilgileri güncel----------------
                //SqlCommand komut1 = new SqlCommand("update Tbl_İade set İadeTC=@p1,İadeAdSoyad=@p2,İadeYas=@p3,İadeTelefon=@p4,İadeKBarkod=@p5,İadeKAd=@p6,İadeKYazar=@p7,İadeKSayi=@p8,İadeKTeslim=@p9,İadeKreturnTarih=@p10,personel=@p11 where İadeID=@p12", bgl.sqlbaglntisi());
                //komut1.Parameters.AddWithValue("@p1", mskTC.Text);
                //komut1.Parameters.AddWithValue("@p2", tbAdSoyad.Text);
                //komut1.Parameters.AddWithValue("@p3", dtpYas.Text);
                //komut1.Parameters.AddWithValue("@p4", mskTelefon.Text);
                //komut1.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut1.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut1.Parameters.AddWithValue("@p7", tbYazar.Text);
                //komut1.Parameters.AddWithValue("@p8", mskKitapSayi.Text);
                //komut1.Parameters.AddWithValue("@p9", dtpTeslimTarih.Text);
                //komut1.Parameters.AddWithValue("@p10", dtpİadeTarih.Text);
                //komut1.Parameters.AddWithValue("@p11", tbTeslimEdenPer.Text);
                //komut1.Parameters.AddWithValue("@p12", tbID.Text);
                //komut1.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //--------Entity metodu ile-------
                int deger = Convert.ToInt32(tbID.Text);
                var degisken = db.Tbl_İade.Find(deger);
                degisken.İadeTC = mskTC.Text;
                degisken.İadeAdSoyad = tbAdSoyad.Text;
                degisken.İadeYas = dtpYas.Text;
                degisken.İadeTelefon = mskTelefon.Text;
                degisken.İadeKBarkod = mskBarkod.Text;
                degisken.İadeKAd = tbKitapAd.Text;
                degisken.İadeKYazar = tbYazar.Text;
                degisken.İadeKSayi = short.Parse(mskKitapSayi.Text);
                degisken.İadeKTeslim = dtpTeslimTarih.Text;
                degisken.İadeKreturnTarih = dtpİadeTarih.Text;
                degisken.personel = tbTeslimEdenPer.Text;
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Güncelleme işlemi gerçekleştirdi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            tbID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            mskTC.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            tbAdSoyad.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            dtpYas.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            mskTelefon.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            mskBarkod.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            tbKitapAd.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
            tbYazar.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
            mskKitapSayi.Text = dataGridView2.Rows[secilen].Cells[8].Value.ToString();
            dtpTeslimTarih.Text = dataGridView2.Rows[secilen].Cells[9].Value.ToString();
            dtpİadeTarih.Text = dataGridView2.Rows[secilen].Cells[10].Value.ToString();
            tbTeslimEdenPer.Text = dataGridView2.Rows[secilen].Cells[11].Value.ToString();
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

        private void btnKayip_MouseEnter(object sender, EventArgs e)
        {
            btnKayip.BackColor = Color.Green;
        }

        private void btnKayip_MouseLeave(object sender, EventArgs e)
        {
            btnKayip.BackColor = Color.Transparent;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnTemizle_MouseEnter(object sender, EventArgs e)
        {
            btnTemizle.BackColor = Color.Green;
        }

        private void btnTemizle_MouseLeave(object sender, EventArgs e)
        {
            btnTemizle.BackColor = Color.Transparent;
        }

        private void tbAra_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_İade WHERE İadeAdSoyad=@p1", bgl.sqlbaglntisi());
            //komut.Parameters.AddWithValue("@p1", tbAra.Text);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //----------Entity metodu ile----------
            string aranan = tbAra.Text;
            var s = from k in db.Tbl_İade
                    where k.İadeAdSoyad.Contains(aranan)
                    select k;
            dataGridView1.DataSource = s.ToList();
        }
    }
}
