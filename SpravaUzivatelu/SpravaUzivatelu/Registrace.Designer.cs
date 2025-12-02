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
            this.buttonprihlasit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelregistrace
            // 
            this.labelregistrace.AutoSize = true;
            this.labelregistrace.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregistrace.Location = new System.Drawing.Point(350, 39);
            this.labelregistrace.Name = "labelregistrace";
            this.labelregistrace.Size = new System.Drawing.Size(108, 21);
            this.labelregistrace.TabIndex = 1;
            this.labelregistrace.Text = "REGISTRACE";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(354, 116);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(100, 20);
            this.textboxusername.TabIndex = 2;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(354, 185);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(100, 20);
            this.textboxpassword.TabIndex = 3;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelusername.Location = new System.Drawing.Point(370, 80);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(65, 13);
            this.labelusername.TabIndex = 4;
            this.labelusername.Text = "username:";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpassword.Location = new System.Drawing.Point(371, 155);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(64, 13);
            this.labelpassword.TabIndex = 5;
            this.labelpassword.Text = "password:";
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labellogin.Location = new System.Drawing.Point(337, 276);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(135, 13);
            this.labellogin.TabIndex = 6;
            this.labellogin.Text = "Už máte účet? LOG IN";
            this.labellogin.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonprihlasit
            // 
            this.buttonprihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonprihlasit.Location = new System.Drawing.Point(362, 222);
            this.buttonprihlasit.Name = "buttonprihlasit";
            this.buttonprihlasit.Size = new System.Drawing.Size(87, 37);
            this.buttonprihlasit.TabIndex = 9;
            this.buttonprihlasit.Text = "Přihlásit";
            this.buttonprihlasit.UseVisualStyleBackColor = true;
            this.buttonprihlasit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonprihlasit);
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
        private System.Windows.Forms.Button buttonprihlasit;
    }
}

