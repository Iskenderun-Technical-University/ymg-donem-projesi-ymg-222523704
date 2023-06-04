namespace OtelOtomasyonu
{
    partial class frmMusteriTanimla
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
            System.Windows.Forms.Label kimliknoLabel;
            System.Windows.Forms.Label adiLabel;
            System.Windows.Forms.Label soyadiLabel;
            System.Windows.Forms.Label ulkeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label aktifLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriTanimla));
            this.kimliknoTextBox = new System.Windows.Forms.TextBox();
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.soyadiTextBox = new System.Windows.Forms.TextBox();
            this.telefonMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ulkeComboBox = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            kimliknoLabel = new System.Windows.Forms.Label();
            adiLabel = new System.Windows.Forms.Label();
            soyadiLabel = new System.Windows.Forms.Label();
            ulkeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kimliknoLabel
            // 
            kimliknoLabel.AutoSize = true;
            kimliknoLabel.Location = new System.Drawing.Point(16, 71);
            kimliknoLabel.Name = "kimliknoLabel";
            kimliknoLabel.Size = new System.Drawing.Size(57, 13);
            kimliknoLabel.TabIndex = 15;
            kimliknoLabel.Text = "kimlikno:";
            // 
            // adiLabel
            // 
            adiLabel.AutoSize = true;
            adiLabel.Location = new System.Drawing.Point(16, 97);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new System.Drawing.Size(28, 13);
            adiLabel.TabIndex = 17;
            adiLabel.Text = "adi:";
            // 
            // soyadiLabel
            // 
            soyadiLabel.AutoSize = true;
            soyadiLabel.Location = new System.Drawing.Point(16, 123);
            soyadiLabel.Name = "soyadiLabel";
            soyadiLabel.Size = new System.Drawing.Size(47, 13);
            soyadiLabel.TabIndex = 19;
            soyadiLabel.Text = "soyadi:";
            // 
            // ulkeLabel
            // 
            ulkeLabel.AutoSize = true;
            ulkeLabel.Location = new System.Drawing.Point(419, 71);
            ulkeLabel.Name = "ulkeLabel";
            ulkeLabel.Size = new System.Drawing.Size(35, 13);
            ulkeLabel.TabIndex = 21;
            ulkeLabel.Text = "ulke:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(419, 97);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(50, 13);
            telefonLabel.TabIndex = 23;
            telefonLabel.Text = "telefon:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(419, 123);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(42, 13);
            adresLabel.TabIndex = 25;
            adresLabel.Text = "adres:";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(16, 151);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(36, 13);
            aktifLabel.TabIndex = 27;
            aktifLabel.Text = "aktif:";
            // 
            // kimliknoTextBox
            // 
            this.kimliknoTextBox.Location = new System.Drawing.Point(101, 68);
            this.kimliknoTextBox.MaxLength = 11;
            this.kimliknoTextBox.Name = "kimliknoTextBox";
            this.kimliknoTextBox.Size = new System.Drawing.Size(265, 20);
            this.kimliknoTextBox.TabIndex = 0;
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(101, 94);
            this.adiTextBox.MaxLength = 50;
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(265, 20);
            this.adiTextBox.TabIndex = 1;
            // 
            // soyadiTextBox
            // 
            this.soyadiTextBox.Location = new System.Drawing.Point(101, 120);
            this.soyadiTextBox.MaxLength = 50;
            this.soyadiTextBox.Name = "soyadiTextBox";
            this.soyadiTextBox.Size = new System.Drawing.Size(265, 20);
            this.soyadiTextBox.TabIndex = 2;
            // 
            // telefonMaskedTextBox
            // 
            this.telefonMaskedTextBox.Location = new System.Drawing.Point(490, 94);
            this.telefonMaskedTextBox.Mask = "(999) 000-0000";
            this.telefonMaskedTextBox.Name = "telefonMaskedTextBox";
            this.telefonMaskedTextBox.Size = new System.Drawing.Size(322, 20);
            this.telefonMaskedTextBox.TabIndex = 4;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(490, 120);
            this.adresTextBox.MaxLength = 50;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(322, 20);
            this.adresTextBox.TabIndex = 5;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.Checked = true;
            this.aktifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktifCheckBox.Location = new System.Drawing.Point(101, 146);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(265, 24);
            this.aktifCheckBox.TabIndex = 8;
            this.aktifCheckBox.UseVisualStyleBackColor = true;
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
            this.musteriDataGridView.Location = new System.Drawing.Point(16, 175);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musteriDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.musteriDataGridView.Size = new System.Drawing.Size(796, 271);
            this.musteriDataGridView.TabIndex = 11;
            this.musteriDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(770, 146);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 23);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(676, 146);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(87, 23);
            this.btnKayit.TabIndex = 30;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(583, 146);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pbMiniLogo
            // 
           // this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini_logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(736, 12);
            this.pbMiniLogo.Name = "pbMiniLogo";
            this.pbMiniLogo.Size = new System.Drawing.Size(76, 50);
            this.pbMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMiniLogo.TabIndex = 47;
            this.pbMiniLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 49;
            this.label1.Text = "Müşteri Kayıt İşlemleri";
            // 
            // ulkeComboBox
            // 
            this.ulkeComboBox.FormattingEnabled = true;
            this.ulkeComboBox.Items.AddRange(new object[] {
            "Türkiye",
            "Azerbeycan",
            "Almanya",
            "Amerika",
            "Arabistan",
            "Hollanda",
            "Rusya",
            "İtalya",
            "Fıransa"});
            this.ulkeComboBox.Location = new System.Drawing.Point(490, 67);
            this.ulkeComboBox.MaxLength = 50;
            this.ulkeComboBox.Name = "ulkeComboBox";
            this.ulkeComboBox.Size = new System.Drawing.Size(322, 21);
            this.ulkeComboBox.TabIndex = 50;
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
            this.subeidDataGridViewTextBoxColumn.DataSource = this.subeBindingSource;
            this.subeidDataGridViewTextBoxColumn.DisplayMember = "adi";
            this.subeidDataGridViewTextBoxColumn.HeaderText = "subeid";
            this.subeidDataGridViewTextBoxColumn.Name = "subeidDataGridViewTextBoxColumn";
            this.subeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subeidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // subeBindingSource
            // 
            this.subeBindingSource.DataSource = typeof(OtelOtomasyonu.sube);
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
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataSource = typeof(OtelOtomasyonu.musteri);
            // 
            // frmMusteriTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(836, 460);
            this.Controls.Add(this.ulkeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMiniLogo);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(kimliknoLabel);
            this.Controls.Add(this.kimliknoTextBox);
            this.Controls.Add(adiLabel);
            this.Controls.Add(this.adiTextBox);
            this.Controls.Add(soyadiLabel);
            this.Controls.Add(this.soyadiTextBox);
            this.Controls.Add(ulkeLabel);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonMaskedTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(aktifLabel);
            this.Controls.Add(this.aktifCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 494);
            this.MinimumSize = new System.Drawing.Size(844, 494);
            this.Name = "frmMusteriTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Tanımla";
            this.Load += new System.EventHandler(this.frmMusteriTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kimliknoTextBox;
        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.TextBox soyadiTextBox;
        private System.Windows.Forms.MaskedTextBox telefonMaskedTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.BindingSource subeBindingSource;
        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ulkeComboBox;
    }
}