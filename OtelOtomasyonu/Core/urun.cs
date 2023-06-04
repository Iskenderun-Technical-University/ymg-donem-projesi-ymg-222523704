using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class urun : IDisposable
    {
		#region ---IDisposable Members---
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
		#endregion

		#region ---Properties/Field - Özellikler Alanlar---
		private int m_id;
		public int id
		{
			get { return m_id; }
			set { m_id = value; }
		}
		private string m_adi;
		public string adi
		{
			get { return m_adi; }
			set { m_adi = value; }
		}
		private float m_birimfiyat;
		public float birimfiyat
		{
			get { return m_birimfiyat; }
			set { m_birimfiyat = value; }
		}

		#endregion

		public urun()
		{
		}

		/// <summary>
		/// urun Nesnesi Oluþtur
		/// </summary>
		public urun(int pid, string padi, float pbirimfiyat)
		{
			this.m_id = pid;
			this.m_adi = padi;
			this.m_birimfiyat = pbirimfiyat;
        }

        // urun tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(urun u)
        {
            try
            {
                // kayýt iþleminin olup olmadýðýna dair bilgiyi tutacak olan bool tipinden deðiþkenimiz ilk deðer atamasýný false yaptým yapmasamda ilk deðeri false olacaktý
                bool kaydedildi = false;
                // kayýt iþlemimi gerçekleþtirebilmek için gerekli baðlantýyý açabilmemi saðlayacak olan connection sýnýfý nesnem
                // connection sýnýfý içerisine baðlantý kurmamý saðalayacak olan veritabaný yolu cümlemi veriyorum
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }
                    using (MySqlCommand cmd = new MySqlCommand("insert into urun (adi,birimfiyat) values(?adi,?birimfiyat)", cnn))
                    {
                        cmd.Parameters.AddWithValue("?adi", u.adi);
                        cmd.Parameters.AddWithValue("?birimfiyat", u.birimfiyat);
                        kaydedildi = cmd.ExecuteNonQuery() > 0;
                    }
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
                return kaydedildi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                return false;
            }
        }
        public static bool Guncelle(urun u)
        {
            try
            {
                bool kaydedildi = false;
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }
                    using (MySqlCommand cmd = new MySqlCommand("update urun set adi=?adi,birimfiyat=?birimfiyat where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", u.id);
                        cmd.Parameters.AddWithValue("?adi", u.adi);
                        cmd.Parameters.AddWithValue("?birimfiyat", u.birimfiyat);
                        kaydedildi = cmd.ExecuteNonQuery() > 0;
                    }
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
                return kaydedildi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                return false;
            }
        }
        public static bool Sil(urun u)
        {
            try
            {
                bool silindi = false;
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }

                    using (MySqlCommand cmd = new MySqlCommand("delete from urun where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", u.id);
                        silindi = cmd.ExecuteNonQuery() > 0;
                    }

                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
                return silindi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                return false;
            }
        }

        // urun tablosundaki bilgileri çeken metodumuz. Geriye List<urun> generic dönmektedir.
        public static List<urun> BilgileriGetir()
        {
            // urun tablomu List<urun> tipinde generic ediyoruz.
            List<urun> urunler = new List<urun>();
            try
            {
                // urun tablomuza baðlantý saðlayabilmek için gerekli connection nesnesimizi tanýmlýyoruz.
                // connection nesnemize baðlantý adresini genel class içerisindeki static olarak belirlediðimiz ConnectionStringName isimli propertiesden alýyoruz.
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    // baðlantý durumumuza göre kapalý ise açmasý için gerekli kontrolümüzü yapýyoruz.
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            // baðlantý açma metodumuzu çalýþtýrýyoruz.
                            cnn.Open();
                            break;

                    }

                    // urun tablomuza gerekli sorgu komutlarýný göndereceðimiz ilgili command nesmenizi tanýmlýyoruz
                    // command nesnemizin görevini yerine getirebilmesi için sorgu ve connection nesnemize ihtiyacý var
                    using (MySqlCommand cmd = new MySqlCommand("select * from urun", cnn))
                    {
                        // sorgumuzan dönecek olan deðerlerimizi alabilmek için dataReader nesnemizi tanýmlýyoruz
                        // dataReader nesnemizin içerisine command nesnemiz içerisindeki ExecuteReader metodumuz aracýlýðý ile bilgileri getiriyoruz.
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            // dataReader nesmeniz içerisindeki bilgileri okuyabilmek için Read() metodunu kullanýyoruz.
                            // Read() metodu okunacak veri olduðu sürece true deðer döner ve bittiðinde false olur bu þekilde while döngüsünden çýkýþ yapar.
                            while (dr.Read())
                            {
                                // urunler generic deðiþkenimizi dataReader dan gelen bilgiler ile dolduruyoruz.
                                // dataReader nesnemizin içeirsinde hazýr metotlar bulunmaktadýr bunlar sayesinde convert etmeden tipine göre bilgileri alabilmekteyiz.
                                // bunuda kullanabilmemiz için gelen satýr içerisindeki hangi kolonun hangi tipde olduðunu bilmemiz gerekiyor
                                urunler.Add(new urun(dr.GetInt32(0), dr.GetString(1), dr.GetFloat(2)));
                            }
                        }
                    }

                    // artýk açýk olan baðlantýmýzý kapatma iþlemimizi gerçektriyioruz.
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            // baðlantý kapat metoduzumu çalýþtýrýyoruz.
                            cnn.Close();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            return urunler;
        }
    }
} 
