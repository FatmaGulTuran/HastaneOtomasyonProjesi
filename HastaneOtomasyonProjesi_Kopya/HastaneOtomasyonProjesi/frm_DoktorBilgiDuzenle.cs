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
    public partial class frm_DoktorBilgiDuzenle : Form
    {
        public frm_DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TcNo;
        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update tbl_Doktor set Doktor_ad=@d1, Doktor_soyad=@d2, Doktor_brans=@d3,Doktor_sifre=@d4  where Doktor_tc=@d5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut2.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@d3", cmb_Brans.Text);
            komut2.Parameters.AddWithValue("@d4", Txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@d5", Msk_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            this.Hide();
            
        }

        private void frm_DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            Msk_TC.Text = TcNo;

            SqlCommand komut = new SqlCommand("Select * from tbl_Doktor where Doktor_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
               txt_soyad.Text = dr[2].ToString();
                cmb_Brans.Text = dr[3].ToString();
                Txt_Sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
           
        }
    }
}
