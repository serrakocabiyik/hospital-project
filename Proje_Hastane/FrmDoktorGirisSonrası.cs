using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorGirisSonrası : Form
    {
        public FrmDoktorGirisSonrası()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorGirisSonrası_Load(object sender, EventArgs e)
        {
            labelTc.Text = TC;

            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorTC = @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tablo_Randevular Where RandevuDoktor = '" + labelAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridViewrandevuListesi.DataSource = dt;

        }

        private void labelTc_Click(object sender, EventArgs e)
        {

        }

        private void labelAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void richTextRandevuDetay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = labelTc.Text;
            fr.Show();

        }

        private void buttonDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void buttonCİKİS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewrandevuListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewrandevuListesi.SelectedCells[0].RowIndex;
            richTextRandevuDetay.Text = dataGridViewrandevuListesi.Rows[secilen].Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}