namespace OtelOtomasyonu
{
    partial class frmUrunTanimla
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
            System.Windows.Forms.Label birimfiyatLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunTanimla));
            this.label1 = new System.Windows.Forms.Label();
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.urunDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.birimfiyatMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            adiLabel = new System.Windows.Forms.Label();
            birimfiyatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adiLabel
            // 
            adiLabel.AutoSize = true;
            adiLabel.Location = new System.Drawing.Point(16, 71);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new System.Drawing.Size(24, 13);
            adiLabel.TabIndex = 51;
            adiLabel.Text = "adi:";
            // 
            // birimfiyatLabel
            // 
            birimfiyatLabel.AutoSize = true;
            birimfiyatLabel.Location = new System.Drawing.Point(16, 97);
            birimfiyatLabel.Name = "birimfiyatLabel";
            birimfiyatLabel.Size = new System.Drawing.Size(50, 13);
            birimfiyatLabel.TabIndex = 53;
            birimfiyatLabel.Text = "birimfiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ürün Tanımla";
            // 
            // pbMiniLogo
            // 
            //this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini_logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(253, 12);
            this.pbMiniLogo.Name = "pbMiniLogo";
            this.pbMiniLogo.Size = new System.Drawing.Size(76, 50);
            this.pbMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMiniLogo.TabIndex = 49;
            this.pbMiniLogo.TabStop = false;
            // 
            // urunDataGridView
            // 
            this.urunDataGridView.AllowUserToAddRows = false;
            this.urunDataGridView.AllowUserToDeleteRows = false;
            this.urunDataGridView.AutoGenerateColumns = false;
            this.urunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.birimfiyatDataGridViewTextBoxColumn});
            this.urunDataGridView.DataSource = this.urunBindingSource;
            this.urunDataGridView.Location = new System.Drawing.Point(12, 155);
            this.urunDataGridView.Name = "urunDataGridView";
            this.urunDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.urunDataGridView.Size = new System.Drawing.Size(317, 264);
            this.urunDataGridView.TabIndex = 50;
            this.urunDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunDataGridView_CellDoubleClick);
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
            // birimfiyatDataGridViewTextBoxColumn
            // 
            this.birimfiyatDataGridViewTextBoxColumn.DataPropertyName = "birimfiyat";
            this.birimfiyatDataGridViewTextBoxColumn.HeaderText = "birimfiyat";
            this.birimfiyatDataGridViewTextBoxColumn.Name = "birimfiyatDataGridViewTextBoxColumn";
            this.birimfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(OtelOtomasyonu.urun);
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(72, 68);
            this.adiTextBox.MaxLength = 50;
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(257, 20);
            this.adiTextBox.TabIndex = 52;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(100, 123);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 58;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(287, 123);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 23);
            this.btnSil.TabIndex = 57;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(193, 123);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(87, 23);
            this.btnKayit.TabIndex = 56;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // birimfiyatMaskedTextBox
            // 
            this.birimfiyatMaskedTextBox.Location = new System.Drawing.Point(72, 94);
            this.birimfiyatMaskedTextBox.Mask = "000.00";
            this.birimfiyatMaskedTextBox.Name = "birimfiyatMaskedTextBox";
            this.birimfiyatMaskedTextBox.Size = new System.Drawing.Size(257, 20);
            this.birimfiyatMaskedTextBox.TabIndex = 55;
            // 
            // frmUrunTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(341, 431);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.birimfiyatMaskedTextBox);
            this.Controls.Add(adiLabel);
            this.Controls.Add(this.adiTextBox);
            this.Controls.Add(birimfiyatLabel);
            this.Controls.Add(this.urunDataGridView);
            this.Controls.Add(this.pbMiniLogo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUrunTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Tanımla";
            this.Load += new System.EventHandler(this.frmUrunTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView urunDataGridView;
        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.MaskedTextBox birimfiyatMaskedTextBox;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyatDataGridViewTextBoxColumn;
    }
}