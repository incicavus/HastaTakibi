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
    public partial class frmHastaIlac : Form
    {
        public frmHastaIlac()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection(@"server=WIN7-BILGISAYAR\SQLEXPRESS; database=HastahaneDB; integrated security=true");
        private void frmHastaIlac_Load(object sender, EventArgs e)
        {
          
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTC.Text))
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from Randevu where HastaTC=@tc", con);

                adp.SelectCommand.Parameters.AddWithValue("@tc", txtTC.Text);

                DataTable dt = new DataTable();

                adp.Fill(dt);

                gvSonuc.DataSource = dt;


            }
        }
    }
}
