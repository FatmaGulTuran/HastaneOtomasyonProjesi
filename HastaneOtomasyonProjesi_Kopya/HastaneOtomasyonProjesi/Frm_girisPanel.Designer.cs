
namespace HastaneOtomasyonProjesi
{
    partial class Frm_girisPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_girisPanel));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_doktorGirisi = new System.Windows.Forms.Button();
            this.btn_sekreterGirisi = new System.Windows.Forms.Button();
            this.btn_hastaGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "hasta.png");
            this.ımageList1.Images.SetKeyName(1, "doctor.png");
            this.ımageList1.Images.SetKeyName(2, "sekreter.png");
            this.ımageList1.Images.SetKeyName(3, "sekreter2.png");
            this.ımageList1.Images.SetKeyName(4, "secretary.png");
            this.ımageList1.Images.SetKeyName(5, "sekretee2.png");
            // 
            // btn_doktorGirisi
            // 
            this.btn_doktorGirisi.BackColor = System.Drawing.Color.Lavender;
            this.btn_doktorGirisi.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorGirisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doktorGirisi.ImageIndex = 1;
            this.btn_doktorGirisi.ImageList = this.ımageList1;
            this.btn_doktorGirisi.Location = new System.Drawing.Point(268, 203);
            this.btn_doktorGirisi.Name = "btn_doktorGirisi";
            this.btn_doktorGirisi.Size = new System.Drawing.Size(420, 97);
            this.btn_doktorGirisi.TabIndex = 1;
            this.btn_doktorGirisi.Text = "Doktor Giriş Ekranı";
            this.btn_doktorGirisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_doktorGirisi.UseVisualStyleBackColor = false;
            this.btn_doktorGirisi.Click += new System.EventHandler(this.btn_doktorGirisi_Click);
            // 
            // btn_sekreterGirisi
            // 
            this.btn_sekreterGirisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sekreterGirisi.BackColor = System.Drawing.Color.Lavender;
            this.btn_sekreterGirisi.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sekreterGirisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sekreterGirisi.ImageIndex = 2;
            this.btn_sekreterGirisi.ImageList = this.ımageList1;
            this.btn_sekreterGirisi.Location = new System.Drawing.Point(268, 306);
            this.btn_sekreterGirisi.Name = "btn_sekreterGirisi";
            this.btn_sekreterGirisi.Size = new System.Drawing.Size(420, 98);
            this.btn_sekreterGirisi.TabIndex = 2;
            this.btn_sekreterGirisi.Text = "Sekreter Giriş Ekranı";
            this.btn_sekreterGirisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sekreterGirisi.UseVisualStyleBackColor = false;
            this.btn_sekreterGirisi.Click += new System.EventHandler(this.btn_sekreterGirisi_Click);
            // 
            // btn_hastaGirisi
            // 
            this.btn_hastaGirisi.BackColor = System.Drawing.Color.Lavender;
            this.btn_hastaGirisi.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastaGirisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hastaGirisi.ImageIndex = 0;
            this.btn_hastaGirisi.ImageList = this.ımageList1;
            this.btn_hastaGirisi.Location = new System.Drawing.Point(268, 100);
            this.btn_hastaGirisi.Name = "btn_hastaGirisi";
            this.btn_hastaGirisi.Size = new System.Drawing.Size(420, 97);
            this.btn_hastaGirisi.TabIndex = 3;
            this.btn_hastaGirisi.Text = "Hasta Giriş Ekranı";
            this.btn_hastaGirisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hastaGirisi.UseVisualStyleBackColor = false;
            this.btn_hastaGirisi.Click += new System.EventHandler(this.btn_hastaGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hastane Giriş Paneli";
            // 
            // Frm_girisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_doktorGirisi);
            this.Controls.Add(this.btn_hastaGirisi);
            this.Controls.Add(this.btn_sekreterGirisi);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frm_girisPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Randevu Sistemi";
//            this.Load += new System.EventHandler(this.Frm_girisPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_doktorGirisi;
        private System.Windows.Forms.Button btn_sekreterGirisi;
        private System.Windows.Forms.Button btn_hastaGirisi;
        private System.Windows.Forms.Label label1;
    }
}

