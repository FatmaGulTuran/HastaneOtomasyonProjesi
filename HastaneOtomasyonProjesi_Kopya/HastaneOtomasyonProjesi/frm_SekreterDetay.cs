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
    public partial class frm_SekreterDetay : Form
    {
        public frm_SekreterDetay()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_SekreterDetay_Load(object sender, EventArgs e)
        {
            //ad-soyad yazımı
            lbl_SekreterTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select Sekreter_ad_soyad From tbl_Sekreter where Sekreter_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_SekreterTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbl_SekreterAd.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları data gride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Brans_ad AS Branşlar From tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktor bilgilerini data gride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Doktor_ad +' '+ Doktor_soyad) as 'Doktorlar',Doktor_brans AS Branş From tbl_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşları combobox'a çekme
            SqlCommand komut2 = new SqlCommand("Select Brans_ad From tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btn_randevuOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutsave = new SqlCommand("insert into tbl_Randevular(Randevu_tarih,Randevu_saat,Randevu_brans,Randevu_doktor) values(@p1,@p2,@p3,@p4)",bgl.baglanti());
            komutsave.Parameters.AddWithValue("@p1", msk_tarih.Text);
            komutsave.Parameters.AddWithValue("@p2", msk_saat.Text);
            komutsave.Parameters.AddWithValue("@p3",cmb_brans.Text );
            komutsave.Parameters.AddWithValue("@p4",cmb_doktor.Text );
            komutsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu eklendi...");
          }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select Doktor_ad,Doktor_soyad From tbl_Doktor where Doktor_brans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btn_DuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutDuyuru = new SqlCommand("insert into tbl_Duyurular (Duyuru) values(@p1)", bgl.baglanti());
            komutDuyuru.Parameters.AddWithValue("@p1", rch_Duyuru.Text);
            komutDuyuru.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu...");

        }

        private void btn_DoktorPanel_Click(object sender, EventArgs e)
        {
            frm_DoktorPaneli fdp = new frm_DoktorPaneli();
            fdp.Show();

        }

        private void btn_HastaPanel_Click(object sender, EventArgs e)
        {
            frm_BransPaneli fbp = new frm_BransPaneli();
            fbp.Show();
        }

        private void btn_RandevuListesi_Click(object sender, EventArgs e)
        {
            frm_RandevuListesi frl = new frm_RandevuListesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Duyurular fdp = new frm_Duyurular();
            fdp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_girisPanel frG = new Frm_girisPanel();
            frG.Show();
            this.Hide();

        }
    }
}
