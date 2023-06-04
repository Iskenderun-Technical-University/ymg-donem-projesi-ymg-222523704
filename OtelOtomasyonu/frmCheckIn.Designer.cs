namespace OtelOtomasyonu
{
    partial class frmCheckIn
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
            System.Windows.Forms.Label cikistarihiLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rezervasyonDataGridView = new System.Windows.Forms.DataGridView();
            this.ilkTarih = new System.Windows.Forms.DateTimePicker();
            this.sonTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            cikistarihiLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cikistarihiLabel
            // 
            cikistarihiLabel.AutoSize = true;
            cikistarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cikistarihiLabel.Location = new System.Drawing.Point(9, 14);
            cikistarihiLabel.Name = "cikistarihiLabel";
            cikistarihiLabel.Size = new System.Drawing.Size(53, 13);
            cikistarihiLabel.TabIndex = 58;
            cikistarihiLabel.Text = "ilk tarih:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.Location = new System.Drawing.Point(290, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 58;
            label1.Text = "son tarih:";
            // 
            // rezervasyonDataGridView
            // 
            this.rezervasyonDataGridView.AllowUserToAddRows = false;
            this.rezervasyonDataGridView.AllowUserToDeleteRows = false;
            this.rezervasyonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rezervasyonDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.rezervasyonDataGridView.Location = new System.Drawing.Point(12, 38);
            this.rezervasyonDataGridView.Name = "rezervasyonDataGridView";
            this.rezervasyonDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rezervasyonDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.rezervasyonDataGridView.Size = new System.Drawing.Size(991, 514);
            this.rezervasyonDataGridView.TabIndex = 49;
            // 
            // ilkTarih
            // 
            this.ilkTarih.Location = new System.Drawing.Point(84, 12);
            this.ilkTarih.Name = "ilkTarih";
            this.ilkTarih.Size = new System.Drawing.Size(193, 20);
            this.ilkTarih.TabIndex = 57;
            // 
            // sonTarih
            // 
            this.sonTarih.Location = new System.Drawing.Point(365, 12);
            this.sonTarih.Name = "sonTarih";
            this.sonTarih.Size = new System.Drawing.Size(193, 20);
            this.sonTarih.TabIndex = 57;
            // 
            // btnGetir
            // 
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(564, 10);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 59;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckIn.Location = new System.Drawing.Point(645, 9);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(358, 23);
            this.btnCheckIn.TabIndex = 59;
            this.btnCheckIn.Text = "Seçili Rezervasyonu Check In Yap";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1015, 564);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(label1);
            this.Controls.Add(cikistarihiLabel);
            this.Controls.Add(this.sonTarih);
            this.Controls.Add(this.ilkTarih);
            this.Controls.Add(this.rezervasyonDataGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "frmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rezervasyonDataGridView;
        private System.Windows.Forms.DateTimePicker ilkTarih;
        private System.Windows.Forms.DateTimePicker sonTarih;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnCheckIn;
    }
}