namespace OtelOtomasyonu
{
    partial class frmKrediKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKrediKarti));
            this.label1 = new System.Windows.Forms.Label();
            this.gbKartTipi = new System.Windows.Forms.GroupBox();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.rbMaster = new System.Windows.Forms.RadioButton();
            this.kartSahibiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kartNoMasked = new System.Windows.Forms.MaskedTextBox();
            this.cvcMasked = new System.Windows.Forms.MaskedTextBox();
            this.sonKullanimTarihiMasked = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbKartTipi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart No";
            // 
            // gbKartTipi
            // 
            this.gbKartTipi.Controls.Add(this.rbVisa);
            this.gbKartTipi.Controls.Add(this.rbMaster);
            this.gbKartTipi.Location = new System.Drawing.Point(73, 149);
            this.gbKartTipi.Name = "gbKartTipi";
            this.gbKartTipi.Size = new System.Drawing.Size(210, 44);
            this.gbKartTipi.TabIndex = 4;
            this.gbKartTipi.TabStop = false;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Location = new System.Drawing.Point(119, 16);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(70, 17);
            this.rbVisa.TabIndex = 1;
            this.rbVisa.Text = "Visa Card";
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.Checked = true;
            this.rbMaster.Location = new System.Drawing.Point(21, 16);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(82, 17);
            this.rbMaster.TabIndex = 0;
            this.rbMaster.TabStop = true;
            this.rbMaster.Text = "Master Card";
            this.rbMaster.UseVisualStyleBackColor = true;
            // 
            // kartSahibiTextBox
            // 
            this.kartSahibiTextBox.Location = new System.Drawing.Point(73, 71);
            this.kartSahibiTextBox.MaxLength = 50;
            this.kartSahibiTextBox.Name = "kartSahibiTextBox";
            this.kartSahibiTextBox.Size = new System.Drawing.Size(210, 20);
            this.kartSahibiTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Sahibi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CVC";
            // 
            // kartNoMasked
            // 
            this.kartNoMasked.Location = new System.Drawing.Point(73, 45);
            this.kartNoMasked.Mask = "0000-0000-0000-0000";
            this.kartNoMasked.Name = "kartNoMasked";
            this.kartNoMasked.Size = new System.Drawing.Size(115, 20);
            this.kartNoMasked.TabIndex = 0;
            // 
            // cvcMasked
            // 
            this.cvcMasked.Location = new System.Drawing.Point(73, 123);
            this.cvcMasked.Mask = "000";
            this.cvcMasked.Name = "cvcMasked";
            this.cvcMasked.Size = new System.Drawing.Size(44, 20);
            this.cvcMasked.TabIndex = 3;
            // 
            // sonKullanimTarihiMasked
            // 
            this.sonKullanimTarihiMasked.Location = new System.Drawing.Point(73, 97);
            this.sonKullanimTarihiMasked.Mask = "00/00";
            this.sonKullanimTarihiMasked.Name = "sonKullanimTarihiMasked";
            this.sonKullanimTarihiMasked.Size = new System.Drawing.Size(44, 20);
            this.sonKullanimTarihiMasked.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Son. Tarihi";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.Location = new System.Drawing.Point(73, 199);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(207, 23);
            this.btnOdemeYap.TabIndex = 5;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(73, 9);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(49, 29);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "- - -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tutar :";
            // 
            // frmKrediKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(292, 235);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.sonKullanimTarihiMasked);
            this.Controls.Add(this.cvcMasked);
            this.Controls.Add(this.kartNoMasked);
            this.Controls.Add(this.gbKartTipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kartSahibiTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKrediKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredi Karti";
            this.Load += new System.EventHandler(this.frmKrediKarti_Load);
            this.gbKartTipi.ResumeLayout(false);
            this.gbKartTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbKartTipi;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.RadioButton rbMaster;
        private System.Windows.Forms.TextBox kartSahibiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox kartNoMasked;
        private System.Windows.Forms.MaskedTextBox cvcMasked;
        private System.Windows.Forms.MaskedTextBox sonKullanimTarihiMasked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label5;
    }
}