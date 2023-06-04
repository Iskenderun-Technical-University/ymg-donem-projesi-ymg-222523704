using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmSubeTanimla : Form
    {
        // form içerisinde ekleme, güncelleme ve silme gibi işlemlerimizi gerçekleştirmek için içerisinde bilgileri taşıyacak olan private değişlenimiz
        sube subeBilgi = new sube();

        public frmSubeTanimla()
        {
            InitializeComponent();
        }

        private void frmSubeTanimla_Load(object sender, EventArgs e)
        {
            subeBindingSource.DataSource = sube.BilgileriGetir();

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
                subeBilgi.adi = adiTextBox.Text;
                subeBilgi.aktif = aktifCheckBox.Checked;

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (subeBilgi.id > 0)
                    kayitBasarili = sube.Guncelle(subeBilgi);
                else
                    kayitBasarili = sube.Ekle(subeBilgi);

                if (kayitBasarili)
                {
                    // kayıt işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    subeBindingSource.DataSource = sube.BilgileriGetir();
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
                if (subeBilgi.id > 0)
                {
                    // kayıt silme işlemimiz için oluşturduğumuz metodumuza sube türünde olan nesnemizi veriyoruz
                    // kayıt silme işlemi başarılı olduğunda bize true değer dönecektir
                    if (sube.Sil(subeBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        subeBindingSource.DataSource = sube.BilgileriGetir();
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
            subeBilgi = null;
            // yeni şube nesnesi oluşturuyoruz
            subeBilgi = new sube();
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this);
        }

        private void subeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // bu yöntem ile subeBindingSource içerisindeki datasource özelliği bize object değer dönmektedir
                    // bu değerimizin List<sube> tipinden olduğunu bildiğimiz için o tipe dönüştürüp liste içerisindeki index numarası ile almak istediğimiz dataya erişebiliyoruz..
                    //temp = ((List<sube>)subeBindingSource.DataSource)[e.RowIndex];

                    // databounditem bize sube sınıfımızdan değer dönmektedir bundan dolayı çalışma zamanı tip tanımlayıcısını kullanarak sube nesnesine dönüşümünü yapıyoruz.
                    // böylelikle grid üzerinde gördüğümüz değerleri artık kendi oluşturduğumuz nesne tipinden erişiyor olacağız
                    // bunu bize sağlayan List<sube> tipinden değerleri getirmemiz ve datasource aktarmamızdır.
                    subeBilgi = subeDataGridView.Rows[e.RowIndex].DataBoundItem as sube;

                    // ilgili alanları aktarma işlemi yapıyoruz
                    adiTextBox.Text = subeBilgi.adi;
                    aktifCheckBox.Checked = subeBilgi.aktif;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
