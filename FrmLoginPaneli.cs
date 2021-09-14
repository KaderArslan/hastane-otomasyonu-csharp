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
    public partial class FrmLoginPaneli : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();

        public FrmLoginPaneli()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void BtnOturumAc_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();


            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", MskTc.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();


            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", MskTc.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = MskTc.Text;
                fr.Show();
                this.Hide();
            }
            
            else if(dr1.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = MskTc.Text;
                frs.Show();
                this.Hide();
            }
            else if(dr2.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = MskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
              MessageBox.Show("Hatalı TC & Şifre");

            }
            bgl.baglanti().Close();
        }

        private void kALİTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hizmetten genel olarak faydalanma \n*Adalet ve hakkaniyet ilkeleri çerçevesinde sağlıklı yaşamanın teşvik edilmesine yönelik faaliyetler ve koruyucu sağlık hizmetlerinden faydalanmaya, \nEşitlik içinde hizmete ulaşma \n*Irk, dil, din ve mezhep, cinsiyet, siyasi düşünce, felsefi inanç, ekonomik ve sosyal durumları dikkate alınmadan hizmet almaya, \nBilgilendirme \n*Her türlü hizmet ve imkânın neler olduğunu öğrenmeye,", "KALİTE");

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon No \n0332 042 01 01 \nE-mail Adres \nkaderarslann0316@gmail.com \nHastane Lokasyonu \nTürkmenbaşı Bulvarı SEYHAN/ADANA", "İLETİŞİM");

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void yENİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            FrmLoginPaneli fr = new FrmLoginPaneli();
            fr.ShowDialog();
        }

        private void FrmLoginPaneli_Load(object sender, EventArgs e)
        {

        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))//(textBox1.Text == " " || textBox2.Text == " ") //string.IsNullOrWhiteSpace(listBox1.Text))
            {
                MessageBox.Show("alanları doldurunuz");
            }
            else
            {
                try
                {

                    if (maskedTextBox1.Text == "12345678910" || textBox1.Text == "0316" &&
                        maskedTextBox1.Text == "10987654321" || textBox1.Text == "6130")
                    {
                        this.Hide();
                        FrmSekreterDetay git = new FrmSekreterDetay();
                        git.ShowDialog();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("şifre & kullanıcı adı yanlış !!");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void LblTC_Click(object sender, EventArgs e)
        {

        }
    }
}
