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
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database=HastahaneDB; integrated security=true");
        private void btnEkle_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyisim.Text))
            {
                SqlCommand ekle = new SqlCommand(string.Format("insert Hasta values ('{0}','{1}','{2}')", txtTC.Text, txtIsim.Text, txtSoyisim.Text), con);

                con.Open();
                ekle.ExecuteNonQuery();
                con.Close();

                txtTC.Clear();
                txtIsim.Clear();
                txtSoyisim.Clear();
                txtTC.Focus();

            }
            else
                MessageBox.Show("TC kimlik numarası, isim, soyisim boş bırakılamaz!..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlDataAdapter bul = new SqlDataAdapter("select * from Hasta where HastaTC=@tc", con);

            bul.SelectCommand.Parameters.AddWithValue("@tc", txtTCArama.Text);

            DataTable dt = new DataTable();
            bul.Fill(dt);
            gvHastaArama.DataSource = dt;


        }

        private void frmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
