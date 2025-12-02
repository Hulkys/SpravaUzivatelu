namespace SpravaUzivatelu
{
    partial class Registrace
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrace));
            this.lblNazev = new System.Windows.Forms.Label();
            this.lblRegistrace = new System.Windows.Forms.Label();
            this.tbUzivatelskeJmeno = new System.Windows.Forms.TextBox();
            this.tbHeslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazev
            // 
            this.lblNazev.AutoSize = true;
            this.lblNazev.Location = new System.Drawing.Point(12, 9);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(113, 13);
            this.lblNazev.TabIndex = 0;
            this.lblNazev.Text = "SPRÁVA UŽIVATELŮ";
            this.lblNazev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistrace
            // 
            this.lblRegistrace.AutoSize = true;
            this.lblRegistrace.Location = new System.Drawing.Point(297, 100);
            this.lblRegistrace.Name = "lblRegistrace";
            this.lblRegistrace.Size = new System.Drawing.Size(76, 13);
            this.lblRegistrace.TabIndex = 1;
            this.lblRegistrace.Text = "REGISTRACE";
            // 
            // tbUzivatelskeJmeno
            // 
            this.tbUzivatelskeJmeno.Location = new System.Drawing.Point(300, 154);
            this.tbUzivatelskeJmeno.Name = "tbUzivatelskeJmeno";
            this.tbUzivatelskeJmeno.Size = new System.Drawing.Size(100, 20);
            this.tbUzivatelskeJmeno.TabIndex = 2;
            // 
            // tbHeslo
            // 
            this.tbHeslo.Location = new System.Drawing.Point(300, 224);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(100, 20);
            this.tbHeslo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "password:";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Location = new System.Drawing.Point(297, 273);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(115, 13);
            this.lblLogIn.TabIndex = 6;
            this.lblLogIn.Text = "Už máte účet? LOG IN";
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Registrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHeslo);
            this.Controls.Add(this.tbUzivatelskeJmeno);
            this.Controls.Add(this.lblRegistrace);
            this.Controls.Add(this.lblNazev);
            this.Name = "Registrace";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazev;
        private System.Windows.Forms.Label lblRegistrace;
        private System.Windows.Forms.TextBox tbUzivatelskeJmeno;
        private System.Windows.Forms.TextBox tbHeslo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

