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
    public partial class FrmUyeİslemi : Form
    {
        public FrmUyeİslemi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        //----------------Entity metodu ile-------------
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        void listele()
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Uyeler", bgl.sqlbaglntisi());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //---------Entity metodu ile----------
            //---------listeleme metodu-----------
            dataGridView1.DataSource = db.Tbl_Uyeler.ToList();
            //------------sütün gizleme metodu---------
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }
        void temizle()
        {
            tbId.Clear();
            tbAd.Clear();
            tbSoyad.Clear();
            cmbCinsiyet.Text = "";
            dtpDogum.Text = "";
            mskTC.Clear();
            mskTelefon.Clear();
            tbEposta.Clear();
            tbAdres.Clear();
            tbSifre.Clear();
            tbAra.Clear();
            tbAd.Focus();
        }

        private void FrmUyeİslemi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbSoyad.Text != "" && cmbCinsiyet.Text != "" && dtpDogum.Text != "" && mskTC.Text != "" && mskTelefon.Text != "" && tbEposta.Text != "" && tbSifre.Text != "" && tbAdres.Text != "")
            {
                //SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Uyeler(UyeTc, UyeAd,UyeSoyad,UyeCinsiyet,UyeDogumtarih,UyeTelefon,UyeEposta,UyeSifre,UyeAdres) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", mskTC.Text);
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
                //-----------Entity metodu------------
                Tbl_Uyeler u = new Tbl_Uyeler();
                u.UyeTC = mskTC.Text;
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
                listele();
                temizle();
                MessageBox.Show("Ekleme işlemi gerçekleştirdi!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbSoyad.Text != "" && cmbCinsiyet.Text != "" && dtpDogum.Text != "" && mskTC.Text != "" && mskTelefon.Text != "" && tbEposta.Text != "" && tbSifre.Text != "" && tbAdres.Text != "")
            {
                //SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Uyeler WHERE UyeID=@p1", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbId.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                int d = Convert.ToInt32(tbId.Text);
                var s = db.Tbl_Uyeler.Find(d);
                db.Tbl_Uyeler.Remove(s);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Bilgiler Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Listelerden Bir Üye Bilginini Seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbAdres.Text != "" && tbEposta.Text != "" && tbId.Text != "" && tbSifre.Text != "" && tbSoyad.Text != "" && mskTC.Text != "" && mskTelefon.Text != "")
            {
                //SqlCommand k = new SqlCommand("update Tbl_Uyeler set UyeTC=@p1, UyeAd=@p2, UyeSoyad=@p3, UyeCinsiyet=@p4, UyeDogumtarih=@p5, UyeTelefon=@p6, UyeEposta=@p7, UyeSifre=@p8, UyeAdres=@p9 where UyeID=@p10", bgl.sqlbaglntisi());
                //k.Parameters.AddWithValue("@p1", mskTC.Text);
                //k.Parameters.AddWithValue("@p2", tbAd.Text);
                //k.Parameters.AddWithValue("@p3", tbSoyad.Text);
                //k.Parameters.AddWithValue("@p4", cmbCinsiyet.Text);
                //k.Parameters.AddWithValue("@p5", dtpDogum.Text);
                //k.Parameters.AddWithValue("@p6", mskTelefon.Text);
                //k.Parameters.AddWithValue("@p7", tbEposta.Text);
                //k.Parameters.AddWithValue("@p8", tbSifre.Text);
                //k.Parameters.AddWithValue("@p9", tbAdres.Text);
                //k.Parameters.AddWithValue("@p10", tbId.Text);
                //k.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //---------Entity metodu ile----------
                int u = Convert.ToInt32(tbId.Text);
                var degisken = db.Tbl_Uyeler.Find(u);
                degisken.UyeTC = mskTC.Text;
                degisken.UyeAd = tbAd.Text;
                degisken.UyeSoyad = tbSoyad.Text;
                degisken.UyeCinsiyet = cmbCinsiyet.Text;
                degisken.UyeDogumtarih = dtpDogum.Text;
                degisken.UyeTelefon = mskTelefon.Text;
                degisken.UyeEposta = tbEposta.Text;
                degisken.UyeSifre = tbSifre.Text;
                degisken.UyeAdres = tbAdres.Text;
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Uye Bilgileri Güncelleşti!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Öence Tablodan Bir Uye Seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dtpDogum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tbEposta.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            tbSifre.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            tbAdres.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
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

        private void tbAra_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Uyeler WHERE UyeAd=@p1", bgl.sqlbaglntisi());
            //komut.Parameters.AddWithValue("@p1", tbAra.Text);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //-------Entity metodu ile------
            string ara = tbAra.Text;
            var u = from k in db.Tbl_Uyeler
                    where k.UyeAd.Contains(ara)
                    select k;
            dataGridView1.DataSource = u.ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
