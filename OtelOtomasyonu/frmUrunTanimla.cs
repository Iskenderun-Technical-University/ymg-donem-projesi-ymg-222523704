using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmUrunTanimla : Form
    {
        // form içerisinde ekleme, güncelleme ve silme gibi işlemlerimizi gerçekleştirmek için içerisinde bilgileri taşıyacak olan private değişlenimiz
        urun urunBilgi = new urun();

        public frmUrunTanimla()
        {
            InitializeComponent();
        }

        private void frmUrunTanimla_Load(object sender, EventArgs e)
        {
            urunBindingSource.DataSource = urun.BilgileriGetir();

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Şube Tanımlama - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(adiTextBox.Text))
                {
                    MessageBox.Show("Lütfen ekrandaki tüm alanları doldurunuz!", "Uyarı");
                    return;
                }

                // değişen bilgileri müşteri sınıfından oluşturduğumuz temp değişkenimize aktarıyoruz.
                // ekranımızdaki bileşenler ile değikenlerimizi eşleştiriyoruz.
                urunBilgi.adi = adiTextBox.Text;
                urunBilgi.birimfiyat = Convert.ToSingle(birimfiyatMaskedTextBox.Text);

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (urunBilgi.id > 0)
                    kayitBasarili = urun.Guncelle(urunBilgi);
                else
                    kayitBasarili = urun.Ekle(urunBilgi);

                if (kayitBasarili)
                {
                    // kayıt işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    urunBindingSource.DataSource = urun.BilgileriGetir();
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
                // silinecek kayıt varmı yokmu diye kontrol ediyoruz.
                if (urunBilgi.id > 0)
                {
                    // kayıt silme işlemimiz için oluşturduğumuz metodumuza urun türünde olan nesnemizi veriyoruz
                    // kayıt silme işlemi başarılı olduğunda bize true değer dönecektir
                    if (urun.Sil(urunBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        urunBindingSource.DataSource = urun.BilgileriGetir();
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
            urunBilgi = null;
            // yeni şube nesnesi oluşturuyoruz
            urunBilgi = new urun();
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this);
        }

        private void urunDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    urunBilgi = urunDataGridView.CurrentRow.DataBoundItem as urun;
                    adiTextBox.Text = urunBilgi.adi;
                    birimfiyatMaskedTextBox.Text = urunBilgi.birimfiyat.ToString("000.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
