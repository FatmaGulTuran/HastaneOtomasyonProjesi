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
    public partial class frm_SekreterGiris : Form
    {
        public frm_SekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btn_giris_Hasta_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_Sekreter where Sekreter_tc=@p1 and Sekreter_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Msk_tc.Text );
            komut.Parameters.AddWithValue("@p2",txt_Sifre.Text );
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_SekreterDetay fr = new frm_SekreterDetay();

                fr.TCno = Msk_tc.Text;
                  fr.Show();
                this.Hide();
            }   
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();

        }

        private void frm_SekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
