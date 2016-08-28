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
    public partial class frmDoktorKayit : Form
    {
        public frmDoktorKayit()
        {
            InitializeComponent();
        }
 SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database=HastahaneDB ; integrated security=true");
        private void frmDoktorKayit_Load(object sender, EventArgs e)
        {
            SqlDataAdapter getir = new SqlDataAdapter("select * from Bolum", con);

            DataTable dt = new DataTable();
            getir.Fill(dt);
            cbBolum.DataSource = dt;

            cbBolum.DisplayMember = "Name";
            cbBolum.ValueMember = "BolumId";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand(string.Format("insert into Doktor(Name,BolumId) values('{0}',{1})", txtDoktor.Text,cbBolum.SelectedValue), con);

            con.Open();
            ekle.ExecuteNonQuery();
            con.Close();

            txtDoktor.Clear();
            txtDoktor.Focus();
        }

        private void cbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
