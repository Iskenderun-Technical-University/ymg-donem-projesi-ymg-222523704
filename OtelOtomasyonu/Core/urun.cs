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

		#region ---Properties/Field - �zellikler Alanlar---
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
		/// urun Nesnesi Olu�tur
		/// </summary>
		public urun(int pid, string padi, float pbirimfiyat)
		{
			this.m_id = pid;
			this.m_adi = padi;
			this.m_birimfiyat = pbirimfiyat;
        }

        // urun tablosuna ekleme g�ncelleme ve silme i�lemlerimizi yapt�raca��m�z haz�r static methodlar tan�ml�yoruz.
        public static bool Ekle(urun u)
        {
            try
            {
                // kay�t i�leminin olup olmad���na dair bilgiyi tutacak olan bool tipinden de�i�kenimiz ilk de�er atamas�n� false yapt�m yapmasamda ilk de�eri false olacakt�
                bool kaydedildi = false;
                // kay�t i�lemimi ger�ekle�tirebilmek i�in gerekli ba�lant�y� a�abilmemi sa�layacak olan connection s�n�f� nesnem
                // connection s�n�f� i�erisine ba�lant� kurmam� sa�alayacak olan veritaban� yolu c�mlemi veriyorum
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

        // urun tablosundaki bilgileri �eken metodumuz. Geriye List<urun> generic d�nmektedir.
        public static List<urun> BilgileriGetir()
        {
            // urun tablomu List<urun> tipinde generic ediyoruz.
            List<urun> urunler = new List<urun>();
            try
            {
                // urun tablomuza ba�lant� sa�layabilmek i�in gerekli connection nesnesimizi tan�ml�yoruz.
                // connection nesnemize ba�lant� adresini genel class i�erisindeki static olarak belirledi�imiz ConnectionStringName isimli propertiesden al�yoruz.
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    // ba�lant� durumumuza g�re kapal� ise a�mas� i�in gerekli kontrol�m�z� yap�yoruz.
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            // ba�lant� a�ma metodumuzu �al��t�r�yoruz.
                            cnn.Open();
                            break;

                    }

                    // urun tablomuza gerekli sorgu komutlar�n� g�nderece�imiz ilgili command nesmenizi tan�ml�yoruz
                    // command nesnemizin g�revini yerine getirebilmesi i�in sorgu ve connection nesnemize ihtiyac� var
                    using (MySqlCommand cmd = new MySqlCommand("select * from urun", cnn))
                    {
                        // sorgumuzan d�necek olan de�erlerimizi alabilmek i�in dataReader nesnemizi tan�ml�yoruz
                        // dataReader nesnemizin i�erisine command nesnemiz i�erisindeki ExecuteReader metodumuz arac�l��� ile bilgileri getiriyoruz.
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            // dataReader nesmeniz i�erisindeki bilgileri okuyabilmek i�in Read() metodunu kullan�yoruz.
                            // Read() metodu okunacak veri oldu�u s�rece true de�er d�ner ve bitti�inde false olur bu �ekilde while d�ng�s�nden ��k�� yapar.
                            while (dr.Read())
                            {
                                // urunler generic de�i�kenimizi dataReader dan gelen bilgiler ile dolduruyoruz.
                                // dataReader nesnemizin i�eirsinde haz�r metotlar bulunmaktad�r bunlar sayesinde convert etmeden tipine g�re bilgileri alabilmekteyiz.
                                // bunuda kullanabilmemiz i�in gelen sat�r i�erisindeki hangi kolonun hangi tipde oldu�unu bilmemiz gerekiyor
                                urunler.Add(new urun(dr.GetInt32(0), dr.GetString(1), dr.GetFloat(2)));
                            }
                        }
                    }

                    // art�k a��k olan ba�lant�m�z� kapatma i�lemimizi ger�ektriyioruz.
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            // ba�lant� kapat metoduzumu �al��t�r�yoruz.
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
