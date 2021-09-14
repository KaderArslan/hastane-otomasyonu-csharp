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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon No \n0332 042 01 01 \nE-mail Adres \nkaderarslann0316@gmail.com \nHastane Lokasyonu \nTürkmenbaşı Bulvarı SEYHAN/ADANA", "İLETİŞİM");
        }

        private void kALİTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hizmetten genel olarak faydalanma \n*Adalet ve hakkaniyet ilkeleri çerçevesinde sağlıklı yaşamanın teşvik edilmesine yönelik faaliyetler ve koruyucu sağlık hizmetlerinden faydalanmaya, \nEşitlik içinde hizmete ulaşma \n*Irk, dil, din ve mezhep, cinsiyet, siyasi düşünce, felsefi inanç, ekonomik ve sosyal durumları dikkate alınmadan hizmet almaya, \nBilgilendirme \n*Her türlü hizmet ve imkânın neler olduğunu öğrenmeye,", "KALİTE");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoktorDetay fr = new FrmDoktorDetay();
            fr.ShowDialog();
        }

        private void LblTC_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
