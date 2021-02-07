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
    public partial class Frm_BilgiDuzenle : Form
    {
        public Frm_BilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcNo;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Frm_BilgiDuzenle_Load(object sender, EventArgs e)
        {
            Msk_TC.Text = tcNo;
            SqlCommand komut = new SqlCommand("Select * From tbl_Hasta where Hasta_tc= @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[2].ToString();
                msk_TelNo.Text = dr[4].ToString();
                Txt_Sifre.Text = dr[5].ToString();
                cmb_cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_bilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update tbl_Hasta set Hasta_ad= @p1,Hasta_soyad=@p2,Hasta_telefon=@p3,Hasta_sifre=@p4,Hasta_cinsiyet=@p5   where Hasta_tc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3", msk_TelNo.Text);
            komut2.Parameters.AddWithValue("@p4", Txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@p5",cmb_cinsiyet.Text );
            komut2.Parameters.AddWithValue("@p6", Msk_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            this.Hide();

                

        }
    }
}
