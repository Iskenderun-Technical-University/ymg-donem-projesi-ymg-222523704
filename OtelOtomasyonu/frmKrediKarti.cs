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
    public partial class frmKrediKarti : Form
    {
        public string Tutar { get; set; }

        public frmKrediKarti()
        {
            InitializeComponent();
        }

        private void frmKrediKarti_Load(object sender, EventArgs e)
        {
            lblTutar.Text = Tutar;
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (kartNoMasked.TextLength >= 15
                & !string.IsNullOrWhiteSpace(kartSahibiTextBox.Text)
                & cvcMasked.TextLength >= 3
                & sonKullanimTarihiMasked.TextLength >= 4)
            {
                this.DialogResult = MessageBox.Show("Ödeme işleminiz başarılı bir şekilde gerçekleştirildi", "Bilgi");
            }
        }
    }
}
