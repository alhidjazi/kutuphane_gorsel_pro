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
    public partial class FrmKitapİslemi : Form
    {
        public FrmKitapİslemi()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        void temizle()
        {
            tbİd.Clear();
            tbKitapAd.Clear();
            tbYazar.Clear();
            tbSayfa.Clear();
            tbKayitYapanP.Clear();
            mskBarkod.Clear();
            tbTuru.Clear();
            tbYayinEvi.Clear();
            cmbDurum.Text = "";
            tbAra.Clear();
            tbKitapAd.Focus();
        }
        void listele()
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Kitaplar", bgl.sqlbaglntisi());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //------------Entity metodu ile ------------
            dataGridView1.DataSource = db.Tbl_Kitaplar.ToList();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbKitapAd.Text != "" && tbYazar.Text != "" && tbSayfa.Text != "" && tbKayitYapanP.Text != "" && mskBarkod.Text != "" && tbTuru.Text != "" && tbYayinEvi.Text != "" && cmbDurum.Text != "")
            {
                //SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kitaplar(KitapAd,KitapYazari,KitapSayfasayisi,personelAd,KitapBarkodu,KitapTuru,KitapYayinevi,KitapDurum) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbKitapAd.Text);
                //komut.Parameters.AddWithValue("@p2", tbYazar.Text);
                //komut.Parameters.AddWithValue("@p3", tbSayfa.Text);
                //komut.Parameters.AddWithValue("@p4", tbKayitYapanP.Text);
                //komut.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut.Parameters.AddWithValue("@p6", tbTuru.Text);
                //komut.Parameters.AddWithValue("@p7", tbYayinEvi.Text);
                //komut.Parameters.AddWithValue("@p8", cmbDurum.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //--------Entity metodu ile kodladım----------
                Tbl_Kitaplar k = new Tbl_Kitaplar();
                k.KitapAd = tbKitapAd.Text;
                k.KitapYazari = tbYazar.Text;
                k.KitapSayfasayisi = tbSayfa.Text;
                k.PersonelAd = tbKayitYapanP.Text;
                k.KitapBarkodu = mskBarkod.Text;
                k.KitapTuru = tbTuru.Text;
                k.KitapYayinevi = tbYayinEvi.Text;
                k.KitapDurum = cmbDurum.Text;
                db.Tbl_Kitaplar.Add(k);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Yeni Kitap Eklendi !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbİd.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && tbSayfa.Text != "" && tbKayitYapanP.Text != "" && mskBarkod.Text != "" && tbTuru.Text != "" && tbYayinEvi.Text != "" && cmbDurum.Text != "")
            {
                //SqlCommand komut = new SqlCommand("UPDATE Tbl_Kitaplar SET KitapAd=@p1, KitapYazari=@p2, KitapSayfasayisi=@p3,PersonelAd=@p4,KitapBarkodu=@p5,KitapTuru=@p6,KitapYayinevi=@p7,KitapDurum=@p8 WHERE KitapID=@p9", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbKitapAd.Text);
                //komut.Parameters.AddWithValue("@p2", tbYazar.Text);
                //komut.Parameters.AddWithValue("@p3", tbSayfa.Text);
                //komut.Parameters.AddWithValue("@p4", tbKayitYapanP.Text);
                //komut.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut.Parameters.AddWithValue("@p6", tbTuru.Text);
                //komut.Parameters.AddWithValue("@p7", tbYayinEvi.Text);
                //komut.Parameters.AddWithValue("@p8", cmbDurum.Text);
                //komut.Parameters.AddWithValue("@p9", tbİd.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //------------Entity metodu ile ------------
                int deger = Convert.ToInt32(tbİd.Text);
                var degisken = db.Tbl_Kitaplar.Find(deger);
                degisken.KitapAd = tbKitapAd.Text;
                degisken.KitapYazari = tbYazar.Text;
                degisken.KitapSayfasayisi = tbSayfa.Text;
                degisken.PersonelAd = tbKayitYapanP.Text;
                degisken.KitapBarkodu = mskBarkod.Text;
                degisken.KitapTuru = tbTuru.Text;
                degisken.KitapYayinevi = tbYayinEvi.Text;
                degisken.KitapDurum = cmbDurum.Text;
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Bilgiler Güncelendi !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbKayitYapanP.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskBarkod.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tbTuru.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tbYayinEvi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            cmbDurum.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbİd.Text != "" && tbKitapAd.Text != "" && tbYazar.Text != "" && tbSayfa.Text != "" && tbKayitYapanP.Text != "" && mskBarkod.Text != "" && tbTuru.Text != "" && tbYayinEvi.Text != "" && cmbDurum.Text != "")
            {
                //SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Kitaplar WHERE KitapID=@p1", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbİd.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //------------Entity metodu ile ------------
                int deger = Convert.ToInt32(tbİd.Text);
                var degisken = db.Tbl_Kitaplar.Find(deger);
                db.Tbl_Kitaplar.Remove(degisken);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Seçtiğiniz Kitap Silindi !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Tablodan Bir Kitap Seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbAra_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kitaplar WHERE KitapAd=@p1", bgl.sqlbaglntisi());
            //komut.Parameters.AddWithValue("@p1", tbAra.Text);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            string ara = tbAra.Text;
            var s = from k in db.Tbl_Kitaplar
                    where k.KitapAd.Contains(ara)
                    select k;
            dataGridView1.DataSource = s.ToList();
        }

        private void FrmKitapİslemi_Load(object sender, EventArgs e)
        {
            listele();
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

        private void btnEkle_MouseEnter(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Green;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Transparent;
        }

        private void btnSil_MouseEnter(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Green;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Transparent;
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
