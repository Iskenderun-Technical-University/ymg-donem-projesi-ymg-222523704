using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class kullanici : IDisposable
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
        private string m_kod;
        public string kod
        {
            get { return m_kod; }
            set { m_kod = value; }
        }
        private string m_sifre;
        public string sifre
        {
            get { return m_sifre; }
            set { m_sifre = value; }
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
        private bool m_yonetici;
        public bool yonetici
        {
            get { return m_yonetici; }
            set { m_yonetici = value; }
        }

        public kullanici()
        {
        }

        /// <summary>
        /// kullanici Nesnesi Oluþtur
        /// </summary>
        public kullanici(int pid, int psubeid, string pkod, string psifre, string padi, string psoyadi, bool pyonetici)
        {
            this.m_id = pid;
            this.m_subeid = psubeid;
            this.m_kod = pkod;
            this.m_sifre = psifre;
            this.m_adi = padi;
            this.m_soyadi = psoyadi;
            this.m_yonetici = pyonetici;
        }

        // kullanýcý tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(kullanici k)
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

                    using (MySqlCommand cmd = new MySqlCommand("insert into kullanici(subeid,kod,sifre,adi,soyadi,yonetici) values(?subeid,?kod,?sifre,?adi,?soyadi,?yonetici)", cnn))
                    {
                        cmd.Parameters.AddWithValue("?subeid", k.subeid);
                        cmd.Parameters.AddWithValue("?kod", k.kod);
                        cmd.Parameters.AddWithValue("?sifre", k.sifre);
                        cmd.Parameters.AddWithValue("?adi", k.adi);
                        cmd.Parameters.AddWithValue("?soyadi", k.soyadi);
                        cmd.Parameters.AddWithValue("?yonetici", k.yonetici);
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
        public static bool Guncelle(kullanici k)
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

                    using (MySqlCommand cmd = new MySqlCommand("update kullanici set subeid=?subeid,kod=?kod,sifre=?sifre,adi=?adi,soyadi=?soyadi,yonetici=?yonetici where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", k.id);
                        cmd.Parameters.AddWithValue("?subeid", k.subeid);
                        cmd.Parameters.AddWithValue("?kod", k.kod);
                        cmd.Parameters.AddWithValue("?sifre", k.sifre);
                        cmd.Parameters.AddWithValue("?adi", k.adi);
                        cmd.Parameters.AddWithValue("?soyadi", k.soyadi);
                        cmd.Parameters.AddWithValue("?yonetici", k.yonetici);
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
        public static bool Sil(kullanici k)
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

                    using (MySqlCommand cmd = new MySqlCommand("delete from kullanici where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", k.id);
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

        // kullanýcý tablosundaki bilgileri çeken metodumuz
        public static List<kullanici> BilgileriGetir()
        {
            List<kullanici> kullanicilar = new List<kullanici>();
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

                    using (MySqlCommand cmd = new MySqlCommand("select * from kullanici", cnn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            while (dr.Read())
                            {
                                kullanicilar.Add(new kullanici(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetBoolean(6)));
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
            return kullanicilar;
        }
    }
}
