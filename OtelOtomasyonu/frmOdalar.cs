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
    public partial class frmOdalar : Form
    {
        public int OdaNo { get; set; }

        public bool Folyo { get; set; }

        public frmOdalar()
        {
            InitializeComponent();
        }

        private void frmOdalar_Load(object sender, EventArgs e)
        {
            int top = 5, left = 5;
            for (int i = 1; i < genel.OdaSayisi; i++)
            {
                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.Top = top;
                btn.Left = left;
                btn.Width = 60;
                btn.Height = 25;
                btn.Name = "oda_" + i;
                btn.Text = i.ToString("00#");
                btn.Tag = "Boş=0";
                btn.Click += new EventHandler(btn_Click);
                this.Controls.Add(btn);
                left += btn.Width + 5;
                if ((i % 12) == 0)
                {
                    top += 30;
                    left = 5;
                }
            }

            using (DataTable doluOdaNumalari = new DataTable())
            {
                using (MySqlDataAdapter dap = new MySqlDataAdapter("select distinct odano, id as rno from rezervasyon where durum=2 and subeid=" + genel.Personel.subeid, genel.ConnectionStringName))
                {
                    dap.Fill(doluOdaNumalari);
                    foreach (DataRow item in doluOdaNumalari.Rows)
                    {
                        Control[] cnt = this.Controls.Find("oda_" + item[0], false);
                        if (cnt.Length > 0)
                        {
                            Button b = (cnt[0] as Button);
                            b.BackColor = Color.FromArgb(192, 0, 0);
                            b.Tag = "Dolu=" + item["rno"];
                        }
                    }
                }
            }

            using (DataTable rezerveOdaNumalari = new DataTable())
            {
                using (MySqlDataAdapter dap = new MySqlDataAdapter("select distinct odano, id as rno from rezervasyon where durum=3 and subeid=" + genel.Personel.subeid, genel.ConnectionStringName))
                {
                    dap.Fill(rezerveOdaNumalari);
                    foreach (DataRow item in rezerveOdaNumalari.Rows)
                    {
                        Control[] cnt = this.Controls.Find("oda_" + item[0], false);
                        if (cnt.Length > 0)
                        {
                            Button b = (cnt[0] as Button);
                            b.BackColor = Color.FromArgb(255, 128, 0);
                            b.Tag = "Rezerve=" + item["rno"];
                        }
                    }
                }
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            string query = b.Tag.ToString();
            if (!Folyo)
            {
                if (query.StartsWith("Rezerve"))
                {
                    MessageBox.Show("Bu Oda 'Rezerve' olduğu için seçilemez!", "Bilgi");
                    return;
                }
                else if (query.StartsWith("Dolu"))
                {
                    MessageBox.Show("Bu Oda 'Dolu' olduğu için seçilemez!", "Bilgi");
                    return;
                }
                OdaNo = Convert.ToInt32(b.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (query.StartsWith("Dolu"))
                {
                    frmAdisyon frm = new frmAdisyon();
                    frm.RezervasyonNo = Convert.ToInt32(query.Split('=')[1]);
                    frm.OdaNo = Convert.ToInt32(b.Text);
                    frm.ShowDialog();
                }
            }
        }

        private void frmOdalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OdaNo == 0)
                DialogResult = DialogResult.Cancel;
        }
    }
}
