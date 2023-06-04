namespace OtelOtomasyonu
{
    partial class frmAdisyon
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
            System.Windows.Forms.Label urunadiLabel;
            System.Windows.Forms.Label birimfiyatLabel;
            System.Windows.Forms.Label adetLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdisyon));
            this.lblEkstra = new System.Windows.Forms.Label();
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.urunadiComboBox = new System.Windows.Forms.ComboBox();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.adisyonDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adisyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimfiyatMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            urunadiLabel = new System.Windows.Forms.Label();
            birimfiyatLabel = new System.Windows.Forms.Label();
            adetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adisyonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adisyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // urunadiLabel
            // 
            urunadiLabel.AutoSize = true;
            urunadiLabel.Location = new System.Drawing.Point(16, 71);
            urunadiLabel.Name = "urunadiLabel";
            urunadiLabel.Size = new System.Drawing.Size(45, 13);
            urunadiLabel.TabIndex = 48;
            urunadiLabel.Text = "urunadi:";
            // 
            // birimfiyatLabel
            // 
            birimfiyatLabel.AutoSize = true;
            birimfiyatLabel.Location = new System.Drawing.Point(16, 98);
            birimfiyatLabel.Name = "birimfiyatLabel";
            birimfiyatLabel.Size = new System.Drawing.Size(50, 13);
            birimfiyatLabel.TabIndex = 50;
            birimfiyatLabel.Text = "birimfiyat:";
            // 
            // adetLabel
            // 
            adetLabel.AutoSize = true;
            adetLabel.Location = new System.Drawing.Point(16, 121);
            adetLabel.Name = "adetLabel";
            adetLabel.Size = new System.Drawing.Size(31, 13);
            adetLabel.TabIndex = 52;
            adetLabel.Text = "adet:";
            // 
            // lblEkstra
            // 
            this.lblEkstra.AutoSize = true;
            this.lblEkstra.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkstra.Location = new System.Drawing.Point(8, 12);
            this.lblEkstra.Name = "lblEkstra";
            this.lblEkstra.Size = new System.Drawing.Size(139, 37);
            this.lblEkstra.TabIndex = 0;
            this.lblEkstra.Text = "Ekstralar";
            // 
            // pbMiniLogo
            // 
           // this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini-logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(346, 12);
            this.pbMiniLogo.Name = "pbMiniLogo";
            this.pbMiniLogo.Size = new System.Drawing.Size(76, 50);
            this.pbMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMiniLogo.TabIndex = 47;
            this.pbMiniLogo.TabStop = false;
            // 
            // urunadiComboBox
            // 
            this.urunadiComboBox.DataSource = this.urunBindingSource;
            this.urunadiComboBox.DisplayMember = "adi";
            this.urunadiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunadiComboBox.FormattingEnabled = true;
            this.urunadiComboBox.Location = new System.Drawing.Point(96, 68);
            this.urunadiComboBox.Name = "urunadiComboBox";
            this.urunadiComboBox.Size = new System.Drawing.Size(326, 21);
            this.urunadiComboBox.TabIndex = 49;
            this.urunadiComboBox.ValueMember = "adi";
            this.urunadiComboBox.SelectedValueChanged += new System.EventHandler(this.urunadiComboBox_SelectedValueChanged);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(OtelOtomasyonu.urun);
            // 
            // adetNumericUpDown
            // 
            this.adetNumericUpDown.Location = new System.Drawing.Point(96, 121);
            this.adetNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adetNumericUpDown.Name = "adetNumericUpDown";
            this.adetNumericUpDown.Size = new System.Drawing.Size(326, 20);
            this.adetNumericUpDown.TabIndex = 53;
            this.adetNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(193, 147);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 61;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(380, 147);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 23);
            this.btnSil.TabIndex = 60;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(286, 147);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(87, 23);
            this.btnKayit.TabIndex = 59;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // adisyonDataGridView
            // 
            this.adisyonDataGridView.AllowUserToAddRows = false;
            this.adisyonDataGridView.AllowUserToDeleteRows = false;
            this.adisyonDataGridView.AutoGenerateColumns = false;
            this.adisyonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adisyonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kullaniciidDataGridViewTextBoxColumn,
            this.subeidDataGridViewTextBoxColumn,
            this.rezervasyonidDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.birimfiyatDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn});
            this.adisyonDataGridView.DataSource = this.adisyonBindingSource;
            this.adisyonDataGridView.Location = new System.Drawing.Point(15, 176);
            this.adisyonDataGridView.Name = "adisyonDataGridView";
            this.adisyonDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adisyonDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adisyonDataGridView.Size = new System.Drawing.Size(407, 276);
            this.adisyonDataGridView.TabIndex = 62;
            this.adisyonDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adisyonDataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // kullaniciidDataGridViewTextBoxColumn
            // 
            this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "kullaniciid";
            this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "kullaniciid";
            this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
            this.kullaniciidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciidDataGridViewTextBoxColumn.Visible = false;
            // 
            // subeidDataGridViewTextBoxColumn
            // 
            this.subeidDataGridViewTextBoxColumn.DataPropertyName = "subeid";
            this.subeidDataGridViewTextBoxColumn.HeaderText = "subeid";
            this.subeidDataGridViewTextBoxColumn.Name = "subeidDataGridViewTextBoxColumn";
            this.subeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervasyonidDataGridViewTextBoxColumn
            // 
            this.rezervasyonidDataGridViewTextBoxColumn.DataPropertyName = "rezervasyonid";
            this.rezervasyonidDataGridViewTextBoxColumn.HeaderText = "rezervasyonid";
            this.rezervasyonidDataGridViewTextBoxColumn.Name = "rezervasyonidDataGridViewTextBoxColumn";
            this.rezervasyonidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervasyonidDataGridViewTextBoxColumn.Visible = false;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birimfiyatDataGridViewTextBoxColumn
            // 
            this.birimfiyatDataGridViewTextBoxColumn.DataPropertyName = "birimfiyat";
            this.birimfiyatDataGridViewTextBoxColumn.HeaderText = "birimfiyat";
            this.birimfiyatDataGridViewTextBoxColumn.Name = "birimfiyatDataGridViewTextBoxColumn";
            this.birimfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adisyonBindingSource
            // 
            this.adisyonBindingSource.DataSource = typeof(OtelOtomasyonu.adisyon);
            // 
            // birimfiyatMaskedTextBox
            // 
            this.birimfiyatMaskedTextBox.Enabled = false;
            this.birimfiyatMaskedTextBox.Location = new System.Drawing.Point(96, 95);
            this.birimfiyatMaskedTextBox.Mask = "000.00";
            this.birimfiyatMaskedTextBox.Name = "birimfiyatMaskedTextBox";
            this.birimfiyatMaskedTextBox.Size = new System.Drawing.Size(326, 20);
            this.birimfiyatMaskedTextBox.TabIndex = 63;
            // 
            // frmAdisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(434, 464);
            this.Controls.Add(this.birimfiyatMaskedTextBox);
            this.Controls.Add(this.adisyonDataGridView);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(adetLabel);
            this.Controls.Add(this.adetNumericUpDown);
            this.Controls.Add(urunadiLabel);
            this.Controls.Add(this.urunadiComboBox);
            this.Controls.Add(birimfiyatLabel);
            this.Controls.Add(this.pbMiniLogo);
            this.Controls.Add(this.lblEkstra);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdisyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adisyon Ekranı";
            this.Load += new System.EventHandler(this.frmAdisyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adisyonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adisyonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEkstra;
        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.ComboBox urunadiComboBox;
        private System.Windows.Forms.NumericUpDown adetNumericUpDown;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView adisyonDataGridView;
        private System.Windows.Forms.MaskedTextBox birimfiyatMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adisyonBindingSource;
        private System.Windows.Forms.BindingSource urunBindingSource;
    }
}