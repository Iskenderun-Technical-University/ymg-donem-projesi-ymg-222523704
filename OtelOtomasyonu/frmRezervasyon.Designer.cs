namespace OtelOtomasyonu
{
    partial class frmRezervasyon
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
            System.Windows.Forms.Label musteriidLabel;
            System.Windows.Forms.Label odaidLabel;
            System.Windows.Forms.Label rezervasyontarihiLabel;
            System.Windows.Forms.Label giristarihiLabel;
            System.Windows.Forms.Label cikistarihiLabel;
            System.Windows.Forms.Label gunLabel;
            System.Windows.Forms.Label odanoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label yetiskinsayiLabel;
            System.Windows.Forms.Label cocuksayiLabel;
            System.Windows.Forms.Label bebeksayiLabel;
            System.Windows.Forms.Label birimfiyatLabel;
            System.Windows.Forms.Label durumLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.pbMiniLogo = new System.Windows.Forms.PictureBox();
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.odaidComboBox = new System.Windows.Forms.ComboBox();
            this.odaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyontarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.giristarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cikistarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odanoTextBox = new System.Windows.Forms.TextBox();
            this.gbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.musteriButton = new System.Windows.Forms.Button();
            this.ulkeTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.soyadiTextBox = new System.Windows.Forms.TextBox();
            this.kimlikNoTextBox = new System.Windows.Forms.TextBox();
            this.gbOdaBilgileri = new System.Windows.Forms.GroupBox();
            this.durumComboBox = new System.Windows.Forms.ComboBox();
            this.birimfiyatMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.bebeksayiNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yetiskinsayiNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gunNumeric = new System.Windows.Forms.NumericUpDown();
            this.odaButton = new System.Windows.Forms.Button();
            this.cocuksayiNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rezervasyonDataGridView = new System.Windows.Forms.DataGridView();
            this.lblOdaBilgi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            musteriidLabel = new System.Windows.Forms.Label();
            odaidLabel = new System.Windows.Forms.Label();
            rezervasyontarihiLabel = new System.Windows.Forms.Label();
            giristarihiLabel = new System.Windows.Forms.Label();
            cikistarihiLabel = new System.Windows.Forms.Label();
            gunLabel = new System.Windows.Forms.Label();
            odanoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            yetiskinsayiLabel = new System.Windows.Forms.Label();
            cocuksayiLabel = new System.Windows.Forms.Label();
            bebeksayiLabel = new System.Windows.Forms.Label();
            birimfiyatLabel = new System.Windows.Forms.Label();
            durumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).BeginInit();
            this.gbMusteriBilgileri.SuspendLayout();
            this.gbOdaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bebeksayiNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetiskinsayiNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocuksayiNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriidLabel
            // 
            musteriidLabel.AutoSize = true;
            musteriidLabel.Location = new System.Drawing.Point(206, 22);
            musteriidLabel.Name = "musteriidLabel";
            musteriidLabel.Size = new System.Drawing.Size(28, 13);
            musteriidLabel.TabIndex = 48;
            musteriidLabel.Text = "adı:";
            // 
            // odaidLabel
            // 
            odaidLabel.AutoSize = true;
            odaidLabel.Location = new System.Drawing.Point(6, 22);
            odaidLabel.Name = "odaidLabel";
            odaidLabel.Size = new System.Drawing.Size(36, 13);
            odaidLabel.TabIndex = 50;
            odaidLabel.Text = "odaid:";
            // 
            // rezervasyontarihiLabel
            // 
            rezervasyontarihiLabel.AutoSize = true;
            rezervasyontarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            rezervasyontarihiLabel.Location = new System.Drawing.Point(239, 22);
            rezervasyontarihiLabel.Name = "rezervasyontarihiLabel";
            rezervasyontarihiLabel.Size = new System.Drawing.Size(111, 13);
            rezervasyontarihiLabel.TabIndex = 52;
            rezervasyontarihiLabel.Text = "rezervasyon tarihi:";
            // 
            // giristarihiLabel
            // 
            giristarihiLabel.AutoSize = true;
            giristarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            giristarihiLabel.Location = new System.Drawing.Point(239, 48);
            giristarihiLabel.Name = "giristarihiLabel";
            giristarihiLabel.Size = new System.Drawing.Size(66, 13);
            giristarihiLabel.TabIndex = 54;
            giristarihiLabel.Text = "giris tarihi:";
            // 
            // cikistarihiLabel
            // 
            cikistarihiLabel.AutoSize = true;
            cikistarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cikistarihiLabel.Location = new System.Drawing.Point(239, 74);
            cikistarihiLabel.Name = "cikistarihiLabel";
            cikistarihiLabel.Size = new System.Drawing.Size(69, 13);
            cikistarihiLabel.TabIndex = 56;
            cikistarihiLabel.Text = "cikis tarihi:";
            // 
            // gunLabel
            // 
            gunLabel.AutoSize = true;
            gunLabel.Location = new System.Drawing.Point(6, 72);
            gunLabel.Name = "gunLabel";
            gunLabel.Size = new System.Drawing.Size(28, 13);
            gunLabel.TabIndex = 58;
            gunLabel.Text = "gun:";
            // 
            // odanoLabel
            // 
            odanoLabel.AutoSize = true;
            odanoLabel.Location = new System.Drawing.Point(6, 49);
            odanoLabel.Name = "odanoLabel";
            odanoLabel.Size = new System.Drawing.Size(40, 13);
            odanoLabel.TabIndex = 70;
            odanoLabel.Text = "odano:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(399, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 48;
            label1.Text = "soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(788, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 48;
            label2.Text = "ülke:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(597, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 13);
            label3.TabIndex = 48;
            label3.Text = "telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 13);
            label4.TabIndex = 48;
            label4.Text = "kimlik no:";
            // 
            // yetiskinsayiLabel
            // 
            yetiskinsayiLabel.AutoSize = true;
            yetiskinsayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yetiskinsayiLabel.Location = new System.Drawing.Point(577, 22);
            yetiskinsayiLabel.Name = "yetiskinsayiLabel";
            yetiskinsayiLabel.Size = new System.Drawing.Size(80, 13);
            yetiskinsayiLabel.TabIndex = 74;
            yetiskinsayiLabel.Text = "yetiskin sayi:";
            // 
            // cocuksayiLabel
            // 
            cocuksayiLabel.AutoSize = true;
            cocuksayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cocuksayiLabel.Location = new System.Drawing.Point(577, 48);
            cocuksayiLabel.Name = "cocuksayiLabel";
            cocuksayiLabel.Size = new System.Drawing.Size(72, 13);
            cocuksayiLabel.TabIndex = 76;
            cocuksayiLabel.Text = "cocuk sayi:";
            // 
            // bebeksayiLabel
            // 
            bebeksayiLabel.AutoSize = true;
            bebeksayiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            bebeksayiLabel.Location = new System.Drawing.Point(577, 74);
            bebeksayiLabel.Name = "bebeksayiLabel";
            bebeksayiLabel.Size = new System.Drawing.Size(72, 13);
            bebeksayiLabel.TabIndex = 78;
            bebeksayiLabel.Text = "bebek sayi:";
            // 
            // birimfiyatLabel
            // 
            birimfiyatLabel.AutoSize = true;
            birimfiyatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            birimfiyatLabel.Location = new System.Drawing.Point(742, 22);
            birimfiyatLabel.Name = "birimfiyatLabel";
            birimfiyatLabel.Size = new System.Drawing.Size(61, 13);
            birimfiyatLabel.TabIndex = 80;
            birimfiyatLabel.Text = "birimfiyat:";
            // 
            // durumLabel
            // 
            durumLabel.AutoSize = true;
            durumLabel.Location = new System.Drawing.Point(898, 15);
            durumLabel.Name = "durumLabel";
            durumLabel.Size = new System.Drawing.Size(39, 13);
            durumLabel.TabIndex = 82;
            durumLabel.Text = "durum:";
            // 
            // pbMiniLogo
            // 
           // this.pbMiniLogo.Image = global::OtelOtomasyonu.Properties.Resources.mini_logo;
            this.pbMiniLogo.Location = new System.Drawing.Point(930, 12);
            this.pbMiniLogo.Name = "pbMiniLogo";
            this.pbMiniLogo.Size = new System.Drawing.Size(76, 50);
            this.pbMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMiniLogo.TabIndex = 47;
            this.pbMiniLogo.TabStop = false;
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(240, 19);
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(153, 20);
            this.adiTextBox.TabIndex = 1;
            // 
            // odaidComboBox
            // 
            this.odaidComboBox.DataSource = this.odaBindingSource;
            this.odaidComboBox.DisplayMember = "adi";
            this.odaidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odaidComboBox.FormattingEnabled = true;
            this.odaidComboBox.Location = new System.Drawing.Point(55, 19);
            this.odaidComboBox.Name = "odaidComboBox";
            this.odaidComboBox.Size = new System.Drawing.Size(164, 21);
            this.odaidComboBox.TabIndex = 0;
            this.odaidComboBox.ValueMember = "id";
            this.odaidComboBox.SelectedIndexChanged += new System.EventHandler(this.odaidComboBox_SelectedIndexChanged);
            // 
            // odaBindingSource
            // 
            this.odaBindingSource.DataSource = typeof(OtelOtomasyonu.oda);
            // 
            // rezervasyontarihiDateTimePicker
            // 
            this.rezervasyontarihiDateTimePicker.Location = new System.Drawing.Point(361, 20);
            this.rezervasyontarihiDateTimePicker.Name = "rezervasyontarihiDateTimePicker";
            this.rezervasyontarihiDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.rezervasyontarihiDateTimePicker.TabIndex = 4;
            this.rezervasyontarihiDateTimePicker.ValueChanged += new System.EventHandler(this.rezervasyontarihiDateTimePicker_ValueChanged);
            // 
            // giristarihiDateTimePicker
            // 
            this.giristarihiDateTimePicker.Location = new System.Drawing.Point(361, 46);
            this.giristarihiDateTimePicker.Name = "giristarihiDateTimePicker";
            this.giristarihiDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.giristarihiDateTimePicker.TabIndex = 5;
            this.giristarihiDateTimePicker.ValueChanged += new System.EventHandler(this.giristarihiDateTimePicker_ValueChanged);
            // 
            // cikistarihiDateTimePicker
            // 
            this.cikistarihiDateTimePicker.Location = new System.Drawing.Point(361, 72);
            this.cikistarihiDateTimePicker.Name = "cikistarihiDateTimePicker";
            this.cikistarihiDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.cikistarihiDateTimePicker.TabIndex = 6;
            this.cikistarihiDateTimePicker.ValueChanged += new System.EventHandler(this.cikistarihiDateTimePicker_ValueChanged);
            // 
            // odanoTextBox
            // 
            this.odanoTextBox.Enabled = false;
            this.odanoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odanoTextBox.Location = new System.Drawing.Point(55, 46);
            this.odanoTextBox.Name = "odanoTextBox";
            this.odanoTextBox.Size = new System.Drawing.Size(92, 21);
            this.odanoTextBox.TabIndex = 1;
            this.odanoTextBox.Text = "---";
            this.odanoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbMusteriBilgileri
            // 
            this.gbMusteriBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbMusteriBilgileri.Controls.Add(this.musteriButton);
            this.gbMusteriBilgileri.Controls.Add(this.ulkeTextBox);
            this.gbMusteriBilgileri.Controls.Add(this.telefonTextBox);
            this.gbMusteriBilgileri.Controls.Add(label2);
            this.gbMusteriBilgileri.Controls.Add(label3);
            this.gbMusteriBilgileri.Controls.Add(this.soyadiTextBox);
            this.gbMusteriBilgileri.Controls.Add(label1);
            this.gbMusteriBilgileri.Controls.Add(this.kimlikNoTextBox);
            this.gbMusteriBilgileri.Controls.Add(label4);
            this.gbMusteriBilgileri.Controls.Add(this.adiTextBox);
            this.gbMusteriBilgileri.Controls.Add(musteriidLabel);
            this.gbMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMusteriBilgileri.Location = new System.Drawing.Point(12, 68);
            this.gbMusteriBilgileri.Name = "gbMusteriBilgileri";
            this.gbMusteriBilgileri.Size = new System.Drawing.Size(994, 53);
            this.gbMusteriBilgileri.TabIndex = 0;
            this.gbMusteriBilgileri.TabStop = false;
            // 
            // musteriButton
            // 
            this.musteriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriButton.Location = new System.Drawing.Point(947, 14);
            this.musteriButton.Name = "musteriButton";
            this.musteriButton.Size = new System.Drawing.Size(41, 32);
            this.musteriButton.TabIndex = 72;
            this.musteriButton.Text = "?";
            this.musteriButton.UseVisualStyleBackColor = true;
            this.musteriButton.Click += new System.EventHandler(this.musteriButton_Click);
            // 
            // ulkeTextBox
            // 
            this.ulkeTextBox.Enabled = false;
            this.ulkeTextBox.Location = new System.Drawing.Point(825, 19);
            this.ulkeTextBox.Name = "ulkeTextBox";
            this.ulkeTextBox.Size = new System.Drawing.Size(116, 20);
            this.ulkeTextBox.TabIndex = 4;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Enabled = false;
            this.telefonTextBox.Location = new System.Drawing.Point(650, 19);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(132, 20);
            this.telefonTextBox.TabIndex = 3;
            // 
            // soyadiTextBox
            // 
            this.soyadiTextBox.Location = new System.Drawing.Point(452, 19);
            this.soyadiTextBox.Name = "soyadiTextBox";
            this.soyadiTextBox.Size = new System.Drawing.Size(139, 20);
            this.soyadiTextBox.TabIndex = 2;
            // 
            // kimlikNoTextBox
            // 
            this.kimlikNoTextBox.Location = new System.Drawing.Point(73, 19);
            this.kimlikNoTextBox.Name = "kimlikNoTextBox";
            this.kimlikNoTextBox.Size = new System.Drawing.Size(127, 20);
            this.kimlikNoTextBox.TabIndex = 0;
            // 
            // gbOdaBilgileri
            // 
            this.gbOdaBilgileri.Controls.Add(this.durumComboBox);
            this.gbOdaBilgileri.Controls.Add(this.birimfiyatMaskedTextBox);
            this.gbOdaBilgileri.Controls.Add(this.btnTemizle);
            this.gbOdaBilgileri.Controls.Add(this.btnSil);
            this.gbOdaBilgileri.Controls.Add(birimfiyatLabel);
            this.gbOdaBilgileri.Controls.Add(this.btnKayit);
            this.gbOdaBilgileri.Controls.Add(bebeksayiLabel);
            this.gbOdaBilgileri.Controls.Add(this.bebeksayiNumericUpDown);
            this.gbOdaBilgileri.Controls.Add(yetiskinsayiLabel);
            this.gbOdaBilgileri.Controls.Add(this.yetiskinsayiNumericUpDown);
            this.gbOdaBilgileri.Controls.Add(this.gunNumeric);
            this.gbOdaBilgileri.Controls.Add(cocuksayiLabel);
            this.gbOdaBilgileri.Controls.Add(this.odaButton);
            this.gbOdaBilgileri.Controls.Add(this.cocuksayiNumericUpDown);
            this.gbOdaBilgileri.Controls.Add(giristarihiLabel);
            this.gbOdaBilgileri.Controls.Add(this.giristarihiDateTimePicker);
            this.gbOdaBilgileri.Controls.Add(cikistarihiLabel);
            this.gbOdaBilgileri.Controls.Add(rezervasyontarihiLabel);
            this.gbOdaBilgileri.Controls.Add(this.cikistarihiDateTimePicker);
            this.gbOdaBilgileri.Controls.Add(this.odaidComboBox);
            this.gbOdaBilgileri.Controls.Add(this.rezervasyontarihiDateTimePicker);
            this.gbOdaBilgileri.Controls.Add(odaidLabel);
            this.gbOdaBilgileri.Controls.Add(gunLabel);
            this.gbOdaBilgileri.Controls.Add(this.odanoTextBox);
            this.gbOdaBilgileri.Controls.Add(odanoLabel);
            this.gbOdaBilgileri.Controls.Add(durumLabel);
            this.gbOdaBilgileri.Location = new System.Drawing.Point(12, 127);
            this.gbOdaBilgileri.Name = "gbOdaBilgileri";
            this.gbOdaBilgileri.Size = new System.Drawing.Size(994, 104);
            this.gbOdaBilgileri.TabIndex = 1;
            this.gbOdaBilgileri.TabStop = false;
            // 
            // durumComboBox
            // 
            this.durumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durumComboBox.FormattingEnabled = true;
            this.durumComboBox.Location = new System.Drawing.Point(898, 30);
            this.durumComboBox.Name = "durumComboBox";
            this.durumComboBox.Size = new System.Drawing.Size(87, 21);
            this.durumComboBox.TabIndex = 83;
            // 
            // birimfiyatMaskedTextBox
            // 
            this.birimfiyatMaskedTextBox.Enabled = false;
            this.birimfiyatMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimfiyatMaskedTextBox.Location = new System.Drawing.Point(809, 19);
            this.birimfiyatMaskedTextBox.Mask = "000.00";
            this.birimfiyatMaskedTextBox.Name = "birimfiyatMaskedTextBox";
            this.birimfiyatMaskedTextBox.Size = new System.Drawing.Size(83, 32);
            this.birimfiyatMaskedTextBox.TabIndex = 81;
            this.birimfiyatMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(745, 60);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(90, 31);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(944, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(41, 31);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(841, 60);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(96, 31);
            this.btnKayit.TabIndex = 11;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // bebeksayiNumericUpDown
            // 
            this.bebeksayiNumericUpDown.Location = new System.Drawing.Point(667, 72);
            this.bebeksayiNumericUpDown.Name = "bebeksayiNumericUpDown";
            this.bebeksayiNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.bebeksayiNumericUpDown.TabIndex = 9;
            this.bebeksayiNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yetiskinsayiNumericUpDown
            // 
            this.yetiskinsayiNumericUpDown.Location = new System.Drawing.Point(667, 20);
            this.yetiskinsayiNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yetiskinsayiNumericUpDown.Name = "yetiskinsayiNumericUpDown";
            this.yetiskinsayiNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.yetiskinsayiNumericUpDown.TabIndex = 7;
            this.yetiskinsayiNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yetiskinsayiNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gunNumeric
            // 
            this.gunNumeric.Location = new System.Drawing.Point(55, 72);
            this.gunNumeric.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.gunNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gunNumeric.Name = "gunNumeric";
            this.gunNumeric.Size = new System.Drawing.Size(92, 20);
            this.gunNumeric.TabIndex = 2;
            this.gunNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gunNumeric.ValueChanged += new System.EventHandler(this.gunNumeric_ValueChanged);
            // 
            // odaButton
            // 
            this.odaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaButton.Location = new System.Drawing.Point(153, 46);
            this.odaButton.Name = "odaButton";
            this.odaButton.Size = new System.Drawing.Size(66, 46);
            this.odaButton.TabIndex = 3;
            this.odaButton.Text = "?";
            this.odaButton.UseVisualStyleBackColor = true;
            this.odaButton.Click += new System.EventHandler(this.odaButton_Click);
            // 
            // cocuksayiNumericUpDown
            // 
            this.cocuksayiNumericUpDown.Location = new System.Drawing.Point(667, 46);
            this.cocuksayiNumericUpDown.Name = "cocuksayiNumericUpDown";
            this.cocuksayiNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.cocuksayiNumericUpDown.TabIndex = 8;
            this.cocuksayiNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rezervasyonDataGridView
            // 
            this.rezervasyonDataGridView.AllowUserToAddRows = false;
            this.rezervasyonDataGridView.AllowUserToDeleteRows = false;
            this.rezervasyonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rezervasyonDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.rezervasyonDataGridView.Location = new System.Drawing.Point(12, 237);
            this.rezervasyonDataGridView.Name = "rezervasyonDataGridView";
            this.rezervasyonDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rezervasyonDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.rezervasyonDataGridView.Size = new System.Drawing.Size(994, 315);
            this.rezervasyonDataGridView.TabIndex = 48;
            this.rezervasyonDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervasyonDataGridView_CellDoubleClick);
            // 
            // lblOdaBilgi
            // 
            this.lblOdaBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOdaBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOdaBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaBilgi.Location = new System.Drawing.Point(269, 12);
            this.lblOdaBilgi.Name = "lblOdaBilgi";
            this.lblOdaBilgi.Size = new System.Drawing.Size(655, 50);
            this.lblOdaBilgi.TabIndex = 49;
            this.lblOdaBilgi.Text = "- - -";
            this.lblOdaBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "Rezervasyon";
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1018, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOdaBilgi);
            this.Controls.Add(this.rezervasyonDataGridView);
            this.Controls.Add(this.gbOdaBilgileri);
            this.Controls.Add(this.gbMusteriBilgileri);
            this.Controls.Add(this.pbMiniLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1034, 600);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1034, 600);
            this.Name = "frmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon İşlemleri";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).EndInit();
            this.gbMusteriBilgileri.ResumeLayout(false);
            this.gbMusteriBilgileri.PerformLayout();
            this.gbOdaBilgileri.ResumeLayout(false);
            this.gbOdaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bebeksayiNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetiskinsayiNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocuksayiNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMiniLogo;
        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.ComboBox odaidComboBox;
        private System.Windows.Forms.DateTimePicker rezervasyontarihiDateTimePicker;
        private System.Windows.Forms.DateTimePicker giristarihiDateTimePicker;
        private System.Windows.Forms.DateTimePicker cikistarihiDateTimePicker;
        private System.Windows.Forms.TextBox odanoTextBox;
        private System.Windows.Forms.GroupBox gbMusteriBilgileri;
        private System.Windows.Forms.TextBox ulkeTextBox;
        private System.Windows.Forms.TextBox soyadiTextBox;
        private System.Windows.Forms.GroupBox gbOdaBilgileri;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox kimlikNoTextBox;
        private System.Windows.Forms.Button odaButton;
        private System.Windows.Forms.Button musteriButton;
        private System.Windows.Forms.NumericUpDown gunNumeric;
        private System.Windows.Forms.NumericUpDown bebeksayiNumericUpDown;
        private System.Windows.Forms.NumericUpDown yetiskinsayiNumericUpDown;
        private System.Windows.Forms.NumericUpDown cocuksayiNumericUpDown;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView rezervasyonDataGridView;
        private System.Windows.Forms.BindingSource odaBindingSource;
        private System.Windows.Forms.MaskedTextBox birimfiyatMaskedTextBox;
        private System.Windows.Forms.Label lblOdaBilgi;
        private System.Windows.Forms.ComboBox durumComboBox;
        private System.Windows.Forms.Label label5;
    }
}