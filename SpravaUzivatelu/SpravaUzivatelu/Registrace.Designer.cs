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
            this.labelregistrace = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelregistrace
            // 
            this.labelregistrace.AutoSize = true;
            this.labelregistrace.Location = new System.Drawing.Point(346, 85);
            this.labelregistrace.Name = "labelregistrace";
            this.labelregistrace.Size = new System.Drawing.Size(76, 13);
            this.labelregistrace.TabIndex = 1;
            this.labelregistrace.Text = "REGISTRACE";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(334, 145);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(100, 20);
            this.textboxusername.TabIndex = 2;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(334, 202);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(100, 20);
            this.textboxpassword.TabIndex = 3;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(356, 117);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(56, 13);
            this.labelusername.TabIndex = 4;
            this.labelusername.Text = "username:";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(356, 177);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(55, 13);
            this.labelpassword.TabIndex = 5;
            this.labelpassword.Text = "password:";
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(319, 240);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(115, 13);
            this.labellogin.TabIndex = 6;
            this.labellogin.Text = "Už máte účet? LOG IN";
            this.labellogin.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Registrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.labelregistrace);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registrace";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registrace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelregistrace;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

