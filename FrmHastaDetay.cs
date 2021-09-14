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

namespace Proje_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = dataGridView2.SelectedCells[0].RowIndex;
            //Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            //Ad SOyad Çekme
             SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Aktif Randevular
          //  DataTable dt1 = new DataTable();
          //  SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + LblAdSoyad.Text + "'", bgl.baglanti());
           // da1.Fill(dt1);
          //  dataGridView1.DataSource = dt1;
            //Randevu Geçmişi
            //DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC="+tc,bgl.baglanti());
           // da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            //Branşı combobx aktarma
            


           // Aktif Randevular
          //  DataTable dt2 = new DataTable();
           // SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + LblAdSoyad.Text + "'", bgl.baglanti());
           // da2.Fill(dt2);
           // dataGridView1.DataSource = dt1;

            bgl.baglanti().Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DataTable dt = new DataTable();
            //SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "'" + " and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
          //  fr.TCno = LblTC.Text;
           // fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = dataGridView2.SelectedCells[0].RowIndex;
            //Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
          //  SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
          //  komut.Parameters.AddWithValue("@p1", LblTC.Text);
           // komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
           // komut.Parameters.AddWithValue("@p3", Txtid.Text);
           // komut.ExecuteNonQuery();
           // bgl.baglanti().Close();
          //  MessageBox.Show("Randevu Alındı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            //DataTable dt2 = new DataTable();
            //SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=", bgl.baglanti());
            //da2.Fill(dt2);
            //dataGridView2.DataSource = dt2;
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kALİTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hizmetten genel olarak faydalanma \n*Adalet ve hakkaniyet ilkeleri çerçevesinde sağlıklı yaşamanın teşvik edilmesine yönelik faaliyetler ve koruyucu sağlık hizmetlerinden faydalanmaya, \nEşitlik içinde hizmete ulaşma \n*Irk, dil, din ve mezhep, cinsiyet, siyasi düşünce, felsefi inanç, ekonomik ve sosyal durumları dikkate alınmadan hizmet almaya, \nBilgilendirme \n*Her türlü hizmet ve imkânın neler olduğunu öğrenmeye,", "KALİTE");

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon No \n0332 042 01 01 \nE-mail Adres \nkaderarslann0316@gmail.com \nHastane Lokasyonu \nTürkmenbaşı Bulvarı SEYHAN/ADANA", "İLETİŞİM");

        }

        private void mİSYONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahlaki değerlerden ödün vermeden, hasta haklarını gözeterek, hastaların ihtiyaç, istek ve beklentilerini kesintisiz ve güvenilir bir şekilde, çağdaş standartlara uygun olarak karşılayan bir kuruluş olmaktır.", "MİSYON");

        }

        private void vİZYONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koruyucu ve tedavi edici sağlık hizmetlerinde Güven, Saygınlık ve Hasta Memnuniyeti adıyla özdeşleştirmiş, sağlam kurumsal kimliği ve tıbbi başarıyla öne çıkan, uluslararası düzeyde örnek bir kuruluş olmakdır.", "VİZYON");

        }

        private void dEĞERLERİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Hasta haklarına saygılı olmak \n*Tıbbi etik kurallara bağlı olmak \n*Bilgili, şeffaf ve güvenilir olmak \n*Araştırmacı, özverili, sorumluluk sahibi ve toplum yararını gözetiyor olmak \n*Değişime uyum sağlamak \n*Katılımcı olmak \n*Ekip ruhu ile işbirliği içinde olmak \n*Dayanışma ve paylaşma ruhuna sahip olmak \n*Kaliteyi bütüncül yaklaşımla yönetmek ve hep birlikte, her an kaliteli hizmet sunmaktır.", "DEĞERLERİMİZ");

        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            FrmLoginPaneli fr = new FrmLoginPaneli();
            fr.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaDetay fr = new FrmHastaDetay();
            fr.ShowDialog();
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void LblTC_Click(object sender, EventArgs e)
        {
          //  SqlCommand komut1 = new SqlCommand("Select HAstaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
          //  komut1.Parameters.AddWithValue("@p1", LblTC.Text);
          //  SqlDataReader dr1 = komut1.ExecuteReader();
          //  while (dr1.Read())
          //  {
            //    LblAdSoyad.Text = dr1[0] + " " + dr1[1];
           // }
           // bgl.baglanti().Close();
        }

        private void LblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //int secilen = dataGridView1.SelectedCells[0].RowIndex;
           //RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void CmbBrans_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //SqlCommand komutkaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            //komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            //komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            //komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            //komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            //komutkaydet.ExecuteNonQuery();
            //bgl.baglanti().Close();
            //MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = dataGridView1.SelectedCells[0].RowIndex;
           // Txtid.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            //DataTable dt2 = new DataTable();
            //SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=", bgl.baglanti());
            //da2.Fill(dt2);
            //dataGridView1.DataSource = dt2;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // int secilen = dataGridView1.SelectedCells[0].RowIndex;
           // Txtid.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }
    }
}
