using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonProjesi
{
    public partial class Frm_girisPanel : Form
    {
        public Frm_girisPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_hastaGirisi_Click(object sender, EventArgs e)
        {
            Form_HastaGiris frHasta = new Form_HastaGiris();
            frHasta.Show();
            this.Hide();
        }

        private void btn_doktorGirisi_Click(object sender, EventArgs e)
        {
            Frm_doktorGiris frDoktor = new Frm_doktorGiris();
            frDoktor.Show();
            this.Hide();
        }

        private void btn_sekreterGirisi_Click(object sender, EventArgs e)
        {
            frm_SekreterGiris frSekreter = new frm_SekreterGiris();
            frSekreter.Show();
            this.Hide();
        }

       
    }
}
