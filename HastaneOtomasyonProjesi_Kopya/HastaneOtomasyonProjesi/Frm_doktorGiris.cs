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
    public partial class Frm_doktorGiris : Form
    {
        public Frm_doktorGiris()
        {
            InitializeComponent();
        }
        
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btn_giris_Hasta_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_Doktor where Doktor_tc=@p1 and Doktor_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_doktorDetay frd = new Frm_doktorDetay();

                frd.tc_no= Msk_tc.Text;
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            bgl.baglanti().Close();
        }
    }
}
