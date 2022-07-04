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
    public partial class FrmPersonelİslemi : Form
    {
        public FrmPersonelİslemi()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
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
            tbSifre.Clear();
            tbAra.Clear();
            tbAd.Focus();
        }
        void listele()
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_personel", bgl.sqlbaglntisi());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //---------Entity metodu ile----------
            dataGridView1.DataSource = db.Tbl_personel.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void FrmPersonelİslemi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbSoyad.Text != "" && cmbCinsiyet.Text != "" && dtpDogum.Text != "" && mskTC.Text != "" && mskTelefon.Text != "" && tbEposta.Text != "" && tbSifre.Text != "")
            {
                //SqlCommand komut = new SqlCommand("INSERT INTO Tbl_personel(PersonelAd,PersonelSoyad,PersonelTC,PersonelCinsiyet,PersonelDogumtarih,PersonelTelefon,PersonelEposta,PersonelSifre) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbAd.Text);
                //komut.Parameters.AddWithValue("@p2", tbSoyad.Text);
                //komut.Parameters.AddWithValue("@p3", mskTC.Text);
                //komut.Parameters.AddWithValue("@p4", cmbCinsiyet.Text);
                //komut.Parameters.AddWithValue("@p5", dtpDogum.Text);
                //komut.Parameters.AddWithValue("@p6", mskTelefon.Text);
                //komut.Parameters.AddWithValue("@p7", tbEposta.Text);
                //komut.Parameters.AddWithValue("@p8", tbSifre.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                Tbl_personel p = new Tbl_personel();
                p.PersonelAd = tbAd.Text;
                p.PersonelSoyad = tbSoyad.Text;
                p.PersonelTC = mskTC.Text;
                p.PersonelCinsiyet = cmbCinsiyet.Text;
                p.PersonelDogumtarih = dtpDogum.Text;
                p.PersonelTelefon = mskTelefon.Text;
                p.PersonelEposta = tbEposta.Text;
                p.PersonelSifre = tbSifre.Text;
                db.Tbl_personel.Add(p);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Ekleme işlemi Gerçekleşmiş!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbSoyad.Text != "" && cmbCinsiyet.Text != "" && dtpDogum.Text != "" && mskTC.Text != "" && mskTelefon.Text != "" && tbEposta.Text != "" && tbSifre.Text != "")
            {
                //SqlCommand komut = new SqlCommand("UPDATE Tbl_personel SET PersonelAd=@p1,PersonelSoyad=@p2,PersonelTC=@p3,PersonelCinsiyet=@p4,PersonelDogumtarih=@p5,PersonelTelefon=@p6,PersonelEposta=@p7,PersonelSifre=@p8 WHERE PersonelID=@p9", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbAd.Text);
                //komut.Parameters.AddWithValue("@p2", tbSoyad.Text);
                //komut.Parameters.AddWithValue("@p3", mskTC.Text);
                //komut.Parameters.AddWithValue("@p4", cmbCinsiyet.Text);
                //komut.Parameters.AddWithValue("@p5", dtpDogum.Text);
                //komut.Parameters.AddWithValue("@p6", mskTelefon.Text);
                //komut.Parameters.AddWithValue("@p7", tbEposta.Text);
                //komut.Parameters.AddWithValue("@p8", tbSifre.Text);
                //komut.Parameters.AddWithValue("@p9", tbId.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                int p = Convert.ToInt32(tbId.Text);
                var g = db.Tbl_personel.Find(p);
                g.PersonelAd = tbAd.Text;
                g.PersonelSoyad = tbSoyad.Text;
                g.PersonelTC = mskTC.Text;
                g.PersonelCinsiyet = cmbCinsiyet.Text;
                g.PersonelDogumtarih = dtpDogum.Text;
                g.PersonelTelefon = mskTelefon.Text;
                g.PersonelEposta = tbEposta.Text;
                g.PersonelSifre = tbSifre.Text;
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Bilginiz Güncenlledi !!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Listedeki Bilgilerden tanesi seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dtpDogum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tbEposta.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            tbSifre.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbSoyad.Text != "" && cmbCinsiyet.Text != "" && dtpDogum.Text != "" && mskTC.Text != "" && mskTelefon.Text != "" && tbEposta.Text != "" && tbSifre.Text != "")
            {
                //SqlCommand komut = new SqlCommand("DELETE FROM Tbl_personel WHERE PersonelID=@p1", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", tbId.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //---------Entity metodu ile----------
                int deger = Convert.ToInt32(tbId.Text);
                var degisken = db.Tbl_personel.Find(deger);
                db.Tbl_personel.Remove(degisken);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Silindi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Listedeki Bilgilerden tanesi seçiniz!! silmek için!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
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

        private void btnEkle_MouseEnter(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Green;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Transparent;
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
            //SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_personel WHERE PersonelAd=@p1", bgl.sqlbaglntisi());
            //komut.Parameters.AddWithValue("@p1", tbAra.Text);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //-------Entity metodu ile------
            string ara = tbAra.Text;
            var p = from k in db.Tbl_personel
                    where k.PersonelAd.Contains(ara)
                    select k;
            dataGridView1.DataSource = p.ToList();
        }
    }
}
