using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmMusteriTanimla : Form
    {
        // form içerisinde bilgi ekleme, güncelleme ve silme işlemlerini bu nesne üzerinden gerçekleştireceğiz
        // müşteri bilgilerini tutması için oluşturuğumuz musteri sınıfımız içerisindek özellikler ile bize kolaylık sağlamaktadır
        musteri musteriBilgi = new musteri();

        public frmMusteriTanimla()
        {
            InitializeComponent();
        }

        private void frmMusteriTanimla_Load(object sender, EventArgs e)
        {
            // form açıldığında yüklenmesi gereken bilgileri çağırıyoruz 
            // grid içerisindeki combobox'ı önce doldurmamız gerekitiği için ilk olarak şube bilgilerini çağırıyoruz
            subeBindingSource.DataSource = sube.BilgileriGetir();

            // grid bilgilerini getirmek için iligili metodu çağırıyoruz.
            musteriBindingSource.DataSource = musteri.BilgileriGetir();

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Müşteri Tanımlama - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (kimliknoTextBox.Text.Length < 10)
                {
                    MessageBox.Show("Lütfen kimlik alanını 11 hane olarak giriniz.", "Uyarı");
                    return;
                }
                if (string.IsNullOrWhiteSpace(adiTextBox.Text)
                    || string.IsNullOrWhiteSpace(soyadiTextBox.Text)
                    || string.IsNullOrWhiteSpace(adresTextBox.Text)
                    || string.IsNullOrWhiteSpace(telefonMaskedTextBox.Text)
                    || string.IsNullOrWhiteSpace(ulkeComboBox.Text))
                {
                    MessageBox.Show("Lütfen ekrandaki tüm alanları doldurunuz!", "Uyarı");
                    return;
                }

                // değişen bilgileri müşteri sınıfından oluşturduğumuz temp değişkenimize aktarıyoruz.
                // ekranımızdaki bileşenler ile değikenlerimizi eşleştiriyoruz.
                // giriş yapan personel bilgisi içerisinden şubeid ve kullanici id bilgilerini alıyoruz.
                musteriBilgi.subeid = genel.Personel.subeid;
                musteriBilgi.kullaniciid = genel.Personel.id;
                // formdaki controllerden bilgileri alıyoruz.
                musteriBilgi.kimlikno = kimliknoTextBox.Text;
                musteriBilgi.adi = adiTextBox.Text;
                musteriBilgi.soyadi = soyadiTextBox.Text;
                musteriBilgi.adres = adresTextBox.Text;
                musteriBilgi.telefon = telefonMaskedTextBox.Text;
                musteriBilgi.ulke = ulkeComboBox.Text;
                musteriBilgi.aktif = aktifCheckBox.Checked;

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (musteriBilgi.id > 0)
                    kayitBasarili = musteri.Guncelle(musteriBilgi);
                else
                    kayitBasarili = musteri.Ekle(musteriBilgi);

                // kayıt işlemi varmı diye kontrol ediyoruz
                if (kayitBasarili)
                {
                    // kaydetme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    musteriBindingSource.DataSource = musteri.BilgileriGetir();
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
                // silinecek kayıt varssa id değeri sıfırdan büyük olması gerekli
                // bu değerin kontrolünü yapıyoruz
                if (musteriBilgi.id > 0)
                {
                    if (musteri.Sil(musteriBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        musteriBindingSource.DataSource = musteri.BilgileriGetir();
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
            musteriBilgi = null;
            // yeni musteri nesnesi oluşturuyoruz
            musteriBilgi = new musteri();
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this);
        }

        private void musteriDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // seçilen kayıt olup olmadığını kontrol ediyoruz
                if (e.RowIndex >= 0)
                {
                    // çalışma zamanı tip tanımlayıcısı ile tip dönüşümü yapıyoruz
                    musteriBilgi = musteriDataGridView.Rows[e.RowIndex].DataBoundItem as musteri;

                    // gelen bilgilerimizi form üzerindeki ilgili controllerimiz içerisine uygun şekilde aktarıyoruz.
                    kimliknoTextBox.Text = musteriBilgi.kimlikno;
                    adiTextBox.Text = musteriBilgi.adi;
                    soyadiTextBox.Text = musteriBilgi.soyadi;
                    adresTextBox.Text = musteriBilgi.adres;
                    telefonMaskedTextBox.Text = musteriBilgi.telefon;
                    ulkeComboBox.Text = musteriBilgi.ulke;
                    aktifCheckBox.Checked = musteriBilgi.aktif;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
