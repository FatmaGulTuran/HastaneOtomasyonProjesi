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
    public partial class frm_DoktorPaneli : Form
    {
        public frm_DoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Doktor__id as id ,Doktor_ad as Ad ,Doktor_soyad as Soyad,Doktor_brans as Branş ,Doktor_tc as TC,Doktor_sifre as Şifre  From tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları combobox'a çekme
            SqlCommand komut2 = new SqlCommand("Select Brans_ad From tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btn_DoktorEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into tbl_Doktor (Doktor_ad,Doktor_soyad,Doktor_brans,Doktor_tc,Doktor_sifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komutEkle.Parameters.AddWithValue("@p2", txt_Soyad.Text );
            komutEkle.Parameters.AddWithValue("@p3",cmb_Brans.Text );
            komutEkle.Parameters.AddWithValue("@p4",msk_TC.Text );
            komutEkle.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi");


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Doktor__id as id ,Doktor_ad as Ad ,Doktor_soyad as Soyad,Doktor_brans as Branş ,Doktor_tc as TC,Doktor_sifre as Şifre  From tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_Brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btn_DoktorSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSilme = new SqlCommand("Delete from tbl_Doktor where Doktor_tc = @p1", bgl.baglanti());
            komutSilme.Parameters.AddWithValue("@p1", msk_TC.Text);
            komutSilme.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi!");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Doktor__id as id ,Doktor_ad as Ad ,Doktor_soyad as Soyad,Doktor_brans as Branş ,Doktor_tc as TC,Doktor_sifre as Şifre  From tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_DoktorGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update tbl_Doktor set Doktor_ad= @p1,Doktor_soyad=@p2,Doktor_brans=@p3,Doktor_sifre=@p4   where Doktor_tc=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3",cmb_Brans .Text);
            komut2.Parameters.AddWithValue("@p4", txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@p5", msk_TC.Text);
           
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi...");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Doktor__id as id ,Doktor_ad as Ad ,Doktor_soyad as Soyad,Doktor_brans as Branş ,Doktor_tc as TC,Doktor_sifre as Şifre  From tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
    }
}
