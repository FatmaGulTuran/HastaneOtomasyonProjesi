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
    public partial class frm_BransPaneli : Form
    {
        public frm_BransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void frm_BransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Brans_id as id,Brans_ad as Branş From tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btn_DoktorEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into tbl_Branslar (Brans_ad) values(@p1)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@p1", txt_Brans_ad.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi...");

            //eklendikten sonra branş paneli tekrar gözükmesi için
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Brans_id as id,Brans_ad as Branş From tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Brans_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Brans_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_DoktorSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from tbl_Branslar where Brans_id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txt_Brans_id.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi!");

            //sildikten sonra branş paneli tekrar gözükmesi için
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Brans_id as id,Brans_ad as Branş From tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_DoktorGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update tbl_Branslar set Brans_ad =@p1 where Brans_id=@p2 ",bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", txt_Brans_ad.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txt_Brans_id.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

            //güncelledikten sonra branş paneli tekrar gözükmesi için
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Brans_id as id,Brans_ad as Branş From tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
