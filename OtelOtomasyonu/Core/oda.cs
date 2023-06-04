using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class oda : IDisposable
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
		private int m_kisisayi;
		public int kisisayi
		{
			get { return m_kisisayi; }
			set { m_kisisayi = value; }
		}
		private float m_gunfiyat;
		public float gunfiyat
		{
			get { return m_gunfiyat; }
			set { m_gunfiyat = value; }
		}

		public oda()
		{
		}

		/// <summary>
		/// oda Nesnesi Oluþtur
		/// </summary>
		public oda(int pid, string padi, int pkisisayi, float pgunfiyat)
		{
			this.m_id = pid;
			this.m_adi = padi;
			this.m_kisisayi = pkisisayi;
			this.m_gunfiyat = pgunfiyat;
        }

        // oda tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(oda s)
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

                    using (MySqlCommand cmd = new MySqlCommand("insert into oda(adi,kisisayi,gunfiyat) values(?adi,?kisisayi,?gunfiyat)", cnn))
                    {
                        cmd.Parameters.AddWithValue("?adi", s.adi);
                        cmd.Parameters.AddWithValue("?kisisayi", s.kisisayi);
                        cmd.Parameters.AddWithValue("?gunfiyat", s.gunfiyat);
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
        public static bool Guncelle(oda s)
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

                    using (MySqlCommand cmd = new MySqlCommand("update oda set adi=?adi,kisisayi=?kisisayi,gunfiyat=?gunfiyat where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", s.id);
                        cmd.Parameters.AddWithValue("?adi", s.adi);
                        cmd.Parameters.AddWithValue("?kisisayi", s.kisisayi);
                        cmd.Parameters.AddWithValue("?gunfiyat", s.gunfiyat);
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
        public static bool Sil(oda s)
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

                    using (MySqlCommand cmd = new MySqlCommand("delete from oda where id=?id", cnn))
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

        // oda tablosundaki bilgileri çeken metodumuz
        public static List<oda> BilgileriGetir()
        {
            List<oda> odalar = new List<oda>();
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

                    using (MySqlCommand cmd = new MySqlCommand("select * from oda", cnn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            while (dr.Read())
                            {
                                //oda odaItem = new oda();
                                //odaItem.id = dr.GetInt32(0);
                                //odaItem.adi = dr.GetString(1);
                                //odaItem.m_kisisayi = dr.GetInt32(2);
                                //odaItem.gunfiyat = dr.GetFloat(3);
                                //odalar.Add(odaItem);

                                odalar.Add(new oda(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetFloat(3)));
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
            return odalar;
        }
    }
} 
