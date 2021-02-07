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
    public partial class Frm_HastaDetay : Form
    {
        public Frm_HastaDetay()
        {
            InitializeComponent();
        }

        private void lbl_Tc_Click(object sender, EventArgs e)
        {

        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Frm_HastaDetay_Load(object sender, EventArgs e)
        {
            // Ad Soyad Çekme
            lbl_Tc.Text = tc;
            SqlCommand komut = new SqlCommand("Select Hasta_ad,Hasta_soyad From tbl_Hasta where Hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_Tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevu_id AS id ,Randevu_tarih AS Tarih , Randevu_saat AS Saat ,Randevu_brans AS Branş,Randevu_doktor AS Doktor , Randevu_durum AS Durum,Hasta_tc From tbl_Randevular where Hasta_tc =" + tc , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select  Brans_ad From tbl_Branslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

           


        }

        private void cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Doktor.Items.Clear();
            //branşa göre doktor çekme
            SqlCommand komut3 = new SqlCommand("Select Doktor_ad,Doktor_soyad From tbl_Doktor where Doktor_brans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                cmb_Doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();

        }

        private void cmb_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {//randevu durumu boş olanları datagride aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevu_id AS id ,Randevu_tarih AS Tarih , Randevu_saat AS Saat ,Randevu_brans AS Branş,Randevu_doktor AS Doktor , Randevu_durum AS Durum,Hasta_tc From tbl_Randevular where Randevu_brans='" + cmb_Brans.Text + " " + "'" + " and Randevu_doktor='"+cmb_Doktor.Text + "' and Randevu_durum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

       

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_RandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komutAl = new SqlCommand("Update tbl_Randevular set Randevu_durum=1,Hasta_tc=@p1 where Randevu_id=@p2", bgl.baglanti());
            komutAl.Parameters.AddWithValue("@p1", lbl_Tc.Text);
            komutAl.Parameters.AddWithValue("@p2", txt_id.Text);
            komutAl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz alındı, randevu saatinde burda bulunmanız rica olunur...","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        

        

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Frm_girisPanel giris = new Frm_girisPanel();
            this.Hide();
            giris.Show();

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Frm_BilgiDuzenle fr = new Frm_BilgiDuzenle();
            fr.tcNo = lbl_Tc.Text;
            fr.Show();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
