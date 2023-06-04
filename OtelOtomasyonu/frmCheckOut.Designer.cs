namespace OtelOtomasyonu
{
    partial class frmCheckOut
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
            this.ilkTarih = new System.Windows.Forms.DateTimePicker();
            this.sonTarih = new System.Windows.Forms.DateTimePicker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.rezervasyonDataGrid = new System.Windows.Forms.DataGrid();
            cikistarihiLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGrid)).BeginInit();
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
            // btnCheckOut
            // 
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckOut.Location = new System.Drawing.Point(645, 9);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(358, 23);
            this.btnCheckOut.TabIndex = 61;
            this.btnCheckOut.Text = "Seçili Rezervasyonu Check Out Yap";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(564, 10);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 60;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // rezervasyonDataGrid
            // 
            this.rezervasyonDataGrid.DataMember = "";
            this.rezervasyonDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.rezervasyonDataGrid.Location = new System.Drawing.Point(12, 38);
            this.rezervasyonDataGrid.Name = "rezervasyonDataGrid";
            this.rezervasyonDataGrid.ParentRowsVisible = false;
            this.rezervasyonDataGrid.Size = new System.Drawing.Size(991, 514);
            this.rezervasyonDataGrid.TabIndex = 62;
            this.rezervasyonDataGrid.DoubleClick += new System.EventHandler(this.rezervasyonDataGrid_DoubleClick);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1015, 564);
            this.Controls.Add(this.rezervasyonDataGrid);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(label1);
            this.Controls.Add(cikistarihiLabel);
            this.Controls.Add(this.sonTarih);
            this.Controls.Add(this.ilkTarih);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ilkTarih;
        private System.Windows.Forms.DateTimePicker sonTarih;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGrid rezervasyonDataGrid;
    }
}