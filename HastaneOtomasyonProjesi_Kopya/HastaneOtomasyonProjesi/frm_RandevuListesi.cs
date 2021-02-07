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
    public partial class frm_RandevuListesi : Form
    {
        public frm_RandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void frm_RandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevu_id AS id ,Randevu_tarih AS Tarih , Randevu_saat AS Saat ,Randevu_brans AS Branş,Randevu_doktor AS Doktor , Randevu_durum AS Durum,Hasta_tc From tbl_Randevular", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

      
    }
}
