using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHastalikKayit_Click(object sender, EventArgs e)
        {
            frmHastalikKayit frm = new frmHastalikKayit();
            frm.ShowDialog();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            frmHastaKayit frm = new frmHastaKayit();
            frm.ShowDialog();

        }

        private void btnIlacKayit_Click(object sender, EventArgs e)
        {
            frmIlacFormu frm = new frmIlacFormu();
            frm.ShowDialog();
        }

        private void btnRandevuTarihcesi_Click(object sender, EventArgs e)
        {
            frmHastaIlac frm = new frmHastaIlac();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIlacVer frm = new frmIlacVer();
            frm.ShowDialog();
        }

        private void btnBolumKayit_Click(object sender, EventArgs e)
        {
            frmBolumKayit frm = new frmBolumKayit();
            frm.ShowDialog();
        }

        private void btnDoktorKayit_Click(object sender, EventArgs e)
        {
            frmDoktorKayit frm = new frmDoktorKayit();
            frm.ShowDialog();
        }
    }
}
