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
    public partial class Frm_doktorDetay : Form
    {
        public Frm_doktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc_no;

        private void Frm_doktorDetay_Load(object sender, EventArgs e)
        {
            //ad-soyad yazımı
            lbl_tc.Text = tc_no;
            SqlCommand komut = new SqlCommand("Select Doktor_ad,Doktor_soyad From tbl_Doktor where Doktor_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               lbl_adSoyad.Text = dr[0].ToString()+" "+dr[1].ToString();
            }
            bgl.baglanti().Close();

            //randevuları çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevu_id AS id ,Randevu_tarih AS Tarih , Randevu_saat AS Saat ,Randevu_brans AS Branş,Randevu_doktor AS Doktor , Randevu_durum AS Durum,Hasta_tc From tbl_Randevular where Randevu_doktor='" + lbl_adSoyad.Text+"'", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

       

        private void btn_bilgiDuzenle_Click_1(object sender, EventArgs e)
        {
            frm_DoktorBilgiDuzenle frdb = new frm_DoktorBilgiDuzenle();
            frdb.TcNo = lbl_tc.Text;

            frdb.Show();
        }

        private void btn_duyurular_Click_1(object sender, EventArgs e)
        {
            frm_Duyurular frDy = new frm_Duyurular();
            frDy.Show();
        }

        private void btn_cikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_girisPanel frG = new Frm_girisPanel();
            frG.Show();
            this.Hide();
        }
    }
}
