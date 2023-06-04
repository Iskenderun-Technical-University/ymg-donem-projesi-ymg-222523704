using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelOtomasyonu
{
    public partial class frmRezervasyon : Form
    {
        // rezervasyon bilgilerimizi formumuz içerisinde taşımasını yapacak olan private değişkenimiz
        rezervasyon rezervasyonBilgi = new rezervasyon();

        musteri secilenMusteri = null;

        private void odabilgileri()
        {
            odaBindingSource.DataSource = oda.BilgileriGetir();
            List<oda> odalar = oda.BilgileriGetir();
            odalar.Insert(0, new oda() { id = 0, adi = "Seçiniz!" });
            odaidComboBox.DataSource = odalar;
        }

        private void rezervasyonlariGetir()
        {
            DataTable dt = new DataTable("rezervasyon");
            using (MySqlDataAdapter dap = new MySqlDataAdapter("select r.id as rezerveno,r.odano,m.kimlikno,m.adi,m.soyadi,m.telefon,m.ulke,r.yetiskinsayi,r.cocuksayi,r.bebeksayi,FORMAT(r.birimfiyat,2) as fiyat,FORMAT((r.birimfiyat * r.gun),2) as toplamfiyat,r.rezervasyontarihi,r.giristarihi,r.cikistarihi from rezervasyon r inner join musteri m on r.musteriid=m.id where r.durum between 2 and 3 and r.subeid=?subeid", genel.ConnectionStringName))
            {
                dap.SelectCommand.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                dap.Fill(dt);
            }
            rezervasyonDataGridView.DataSource = dt;
        }

        public frmRezervasyon()
        {
            InitializeComponent();
        }

        bool load;
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            load = true;
            odabilgileri();

            cikistarihiDateTimePicker.Value = giristarihiDateTimePicker.Value.AddDays(Convert.ToInt32(gunNumeric.Value));

            durumComboBox.ValueMember = "id";
            durumComboBox.DisplayMember = "adi";
            durumComboBox.DataSource = genel.RezervasyonDurumlari();

            rezervasyonlariGetir();

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Rezervasyon Tanımlama - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;

            load = false;
        }

        private void musteriButton_Click(object sender, EventArgs e)
        {
            frmMusteriler musteriler = new frmMusteriler();
            if (!string.IsNullOrEmpty(kimlikNoTextBox.Text))
                musteriler.AramaKriteri = kimlikNoTextBox.Text.Trim();
            else if (!string.IsNullOrEmpty(adiTextBox.Text))
                musteriler.AramaKriteri = adiTextBox.Text.Trim();
            else if (!string.IsNullOrEmpty(soyadiTextBox.Text))
                musteriler.AramaKriteri = soyadiTextBox.Text.Trim();
            else
                musteriler.AramaKriteri = "*";
            if (musteriler.ShowDialog() == DialogResult.OK)
            {
                secilenMusteri = musteriler.MusteriBilgi;
                kimlikNoTextBox.Text = secilenMusteri.kimlikno;
                adiTextBox.Text = secilenMusteri.adi;
                soyadiTextBox.Text = secilenMusteri.soyadi;
                telefonTextBox.Text = secilenMusteri.telefon;
                ulkeTextBox.Text = secilenMusteri.ulke;
            }
        }

        private void odaButton_Click(object sender, EventArgs e)
        {
            frmOdalar odalar = new frmOdalar();
            if (odalar.ShowDialog() == DialogResult.OK)
                odanoTextBox.Text = odalar.OdaNo.ToString();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenMusteri == null)
                {
                    MessageBox.Show("Lütfen önce müşteri seçiniz!", "Uyarı");
                    return;
                }
                else if (durumComboBox.SelectedIndex <= 0)
                {
                    MessageBox.Show("Lütfen durum bilgisi seçiniz!", "Uyarı");
                    return;
                }

                // değişen bilgileri kullanıcı sınıfından oluşturduğumuz temp değişkenimize aktarıyoruz.
                // ekranımızdaki bileşenler ile değikenlerimizi eşleştiriyoruz.

                // combobox dan gelen bilgi string olduğu için integer tipine dönüştürme işlemi yapıyoruz
                rezervasyonBilgi.musteriid = secilenMusteri.id;
                rezervasyonBilgi.kullaniciid = genel.Personel.id;
                rezervasyonBilgi.subeid = genel.Personel.subeid;
                rezervasyonBilgi.odaid = Convert.ToInt32(odaidComboBox.SelectedValue);
                rezervasyonBilgi.odano = Convert.ToInt16(odanoTextBox.Text);
                rezervasyonBilgi.rezervasyontarihi = rezervasyontarihiDateTimePicker.Value;
                rezervasyonBilgi.giristarihi = giristarihiDateTimePicker.Value;
                rezervasyonBilgi.cikistarihi = cikistarihiDateTimePicker.Value;
                rezervasyonBilgi.gun = Convert.ToInt16(gunNumeric.Value);
                rezervasyonBilgi.yetiskinsayi = Convert.ToInt16(yetiskinsayiNumericUpDown.Value);
                rezervasyonBilgi.cocuksayi = Convert.ToInt16(cocuksayiNumericUpDown.Value);
                rezervasyonBilgi.bebeksayi = Convert.ToInt16(bebeksayiNumericUpDown.Value);
                rezervasyonBilgi.birimfiyat = Convert.ToSingle(birimfiyatMaskedTextBox.Text);
                rezervasyonBilgi.durum = Convert.ToByte(durumComboBox.SelectedValue);

                // kayıt işlemimizin başarılı olup olmadığına dair bilginin tutulacağı değişkenimiz
                bool kayitBasarili = false;

                // bilginin daha önce kayıtlı olup olmadığının kontrolünü yapıyoruz.
                // eğer daha önceden kayıtlı ise güncelleme yapılacak değilse yeni kayıt ekleyecek.
                // ekleme yada güncelleme işleminden evet/hayır bilgisi dönmektedir.
                if (rezervasyonBilgi.id > 0)
                    kayitBasarili = rezervasyon.Guncelle(rezervasyonBilgi); // güncelleme metodumuz, işlem başarılı ise true döner
                else
                    kayitBasarili = rezervasyon.Ekle(rezervasyonBilgi); // ekleme metdomuz, işlem başarılı ise true döner

                // kayıt işlemi başarılımı değilmi diye kontrol ediyoruz
                if (kayitBasarili)
                {
                    // kayıt işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                    btnTemizle.PerformClick();
                    // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                    rezervasyonlariGetir();
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
                if (rezervasyonBilgi.id > 0)
                {
                    // kullanıcı silindiğinde bize true bir değer döner
                    if (rezervasyon.Sil(rezervasyonBilgi))
                    {
                        // silme işlemimiz başarılı bir şekilde gerçekleştiğinde temizle butonumuzu çalıştırıyoruz.
                        btnTemizle.PerformClick();
                        // değişen kayıtlarımızın grid üzerinde yenilenmesi için data getirme metodumuzu tekar çalıştırıyoruz.
                        rezervasyonlariGetir();
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
            rezervasyonBilgi = null;
            // yeni rezervasyon nesnesi oluşturuyoruz
            rezervasyonBilgi = new rezervasyon();
            // müşteri bilgilerini taşıan objemizi sıfırlıyoruz.
            secilenMusteri = null;
            // form üzerindeki bilgileri temizliyoruz.
            genel.Temizle(this.gbMusteriBilgileri);
            genel.Temizle(this.gbOdaBilgileri);
        }

        private void odaidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odaidComboBox.SelectedIndex > 0)
            {
                oda o = odaidComboBox.SelectedItem as oda;
                birimfiyatMaskedTextBox.Text = o.gunfiyat.ToString("000.00");
                lblOdaBilgi.Text = "Bu oda da kalabilecek toplam '" + o.kisisayi + "' kişi kalabilir!";
            }
        }

        bool numericValue;
        private void gunNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!load & !cikisTarihi)
            {
                numericValue = true;
                cikistarihiDateTimePicker.Value = giristarihiDateTimePicker.Value.AddDays(Convert.ToInt32(gunNumeric.Value));
                numericValue = false;
            }
        }

        private void rezervasyontarihiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!load)
                if (rezervasyontarihiDateTimePicker.Value > giristarihiDateTimePicker.Value)
                {
                    MessageBox.Show("Rezervasyon tarihi giriş tarihinden büyük olamaz!", "Uyarı");
                    rezervasyontarihiDateTimePicker.Value = giristarihiDateTimePicker.Value;
                }
        }

        private void giristarihiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!load)
                cikistarihiDateTimePicker.Value = giristarihiDateTimePicker.Value.AddDays(Convert.ToInt32(gunNumeric.Value));
        }

        bool cikisTarihi;
        private void cikistarihiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!load & !numericValue)
                if (cikistarihiDateTimePicker.Value <= giristarihiDateTimePicker.Value)
                {
                    MessageBox.Show("Çıkış tarihi giriş tarihinden büyük olmalıdır.", "Uyarı");
                    cikistarihiDateTimePicker.Value = giristarihiDateTimePicker.Value.AddDays(Convert.ToInt32(gunNumeric.Value));
                }
                else
                {
                    cikisTarihi = true;
                    TimeSpan ts = cikistarihiDateTimePicker.Value - giristarihiDateTimePicker.Value;
                    gunNumeric.Value = ts.Days + 1;
                    cikisTarihi = false;
                }
        }

        private void rezervasyonDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    rezervasyonBilgi = rezervasyon.Getir(Convert.ToInt32(rezervasyonDataGridView.Rows[e.RowIndex].Cells["rezerveno"].Value));

                    if (rezervasyonBilgi.id > 0)
                    {
                        load = true;
                        secilenMusteri = musteri.Getir(rezervasyonBilgi.musteriid);
                        kimlikNoTextBox.Text = secilenMusteri.kimlikno;
                        adiTextBox.Text = secilenMusteri.adi;
                        soyadiTextBox.Text = secilenMusteri.soyadi;
                        telefonTextBox.Text = secilenMusteri.telefon;
                        ulkeTextBox.Text = secilenMusteri.ulke;
                        odaidComboBox.SelectedValue = rezervasyonBilgi.odaid;
                        odanoTextBox.Text = rezervasyonBilgi.odano.ToString();
                        giristarihiDateTimePicker.Value = rezervasyonBilgi.giristarihi;
                        cikistarihiDateTimePicker.Value = rezervasyonBilgi.cikistarihi;
                        rezervasyontarihiDateTimePicker.Value = rezervasyonBilgi.rezervasyontarihi;
                        gunNumeric.Value = rezervasyonBilgi.gun;
                        yetiskinsayiNumericUpDown.Value = rezervasyonBilgi.yetiskinsayi;
                        cocuksayiNumericUpDown.Value = rezervasyonBilgi.cocuksayi;
                        bebeksayiNumericUpDown.Value = rezervasyonBilgi.bebeksayi;
                        birimfiyatMaskedTextBox.Text = rezervasyonBilgi.birimfiyat.ToString("000.00");
                        durumComboBox.SelectedValue = rezervasyonBilgi.durum.ToString();
                        load = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
