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
    public partial class frmAdisyon : Form
    {
        adisyon adisyonBilgi = new adisyon();

        public int RezervasyonNo { get; set; }

        public int OdaNo { get; set; }

        public frmAdisyon()
        {
            InitializeComponent();
        }

        private void frmAdisyon_Load(object sender, EventArgs e)
        {
            List<urun> urunler = urun.BilgileriGetir();
            urunler.Insert(0, new urun() { id = 0, adi = "<Seçiniz>" });
            urunBindingSource.DataSource = urunler;

            // form açıldığında adisyon bilgilerinin grid üzerine yüklenmesini sağlıyoruz..
            adisyonBindingSource.DataSource = adisyon.BilgileriGetir(RezervasyonNo);

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Adisyon - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;

            lblEkstra.Text = "Oda: " + OdaNo + " Ekstra";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.RezervasyonNo <= 0
                    || urunadiComboBox.SelectedIndex <= 0
                    || Convert.ToInt32(adetNumericUpDown.Value) <= 0)
                {
                    MessageBox.Show("Lütfen ekrandaki tüm alanları doldurunuz!", "Uyarı");
                    return;
                }

                adisyonBilgi.subeid = genel.Personel.subeid;
                adisyonBilgi.kullaniciid = genel.Personel.id;
                adisyonBilgi.rezervasyonid = this.RezervasyonNo;
                // değişen bilgileri adisyon sınıfından oluşturduğumuz temp değişkenimize aktarıyoruz.
                // ekranımızdaki bileşenler ile değikenlerimizi eşleştiriyoruz.
                adisyonBilgi.urunadi = urunadiComboBox.Text;
                // numeric controlünden gelen değer decimal olduğu için içerisindeki değerin
                // int16 tipinden olduğunu biliyoruz ve convert sınıfı aracılığı ile dönüştürme işlemimizi yapıyoruz
                adisyonBilgi.adet = Convert.ToInt16(adetNumericUpDown.Value);
                // maskedtext kutusu içerisindeki değer string olduğu için float tipine dönüştürme işlemi yapıyoruz
                adisyonBilgi.birimfiyat = Convert.ToSingle(birimfiyatMaskedTextBox.Text);

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (adisyonBilgi.id > 0)
                    kayitBasarili = adisyon.Guncelle(adisyonBilgi);
                else
                    kayitBasarili = adisyon.Ekle(adisyonBilgi);

                if (kayitBasarili)
                {
                    // kayıt işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    adisyonBindingSource.DataSource = adisyon.BilgileriGetir(RezervasyonNo);
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
                if (adisyonBilgi.id > 0)
                {
                    if (adisyon.Sil(adisyonBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        adisyonBindingSource.DataSource = adisyon.BilgileriGetir(RezervasyonNo);
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
            adisyonBilgi = null;
            // yeni şube nesnesi oluşturuyoruz
            adisyonBilgi = new adisyon();
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this);
        }

        private void adisyonDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    adisyonBilgi = adisyonDataGridView.CurrentRow.DataBoundItem as adisyon;
                    urunadiComboBox.SelectedValue = adisyonBilgi.urunadi;
                    adetNumericUpDown.Value = adisyonBilgi.adet;
                    birimfiyatMaskedTextBox.Text = adisyonBilgi.birimfiyat.ToString("000.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void urunadiComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (urunadiComboBox.SelectedValue != null)
            {
                urun u = urunadiComboBox.SelectedItem as urun;
                birimfiyatMaskedTextBox.Text = u.birimfiyat.ToString("000.00");
            }
            else
            {
                birimfiyatMaskedTextBox.Text = string.Empty;
            }
        }
    }
}
