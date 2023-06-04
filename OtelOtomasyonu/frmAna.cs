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
    public partial class frmAna : Form
    {
        // yönetici ise bileşenleri aktif etsin değilse pasif etsin diye bir bool tipinden değişken tanımlıyoruz.
        // yönetici olup olmadığını genel sınıfı içerisinde kullanıcı nesnemiz ile tanımladığımız personel isimli değişkenimizin özelliğinden alıyoruz.
        bool erisimIzni = genel.Personel.yonetici;

        private bool FormAcik(Form form)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    form.Dispose();
                    return true;
                }
            }
            return false;
        }

        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            #region --- Yetkili Kontrolü ---
            gbYonetimPaneli.Enabled = erisimIzni;
            #endregion

            // Form bilgi ekranına giriş yapan personel bilgisi ve ekran adını gösteriyoruz
            this.Text = "Menü Ekranı - Şube: " + genel.SubeAdi + " | " + (genel.Personel.yonetici ? "Yönetici" : "Personel") + ": " + genel.Personel.adi + " " + genel.Personel.soyadi;
        }

        private void frmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region --- Eğer Uygulamayı Sonlandırmak İstersek Bu Kodu Çalıştırmalıyız ---
            // Uygulamamızı sonlandırmak için exit metodundan yararlanıyoruz.
            // bu kodu çalıştırmamızdaki amaç giriş ekranını hide yaptığımız için uygulamamız tam anlamı ile sonlanmayacaktır
            // exit metodu sayesinde uygulamamızın yaşam döngüsü tamamı ile sona erecektir.
            // Application.Exit(); 
            #endregion

            // Uygulamayı sonlandırmadan giriş formuna dönüş yapacağım için Açık olan Ana Menü formumu kapatıyorum.
            this.Close();

            // daha önce giriş yapmış personel bilgisini sıfırlıyoruz..
            genel.Personel = null;

            // application nesnesi içerisinde bana açık olan formları veren OpenForms özelliğini kullanıyorum
            // gizlediğim giriş forumumu OpenForms özelliğine Form.Name vererek tekrar Show() metodu ile gösteriyorum
            Application.OpenForms["frmGiris"].Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            // show ilede açtırabiliriz fakat showdialog kullanmamızdaki sebeb ise diğer formlara müdahale edilememesidir ve show dialog bize durum bilgisi verir
            #region --- Neden ShowDialog Kullanmalıyız Örnek ---
            // örnek olarak aşağıdaki kod parçadığında da göreceğiniz gibi form üzerinden bize dialog result durumunu dönderir.
            //switch (frm.ShowDialog())
            //{
            //    case DialogResult.Abort:
            //        break;
            //    case DialogResult.Cancel:
            //        break;
            //    case DialogResult.Ignore:
            //        break;
            //    case DialogResult.No:
            //        break;
            //    case DialogResult.None:
            //        break;
            //    case DialogResult.OK:
            //        break;
            //    case DialogResult.Retry:
            //        break;
            //    case DialogResult.Yes:
            //        break;
            //} 
            #endregion
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnMusteriTanimla_Click(object sender, EventArgs e)
        {
            frmMusteriTanimla frm = new frmMusteriTanimla();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnKullaniciTanimla_Click(object sender, EventArgs e)
        {
            frmKullaniciTanimla frm = new frmKullaniciTanimla();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnSubeTanimla_Click(object sender, EventArgs e)
        {
            frmSubeTanimla frm = new frmSubeTanimla();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnOdaTanimla_Click(object sender, EventArgs e)
        {
            frmOdaTanimla frm = new frmOdaTanimla();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnUrunTanimla_Click(object sender, EventArgs e)
        {
            frmUrunTanimla frm = new frmUrunTanimla();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frm = new frmCheckIn();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut frm = new frmCheckOut();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar frm = new frmOdalar();
            if (!FormAcik(frm))
                frm.Show();
        }

        private void btnFolyo_Click(object sender, EventArgs e)
        {
            frmOdalar frm = new frmOdalar();
            frm.Folyo = true;
            if (!FormAcik(frm))
                frm.Show();
        }

        private void tumButonlar_MouseHover(object sender, EventArgs e)
        {
            // Mouse, Buton üzerine geldiğinde mouse imleçinde EL görünmesi için gerekli ayarlar..
            ((Control)sender).Cursor = Cursors.Hand;
            // Mouse, Buton üzerine geldiğinde arkaplan rengi değiştirmek için gerekli ayarlar..
            ((Control)sender).BackColor = Color.FromArgb(255, 128, 0);
        }

        private void tumButonlar_MouseLeave(object sender, EventArgs e)
        {
            // Mouse, Buton üzerinden çekildiğinde arkaplan rengini tekrar eski haline getiriyoruz
            ((Control)sender).BackColor = Color.FromArgb(4, 16, 37);
        }
    }
}
