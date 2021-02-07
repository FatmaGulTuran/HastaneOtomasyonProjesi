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
    public partial class Form_HastaGiris : Form
    {
        public Form_HastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void lnk_UyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_hastaKayit frKayit = new Frm_hastaKayit();
            frKayit.Show();
        }

        private void btn_giris_Hasta_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_Hasta where Hasta_tc=@p1 and Hasta_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Frm_HastaDetay fr = new Frm_HastaDetay();
                fr.tc = Msk_tc.Text;

                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            bgl.baglanti().Close();

        }

        private void Form_HastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
