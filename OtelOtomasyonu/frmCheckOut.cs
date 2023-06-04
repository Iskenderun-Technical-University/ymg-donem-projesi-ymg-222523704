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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void rezervasyonlariGetir()
        {
            try
            {
                DataSet ds = new DataSet("rezerve_to_urunler");

                using (MySqlDataAdapter dap = new MySqlDataAdapter("select r.id as rezerveno,r.odano,m.kimlikno,m.adi,m.soyadi,m.telefon,m.ulke,r.yetiskinsayi,r.cocuksayi,r.bebeksayi,FORMAT(r.birimfiyat,2) as fiyat,FORMAT((r.birimfiyat * r.gun),2) as toplamfiyat,r.rezervasyontarihi,r.giristarihi,r.cikistarihi from rezervasyon r inner join musteri m on r.musteriid=m.id where r.durum=2 and r.subeid=?subeid and r.cikistarihi between ?ilkTarih and ?sonTarih", genel.ConnectionStringName))
                {
                    dap.SelectCommand.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                    dap.SelectCommand.Parameters.AddWithValue("?ilkTarih", ilkTarih.Value.AddDays(-1));
                    dap.SelectCommand.Parameters.AddWithValue("?sonTarih", sonTarih.Value.AddDays(1));
                    dap.Fill(ds, "rezervasyon");
                }

                using (MySqlDataAdapter dap = new MySqlDataAdapter("select a.rezervasyonid as rezerveno, a.urunadi,FORMAT(a.birimfiyat,2) as fiyat,a.adet,FORMAT((a.birimfiyat*a.adet),2) as tutar from adisyon a inner join rezervasyon r on r.id=a.rezervasyonid where r.durum=2 and r.subeid=?subeid and r.cikistarihi between ?ilkTarih and ?sonTarih", genel.ConnectionStringName))
                {
                    dap.SelectCommand.Parameters.AddWithValue("?subeid", genel.Personel.subeid);
                    dap.SelectCommand.Parameters.AddWithValue("?ilkTarih", ilkTarih.Value.AddDays(-1));
                    dap.SelectCommand.Parameters.AddWithValue("?sonTarih", sonTarih.Value.AddDays(1));
                    dap.Fill(ds, "adisyon");
                }

                //assign relation to dataset 
                ds.Relations.Add("Adisyon_Detaylari", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0], false);

                rezervasyonDataGrid.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
            }
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
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
            if (rezervasyonDataGrid.CurrentRowIndex >= 0)
            {
                rezervasyon r = rezervasyon.Getir(Convert.ToInt32(rezervasyonDataGrid[rezervasyonDataGrid.CurrentRowIndex, 0]));
                if (r.id > 0)
                {
                    if (MessageBox.Show("Ödemenizi kredi kartı ile yapmak istiyormusnuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmKrediKarti krediKarti = new frmKrediKarti();
                        krediKarti.Tutar = ((r.gun * r.birimfiyat) + adisyon.Tutar(r.id)).ToString("##0.#0");
                        switch (krediKarti.ShowDialog())
                        {
                            case DialogResult.Yes:
                            case DialogResult.OK:
                                r.durum = 1;
                                if (rezervasyon.Guncelle(r))
                                    rezervasyonlariGetir();
                                break;
                            default:
                                MessageBox.Show("Hesabınızdan para çekilemedi", "Uyarı");
                                break;
                        }
                    }
                    else
                    {
                        frmNormalOdeme normal = new frmNormalOdeme();
                        normal.Tutar = ((r.gun * r.birimfiyat) + adisyon.Tutar(r.id)).ToString("##0.#0");
                        switch (normal.ShowDialog())
                        {
                            case DialogResult.Yes:
                            case DialogResult.OK:
                                r.durum = 1;
                                if (rezervasyon.Guncelle(r))
                                    rezervasyonlariGetir();
                                break;
                            default:
                                MessageBox.Show("Hesabınızdan para çekilemedi", "Uyarı");
                                break;
                        }
                    }
                }
            }
        }

        private void rezervasyonDataGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (rezervasyonDataGrid.CurrentRowIndex >= 0)
                {
                    frmAdisyon frm = new frmAdisyon();
                    frm.RezervasyonNo = Convert.ToInt32(rezervasyonDataGrid[rezervasyonDataGrid.CurrentRowIndex, 0]);
                    frm.OdaNo = Convert.ToInt32(rezervasyonDataGrid[rezervasyonDataGrid.CurrentRowIndex, 1]);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
