namespace Proje_Hastane
{
    partial class FrmDoktorGirisSonrası
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextRandevuDetay = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewrandevuListesi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCİKİS = new System.Windows.Forms.Button();
            this.buttonDuyuru = new System.Windows.Forms.Button();
            this.buttonBilgiDuzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrandevuListesi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(130, 71);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(76, 23);
            this.labelAdSoyad.TabIndex = 1;
            this.labelAdSoyad.Text = "Null Null";
            this.labelAdSoyad.Click += new System.EventHandler(this.labelAdSoyad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(130, 43);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(120, 23);
            this.labelTc.TabIndex = 1;
            this.labelTc.Text = "00000000000";
            this.labelTc.Click += new System.EventHandler(this.labelTc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextRandevuDetay);
            this.groupBox2.Location = new System.Drawing.Point(46, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextRandevuDetay
            // 
            this.richTextRandevuDetay.Location = new System.Drawing.Point(6, 35);
            this.richTextRandevuDetay.Name = "richTextRandevuDetay";
            this.richTextRandevuDetay.Size = new System.Drawing.Size(303, 110);
            this.richTextRandevuDetay.TabIndex = 0;
            this.richTextRandevuDetay.Text = "";
            this.richTextRandevuDetay.TextChanged += new System.EventHandler(this.richTextRandevuDetay_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewrandevuListesi);
            this.groupBox3.Location = new System.Drawing.Point(379, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 431);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridViewrandevuListesi
            // 
            this.dataGridViewrandevuListesi.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewrandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewrandevuListesi.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewrandevuListesi.Name = "dataGridViewrandevuListesi";
            this.dataGridViewrandevuListesi.RowHeadersWidth = 51;
            this.dataGridViewrandevuListesi.RowTemplate.Height = 24;
            this.dataGridViewrandevuListesi.Size = new System.Drawing.Size(403, 402);
            this.dataGridViewrandevuListesi.TabIndex = 0;
            this.dataGridViewrandevuListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewrandevuListesi_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCİKİS);
            this.groupBox4.Controls.Add(this.buttonDuyuru);
            this.groupBox4.Controls.Add(this.buttonBilgiDuzenle);
            this.groupBox4.Location = new System.Drawing.Point(46, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 144);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // buttonCİKİS
            // 
            this.buttonCİKİS.Location = new System.Drawing.Point(6, 86);
            this.buttonCİKİS.Name = "buttonCİKİS";
            this.buttonCİKİS.Size = new System.Drawing.Size(303, 39);
            this.buttonCİKİS.TabIndex = 3;
            this.buttonCİKİS.Text = "Çıkış";
            this.buttonCİKİS.UseVisualStyleBackColor = true;
            this.buttonCİKİS.Click += new System.EventHandler(this.buttonCİKİS_Click);
            // 
            // buttonDuyuru
            // 
            this.buttonDuyuru.Location = new System.Drawing.Point(163, 35);
            this.buttonDuyuru.Name = "buttonDuyuru";
            this.buttonDuyuru.Size = new System.Drawing.Size(146, 45);
            this.buttonDuyuru.TabIndex = 1;
            this.buttonDuyuru.Text = "Duyurular";
            this.buttonDuyuru.UseVisualStyleBackColor = true;
            this.buttonDuyuru.Click += new System.EventHandler(this.buttonDuyuru_Click);
            // 
            // buttonBilgiDuzenle
            // 
            this.buttonBilgiDuzenle.Location = new System.Drawing.Point(6, 35);
            this.buttonBilgiDuzenle.Name = "buttonBilgiDuzenle";
            this.buttonBilgiDuzenle.Size = new System.Drawing.Size(151, 45);
            this.buttonBilgiDuzenle.TabIndex = 0;
            this.buttonBilgiDuzenle.Text = "Bilgi Düzenle";
            this.buttonBilgiDuzenle.UseVisualStyleBackColor = true;
            this.buttonBilgiDuzenle.Click += new System.EventHandler(this.buttonBilgiDuzenle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDoktorGirisSonrası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(786, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmDoktorGirisSonrası";
            this.Text = "Doktor Detayı";
            this.Load += new System.EventHandler(this.FrmDoktorGirisSonrası_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrandevuListesi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewrandevuListesi;
        private System.Windows.Forms.RichTextBox richTextRandevuDetay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCİKİS;
        private System.Windows.Forms.Button buttonDuyuru;
        private System.Windows.Forms.Button buttonBilgiDuzenle;
        private System.Windows.Forms.Button button1;
    }
}