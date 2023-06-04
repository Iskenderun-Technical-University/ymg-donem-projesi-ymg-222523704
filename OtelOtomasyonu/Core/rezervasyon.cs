using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelOtomasyonu
{
    public partial class rezervasyon : IDisposable
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
        private int m_musteriid;
        public int musteriid
        {
            get { return m_musteriid; }
            set { m_musteriid = value; }
        }
        private int m_odaid;
        public int odaid
        {
            get { return m_odaid; }
            set { m_odaid = value; }
        }
        private Int16 m_odano;
        public Int16 odano
        {
            get { return m_odano; }
            set { m_odano = value; }
        }
        private DateTime m_rezervasyontarihi;
        public DateTime rezervasyontarihi
        {
            get { return m_rezervasyontarihi; }
            set { m_rezervasyontarihi = value; }
        }
        private DateTime m_giristarihi;
        public DateTime giristarihi
        {
            get { return m_giristarihi; }
            set { m_giristarihi = value; }
        }
        private DateTime m_cikistarihi;
        public DateTime cikistarihi
        {
            get { return m_cikistarihi; }
            set { m_cikistarihi = value; }
        }
        private Int16 m_gun;
        public Int16 gun
        {
            get { return m_gun; }
            set { m_gun = value; }
        }
        private Int16 m_yetiskinsayi;
        public Int16 yetiskinsayi
        {
            get { return m_yetiskinsayi; }
            set { m_yetiskinsayi = value; }
        }
        private Int16 m_cocuksayi;
        public Int16 cocuksayi
        {
            get { return m_cocuksayi; }
            set { m_cocuksayi = value; }
        }
        private Int16 m_bebeksayi;
        public Int16 bebeksayi
        {
            get { return m_bebeksayi; }
            set { m_bebeksayi = value; }
        }
        private float m_birimfiyat;
        public float birimfiyat
        {
            get { return m_birimfiyat; }
            set { m_birimfiyat = value; }
        }
        private byte m_durum;
        public byte durum
        {
            get { return m_durum; }
            set { m_durum = value; }
        }

        public rezervasyon()
        {
        }

        /// <summary>
        /// rezervasyon Nesnesi Oluþtur
        /// </summary>
        public rezervasyon(int pid, int pkullaniciid, int psubeid, int pmusteriid, int podaid, Int16 podano, DateTime prezervasyontarihi, DateTime pgiristarihi, DateTime pcikistarihi, Int16 pgun, Int16 pyetiskinsayi, Int16 pcocuksayi, Int16 pbebeksayi, float pbirimfiyat, byte pdurum)
        {
            this.m_id = pid;
            this.m_kullaniciid = pkullaniciid;
            this.m_subeid = psubeid;
            this.m_musteriid = pmusteriid;
            this.m_odaid = podaid;
            this.m_odano = podano;
            this.m_rezervasyontarihi = prezervasyontarihi;
            this.m_giristarihi = pgiristarihi;
            this.m_cikistarihi = pcikistarihi;
            this.m_gun = pgun;
            this.m_yetiskinsayi = pyetiskinsayi;
            this.m_cocuksayi = pcocuksayi;
            this.m_bebeksayi = pbebeksayi;
            this.m_birimfiyat = pbirimfiyat;
            this.m_durum = pdurum;
        }

        // rezervasyon tablosuna ekleme güncelleme ve silme iþlemlerimizi yaptýracaðýmýz hazýr static methodlar tanýmlýyoruz.
        public static bool Ekle(rezervasyon p)
        {
            try
            {
                bool kaydedildi = false;
                using (MySqlConnection cnn = new MySqlConnection(genel.ConnectionStringName))
                {
                    switch (cnn.State)
                    {
                        case System.Data.ConnectionState.Closed:
                            cnn.Open();
                            break;
                    }
                    using (MySqlCommand cmd = new MySqlCommand("insert into rezervasyon (kullaniciid,subeid,musteriid,odaid,odano,rezervasyontarihi,giristarihi,cikistarihi,gun,yetiskinsayi,cocuksayi,bebeksayi,birimfiyat,durum) values(?kullaniciid,?subeid,?musteriid,?odaid,?odano,?rezervasyontarihi,?giristarihi,?cikistarihi,?gun,?yetiskinsayi,?cocuksayi,?bebeksayi,?birimfiyat,?durum)", cnn))
                    {
                        cmd.Parameters.AddWithValue("kullaniciid", p.kullaniciid);
                        cmd.Parameters.AddWithValue("subeid", p.subeid);
                        cmd.Parameters.AddWithValue("musteriid", p.musteriid);
                        cmd.Parameters.AddWithValue("odaid", p.odaid);
                        cmd.Parameters.AddWithValue("odano", p.odano);
                        cmd.Parameters.AddWithValue("rezervasyontarihi", p.rezervasyontarihi);
                        cmd.Parameters.AddWithValue("giristarihi", p.giristarihi);
                        cmd.Parameters.AddWithValue("cikistarihi", p.cikistarihi);
                        cmd.Parameters.AddWithValue("gun", p.gun);
                        cmd.Parameters.AddWithValue("yetiskinsayi", p.yetiskinsayi);
                        cmd.Parameters.AddWithValue("cocuksayi", p.cocuksayi);
                        cmd.Parameters.AddWithValue("bebeksayi", p.bebeksayi);
                        cmd.Parameters.AddWithValue("birimfiyat", p.birimfiyat);
                        cmd.Parameters.AddWithValue("durum", p.durum);
                        kaydedildi = cmd.ExecuteNonQuery() > 0;
                    }
                    switch (cnn.State)
                    {
                        case System.Data.ConnectionState.Open:
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
        public static bool Guncelle(rezervasyon p)
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
                    using (MySqlCommand cmd = new MySqlCommand("update rezervasyon set kullaniciid=?kullaniciid,subeid=?subeid,musteriid=?musteriid,odaid=?odaid,odano=?odano,rezervasyontarihi=?rezervasyontarihi,giristarihi=?giristarihi,cikistarihi=?cikistarihi,gun=?gun,yetiskinsayi=?yetiskinsayi,cocuksayi=?cocuksayi,bebeksayi=?bebeksayi,birimfiyat=?birimfiyat,durum=?durum where id=?id", cnn))
                    {
                        cmd.Parameters.AddWithValue("id", p.id);
                        cmd.Parameters.AddWithValue("kullaniciid", p.kullaniciid);
                        cmd.Parameters.AddWithValue("subeid", p.subeid);
                        cmd.Parameters.AddWithValue("musteriid", p.musteriid);
                        cmd.Parameters.AddWithValue("odaid", p.odaid);
                        cmd.Parameters.AddWithValue("odano", p.odano);
                        cmd.Parameters.AddWithValue("rezervasyontarihi", p.rezervasyontarihi);
                        cmd.Parameters.AddWithValue("giristarihi", p.giristarihi);
                        cmd.Parameters.AddWithValue("cikistarihi", p.cikistarihi);
                        cmd.Parameters.AddWithValue("gun", p.gun);
                        cmd.Parameters.AddWithValue("yetiskinsayi", p.yetiskinsayi);
                        cmd.Parameters.AddWithValue("cocuksayi", p.cocuksayi);
                        cmd.Parameters.AddWithValue("bebeksayi", p.bebeksayi);
                        cmd.Parameters.AddWithValue("birimfiyat", p.birimfiyat);
                        cmd.Parameters.AddWithValue("durum", p.durum);
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
        public static bool Sil(rezervasyon k)
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
                    using (MySqlCommand cmd = new MySqlCommand("delete from rezervasyon where id=?id", cnn))
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

        // rezervasyon tablosundaki bilgileri çeken metodumuz
        public static rezervasyon Getir(int id)
        {
            rezervasyon rezervasyonlar = new rezervasyon();
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
                    using (MySqlCommand cmd = new MySqlCommand("select * from rezervasyon where id=?id limit 1", cnn))
                    {
                        cmd.Parameters.AddWithValue("?id", id);
                        using (MySqlDataReader IDR = cmd.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            while (IDR.Read())
                            {
                                rezervasyonlar = new rezervasyon(Convert.ToInt32(IDR["id"]), Convert.ToInt32(IDR["kullaniciid"]), Convert.ToInt32(IDR["subeid"]), Convert.ToInt32(IDR["musteriid"]), Convert.ToInt32(IDR["odaid"]), Convert.ToInt16(IDR["odano"]), Convert.ToDateTime(IDR["rezervasyontarihi"]), Convert.ToDateTime(IDR["giristarihi"]), Convert.ToDateTime(IDR["cikistarihi"]), Convert.ToInt16(IDR["gun"]), Convert.ToInt16(IDR["yetiskinsayi"]), Convert.ToInt16(IDR["cocuksayi"]), Convert.ToInt16(IDR["bebeksayi"]), Convert.ToSingle(IDR["birimfiyat"]), Convert.ToByte(IDR["durum"]));
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
            return rezervasyonlar;
        }
        public static List<rezervasyon> BilgileriGetir()
        {
            List<rezervasyon> rezervasyonlar = new List<rezervasyon>();
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
                    using (MySqlCommand cmd = new MySqlCommand("select * from rezervasyon where subeid=?subeid", cnn))
                    {
                        cmd.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                        using (MySqlDataReader IDR = cmd.ExecuteReader(CommandBehavior.Default))
                        {
                            while (IDR.Read())
                            {
                                rezervasyonlar.Add(new rezervasyon(Convert.ToInt32(IDR["id"]), Convert.ToInt32(IDR["kullaniciid"]), Convert.ToInt32(IDR["subeid"]), Convert.ToInt32(IDR["musteriid"]), Convert.ToInt32(IDR["odaid"]), Convert.ToInt16(IDR["odano"]), Convert.ToDateTime(IDR["rezervasyontarihi"]), Convert.ToDateTime(IDR["giristarihi"]), Convert.ToDateTime(IDR["cikistarihi"]), Convert.ToInt16(IDR["gun"]), Convert.ToInt16(IDR["yetiskinsayi"]), Convert.ToInt16(IDR["cocuksayi"]), Convert.ToInt16(IDR["bebeksayi"]), Convert.ToSingle(IDR["birimfiyat"]), Convert.ToByte(IDR["durum"])));
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
            return rezervasyonlar;
        }
    }
}
