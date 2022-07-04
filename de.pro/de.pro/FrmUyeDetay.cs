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
    public partial class FrmUyeDetay : Form
    {
        public FrmUyeDetay()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        //---------------------------------------------------------------------
        kutuphane_projesiEntities db = new kutuphane_projesiEntities();
        public string tc;
        public string id;
        void listele()
        {
            //---------Kitaplar listenecek------------ -
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kitaplar", bgl.sqlbaglntisi());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //---------Entity metodu ile----------
            dataGridView1.DataSource = db.Tbl_Kitaplar.ToList();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            //--------emanetler listenecek-------------- -
            //DataTable dt2 = new DataTable();
            //SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_EmanetKitaplar", bgl.sqlbaglntisi());
            //da2.Fill(dt2);
            //dataGridView2.DataSource = dt2;
            //---------Entity metodu ile----------
            dataGridView2.DataSource = db.Tbl_EmanetKitaplar.ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[11].Visible = false;
            dataGridView2.Columns[12].Visible = false;
        }
        void temizle()
        {
            tbPer.Clear();
            tbKitapAd.Clear();
            mskBarkod.Clear();
            mskKSayi.Clear();
            tbKitapYazari.Clear();
            lblID.Text = "";
            dtpTeslim.Text = "";
            dtpİade.Text = "";
        }

        private void FrmUyeDetay_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = tc;
            lblID.Text = id;
            //-------------TC'ye göre diğer bilgileri göster-------------
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Uyeler where UyeTC=@p1", bgl.sqlbaglntisi());
            komut1.Parameters.AddWithValue("@p1", lblTCNo.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblTelefon.Text = dr1[6].ToString();
                lblYas.Text = dr1[5].ToString();
            }
            listele();

            SqlCommand komut2 = new SqlCommand("SELECT UyeAd,UyeSoyad FROM Tbl_Uyeler WHERE UyeTC=@p1", bgl.sqlbaglntisi());
            komut2.Parameters.AddWithValue("@p1", lblTCNo.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblAdSoyad.Text = dr2[0] + " " + dr2[1];
            }
            bgl.sqlbaglntisi().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbKitapYazari.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbPer.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskBarkod.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            mskBarkod.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            tbKitapAd.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
            tbKitapYazari.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
            tbPer.Text = dataGridView2.Rows[secilen].Cells[11].Value.ToString();
            dtpTeslim.Text = dataGridView2.Rows[secilen].Cells[9].Value.ToString();
            dtpİade.Text = dataGridView2.Rows[secilen].Cells[10].Value.ToString();
            mskKSayi.Text = dataGridView2.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnEmanetAl_Click(object sender, EventArgs e)
        {
            if (tbKitapAd.Text != "" && tbKitapYazari.Text != "" && tbPer.Text != "" && mskBarkod.Text != "" && mskKSayi.Text != "")
            {
                //SqlCommand komut = new SqlCommand("insert into Tbl_EmanetKitaplar (EmanetTC,EmanetAdSoyad,EmanetYas,EmanetTelefon,EmanetKBarkod,EmanetKAd,EmanetKYazar,EmanetKSayi,EmanetKTeslim,İade,EmanetTeslimEdilenPer) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
                //komut.Parameters.AddWithValue("@p2", lblAdSoyad.Text);
                //komut.Parameters.AddWithValue("@p3", lblYas.Text);
                //komut.Parameters.AddWithValue("@p4", lblTelefon.Text);
                //komut.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut.Parameters.AddWithValue("@p7", tbKitapYazari.Text);
                //komut.Parameters.AddWithValue("@p8", mskKSayi.Text);
                //komut.Parameters.AddWithValue("@p9", dtpTeslim.Text);
                //komut.Parameters.AddWithValue("@p10", dtpİade.Text);
                //komut.Parameters.AddWithValue("@p11", tbPer.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                Tbl_EmanetKitaplar ek = new Tbl_EmanetKitaplar();
                ek.EmanetTC = lblTCNo.Text;
                ek.EmanetAdSoyad = lblAdSoyad.Text;
                ek.EmanetYas = lblYas.Text;
                ek.EmanetTelefon = lblTelefon.Text;
                ek.EmanetKBarkod = mskBarkod.Text;
                ek.EmanetKAd = tbKitapAd.Text;
                ek.EmanetKYazar = tbKitapYazari.Text;
                ek.EmanetKSayi = short.Parse(mskKSayi.Text);
                ek.EmanetKTeslim = dtpTeslim.Text;
                ek.İade = dtpİade.Text;
                ek.EmanetTeslimEdilenPer = tbPer.Text;
                db.Tbl_EmanetKitaplar.Add(ek);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("Emanet İşlemi Gerçekleşmiş!!");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnİade_Click(object sender, EventArgs e)
        {
            if (tbKitapAd.Text != "" && tbKitapYazari.Text != "" && tbPer.Text != "" && mskBarkod.Text != "" && mskKSayi.Text != "" && dtpİade.Text !=""&& dtpTeslim.Text!="")
            {
                //----------önce silip-------- -
                //SqlCommand komut = new SqlCommand("delete from Tbl_EmanetKitaplar where EmanetID=@p1", bgl.sqlbaglntisi());
                //komut.Parameters.AddWithValue("@p1", lblID.Text);
                //komut.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                //listele();
                //temizle();
                //---------Entity metodu ile----------
                int s = Convert.ToInt32(lblID.Text);
                var degisken = db.Tbl_EmanetKitaplar.Find(s);
                db.Tbl_EmanetKitaplar.Remove(degisken);
                db.SaveChanges();
                listele();
                temizle();
                //--------sonra iade listesine eklenecek--------
                //SqlCommand komut2 = new SqlCommand("insert into Tbl_İade(İadeTC,İadeAdSoyad,İadeYas,İadeTelefon,İadeKBarkod,İadeKAd,İadeKYazar,İadeKSayi,İadeKTeslim,İadeKreturnTarih,personel) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.sqlbaglntisi());
                //komut2.Parameters.AddWithValue("@p1", lblTCNo.Text);
                //komut2.Parameters.AddWithValue("@p2", lblAdSoyad.Text);
                //komut2.Parameters.AddWithValue("@p3", lblYas.Text);
                //komut2.Parameters.AddWithValue("@p4", lblTelefon.Text);
                //komut2.Parameters.AddWithValue("@p5", mskBarkod.Text);
                //komut2.Parameters.AddWithValue("@p6", tbKitapAd.Text);
                //komut2.Parameters.AddWithValue("@p7", tbKitapYazari.Text);
                //komut2.Parameters.AddWithValue("@p8", mskKSayi.Text);
                //komut2.Parameters.AddWithValue("@p9", dtpTeslim.Text);
                //komut2.Parameters.AddWithValue("@p10", dtpİade.Text);
                //komut2.Parameters.AddWithValue("@p11", tbPer.Text);
                //komut2.ExecuteNonQuery();
                //bgl.sqlbaglntisi().Close();
                Tbl_İade i = new Tbl_İade();
                i.İadeTC = lblTCNo.Text;
                i.İadeAdSoyad = lblAdSoyad.Text;
                i.İadeYas = lblYas.Text;
                i.İadeTelefon = lblTelefon.Text;
                i.İadeKBarkod = mskBarkod.Text;
                i.İadeKAd = tbKitapAd.Text;
                i.İadeKYazar = tbKitapYazari.Text;
                i.İadeKSayi = short.Parse(mskKSayi.Text);
                i.İadeKTeslim = dtpTeslim.Text;
                i.İadeKreturnTarih = dtpİade.Text;
                i.personel = tbPer.Text;
                db.Tbl_İade.Add(i);
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("İade Edildi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen önce Emanet listesinden seciniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            listele();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiGuncelle frm = new FrmBilgiGuncelle();
            frm.TCNo = lblTCNo.Text;
            frm.ID = lblID.Text;
            frm.Show();
            this.Hide();
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

        private void tbTemizle_MouseEnter(object sender, EventArgs e)
        {
            tbTemizle.BackColor = Color.Green;
        }

        private void tbTemizle_MouseLeave(object sender, EventArgs e)
        {
            tbTemizle.BackColor = Color.Transparent;
        }

        private void btnEmanetAl_MouseEnter(object sender, EventArgs e)
        {
            btnEmanetAl.BackColor = Color.Green;
        }

        private void btnEmanetAl_MouseLeave(object sender, EventArgs e)
        {
            btnEmanetAl.BackColor = Color.Transparent;
        }

        private void btnİade_MouseEnter(object sender, EventArgs e)
        {
            btnİade.BackColor = Color.Green;
        }

        private void btnİade_MouseLeave(object sender, EventArgs e)
        {
            btnİade.BackColor = Color.Transparent;
        }

        private void btnTarihGuncelle_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "" && dtpİade.Text != "")
            {
                int d = Convert.ToInt32(lblID.Text);
                var d1 = db.Tbl_EmanetKitaplar.Find(d);
                d1.İade = dtpİade.Text;
                db.SaveChanges();
                listele();
                temizle();
                MessageBox.Show("İade Tarihi Güncellemişti!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bir Emanet Seçiniz !!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTarihGuncelle_MouseEnter(object sender, EventArgs e)
        {
            btnTarihGuncelle.BackColor = Color.Yellow;
        }

        private void btnTarihGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnTarihGuncelle.BackColor = Color.Transparent;
        }
    }
}
