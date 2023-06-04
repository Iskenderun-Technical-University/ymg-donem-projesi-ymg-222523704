namespace OtelOtomasyonu
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOturumAc = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cmbSubeler = new System.Windows.Forms.ComboBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kod";
            // 
            // btnOturumAc
            // 
            this.btnOturumAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOturumAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOturumAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturumAc.ForeColor = System.Drawing.Color.White;
            this.btnOturumAc.Location = new System.Drawing.Point(241, 91);
            this.btnOturumAc.Name = "btnOturumAc";
            this.btnOturumAc.Size = new System.Drawing.Size(139, 40);
            this.btnOturumAc.TabIndex = 3;
            this.btnOturumAc.TabStop = false;
            this.btnOturumAc.Text = "Oturum Aç";
            this.btnOturumAc.UseVisualStyleBackColor = false;
            this.btnOturumAc.Click += new System.EventHandler(this.btnOturumAc_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.txtSifre.Location = new System.Drawing.Point(241, 65);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(139, 20);
            this.txtSifre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şube";
            // 
            // pbResim
            // 
            this.pbResim.Image = ((System.Drawing.Image)(resources.GetObject("pbResim.Image")));
            this.pbResim.Location = new System.Drawing.Point(5, -3);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(185, 147);
            this.pbResim.TabIndex = 4;
            this.pbResim.TabStop = false;
            // 
            // cmbSubeler
            // 
            this.cmbSubeler.DisplayMember = "0";
            this.cmbSubeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSubeler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.cmbSubeler.FormattingEnabled = true;
            this.cmbSubeler.Location = new System.Drawing.Point(241, 12);
            this.cmbSubeler.Name = "cmbSubeler";
            this.cmbSubeler.Size = new System.Drawing.Size(139, 21);
            this.cmbSubeler.TabIndex = 1;
            this.cmbSubeler.ValueMember = "0";
            // 
            // txtKod
            // 
            this.txtKod.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OtelOtomasyonu.Properties.Settings.Default, "PersonelKod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.txtKod.Location = new System.Drawing.Point(241, 39);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(138, 20);
            this.txtKod.TabIndex = 2;
            this.txtKod.Text = global::OtelOtomasyonu.Properties.Settings.Default.PersonelKod;
            // 
            // frmGiris
            // 
            this.AcceptButton = this.btnOturumAc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnOturumAc);
            this.Controls.Add(this.cmbSubeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 175);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş - Otel Otomasyon v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGiris_FormClosed);
            this.Load += new System.EventHandler(this.frmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubeler;
        private System.Windows.Forms.Button btnOturumAc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbResim;
    }
}