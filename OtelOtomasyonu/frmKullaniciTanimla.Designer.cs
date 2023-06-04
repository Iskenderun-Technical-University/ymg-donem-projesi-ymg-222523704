namespace OtelOtomasyonu
{
    partial class frmKullaniciTanimla
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
            System.Windows.Forms.Label subeidLabel;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label sifreLabel;
            System.Windows.Forms.Label adiLabel;
            System.Windows.Forms.Label soyadiLabel;
            System.Windows.Forms.Label yoneticiLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciTanimla));
            this.subeidComboBox = new System.Windows.Forms.ComboBox();
            this.subeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.soyadiTextBox = new System.Windows.Forms.TextBox();
            this.yoneticiCheckBox = new System.Windows.Forms.CheckBox();
            this.kullaniciDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnSubeEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            subeidLabel = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            sifreLabel = new System.Windows.Forms.Label();
            adiLabel = new System.Windows.Forms.Label();
            soyadiLabel = new System.Windows.Forms.Label();
            yoneticiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // subeidLabel
            // 
            subeidLabel.AutoSize = true;
            subeidLabel.Location = new System.Drawing.Point(15, 71);
            subeidLabel.Name = "subeidLabel";
            subeidLabel.Size = new System.Drawing.Size(48, 13);
            subeidLabel.TabIndex = 13;
            subeidLabel.Text = "subeid:";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Location = new System.Drawing.Point(15, 98);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(32, 13);
            kodLabel.TabIndex = 15;
            kodLabel.Text = "kod:";
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.Location = new System.Drawing.Point(15, 124);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new System.Drawing.Size(35, 13);
            sifreLabel.TabIndex = 17;
            sifreLabel.Text = "sifre:";
            // 
            // adiLabel
            // 
            adiLabel.AutoSize = true;
            adiLabel.Location = new System.Drawing.Point(266, 71);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new System.Drawing.Size(28, 13);
            adiLabel.TabIndex = 19;
            adiLabel.Text = "adi:";
            // 
            // soyadiLabel
            // 
            soyadiLabel.AutoSize = true;
            soyadiLabel.Location = new System.Drawing.Point(266, 97);
            soyadiLabel.Name = "soyadiLabel";
            soyadiLabel.Size = new System.Drawing.Size(47, 13);
            soyadiLabel.TabIndex = 21;
            soyadiLabel.Text = "soyadi:";
            // 
            // yoneticiLabel
            // 
            yoneticiLabel.AutoSize = true;
            yoneticiLabel.Location = new System.Drawing.Point(266, 125);
            yoneticiLabel.Name = "yoneticiLabel";
            yoneticiLabel.Size = new System.Drawing.Size(55, 13);
            yoneticiLabel.TabIndex = 23;
            yoneticiLabel.Text = "yonetici:";
            // 
            // subeidComboBox
            // 
            this.subeidComboBox.DataSource = this.subeBindingSource;
            this.subeidComboBox.DisplayMember = "adi";
            this.subeidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subeidComboBox.FormattingEnabled = true;
            this.subeidComboBox.Location = new System.Drawing.Point(76, 68);
            this.subeidComboBox.Name = "subeidComboBox";
            this.subeidComboBox.Size = new System.Drawing.Size(145, 21);
            this.subeidComboBox.TabIndex = 0;
            this.subeidComboBox.ValueMember = "id";
            // 
            // subeBindingSource
            // 
            this.subeBindingSource.DataSource = typeof(OtelOtomasyonu.sube);
            // 
            // kodTextBox
            // 
            this.kodTextBox.Location = new System.Drawing.Point(76, 95);
            this.kodTextBox.MaxLength = 50;
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(175, 20);
            this.kodTextBox.TabIndex = 1;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(76, 121);
            this.sifreTextBox.MaxLength = 50;
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(175, 20);
            this.sifreTextBox.TabIndex = 2;
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(344, 68);
            this.adiTextBox.MaxLength = 50;
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(244, 20);
            this.adiTextBox.TabIndex = 3;
            // 
            // soyadiTextBox
            // 
            this.soyadiTextBox.Location = new System.Drawing.Point(344, 94);
            this.soyadiTextBox.MaxLength = 50;
            this.soyadiTextBox.Name = "soyadiTextBox";
            this.soyadiTextBox.Size = new System.Drawing.Size(244, 20);
            this.soyadiTextBox.TabIndex = 4;
            // 
            // yoneticiCheckBox
            // 
            this.yoneticiCheckBox.Checked = true;
            this.yoneticiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yoneticiCheckBox.Location = new System.Drawing.Point(344, 120);
            this.yoneticiCheckBox.Name = "yoneticiCheckBox";
            this.yoneticiCheckBox.Size = new System.Drawing.Size(244, 24);
            this.yoneticiCheckBox.TabIndex = 5;
            this.yoneticiCheckBox.UseVisualStyleBackColor = true;
            // 
            // kullaniciDataGridView
            // 
            this.kullaniciDataGridView.AllowUserToAddRows = false;
            this.kullaniciDataGridView.AllowUserToDeleteRows = false;
            this.kullaniciDataGridView.AutoGenerateColumns = false;
            this.kullaniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subeidDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.yoneticiDataGridViewCheckBoxColumn});
            this.kullaniciDataGridView.DataSource = this.kullaniciBindingSource;
            this.kullaniciDataGridView.Location = new System.Drawing.Point(14, 179);
            this.kullaniciDataGridView.Name = "kullaniciDataGridView";
            this.kullaniciDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullaniciDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kullaniciDataGridView.Size = new System.Drawing.Size(574, 373);
            this.kullaniciDataGridView.TabIndex = 8;
            this.kullaniciDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullaniciDataGridView_CellDoubleClick);
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
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
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
            // yoneticiDataGridViewCheckBoxColumn
            // 
            this.yoneticiDataGridViewCheckBoxColumn.DataPropertyName = "yonetici";
            this.yoneticiDataGridViewCheckBoxColumn.HeaderText = "yonetici";
            this.yoneticiDataGridViewCheckBoxColumn.Name = "yoneticiDataGridViewCheckBoxColumn";
            this.yoneticiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataSource = typeof(OtelOtomasyonu.kullanici);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(545, 150);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 23);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.Location = new System.Drawing.Point(452, 150);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(87, 23);
            this.btnKayit.TabIndex = 26;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnSubeEkle
            // 
            this.btnSubeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubeEkle.ForeColor = System.Drawing.Color.White;
            this.btnSubeEkle.Location = new System.Drawing.Point(226, 68);
            this.btnSubeEkle.Name = "btnSubeEkle";
            this.btnSubeEkle.Size = new System.Drawing.Size(25, 21);
            this.btnSubeEkle.TabIndex = 26;
            this.btnSubeEkle.Text = "+";
            this.btnSubeEkle.UseVisualStyleBackColor = true;
            this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(359, 150);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pbMiniLogo
            // 
          //  this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini-logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(512, 12);
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
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "Personel Kayıt İşlemleri";
            // 
            // frmKullaniciTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(600, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMiniLogo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSubeEkle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.kullaniciDataGridView);
            this.Controls.Add(subeidLabel);
            this.Controls.Add(this.subeidComboBox);
            this.Controls.Add(kodLabel);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(sifreLabel);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(adiLabel);
            this.Controls.Add(this.adiTextBox);
            this.Controls.Add(soyadiLabel);
            this.Controls.Add(this.soyadiTextBox);
            this.Controls.Add(yoneticiLabel);
            this.Controls.Add(this.yoneticiCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKullaniciTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Tanımla";
            this.Load += new System.EventHandler(this.frmKullaniciTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subeidComboBox;
        private System.Windows.Forms.TextBox kodTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.TextBox soyadiTextBox;
        private System.Windows.Forms.CheckBox yoneticiCheckBox;
        private System.Windows.Forms.DataGridView kullaniciDataGridView;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.BindingSource subeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn yoneticiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.Label label1;
    }
}