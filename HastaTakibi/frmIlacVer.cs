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
    public partial class frmIlacVer : Form
    {
        public frmIlacVer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database=HastahaneDB; integrated security=true");



        private void frmIlacVer_Load(object sender, EventArgs e)
        {
            SqlDataAdapter bolumGetir = new SqlDataAdapter("select * from Bolum", con);
            DataTable dt = new DataTable();
            bolumGetir.Fill(dt);
            cbBolum.DisplayMember = "Name";
            cbBolum.ValueMember = "BolumID";
            cbBolum.DataSource = dt;


            SqlDataAdapter hastalikGetir = new SqlDataAdapter("select * from Hastalik", con);
            DataTable dt1 = new DataTable();
            hastalikGetir.Fill(dt1);
            cbHastalik.DisplayMember = "HastalikName";
            cbHastalik.ValueMember = "HastalikID";
            cbHastalik.DataSource = dt1;


            SqlDataAdapter doktorGetir = new SqlDataAdapter("select * from Doktor", con);
            DataTable dt2 = new DataTable();
            doktorGetir.Fill(dt2);
            cbDoktor.DisplayMember = "Name";
            cbDoktor.ValueMember = "DoktorID";
            cbDoktor.DataSource = dt2;


            SqlDataAdapter ilacgetir = new SqlDataAdapter("select * from Ilaclar", con);
            DataTable dt3 = new DataTable();
            ilacgetir.Fill(dt3);
            lbIlacVer.DisplayMember = "IlacName";
            lbIlacVer.ValueMember = "IlacID";
            lbIlacVer.DataSource = dt3;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand(string.Format("insert Randevu (HastaTc,BolumAdi,HastalikAdi,DoktorAdi,IlacAdi) values ('{0}',{1},{2},{3},{4})", txtTC.Text, cbBolum.SelectedValue.ToString(), cbHastalik.SelectedValue.ToString(), cbDoktor.SelectedValue.ToString(), lbIlacVer.SelectedValue));

            ekle.Connection = con;
            con.Open();
            ekle.ExecuteNonQuery();
            con.Close();

            txtTC.Clear();

        }


    }
}
