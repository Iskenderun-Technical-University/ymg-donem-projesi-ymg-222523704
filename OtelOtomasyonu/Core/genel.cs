using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace OtelOtomasyonu
{
    public static class genel
    {
        // veritabanına bağlantı kurmamızı sağlayan cümle
        public static string ConnectionStringName
        {
            get { return "Server=localhost;Port=3306;Database=oteldb;charset=utf8;Uid=root;Pwd=;"; }
        }

        public static Int16 OdaSayisi { get { return 51; } }

        // giriş yaptığımız şube bilgisini taşıyacağımız string değişkenimiz
        public static string SubeAdi { get; set; }

        // kullanıcı tablosundan gelecek olan bilgileri tutacak objemizi tanımladık
        public static kullanici Personel { get; set; }

        public static DataTable RezervasyonDurumlari()
        {
            DataTable dt = new DataTable("RezervasyonDurumlari");
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Adi", typeof(string));

            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "<Seçiniz>";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Oda Dolu";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "Rezerve";
            dt.Rows.Add(dr);

            return dt;
        }

        public static void Temizle(Control c)
        {
            foreach (Control item in c.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = string.Empty;
                else if (item is CheckBox)
                    (item as CheckBox).Checked = false;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is NumericUpDown)
                {
                    NumericUpDown n = item as NumericUpDown;
                    n.Value = n.Minimum;
                }
            }
        }
    }
}
