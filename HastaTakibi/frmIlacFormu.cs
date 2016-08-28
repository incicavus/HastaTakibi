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
    public partial class frmIlacFormu : Form
    {
        public frmIlacFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database=HastahaneDB; integrated security=true");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                SqlCommand ekle = new SqlCommand(string.Format("insert Ilaclar values ('{0}') ", txtName.Text), con);

                con.Open();
                ekle.ExecuteNonQuery();
                con.Close();

                txtName.Clear();
                txtName.Focus();

                frmIlacFormu_Load(sender, e);
            }

            else
                MessageBox.Show("İlaç ismini giriniz!..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmIlacFormu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter getir = new SqlDataAdapter("select *from Ilaclar", con);

            DataTable dt = new DataTable();
            getir.Fill(dt);
            lbIlacListesi.DataSource = dt;

            lbIlacListesi.DisplayMember = "IlacName";
            lbIlacListesi.ValueMember = "IlacId";
        }
    }
}
