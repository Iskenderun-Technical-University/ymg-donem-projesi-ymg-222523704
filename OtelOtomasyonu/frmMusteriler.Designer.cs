namespace OtelOtomasyonu
{
    partial class frmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.AllowUserToAddRows = false;
            this.musteriDataGridView.AllowUserToDeleteRows = false;
            this.musteriDataGridView.AutoGenerateColumns = false;
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subeidDataGridViewTextBoxColumn,
            this.kullaniciidDataGridViewTextBoxColumn,
            this.kimliknoDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.ulkeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn});
            this.musteriDataGridView.DataSource = this.musteriBindingSource;
            this.musteriDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriDataGridView.Location = new System.Drawing.Point(0, 0);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musteriDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.musteriDataGridView.Size = new System.Drawing.Size(643, 425);
            this.musteriDataGridView.TabIndex = 12;
            this.musteriDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellDoubleClick);
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataSource = typeof(OtelOtomasyonu.musteri);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // subeidDataGridViewTextBoxColumn
            // 
            this.subeidDataGridViewTextBoxColumn.DataPropertyName = "subeid";
            this.subeidDataGridViewTextBoxColumn.HeaderText = "subeid";
            this.subeidDataGridViewTextBoxColumn.Name = "subeidDataGridViewTextBoxColumn";
            this.subeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kullaniciidDataGridViewTextBoxColumn
            // 
            this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "kullaniciid";
            this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "kullaniciid";
            this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
            this.kullaniciidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kimliknoDataGridViewTextBoxColumn
            // 
            this.kimliknoDataGridViewTextBoxColumn.DataPropertyName = "kimlikno";
            this.kimliknoDataGridViewTextBoxColumn.HeaderText = "kimlikno";
            this.kimliknoDataGridViewTextBoxColumn.Name = "kimliknoDataGridViewTextBoxColumn";
            this.kimliknoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            this.soyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulkeDataGridViewTextBoxColumn
            // 
            this.ulkeDataGridViewTextBoxColumn.DataPropertyName = "ulke";
            this.ulkeDataGridViewTextBoxColumn.HeaderText = "ulke";
            this.ulkeDataGridViewTextBoxColumn.Name = "ulkeDataGridViewTextBoxColumn";
            this.ulkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            this.aktifDataGridViewCheckBoxColumn.DataPropertyName = "aktif";
            this.aktifDataGridViewCheckBoxColumn.HeaderText = "aktif";
            this.aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            this.aktifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 425);
            this.Controls.Add(this.musteriDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource musteriBindingSource;
    }
}