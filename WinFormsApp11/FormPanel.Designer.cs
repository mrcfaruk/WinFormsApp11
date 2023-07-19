namespace WinFormsApp11
{
    partial class FormPanel
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(14, 372);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(50, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLogout,
            this.ürünEkleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(486, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemLogout
            // 
            this.ToolStripMenuItemLogout.Name = "ToolStripMenuItemLogout";
            this.ToolStripMenuItemLogout.Size = new System.Drawing.Size(133, 24);
            this.ToolStripMenuItemLogout.Text = "Kullanıcı Değiştir";
            this.ToolStripMenuItemLogout.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünleriListeleToolStripMenuItem,
            this.ürünEkleToolStripMenuItem1});
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ürünEkleToolStripMenuItem.Text = "Ürün";
            // 
            // ürünleriListeleToolStripMenuItem
            // 
            this.ürünleriListeleToolStripMenuItem.Name = "ürünleriListeleToolStripMenuItem";
            this.ürünleriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ürünleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            this.ürünleriListeleToolStripMenuItem.Click += new System.EventHandler(this.ürünleriListeleToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem1
            // 
            this.ürünEkleToolStripMenuItem1.Name = "ürünEkleToolStripMenuItem1";
            this.ürünEkleToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.ürünEkleToolStripMenuItem1.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem1.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem1_Click);
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 425);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPanel";
            this.Text = "Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPanel_FormClosed);
            this.Load += new System.EventHandler(this.FormPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUsername;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItemLogout;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünleriListeleToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem1;
    }
}