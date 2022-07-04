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
    public partial class FrmTumİslem : Form
    {
        public FrmTumİslem()
        {
            InitializeComponent();
        }

        private void btnKitapİslem_Click(object sender, EventArgs e)
        {
            FrmKitapİslemi frm = new FrmKitapİslemi();
            frm.Show();
        }

        private void btnKitapİslem_MouseEnter(object sender, EventArgs e)
        {
            btnKitapİslem.BackColor = Color.GreenYellow;
        }

        private void btnKitapİslem_MouseLeave(object sender, EventArgs e)
        {
            btnKitapİslem.BackColor = Color.Transparent;
        }

        private void btnEmanetİslem_Click(object sender, EventArgs e)
        {
            FrmEmanetİslemi frm = new FrmEmanetİslemi();
            frm.Show();
        }

        private void btnEmanetİslem_MouseEnter(object sender, EventArgs e)
        {
            btnEmanetİslem.BackColor = Color.GreenYellow;
        }

        private void btnEmanetİslem_MouseLeave(object sender, EventArgs e)
        {
            btnEmanetİslem.BackColor = Color.Transparent;
        }

        private void btnUyeİslem_Click(object sender, EventArgs e)
        {
            FrmUyeİslemi frm = new FrmUyeİslemi();
            frm.Show();
        }

        private void btnUyeİslem_MouseEnter(object sender, EventArgs e)
        {
            btnUyeİslem.BackColor = Color.GreenYellow;
        }

        private void btnUyeİslem_MouseLeave(object sender, EventArgs e)
        {
            btnUyeİslem.BackColor = Color.Transparent;
        }

        private void btnİstatistikler_Click(object sender, EventArgs e)
        {
            Frmİstatistikler frm = new Frmİstatistikler();
            frm.Show();
        }

        private void btnİstatistikler_MouseEnter(object sender, EventArgs e)
        {
            btnİstatistikler.BackColor = Color.GreenYellow;
        }

        private void btnİstatistikler_MouseLeave(object sender, EventArgs e)
        {
            btnİstatistikler.BackColor = Color.Transparent;
        }

        private void btnGecmisEmanet_Click(object sender, EventArgs e)
        {
            FrmGecmisEmanet frm = new FrmGecmisEmanet();
            frm.Show();
        }

        private void btnGecmisEmanet_MouseEnter(object sender, EventArgs e)
        {
            btnGecmisEmanet.BackColor = Color.GreenYellow;
        }

        private void btnGecmisEmanet_MouseLeave(object sender, EventArgs e)
        {
            btnGecmisEmanet.BackColor = Color.Transparent;
        }

        private void btnPersonelİslem_Click(object sender, EventArgs e)
        {
            FrmPersonelİslemi frm = new FrmPersonelİslemi();
            frm.Show();
        }

        private void btnPersonelİslem_MouseEnter(object sender, EventArgs e)
        {
            btnPersonelİslem.BackColor = Color.GreenYellow;
        }

        private void btnPersonelİslem_MouseLeave(object sender, EventArgs e)
        {
            btnPersonelİslem.BackColor = Color.Transparent;
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
