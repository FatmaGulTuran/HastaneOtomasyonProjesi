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

namespace HastaneOtomasyonProjesi
{
    public partial class frm_Duyurular : Form
    {
        public frm_Duyurular()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void frm_Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Duyuru_id As id,Duyuru From tbl_Duyurular", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
    }
}
