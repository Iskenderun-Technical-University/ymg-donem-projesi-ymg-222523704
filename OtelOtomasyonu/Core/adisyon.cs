using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class adisyon : IDisposable
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
        private int m_kullaniciid;
        public int kullaniciid
        {
            get { return m_kullaniciid; }
            set { m_kullaniciid = value; }
        }
        private int m_subeid;
        public int subeid
        {
            get { return m_subeid; }
            set { m_subeid = value; }
        }
        private int m_rezervasyonid;
        public int rezervasyonid
        {
            get { return m_rezervasyonid; }
            set { m_rezervasyonid = value; }
        }
        private string m_urunadi;
        public string urunadi
        {
            get { return m_urunadi; }
            set { m_urunadi = value; }
        }
        private float m_birimfiyat;
        public float birimfiyat
        {
            get { return m_birimfiyat; }
            set { m_birimfiyat = value; }
        }
        private Int16 m_adet;
        public Int16 adet
        {
            get { return m_adet; }
            set { m_adet = value; }
        }
        #endregion

        public adisyon()
        {
        }

        /// <summary>
        /// adisyon Nesnesi Olu�tur
        /// </summary>
        public adisyon(int pid, int pkullaniciid, int psubeid, int prezervasyonid, string purunadi, float pbirimfiyat, Int16 padet)
        {
            this.m_id = pid;
            this.m_kullaniciid = pkullaniciid;
            this.m_subeid = psubeid;
            this.m_rezervasyonid = prezervasyonid;
            this.m_urunadi = purunadi;
            this.m_birimfiyat = pbirimfiyat;
            this.m_adet = padet;
        }

        // adisyon tablosuna ekleme g�ncelleme ve silme i�lemlerimizi yapt�raca��m�z haz�r static methodlar tan�ml�yoruz.
        public static bool Ekle(adisyon a)
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
                    using (MySqlCommand cmd = new MySqlCommand("insert into adisyon (kullaniciid,subeid,rezervasyonid,urunadi,birimfiyat,adet) values(?kullaniciid,?subeid,?rezervasyonid,?urunadi,?birimfiyat,?adet)", cnn))
                    {
                        cmd.Parameters.AddWithValue("?kullaniciid", a.kullaniciid);
                        cmd.Parameters.AddWithValue("?subeid", a.subeid);
                        cmd.Parameters.AddWithValue("?rezervasyonid", a.rezervasyonid);
                        cmd.Parameters.AddWithValue("?urunadi", a.urunadi);
                        cmd.Parameters.AddWithValue("?birimfiyat", a.birimfiyat);
                        cmd.Parameters.AddWithValue("?adet", a.adet);
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

        public static bool Guncelle(adisyon a)
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
                    using (MySqlCommand cmd = new MySqlCommand("update adisyon set kullaniciid=?kullaniciid,subeid=?subeid,rezervasyonid=?rezervasyonid,urunadi=?urunadi,birimfiyat=?birimfiyat,adet=?adet where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", a.id);
                        cmd.Parameters.AddWithValue("?kullaniciid", a.kullaniciid);
                        cmd.Parameters.AddWithValue("?subeid", a.subeid);
                        cmd.Parameters.AddWithValue("?rezervasyonid", a.rezervasyonid);
                        cmd.Parameters.AddWithValue("?urunadi", a.urunadi);
                        cmd.Parameters.AddWithValue("?birimfiyat", a.birimfiyat);
                        cmd.Parameters.AddWithValue("?adet", a.adet);
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
        public static bool Sil(adisyon a)
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
                    using (MySqlCommand cmd = new MySqlCommand("delete from adisyon where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", a.id);
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

        // adisyon tablosundaki bilgileri �eken metodumuz. Geriye List<adisyon> generic d�nmektedir.
        public static List<adisyon> BilgileriGetir(int rezervasyonid)
        {
            // adisyon tablomu List<adisyon> tipinde generic ediyoruz.
            List<adisyon> adisyonler = new List<adisyon>();
            try
            {
                // adisyon tablomuza ba�lant� sa�layabilmek i�in gerekli connection nesnesimizi tan�ml�yoruz.
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
                    // adisyon tablomuza gerekli sorgu komutlar�n� g�nderece�imiz ilgili command nesmenizi tan�ml�yoruz
                    // command nesnemizin g�revini yerine getirebilmesi i�in sorgu ve connection nesnemize ihtiyac� var
                    using (MySqlCommand cmd = new MySqlCommand("select * from adisyon where rezervasyonid=?rezervasyonid", cnn))
                    {
                        cmd.Parameters.AddWithValue("?rezervasyonid", rezervasyonid);
                        // sorgumuzan d�necek olan de�erlerimizi alabilmek i�in dataReader nesnemizi tan�ml�yoruz
                        // dataReader nesnemizin i�erisine command nesnemiz i�erisindeki ExecuteReader metodumuz arac�l��� ile bilgileri getiriyoruz.
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            // dataReader nesmeniz i�erisindeki bilgileri okuyabilmek i�in Read() metodunu kullan�yoruz.
                            // Read() metodu okunacak veri oldu�u s�rece true de�er d�ner ve bitti�inde false olur bu �ekilde while d�ng�s�nden ��k�� yapar.
                            while (dr.Read())
                            {
                                // adisyonler generic de�i�kenimizi dataReader dan gelen bilgiler ile dolduruyoruz.
                                // dataReader nesnemizin i�eirsinde haz�r metotlar bulunmaktad�r bunlar sayesinde convert etmeden tipine g�re bilgileri alabilmekteyiz.
                                // bunuda kullanabilmemiz i�in gelen sat�r i�erisindeki hangi kolonun hangi tipde oldu�unu bilmemiz gerekiyor
                                adisyonler.Add(new adisyon(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetString(4), dr.GetFloat(5), dr.GetInt16(6)));
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
            return adisyonler;
        }
        public static double Tutar(int rezervasyonid)
        {
            try
            {
                double tutar = 0.0f;
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }
                    using (MySqlCommand cmd = new MySqlCommand("select FORMAT(SUM((a.birimfiyat*a.adet)),2) AS total from adisyon a where rezervasyonid=?rezervasyonid", cnn))
                    {
                        cmd.Parameters.AddWithValue("?rezervasyonid", rezervasyonid);
                        tutar = Convert.ToDouble(cmd.ExecuteScalar());
                    }
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
                return tutar;
            }
            catch (Exception ex)
            {
                return 0.0f;
            }
        }
    }
}
