using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmMusteriler : Form
    {
        public string AramaKriteri { get; set; }

        public musteri MusteriBilgi { get; set; }

        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            try
            {
            tekrar:
                musteriBindingSource.DataSource = musteri.BilgileriGetir(AramaKriteri);

                if (musteriDataGridView.RowCount <= 0)
                {
                    if (MessageBox.Show("Aradığınız kriterlerde kayıt bulunamadı yeni kayıt oluşturmak istermisiniz.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmMusteriTanimla frm = new frmMusteriTanimla();
                        frm.ShowDialog();
                        goto tekrar;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void musteriDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriBilgi = musteriDataGridView.CurrentRow.DataBoundItem as musteri;
            DialogResult = DialogResult.OK;
        }
    }
}
