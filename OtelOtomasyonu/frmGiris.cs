using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelOtomasyonu
{
    public partial class frmGiris : Form
    {
        // Methodlarımız
        private void SubeleriDoldur()
        {
            try
            {
                // şube tablosundan gelen bilgileri doldurduğumuz combobox üzerindeki ayarları yapılandırıyoruz!
                // 1. combobox'ın selectedvalue özelliğinde gösterilecek kolon adını belirtiyoruz..
                cmbSubeler.ValueMember = "id";
                // 2. combobox'ın text özelliğinde gösterilecek kolon adını belirtiyoruz
                cmbSubeler.DisplayMember = "adi";
                // 3. datasource özelliğine içerisine dataları aktardığımız datatable'ımızı veriyoruz..
                cmbSubeler.DataSource = sube.TabloOlarakGetir();
                // Varsayılanda kayıtlı olan şubeyi seçiyoruz..
                cmbSubeler.SelectedValue = Properties.Settings.Default.SubeID; // sube tablosundaki bilgileri çekmek için adapter nesnemizi oluşturuyoruz.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void KullaniciGirisYap()
        {
            try
            {
                #region --- Kullanıcı Giriş İşlemleri ---
                // veritabanı ile bağlantı kurabilmek için connection nesnemizi oluşturduk.
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    // bağlantımız kapalı ise bağlantı açma işlemimizi gerçekleştiriyoruz.
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;
                    }

                    // tablomuza gerekli sorgu ve komutları göndermemizi sağlayacak olan nesnemiz.
                    using (MySqlCommand cmd = new MySqlCommand("select * from kullanici where subeid=?sube and kod=?kod and sifre=?sifre limit 1", cnn))
                    {
                        // sorgumuz içerisinde gönderdiğimiz parametrelerimiz atama işlemi
                        cmd.Parameters.AddWithValue("?sube", cmbSubeler.SelectedValue);
                        cmd.Parameters.AddWithValue("?kod", txtKod.Text);
                        cmd.Parameters.AddWithValue("?sifre", txtSifre.Text);

                        // data okuma işlemimiz için datareader sınıfından faydalanıyoruz.
                        // data reader tek satırlık data okuma işlemlerinde performans sağlamaktadır.
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
                            // veritabanından gelen personel bilgisini ilgili genel sınıfı içerisindeki static değikenimize aktarıyoruz.
                            // aktarma işlemi esnasında kullanıcı nesnemiz içerisinde tanımladığımız constructor dan faydalanıyoruz.
                            // aktarım
                            while (dr.Read())
                                genel.Personel = new kullanici(Convert.ToInt32(dr["id"]), Convert.ToInt32(dr["subeid"]), dr["kod"].ToString(), dr["sifre"].ToString(), dr["adi"].ToString(), dr["soyadi"].ToString(), Convert.ToBoolean(dr["yonetici"]));
                        }
                    }

                    // bağlantımız açık ise bağlantı kapatma işlemimizi gerçekleştiriyoruz.
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtSifre.Text = "admin";

            SubeleriDoldur();
        }

        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamamızı sonlandırmak için exit metodundan yararlanıyoruz.
            // bu kodu çalıştırmamızdaki amaç giriş ekranını hide yaptığımız için uygulamamız tam anlamı ile sonlanmayacaktır
            // exit metodu sayesinde uygulamamızın yaşam döngüsü tamamı ile sona erecektir.
            Application.Exit();
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {
            #region --- Giriş Alanlarından Boş Giriş Yapılmaması İçin Kontrol Ediyoruz ---
            if (cmbSubeler.SelectedIndex <= 0)
            {
                MessageBox.Show("Lütfen şube seçiniz!", "Uyarı");
                return;
            }
            else if (string.IsNullOrEmpty(txtKod.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kod yada şifre alanını boş bırakmayınız!", "Uyarı");
                return;
            }
            #endregion

            KullaniciGirisYap();

            #region --- Personel Giriş Yaptıktan Sonra Açılacak Ekran ---
            // personel giriş yapıntığında personel değişkenimizi dolduracak ve bu sayede personelin giriş yapıp yapmadığını anlayacağız.
            // personel değişkenimizin boş olup olmadığını kontrol ediyoruz.
            if (genel.Personel != null)
            {
                #region --- Giriş Bilgileri Kayıt Altına Alıyoruz ---
                Properties.Settings.Default.SubeID = genel.Personel.subeid;
                Properties.Settings.Default.PersonelKod = genel.Personel.kod;
                Properties.Settings.Default.Save();
                #endregion

                // giriş forumumuzu gizliyoruz 
                this.Hide();

                // giriş yapılan şube bilgisini iligli değişkenimize atıyoruz
                genel.SubeAdi = cmbSubeler.Text;

                // ana ekranımızın olduğu formu açıyoruz..
                frmAna frm = new frmAna();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Seçtiğiniz şube içerisinde böyle bir personel bulunamadı. Lütfen kod ve şifrenizi kontrol ediniz tekrar deneyiniz.", "Uyarı");
            #endregion
        }
    }
}
