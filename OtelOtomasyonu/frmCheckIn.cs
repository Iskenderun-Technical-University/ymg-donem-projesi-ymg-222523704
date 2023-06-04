using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelOtomasyonu
{
    public partial class frmCheckIn : Form
    {
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void rezervasyonlariGetir()
        {
            try
            {
                DataTable dtRezervasyon = new DataTable("rezervasyon");
                using (MySqlDataAdapter dap = new MySqlDataAdapter("select r.id as rezerveno,r.odano,m.kimlikno,m.adi,m.soyadi,m.telefon,m.ulke,r.yetiskinsayi,r.cocuksayi,r.bebeksayi,FORMAT(r.birimfiyat,2) as fiyat,FORMAT((r.birimfiyat * r.gun),2) as toplamfiyat,r.rezervasyontarihi,r.giristarihi,r.cikistarihi from rezervasyon r inner join musteri m on r.musteriid=m.id where r.durum=3 and r.subeid=?subeid and r.giristarihi between ?ilkTarih and ?sonTarih", genel.ConnectionStringName))
                {
                    dap.SelectCommand.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                    dap.SelectCommand.Parameters.AddWithValue("?ilkTarih", ilkTarih.Value.AddDays(-1));
                    dap.SelectCommand.Parameters.AddWithValue("?sonTarih", sonTarih.Value.AddDays(1));
                    dap.Fill(dtRezervasyon);
                }
                rezervasyonDataGridView.DataSource = dtRezervasyon;
            }
            catch (Exception)
            {
            }
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            ilkTarih.Value = ilkTarih.Value.AddDays(-30);
            sonTarih.Value = sonTarih.Value.AddDays(30);
            rezervasyonlariGetir();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            rezervasyonlariGetir();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (rezervasyonDataGridView.CurrentRow != null)
            {
                rezervasyon r = rezervasyon.Getir(Convert.ToInt32(rezervasyonDataGridView.CurrentRow.Cells["rezerveno"].Value));
                r.durum = 2;
                if (rezervasyon.Guncelle(r))
                    rezervasyonlariGetir();
            }
        }
    }
}
