using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmOdaTanimla : Form
    {
        // form içerisinde ekleme, güncelleme ve silme gibi işlemlerimizi gerçekleştirmek için içerisinde bilgileri taşıyacak olan private değişlenimiz
        oda odaBilgi = new oda();

        public frmOdaTanimla()
        {
            InitializeComponent();
        }

        private void frmOdaTanimla_Load(object sender, EventArgs e)
        {
            // form açıldığında oda bilgilerinin grid üzerine yüklenmesini sağlıyoruz..
            odaBindingSource.DataSource = oda.BilgileriGetir();

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Oda Tanımlama - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(adiTextBox.Text)
                    || string.IsNullOrWhiteSpace(gunfiyatMaskedTextBox.Text)
                    || Convert.ToInt32(kisisayiNumericUpDown.Value) <= 0)
                {
                    MessageBox.Show("Lütfen ekrandaki tüm alanları doldurunuz!", "Uyarı");
                    return;
                }

                // değişen bilgileri oda sınıfından oluşturduğumuz temp değişkenimize aktarıyoruz.
                // ekranımızdaki bileşenler ile değikenlerimizi eşleştiriyoruz.
                odaBilgi.adi = adiTextBox.Text;
                // numeric controlünden gelen değer decimal olduğu için içerisindeki değerin
                // int tipinden olduğunu biliyoruz ve convert sınıfı aracılığı ile dönüştürme işlemimizi yapıyoruz
                odaBilgi.kisisayi = Convert.ToInt32(kisisayiNumericUpDown.Value);
                // maskedtext kutusu içerisindeki değer string olduğu için float tipine dönüştürme işlemi yapıyoruz
                odaBilgi.gunfiyat = Convert.ToSingle(gunfiyatMaskedTextBox.Text);

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (odaBilgi.id > 0)
                    kayitBasarili = oda.Guncelle(odaBilgi);
                else
                    kayitBasarili = oda.Ekle(odaBilgi);

                if (kayitBasarili)
                {
                    // kayıt işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    odaBindingSource.DataSource = oda.BilgileriGetir();
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
                if (odaBilgi.id > 0)
                {
                    if (oda.Sil(odaBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        odaBindingSource.DataSource = oda.BilgileriGetir();
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
            odaBilgi = null;
            // yeni şube nesnesi oluşturuyoruz
            odaBilgi = new oda();
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this);
        }

        private void odaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // oda nesnemizi grid içerisinden alama yönetemleri
                    // 1. yöntem..
                    //odaBilgi = ((List<oda>)odaBindingSource.DataSource)[e.RowIndex];
                    // 2. yöntem..
                    //odaBilgi = (odaBindingSource.DataSource as List<oda>)[e.RowIndex];
                    // 3. yöntem
                    //odaBilgi = (oda)odaDataGridView.Rows[e.RowIndex].DataBoundItem;
                    // 4. yöntem
                    //odaBilgi = odaDataGridView.Rows[e.RowIndex].DataBoundItem as oda;
                    // 5. yöntem.. (tavsiye edilir)
                    //odaBilgi = (oda)odaDataGridView.CurrentRow.DataBoundItem;
                    // 6. yöntem.. (tavsiye edilir)
                    odaBilgi = odaDataGridView.CurrentRow.DataBoundItem as oda;

                    // gelen değerlerimi atama işlemlerimi gerçekleştiriyorum
                    adiTextBox.Text = odaBilgi.adi;
                    kisisayiNumericUpDown.Value = odaBilgi.kisisayi;
                    // günün fiyat bilgisi float türünden döndüğü için onu tostring özelliği ile dönüştürüyoruz ve ilgili alana aktarıyoruz
                    // parasal değeri ekranda doğru yazdırabilmem için formatter bilgisini tostring içerisine verdim
                    // bunu sadece sayısal alanlarda yapabiliyoruz..
                    gunfiyatMaskedTextBox.Text = odaBilgi.gunfiyat.ToString("000.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
