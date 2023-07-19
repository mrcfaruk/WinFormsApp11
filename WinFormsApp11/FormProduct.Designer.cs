namespace WinFormsApp11
{
    partial class FormProduct
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKDV = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKDVDahilToplam = new System.Windows.Forms.TextBox();
            this.textBoxGenelToplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxozellik = new System.Windows.Forms.TextBox();
            this.listBoxozellik = new System.Windows.Forms.ListBox();
            this.radioButtonTRY = new System.Windows.Forms.RadioButton();
            this.radioButtonUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonEUR = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 36);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(14, 95);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(114, 27);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::WinFormsApp11.Properties.Resources.check__2_;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(535, 408);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 32);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.FormattingEnabled = true;
            this.comboBoxBirim.Items.AddRange(new object[] {
            "Adet",
            "Gram",
            "Litre",
            "Santimetre"});
            this.comboBoxBirim.Location = new System.Drawing.Point(14, 193);
            this.comboBoxBirim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(114, 28);
            this.comboBoxBirim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ölçü Birimi";
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTarih.Location = new System.Drawing.Point(14, 256);
            this.dateTimePickerTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(142, 27);
            this.dateTimePickerTarih.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih";
            // 
            // comboBoxKDV
            // 
            this.comboBoxKDV.FormattingEnabled = true;
            this.comboBoxKDV.Items.AddRange(new object[] {
            "%0",
            "%1",
            "%8",
            "%18"});
            this.comboBoxKDV.Location = new System.Drawing.Point(135, 95);
            this.comboBoxKDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKDV.Name = "comboBoxKDV";
            this.comboBoxKDV.Size = new System.Drawing.Size(57, 28);
            this.comboBoxKDV.TabIndex = 9;
            this.comboBoxKDV.TextChanged += new System.EventHandler(this.comboBoxKDV_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(457, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Barkod";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(135, 36);
            this.textBoxBarkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(114, 27);
            this.textBoxBarkod.TabIndex = 12;
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(470, 406);
            this.checkBoxAktif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(59, 24);
            this.checkBoxAktif.TabIndex = 13;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxKDVDahilToplam);
            this.groupBox1.Controls.Add(this.textBoxGenelToplam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(395, 321);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(227, 79);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "KDV Oranı";
            // 
            // textBoxKDVDahilToplam
            // 
            this.textBoxKDVDahilToplam.Location = new System.Drawing.Point(108, 43);
            this.textBoxKDVDahilToplam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKDVDahilToplam.Name = "textBoxKDVDahilToplam";
            this.textBoxKDVDahilToplam.ReadOnly = true;
            this.textBoxKDVDahilToplam.Size = new System.Drawing.Size(114, 27);
            this.textBoxKDVDahilToplam.TabIndex = 2;
            // 
            // textBoxGenelToplam
            // 
            this.textBoxGenelToplam.Location = new System.Drawing.Point(105, 8);
            this.textBoxGenelToplam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGenelToplam.Name = "textBoxGenelToplam";
            this.textBoxGenelToplam.ReadOnly = true;
            this.textBoxGenelToplam.Size = new System.Drawing.Size(114, 27);
            this.textBoxGenelToplam.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Genel Toplam";
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(131, 193);
            this.textBoxAdet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(60, 27);
            this.textBoxAdet.TabIndex = 15;
            this.textBoxAdet.TextChanged += new System.EventHandler(this.textBoxAdet_TextChanged);
            this.textBoxAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAdet_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adet";
            // 
            // textBoxozellik
            // 
            this.textBoxozellik.Location = new System.Drawing.Point(12, 291);
            this.textBoxozellik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxozellik.Name = "textBoxozellik";
            this.textBoxozellik.Size = new System.Drawing.Size(137, 27);
            this.textBoxozellik.TabIndex = 17;
            this.textBoxozellik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxozellik_KeyPress_1);
            // 
            // listBoxozellik
            // 
            this.listBoxozellik.FormattingEnabled = true;
            this.listBoxozellik.ItemHeight = 20;
            this.listBoxozellik.Location = new System.Drawing.Point(14, 321);
            this.listBoxozellik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxozellik.Name = "listBoxozellik";
            this.listBoxozellik.Size = new System.Drawing.Size(137, 124);
            this.listBoxozellik.TabIndex = 18;
            this.listBoxozellik.SelectedIndexChanged += new System.EventHandler(this.listBoxozellik_SelectedIndexChanged_1);
            this.listBoxozellik.DoubleClick += new System.EventHandler(this.listBoxozellik_DoubleClick_1);
            // 
            // radioButtonTRY
            // 
            this.radioButtonTRY.AutoSize = true;
            this.radioButtonTRY.Location = new System.Drawing.Point(14, 133);
            this.radioButtonTRY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTRY.Name = "radioButtonTRY";
            this.radioButtonTRY.Size = new System.Drawing.Size(52, 24);
            this.radioButtonTRY.TabIndex = 19;
            this.radioButtonTRY.TabStop = true;
            this.radioButtonTRY.Text = "TRY";
            this.radioButtonTRY.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSD
            // 
            this.radioButtonUSD.AutoSize = true;
            this.radioButtonUSD.Location = new System.Drawing.Point(72, 137);
            this.radioButtonUSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonUSD.Name = "radioButtonUSD";
            this.radioButtonUSD.Size = new System.Drawing.Size(56, 24);
            this.radioButtonUSD.TabIndex = 20;
            this.radioButtonUSD.TabStop = true;
            this.radioButtonUSD.Text = "USD";
            this.radioButtonUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonEUR
            // 
            this.radioButtonEUR.AutoSize = true;
            this.radioButtonEUR.Location = new System.Drawing.Point(134, 137);
            this.radioButtonEUR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonEUR.Name = "radioButtonEUR";
            this.radioButtonEUR.Size = new System.Drawing.Size(54, 24);
            this.radioButtonEUR.TabIndex = 21;
            this.radioButtonEUR.TabStop = true;
            this.radioButtonEUR.Text = "EUR";
            this.radioButtonEUR.UseVisualStyleBackColor = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 445);
            this.Controls.Add(this.radioButtonEUR);
            this.Controls.Add(this.radioButtonUSD);
            this.Controls.Add(this.radioButtonTRY);
            this.Controls.Add(this.listBoxozellik);
            this.Controls.Add(this.textBoxozellik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAdet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxKDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBirim);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProduct";
            this.Text = "FormProductcs";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxPrice;
        private Label label2;
        private Button buttonSave;
        private ComboBox comboBoxBirim;
        private Label label3;
        private DateTimePicker dateTimePickerTarih;
        private Label label4;
        private ComboBox comboBoxKDV;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBoxBarkod;
        private CheckBox checkBoxAktif;
        private GroupBox groupBox1;
        private TextBox textBoxGenelToplam;
        private Label label6;
        private TextBox textBoxAdet;
        private Label label7;
        private Label label8;
        private TextBox textBoxKDVDahilToplam;
        private TextBox textBoxozellik;
        private ListBox listBoxozellik;
        private RadioButton radioButtonTRY;
        private RadioButton radioButtonUSD;
        private RadioButton radioButtonEUR;
    }
}