using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmKullaniciTanimla : Form
    {
        // kullanıcı bilgilerimizi formumuz içerisinde taşımasını yapacak olan private değişkenimiz
        kullanici kullaniciBilgi = new kullanici();

        // Methodlarımız
        private void SubeleriDoldur()
        {
            try
            {
                #region --- Subeleri ComboBox'a Dolurmak İçin Farklı Bir Yöntem ---
                //// şube tablosundan gelen bilgileri doldurduğumuz combobox üzerindeki ayarları yapılandırıyoruz!
                //// 1. combobox'ın selectedvalue özelliğinde gösterilecek kolon adını belirtiyoruz..
                //subeidComboBox.ValueMember = "id";
                //// 2. combobox'ın text özelliğinde gösterilecek kolon adını belirtiyoruz
                //subeidComboBox.DisplayMember = "adi";
                //// 3. datasource özelliğine içerisine dataları aktardığımız datatable'ımızı veriyoruz..
                //subeidComboBox.DataSource = sube.TabloOlarakGetir(); 
                #endregion

                // şube bilgilerini getiriyoruz
                subeBindingSource.DataSource = sube.BilgileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        public frmKullaniciTanimla()
        {
            InitializeComponent();
        }

        private void frmKullaniciTanimla_Load(object sender, EventArgs e)
        {
            // form açılırken yapmamız gereken işlemleri burada belirtiyoruz
            // şubeleri doldurma işlemimizi yapmak için şubeleri doldur metodunu çağırıyoruz
            // bu metod aynı zamanda grid içerisindeki şube bilgilerinide getirmektedir
            // grid içerisindeki bilgi grid dolmadan önce yapılması gereklidir
            SubeleriDoldur();

            // grid içerisinde ekstradan dolması gereken alanları bu kod parçacığından önce yapmalıyız.
            // kullanıcı bilgilerinin gelmesi için kullanıcı sınıfı içerisinde oluşturduğumuz bilgileri getir metodumuzu çalıştırıyoruz
            kullaniciBindingSource.DataSource = kullanici.BilgileriGetir();

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Kullanıcı Tanımlama - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(adiTextBox.Text)
                    || string.IsNullOrWhiteSpace(soyadiTextBox.Text)
                    || string.IsNullOrWhiteSpace(kodTextBox.Text)
                    || string.IsNullOrWhiteSpace(sifreTextBox.Text)
                    || Convert.ToInt32(subeidComboBox.SelectedValue) <= 0)
                {
                    MessageBox.Show("Lütfen ekrandaki tüm alanları doldurunuz!", "Uyarı");
                    return;
                }

                // değişen bilgileri kullanıcı sınıfından oluşturduğumuz temp değişkenimize aktarıyoruz.
                // ekranımızdaki bileşenler ile değikenlerimizi eşleştiriyoruz.

                // combobox dan gelen bilgi string olduğu için integer tipine dönüştürme işlemi yapıyoruz
                kullaniciBilgi.subeid = Convert.ToInt32(subeidComboBox.SelectedValue);
                kullaniciBilgi.kod = kodTextBox.Text;
                kullaniciBilgi.sifre = sifreTextBox.Text;
                kullaniciBilgi.adi = adiTextBox.Text;
                kullaniciBilgi.soyadi = soyadiTextBox.Text;
                kullaniciBilgi.yonetici = yoneticiCheckBox.Checked;

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (kullaniciBilgi.id > 0)
                    kayitBasarili = kullanici.Guncelle(kullaniciBilgi); // güncelleme metodumuz, işlem başarılı ise true döner
                else
                    kayitBasarili = kullanici.Ekle(kullaniciBilgi); // ekleme metdomuz, işlem başarılı ise true döner

                // kayıt işlemi başarılımı değilmi diye kontrol ediyoruz
                if (kayitBasarili)
                {
                    // kayıt işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    kullaniciBindingSource.DataSource = kullanici.BilgileriGetir();
                    // işlemimizin başarılı olduğuna dair ekranda mesaj çıkarıyoruz...
                    MessageBox.Show("İşleminiz başarılı bir şekilde gerçekleştirildi!", "Bilgi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // silinecek kayıt olup olmadığını kontrol ediyoruz
                if (kullaniciBilgi.id > 0)
                {
                    // kullanıcı silindiğinde bize true bir değer döner
                    if (kullanici.Sil(kullaniciBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        kullaniciBindingSource.DataSource = kullanici.BilgileriGetir();
                        // işlemimizin başarılı olduğuna dair ekranda mesaj çıkarıyoruz...
                        MessageBox.Show("Silme İşleminiz başarılı bir şekilde gerçekleştirildi!", "Bilgi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // var olan bilgileri sıfırlıyoruz
            kullaniciBilgi = null;
            // yeni kullanici nesnesi oluşturuyoruz
            kullaniciBilgi = new kullanici();
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this);
        }

        private void kullaniciDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // seçilen kayıt olup olmadığını kontrol ediyoruz
                if (e.RowIndex >= 0)
                {
                    // seçilen kayıt bilgisini almak için event args içerisinden bize gelen index bilgilerini kullanıyoruz.
                    // databounditem bize object değer dönmektedir ve bu object değerimizin tipini bildiğimiz için çalışma zamanı tip tanımlayıcısını kullanarak
                    // tip dönüştürme işlemimizi gerçekleştiriyoruz, burada tipimiz kullanıcı sınıfından olduğu için kullanıcı tipinden alarak içindeki değerleri okuyoruz
                    kullaniciBilgi = kullaniciDataGridView.Rows[e.RowIndex].DataBoundItem as kullanici;
                    // değerlerimizi form üzerindeki controllerimiz ile ilişkilendiriyoruz
                    // veritabınından gelen alanları ilgili alanlara aktararak form üzerinde görünmesini ve değişikliğinin yapılmasını sağlıyoruz
                    subeidComboBox.SelectedValue = kullaniciBilgi.subeid;
                    kodTextBox.Text = kullaniciBilgi.kod;
                    sifreTextBox.Text = kullaniciBilgi.sifre;
                    adiTextBox.Text = kullaniciBilgi.adi;
                    soyadiTextBox.Text = kullaniciBilgi.soyadi;
                    yoneticiCheckBox.Checked = kullaniciBilgi.yonetici;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            // yeni şube tanımlamak için şube tanımlama formunu açıyoruz.
            frmSubeTanimla frm = new frmSubeTanimla();
            // show ilede açtırabiliriz fakat showdialog kullanmamızdaki sebeb ise diğer formlara müdahale edilememesidir ve show dialog bize durum bilgisi verir
            frm.ShowDialog();
            // değişen kayıtları algılamak için şube formu kapandıktan sonra subeleri doldur metodumuzu çalıştıyoruz..
            SubeleriDoldur();

            // gridimiz üzerindeki combobox alanındaki bilgilerinde yenilenmesi için tekrar kullanıcı bilgilerini çekiyoruz
            kullaniciBindingSource.DataSource = kullanici.BilgileriGetir();
        }
    }
}
