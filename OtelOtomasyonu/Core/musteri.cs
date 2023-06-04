using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelOtomasyonu
{
    public partial class musteri : IDisposable
    {
        #region ---IDisposable Members---
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        private int m_id;
        public int id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private int m_subeid;
        public int subeid
        {
            get { return m_subeid; }
            set { m_subeid = value; }
        }
        private int m_kullaniciid;
        public int kullaniciid
        {
            get { return m_kullaniciid; }
            set { m_kullaniciid = value; }
        }
        private string m_kimlikno;
        public string kimlikno
        {
            get { return m_kimlikno; }
            set { m_kimlikno = value; }
        }
        private string m_adi;
        public string adi
        {
            get { return m_adi; }
            set { m_adi = value; }
        }
        private string m_soyadi;
        public string soyadi
        {
            get { return m_soyadi; }
            set { m_soyadi = value; }
        }
        private string m_ulke;
        public string ulke
        {
            get { return m_ulke; }
            set { m_ulke = value; }
        }
        private string m_telefon;
        public string telefon
        {
            get { return m_telefon; }
            set { m_telefon = value; }
        }
        private string m_adres;
        public string adres
        {
            get { return m_adres; }
            set { m_adres = value; }
        }
        private bool m_aktif;
        public bool aktif
        {
            get { return m_aktif; }
            set { m_aktif = value; }
        }

        public musteri()
        {
        }

        /// <summary>
        /// musteri Nesnesi Oluþtur
        /// </summary>
        public musteri(int pid, int psubeid, int pkullaniciid, string pkimlikno, string padi, string psoyadi, string pulke, string ptelefon, string padres, bool paktif)
        {
            this.m_id = pid;
            this.m_subeid = psubeid;
            this.m_kullaniciid = pkullaniciid;
            this.m_kimlikno = pkimlikno;
            this.m_adi = padi;
            this.m_soyadi = psoyadi;
            this.m_ulke = pulke;
            this.m_telefon = ptelefon;
            this.m_adres = padres;
            this.m_aktif = paktif;
        }

        // musteri tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(musteri m)
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

                    using (MySqlCommand cmd = new MySqlCommand("insert into musteri(subeid,kullaniciid,kimlikno,adi,soyadi,ulke,telefon,adres,aktif) values(?subeid,?kullaniciid,?kimlikno,?adi,?soyadi,?ulke,?telefon,?adres,?aktif)", cnn))
                    {
                        cmd.Parameters.AddWithValue("?subeid", m.subeid);
                        cmd.Parameters.AddWithValue("?kullaniciid", m.kullaniciid);
                        cmd.Parameters.AddWithValue("?kimlikno", m.kimlikno);
                        cmd.Parameters.AddWithValue("?adi", m.adi);
                        cmd.Parameters.AddWithValue("?soyadi", m.soyadi);
                        cmd.Parameters.AddWithValue("?ulke", m.ulke);
                        cmd.Parameters.AddWithValue("?telefon", m.telefon);
                        cmd.Parameters.AddWithValue("?adres", m.adres);
                        cmd.Parameters.AddWithValue("?aktif", m.aktif);
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
        public static bool Guncelle(musteri m)
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

                    using (MySqlCommand cmd = new MySqlCommand("update musteri set subeid=?subeid,kullaniciid=?kullaniciid,kimlikno=?kimlikno,adi=?adi,soyadi=?soyadi,ulke=?ulke,telefon=?telefon,adres=?adres,aktif=?aktif where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", m.id);
                        cmd.Parameters.AddWithValue("?subeid", m.subeid);
                        cmd.Parameters.AddWithValue("?kullaniciid", m.kullaniciid);
                        cmd.Parameters.AddWithValue("?kimlikno", m.kimlikno);
                        cmd.Parameters.AddWithValue("?adi", m.adi);
                        cmd.Parameters.AddWithValue("?soyadi", m.soyadi);
                        cmd.Parameters.AddWithValue("?ulke", m.ulke);
                        cmd.Parameters.AddWithValue("?telefon", m.telefon);
                        cmd.Parameters.AddWithValue("?adres", m.adres);
                        cmd.Parameters.AddWithValue("?aktif", m.aktif);
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
        public static bool Sil(musteri m)
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

                    using (MySqlCommand cmd = new MySqlCommand("delete from musteri where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", m.id);
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

        // musteri tablosundaki bilgileri çeken metodumuz
        public static musteri Getir(int id)
        {
            musteri m = new musteri();
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }
                    using (MySqlCommand cmd = new MySqlCommand("select * from musteri where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", id);
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            while (dr.Read())
                            {
                                m = new musteri(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetBoolean(9));
                            }
                        }
                    }
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            return m;
        }
        public static List<musteri> BilgileriGetir()
        {
            List<musteri> musteriler = new List<musteri>();
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }
                    using (MySqlCommand cmd = new MySqlCommand("select * from musteri where subeid=?subeid", cnn))
                    {
                        cmd.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            while (dr.Read())
                            {
                                musteriler.Add(new musteri(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetBoolean(9)));
                            }
                        }
                    }
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            return musteriler;
        }
        public static List<musteri> BilgileriGetir(string aramaKriteri)
        {
            List<musteri> musteriler = new List<musteri>();
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case ConnectionState.Closed:
                            cnn.Open();
                            break;

                    }
                    using (MySqlCommand cmd = new MySqlCommand("select * from musteri where subeid=?subeid and kimlikno like ?kimlikno or subeid=?subeid and adi like ?adi or subeid=?subeid and soyadi like ?soyadi", cnn))
                    {
                        cmd.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                        cmd.Parameters.AddWithValue("?kimlikno", aramaKriteri.Replace("*", "%"));
                        cmd.Parameters.AddWithValue("?adi", aramaKriteri.Replace("*", "%"));
                        cmd.Parameters.AddWithValue("?soyadi", aramaKriteri.Replace("*", "%"));
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            while (dr.Read())
                            {
                                musteriler.Add(new musteri(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetBoolean(9)));
                            }
                        }
                    }
                    switch (cnn.State)
                    {
                        case ConnectionState.Open:
                            cnn.Close();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            return musteriler;
        }
    }
}
