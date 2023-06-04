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
    public partial class frmNormalOdeme : Form
    {
        public string Tutar { get; set; }

        public frmNormalOdeme()
        {
            InitializeComponent();
        }

        private void frmNormalOdeme_Load(object sender, EventArgs e)
        {
            lblTutar.Text = Tutar;
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
