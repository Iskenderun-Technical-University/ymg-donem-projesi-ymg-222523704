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

        #region ---Properties/Field - Özellikler Alanlar---
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
        /// adisyon Nesnesi Oluþtur
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

        // adisyon tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(adisyon a)
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

        // adisyon tablosundaki bilgileri çeken metodumuz. Geriye List<adisyon> generic dönmektedir.
        public static List<adisyon> BilgileriGetir(int rezervasyonid)
        {
            // adisyon tablomu List<adisyon> tipinde generic ediyoruz.
            List<adisyon> adisyonler = new List<adisyon>();
            try
            {
                // adisyon tablomuza baðlantý saðlayabilmek için gerekli connection nesnesimizi tanýmlýyoruz.
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
                    // adisyon tablomuza gerekli sorgu komutlarýný göndereceðimiz ilgili command nesmenizi tanýmlýyoruz
                    // command nesnemizin görevini yerine getirebilmesi için sorgu ve connection nesnemize ihtiyacý var
                    using (MySqlCommand cmd = new MySqlCommand("select * from adisyon where rezervasyonid=?rezervasyonid", cnn))
                    {
                        cmd.Parameters.AddWithValue("?rezervasyonid", rezervasyonid);
                        // sorgumuzan dönecek olan deðerlerimizi alabilmek için dataReader nesnemizi tanýmlýyoruz
                        // dataReader nesnemizin içerisine command nesnemiz içerisindeki ExecuteReader metodumuz aracýlýðý ile bilgileri getiriyoruz.
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            // dataReader nesmeniz içerisindeki bilgileri okuyabilmek için Read() metodunu kullanýyoruz.
                            // Read() metodu okunacak veri olduðu sürece true deðer döner ve bittiðinde false olur bu þekilde while döngüsünden çýkýþ yapar.
                            while (dr.Read())
                            {
                                // adisyonler generic deðiþkenimizi dataReader dan gelen bilgiler ile dolduruyoruz.
                                // dataReader nesnemizin içeirsinde hazýr metotlar bulunmaktadýr bunlar sayesinde convert etmeden tipine göre bilgileri alabilmekteyiz.
                                // bunuda kullanabilmemiz için gelen satýr içerisindeki hangi kolonun hangi tipde olduðunu bilmemiz gerekiyor
                                adisyonler.Add(new adisyon(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetString(4), dr.GetFloat(5), dr.GetInt16(6)));
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
