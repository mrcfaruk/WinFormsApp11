namespace WinFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlus = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.textBoxPlus = new System.Windows.Forms.TextBox();
            this.textBoxMinus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(309, 140);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(28, 30);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(356, 148);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 15);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "0";
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(387, 141);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(28, 29);
            this.buttonMinus.TabIndex = 2;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // textBoxPlus
            // 
            this.textBoxPlus.Location = new System.Drawing.Point(309, 98);
            this.textBoxPlus.Name = "textBoxPlus";
            this.textBoxPlus.Size = new System.Drawing.Size(28, 23);
            this.textBoxPlus.TabIndex = 3;
            
            // 
            // textBoxMinus
            // 
            this.textBoxMinus.Location = new System.Drawing.Point(387, 98);
            this.textBoxMinus.Name = "textBoxMinus";
            this.textBoxMinus.Size = new System.Drawing.Size(28, 23);
            this.textBoxMinus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMinus);
            this.Controls.Add(this.textBoxPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPlus;
        private Label labelCount;
        private Button buttonMinus;
        private TextBox textBoxPlus;
        private TextBox textBoxMinus;
    }
}