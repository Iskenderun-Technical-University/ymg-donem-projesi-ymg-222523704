using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class sube : IDisposable
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
        private string m_adi;
        public string adi
        {
            get { return m_adi; }
            set { m_adi = value; }
        }
        private bool m_aktif;
        public bool aktif
        {
            get { return m_aktif; }
            set { m_aktif = value; }
        }

        public sube()
        {
        }

        /// <summary>
        /// sube Nesnesi Oluþtur
        /// </summary>
        public sube(int pid, string padi, bool paktif)
        {
            this.m_id = pid;
            this.m_adi = padi;
            this.m_aktif = paktif;
        }

        // sube tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(sube s)
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

                    using (MySqlCommand cmd = new MySqlCommand("insert into sube(adi,aktif) values(?adi,?aktif)", cnn))
                    {
                        cmd.Parameters.AddWithValue("?adi", s.adi);
                        cmd.Parameters.AddWithValue("?aktif", s.aktif);
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
        public static bool Guncelle(sube s)
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

                    using (MySqlCommand cmd = new MySqlCommand("update sube set adi=?adi,aktif=?aktif where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", s.id);
                        cmd.Parameters.AddWithValue("?adi", s.adi);
                        cmd.Parameters.AddWithValue("?aktif", s.aktif);
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
        public static bool Sil(sube s)
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

                    using (MySqlCommand cmd = new MySqlCommand("delete from sube where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", s.id);
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

        // sube tablosundaki bilgileri çeken metodumuz. Geriye List<sube> generic dönmektedir.
        public static List<sube> BilgileriGetir()
        {
            // þube tablomu List<sube> tipinde generic ediyoruz.
            List<sube> subeler = new List<sube>();
            try
            {
                // þube tablomuza baðlantý saðlayabilmek için gerekli connection nesnesimizi tanýmlýyoruz.
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

                    // þube tablomuza gerekli sorgu komutlarýný göndereceðimiz ilgili command nesmenizi tanýmlýyoruz
                    // command nesnemizin görevini yerine getirebilmesi için sorgu ve connection nesnemize ihtiyacý var
                    using (MySqlCommand cmd = new MySqlCommand("select * from sube", cnn))
                    {
                        // sorgumuzan dönecek olan deðerlerimizi alabilmek için dataReader nesnemizi tanýmlýyoruz
                        // dataReader nesnemizin içerisine command nesnemiz içerisindeki ExecuteReader metodumuz aracýlýðý ile bilgileri getiriyoruz.
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            // dataReader nesmeniz içerisindeki bilgileri okuyabilmek için Read() metodunu kullanýyoruz.
                            // Read() metodu okunacak veri olduðu sürece true deðer döner ve bittiðinde false olur bu þekilde while döngüsünden çýkýþ yapar.
                            while (dr.Read())
                            {
                                // subeler generic deðiþkenimizi dataReader dan gelen bilgiler ile dolduruyoruz.
                                // dataReader nesnemizin içeirsinde hazýr metotlar bulunmaktadýr bunlar sayesinde convert etmeden tipine göre bilgileri alabilmekteyiz.
                                // bunuda kullanabilmemiz için gelen satýr içerisindeki hangi kolonun hangi tipde olduðunu bilmemiz gerekiyor
                                subeler.Add(new sube(dr.GetInt32(0), dr.GetString(1), dr.GetBoolean(2)));
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
            return subeler;
        }

        public static DataTable TabloOlarakGetir()
        {
            // sube tablomuzdaki datalarý aktaracaðýmýz nesnemiz
            DataTable dt = new DataTable("sube");
            try
            {
                // sube tablosundaki bilgileri çekmek için adapter nesnemizi oluþturuyoruz.
                using (MySqlDataAdapter dap = new MySqlDataAdapter("select * from sube", genel.ConnectionStringName))
                {
                    // datatable içerisine sube tablosundaki bilgileri dolduruyoruz.
                    dap.Fill(dt);

                    // þube bilgileri seçtiðimiz ekranda varsayýlan olarak seçiniz tanýmlamasý ekleyeceðiz.
                    DataRow dr = dt.NewRow();
                    dr["id"] = 0;
                    dr["adi"] = "<Seçiniz>";
                    dt.Rows.InsertAt(dr, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            return dt;
        }
    }
}
