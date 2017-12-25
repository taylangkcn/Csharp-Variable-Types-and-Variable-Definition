namespace WindowsFormsApp1
{
    partial class Form1
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
            this.sayi_kutusu1 = new WindowsFormsApp1.sayi_kutusu();
            this.sifre_kontrol1 = new WindowsFormsApp1.sifre_kontrol();
            this.SuspendLayout();
            // 
            // sayi_kutusu1
            // 
            this.sayi_kutusu1.Location = new System.Drawing.Point(12, 31);
            this.sayi_kutusu1.Name = "sayi_kutusu1";
            this.sayi_kutusu1.Size = new System.Drawing.Size(179, 36);
            this.sayi_kutusu1.TabIndex = 0;
            // 
            // sifre_kontrol1
            // 
            this.sifre_kontrol1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sifre_kontrol1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_kontrol1.Kul_adi = "ali";
            this.sifre_kontrol1.Location = new System.Drawing.Point(12, 95);
            this.sifre_kontrol1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifre_kontrol1.Name = "sifre_kontrol1";
            this.sifre_kontrol1.Sifre = "123";
            this.sifre_kontrol1.Size = new System.Drawing.Size(346, 108);
            this.sifre_kontrol1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.sifre_kontrol1);
            this.Controls.Add(this.sayi_kutusu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private sayi_kutusu sayi_kutusu1;
        private sifre_kontrol sifre_kontrol1;
    }
}

