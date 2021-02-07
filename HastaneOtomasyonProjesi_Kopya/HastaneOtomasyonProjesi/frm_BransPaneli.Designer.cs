
namespace HastaneOtomasyonProjesi
{
    partial class frm_BransPaneli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BransPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_DoktorGüncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_DoktorSil = new System.Windows.Forms.Button();
            this.btn_DoktorEkle = new System.Windows.Forms.Button();
            this.txt_Brans_ad = new System.Windows.Forms.TextBox();
            this.txt_Brans_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(369, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 337);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncel Branş Listesi";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(465, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_DoktorGüncelle
            // 
            this.btn_DoktorGüncelle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DoktorGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoktorGüncelle.ImageIndex = 2;
            this.btn_DoktorGüncelle.ImageList = this.ımageList1;
            this.btn_DoktorGüncelle.Location = new System.Drawing.Point(106, 268);
            this.btn_DoktorGüncelle.Name = "btn_DoktorGüncelle";
            this.btn_DoktorGüncelle.Size = new System.Drawing.Size(175, 62);
            this.btn_DoktorGüncelle.TabIndex = 28;
            this.btn_DoktorGüncelle.Text = "Güncelle";
            this.btn_DoktorGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DoktorGüncelle.UseVisualStyleBackColor = true;
            this.btn_DoktorGüncelle.Click += new System.EventHandler(this.btn_DoktorGüncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekleme.jpg");
            this.ımageList1.Images.SetKeyName(1, "guncelle3.png");
            this.ımageList1.Images.SetKeyName(2, "guncelle.png");
            this.ımageList1.Images.SetKeyName(3, "sil.png");
            // 
            // btn_DoktorSil
            // 
            this.btn_DoktorSil.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DoktorSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoktorSil.ImageIndex = 3;
            this.btn_DoktorSil.ImageList = this.ımageList1;
            this.btn_DoktorSil.Location = new System.Drawing.Point(205, 206);
            this.btn_DoktorSil.Name = "btn_DoktorSil";
            this.btn_DoktorSil.Size = new System.Drawing.Size(107, 56);
            this.btn_DoktorSil.TabIndex = 27;
            this.btn_DoktorSil.Text = "Sil";
            this.btn_DoktorSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DoktorSil.UseVisualStyleBackColor = true;
            this.btn_DoktorSil.Click += new System.EventHandler(this.btn_DoktorSil_Click);
            // 
            // btn_DoktorEkle
            // 
            this.btn_DoktorEkle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DoktorEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoktorEkle.ImageIndex = 0;
            this.btn_DoktorEkle.ImageList = this.ımageList1;
            this.btn_DoktorEkle.Location = new System.Drawing.Point(83, 206);
            this.btn_DoktorEkle.Name = "btn_DoktorEkle";
            this.btn_DoktorEkle.Size = new System.Drawing.Size(116, 56);
            this.btn_DoktorEkle.TabIndex = 26;
            this.btn_DoktorEkle.Text = "Ekle";
            this.btn_DoktorEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DoktorEkle.UseVisualStyleBackColor = true;
            this.btn_DoktorEkle.Click += new System.EventHandler(this.btn_DoktorEkle_Click);
            // 
            // txt_Brans_ad
            // 
            this.txt_Brans_ad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Brans_ad.Location = new System.Drawing.Point(144, 138);
            this.txt_Brans_ad.Name = "txt_Brans_ad";
            this.txt_Brans_ad.Size = new System.Drawing.Size(194, 36);
            this.txt_Brans_ad.TabIndex = 22;
            // 
            // txt_Brans_id
            // 
            this.txt_Brans_id.Enabled = false;
            this.txt_Brans_id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Brans_id.Location = new System.Drawing.Point(144, 89);
            this.txt_Brans_id.Name = "txt_Brans_id";
            this.txt_Brans_id.Size = new System.Drawing.Size(194, 36);
            this.txt_Brans_id.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(14, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 44);
            this.label6.TabIndex = 20;
            this.label6.Text = "Branş Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Branş Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Branş No:";
            // 
            // frm_BransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(867, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DoktorGüncelle);
            this.Controls.Add(this.btn_DoktorSil);
            this.Controls.Add(this.btn_DoktorEkle);
            this.Controls.Add(this.txt_Brans_ad);
            this.Controls.Add(this.txt_Brans_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_BransPaneli";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.frm_BransPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DoktorGüncelle;
        private System.Windows.Forms.Button btn_DoktorSil;
        private System.Windows.Forms.Button btn_DoktorEkle;
        private System.Windows.Forms.TextBox txt_Brans_ad;
        private System.Windows.Forms.TextBox txt_Brans_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}