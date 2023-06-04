namespace OtelOtomasyonu
{
    partial class frmSubeTanimla
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
            System.Windows.Forms.Label aktifLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubeTanimla));
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.subeDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            adiLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // adiLabel
            // 
            adiLabel.AutoSize = true;
            adiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adiLabel.Location = new System.Drawing.Point(15, 71);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new System.Drawing.Size(28, 13);
            adiLabel.TabIndex = 29;
            adiLabel.Text = "adi:";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aktifLabel.Location = new System.Drawing.Point(15, 99);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(36, 13);
            aktifLabel.TabIndex = 31;
            aktifLabel.Text = "aktif:";
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(57, 68);
            this.adiTextBox.MaxLength = 50;
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(349, 20);
            this.adiTextBox.TabIndex = 0;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.Location = new System.Drawing.Point(57, 94);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(54, 24);
            this.aktifCheckBox.TabIndex = 1;
            this.aktifCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(364, 94);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(270, 94);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(87, 23);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // subeDataGridView
            // 
            this.subeDataGridView.AllowUserToAddRows = false;
            this.subeDataGridView.AllowUserToDeleteRows = false;
            this.subeDataGridView.AutoGenerateColumns = false;
            this.subeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn});
            this.subeDataGridView.DataSource = this.subeBindingSource;
            this.subeDataGridView.Location = new System.Drawing.Point(18, 126);
            this.subeDataGridView.Name = "subeDataGridView";
            this.subeDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.subeDataGridView.Size = new System.Drawing.Size(388, 274);
            this.subeDataGridView.TabIndex = 4;
            this.subeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subeDataGridView_CellDoubleClick);
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
            // aktifDataGridViewCheckBoxColumn
            // 
            this.aktifDataGridViewCheckBoxColumn.DataPropertyName = "aktif";
            this.aktifDataGridViewCheckBoxColumn.HeaderText = "aktif";
            this.aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            this.aktifDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // subeBindingSource
            // 
            this.subeBindingSource.DataSource = typeof(OtelOtomasyonu.sube);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(177, 94);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pbMiniLogo
            // 
           // this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini-logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(330, 12);
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
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "Şube Tanımla";
            // 
            // frmSubeTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(428, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMiniLogo);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.subeDataGridView);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(adiLabel);
            this.Controls.Add(this.adiTextBox);
            this.Controls.Add(aktifLabel);
            this.Controls.Add(this.aktifCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 448);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 448);
            this.Name = "frmSubeTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Tanımla";
            this.Load += new System.EventHandler(this.frmSubeTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView subeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource subeBindingSource;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.Label label1;
    }
}