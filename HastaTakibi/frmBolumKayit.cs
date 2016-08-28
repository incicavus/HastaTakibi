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
namespace HastaTakibi
{
    public partial class frmBolumKayit : Form
    {
        public frmBolumKayit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database= HastahaneDB; integrated security=true");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBolum.Text))
            {
                SqlCommand ekle = new SqlCommand(string.Format("insert Bolum values ('{0}')", txtBolum.Text), con);

                con.Open();
                ekle.ExecuteNonQuery();
                con.Close();

                txtBolum.Clear();
                txtBolum.Focus();

            }

            else
                MessageBox.Show("Bölüm ismi giriniz!..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void frmBolumKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
