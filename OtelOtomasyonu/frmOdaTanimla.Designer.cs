namespace OtelOtomasyonu
{
    partial class frmOdaTanimla
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
            System.Windows.Forms.Label adiLabel;
            System.Windows.Forms.Label kisisayiLabel;
            System.Windows.Forms.Label gunfiyatLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaTanimla));
            this.odaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisisayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.kisisayiNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gunfiyatMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            adiLabel = new System.Windows.Forms.Label();
            kisisayiLabel = new System.Windows.Forms.Label();
            gunfiyatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisisayiNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // adiLabel
            // 
            adiLabel.AutoSize = true;
            adiLabel.Location = new System.Drawing.Point(16, 69);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new System.Drawing.Size(28, 13);
            adiLabel.TabIndex = 38;
            adiLabel.Text = "adi:";
            // 
            // kisisayiLabel
            // 
            kisisayiLabel.AutoSize = true;
            kisisayiLabel.Location = new System.Drawing.Point(16, 92);
            kisisayiLabel.Name = "kisisayiLabel";
            kisisayiLabel.Size = new System.Drawing.Size(52, 13);
            kisisayiLabel.TabIndex = 40;
            kisisayiLabel.Text = "kisisayi:";
            // 
            // gunfiyatLabel
            // 
            gunfiyatLabel.AutoSize = true;
            gunfiyatLabel.Location = new System.Drawing.Point(16, 121);
            gunfiyatLabel.Name = "gunfiyatLabel";
            gunfiyatLabel.Size = new System.Drawing.Size(56, 13);
            gunfiyatLabel.TabIndex = 42;
            gunfiyatLabel.Text = "gunfiyat:";
            // 
            // odaDataGridView
            // 
            this.odaDataGridView.AllowUserToAddRows = false;
            this.odaDataGridView.AllowUserToDeleteRows = false;
            this.odaDataGridView.AutoGenerateColumns = false;
            this.odaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.kisisayiDataGridViewTextBoxColumn,
            this.gunfiyatDataGridViewTextBoxColumn});
            this.odaDataGridView.DataSource = this.odaBindingSource;
            this.odaDataGridView.Location = new System.Drawing.Point(14, 173);
            this.odaDataGridView.Name = "odaDataGridView";
            this.odaDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.odaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.odaDataGridView.Size = new System.Drawing.Size(390, 229);
            this.odaDataGridView.TabIndex = 5;
            this.odaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odaDataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kisisayiDataGridViewTextBoxColumn
            // 
            this.kisisayiDataGridViewTextBoxColumn.DataPropertyName = "kisisayi";
            this.kisisayiDataGridViewTextBoxColumn.HeaderText = "kisisayi";
            this.kisisayiDataGridViewTextBoxColumn.Name = "kisisayiDataGridViewTextBoxColumn";
            this.kisisayiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gunfiyatDataGridViewTextBoxColumn
            // 
            this.gunfiyatDataGridViewTextBoxColumn.DataPropertyName = "gunfiyat";
            this.gunfiyatDataGridViewTextBoxColumn.HeaderText = "gunfiyat";
            this.gunfiyatDataGridViewTextBoxColumn.Name = "gunfiyatDataGridViewTextBoxColumn";
            this.gunfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaBindingSource
            // 
            this.odaBindingSource.DataSource = typeof(OtelOtomasyonu.oda);
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(78, 66);
            this.adiTextBox.MaxLength = 50;
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(326, 20);
            this.adiTextBox.TabIndex = 0;
            // 
            // kisisayiNumericUpDown
            // 
            this.kisisayiNumericUpDown.Location = new System.Drawing.Point(78, 92);
            this.kisisayiNumericUpDown.Name = "kisisayiNumericUpDown";
            this.kisisayiNumericUpDown.Size = new System.Drawing.Size(326, 20);
            this.kisisayiNumericUpDown.TabIndex = 1;
            // 
            // gunfiyatMaskedTextBox
            // 
            this.gunfiyatMaskedTextBox.Location = new System.Drawing.Point(78, 118);
            this.gunfiyatMaskedTextBox.Mask = "000.00";
            this.gunfiyatMaskedTextBox.Name = "gunfiyatMaskedTextBox";
            this.gunfiyatMaskedTextBox.Size = new System.Drawing.Size(326, 20);
            this.gunfiyatMaskedTextBox.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(362, 144);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 23);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(268, 144);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(87, 23);
            this.btnKayit.TabIndex = 43;
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
            this.btnTemizle.Location = new System.Drawing.Point(175, 144);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 45;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pbMiniLogo
            // 
           // this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini_logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(328, 10);
            this.pbMiniLogo.Name = "pbMiniLogo";
            this.pbMiniLogo.Size = new System.Drawing.Size(76, 50);
            this.pbMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMiniLogo.TabIndex = 46;
            this.pbMiniLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "Oda Tanımla";
            // 
            // frmOdaTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(427, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMiniLogo);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(adiLabel);
            this.Controls.Add(this.adiTextBox);
            this.Controls.Add(kisisayiLabel);
            this.Controls.Add(this.kisisayiNumericUpDown);
            this.Controls.Add(gunfiyatLabel);
            this.Controls.Add(this.gunfiyatMaskedTextBox);
            this.Controls.Add(this.odaDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 450);
            this.Name = "frmOdaTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Tanımla";
            this.Load += new System.EventHandler(this.frmOdaTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisisayiNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView odaDataGridView;
        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.NumericUpDown kisisayiNumericUpDown;
        private System.Windows.Forms.MaskedTextBox gunfiyatMaskedTextBox;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisisayiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource odaBindingSource;
        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.Label label1;
    }
}