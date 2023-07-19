namespace WinFormsApp11
{
    partial class FormProductList
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
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.StokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KdvOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.AllowUserToAddRows = false;
            this.dataGridViewUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewUrunler.AllowUserToOrderColumns = true;
            this.dataGridViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokAdi,
            this.KdvOrani,
            this.Fiyat,
            this.OlcuBirimi,
            this.Adet,
            this.ParaBirimi,
            this.Barkod,
            this.Id});
            this.dataGridViewUrunler.Location = new System.Drawing.Point(0, 68);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.ReadOnly = true;
            this.dataGridViewUrunler.RowTemplate.Height = 29;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(1137, 372);
            this.dataGridViewUrunler.TabIndex = 0;
            // 
            // StokAdi
            // 
            this.StokAdi.HeaderText = "STOK ADI";
            this.StokAdi.Name = "StokAdi";
            this.StokAdi.ReadOnly = true;
            // 
            // KdvOrani
            // 
            this.KdvOrani.HeaderText = "KDV (%)";
            this.KdvOrani.Name = "KdvOrani";
            this.KdvOrani.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "FİYAT";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // OlcuBirimi
            // 
            this.OlcuBirimi.HeaderText = "ÖLÇÜ BİRİMİ";
            this.OlcuBirimi.Name = "OlcuBirimi";
            this.OlcuBirimi.ReadOnly = true;
            // 
            // Adet
            // 
            this.Adet.HeaderText = "ADET";
            this.Adet.Name = "Adet";
            this.Adet.ReadOnly = true;
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.HeaderText = "PARA BİRİMİ";
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.ReadOnly = true;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "BARKOD";
            this.Barkod.Name = "Barkod";
            this.Barkod.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(12, 12);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(91, 36);
            this.buttonDuzenle.TabIndex = 1;
            this.buttonDuzenle.Text = "Düzenle";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(109, 12);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(102, 36);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 441);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.dataGridViewUrunler);
            this.Name = "FormProductList";
            this.Text = "FormProductList";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewUrunler;
        private DataGridViewTextBoxColumn StokAdi;
        private DataGridViewTextBoxColumn KdvOrani;
        private DataGridViewTextBoxColumn Fiyat;
        private DataGridViewTextBoxColumn OlcuBirimi;
        private DataGridViewTextBoxColumn Adet;
        private DataGridViewTextBoxColumn ParaBirimi;
        private DataGridViewTextBoxColumn Barkod;
        private DataGridViewTextBoxColumn Id;
        private Button buttonDuzenle;
        private Button buttonSil;
    }
}