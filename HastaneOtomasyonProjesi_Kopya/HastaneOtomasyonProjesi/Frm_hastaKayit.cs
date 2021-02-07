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
    public partial class Frm_hastaKayit : Form
    {
        public Frm_hastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi(); 

        private void btn_hastaKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Hasta (Hasta_ad,Hasta_soyad,Hasta_tc,Hasta_telefon,Hasta_sifre,Hasta_cinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3",Msk_TC.Text );
            komut.Parameters.AddWithValue("@p4",msk_TelNo.Text );
            komut.Parameters.AddWithValue("@p5",Txt_Sifre.Text );
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt gerçekleşmiştir...");


        }
    }
}
