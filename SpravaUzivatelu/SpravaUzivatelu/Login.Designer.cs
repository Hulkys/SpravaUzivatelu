namespace SpravaUzivatelu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonprihlasit = new System.Windows.Forms.Button();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.labelregistrace = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonprihlasit
            // 
            this.buttonprihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonprihlasit.Location = new System.Drawing.Point(372, 215);
            this.buttonprihlasit.Name = "buttonprihlasit";
            this.buttonprihlasit.Size = new System.Drawing.Size(87, 37);
            this.buttonprihlasit.TabIndex = 17;
            this.buttonprihlasit.Text = "Registrovat";
            this.buttonprihlasit.UseVisualStyleBackColor = true;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labellogin.Location = new System.Drawing.Point(347, 269);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(135, 13);
            this.labellogin.TabIndex = 15;
            this.labellogin.Text = "Už máte účet? LOG IN";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpassword.Location = new System.Drawing.Point(381, 148);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(64, 13);
            this.labelpassword.TabIndex = 14;
            this.labelpassword.Text = "password:";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelusername.Location = new System.Drawing.Point(380, 73);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(65, 13);
            this.labelusername.TabIndex = 13;
            this.labelusername.Text = "username:";
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(364, 178);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(100, 20);
            this.textboxpassword.TabIndex = 12;
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(364, 109);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(100, 20);
            this.textboxusername.TabIndex = 11;
            // 
            // labelregistrace
            // 
            this.labelregistrace.AutoSize = true;
            this.labelregistrace.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregistrace.Location = new System.Drawing.Point(360, 32);
            this.labelregistrace.Name = "labelregistrace";
            this.labelregistrace.Size = new System.Drawing.Size(108, 21);
            this.labelregistrace.TabIndex = 10;
            this.labelregistrace.Text = "REGISTRACE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonprihlasit);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.labelregistrace);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonprihlasit;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label labelregistrace;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}