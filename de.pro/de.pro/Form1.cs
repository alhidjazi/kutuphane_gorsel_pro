using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;

namespace de.pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //sqlbaglanti bgl = new sqlbaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            FrmUyeGirisi frm = new FrmUyeGirisi();
            frm.Show();
        }

        private void btnPersomel_Click(object sender, EventArgs e)
        {
            FrmPersonelGirisi frm = new FrmPersonelGirisi();
            frm.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Görsel programala final projesi olarak oluşturdum", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHakkimizda_MouseEnter(object sender, EventArgs e)
        {
            btnHakkimizda.BackColor = Color.Yellow;
        }

        private void btnHakkimizda_MouseLeave(object sender, EventArgs e)
        {
            btnHakkimizda.BackColor = Color.Transparent;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Red;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Transparent;
        }

        private void btnGiris_MouseEnter(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.GreenYellow;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Transparent;
        }

        private void btnPersomel_MouseEnter(object sender, EventArgs e)
        {
            btnPersomel.BackColor = Color.GreenYellow;
        }

        private void btnPersomel_MouseLeave(object sender, EventArgs e)
        {
            btnPersomel.BackColor = Color.Transparent;
        }
    }
}
