namespace SpravaUzivatelu
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.labelRegistrace = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxZmenitHeslo = new System.Windows.Forms.TextBox();
            this.labelZmenitHeslo = new System.Windows.Forms.Label();
            this.btnZmenit = new System.Windows.Forms.Button();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.textboxusername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegistrace
            // 
            this.labelRegistrace.AutoSize = true;
            this.labelRegistrace.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrace.Location = new System.Drawing.Point(357, 30);
            this.labelRegistrace.Name = "labelRegistrace";
            this.labelRegistrace.Size = new System.Drawing.Size(52, 21);
            this.labelRegistrace.TabIndex = 19;
            this.labelRegistrace.Text = "USER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(809, 467);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxZmenitHeslo
            // 
            this.textBoxZmenitHeslo.Location = new System.Drawing.Point(274, 242);
            this.textBoxZmenitHeslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZmenitHeslo.Name = "textBoxZmenitHeslo";
            this.textBoxZmenitHeslo.Size = new System.Drawing.Size(222, 20);
            this.textBoxZmenitHeslo.TabIndex = 21;
            // 
            // labelZmenitHeslo
            // 
            this.labelZmenitHeslo.AutoSize = true;
            this.labelZmenitHeslo.Location = new System.Drawing.Point(350, 214);
            this.labelZmenitHeslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelZmenitHeslo.Name = "labelZmenitHeslo";
            this.labelZmenitHeslo.Size = new System.Drawing.Size(65, 13);
            this.labelZmenitHeslo.TabIndex = 22;
            this.labelZmenitHeslo.Text = "změnit heslo";
            // 
            // btnZmenit
            // 
            this.btnZmenit.Location = new System.Drawing.Point(334, 280);
            this.btnZmenit.Margin = new System.Windows.Forms.Padding(2);
            this.btnZmenit.Name = "btnZmenit";
            this.btnZmenit.Size = new System.Drawing.Size(95, 47);
            this.btnZmenit.TabIndex = 23;
            this.btnZmenit.Text = "Změnit";
            this.btnZmenit.UseVisualStyleBackColor = true;
            this.btnZmenit.Click += new System.EventHandler(this.btnZmenit_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpassword.Location = new System.Drawing.Point(351, 125);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(64, 13);
            this.labelpassword.TabIndex = 27;
            this.labelpassword.Text = "password:";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelusername.Location = new System.Drawing.Point(350, 65);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(65, 13);
            this.labelusername.TabIndex = 26;
            this.labelusername.Text = "username:";
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(334, 153);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(100, 20);
            this.textboxpassword.TabIndex = 25;
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(334, 92);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(100, 20);
            this.textboxusername.TabIndex = 24;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.btnZmenit);
            this.Controls.Add(this.labelZmenitHeslo);
            this.Controls.Add(this.textBoxZmenitHeslo);
            this.Controls.Add(this.labelRegistrace);
            this.Controls.Add(this.pictureBox2);
            this.Name = "User";
            this.Text = "UzivatelskeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRegistrace;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxZmenitHeslo;
        private System.Windows.Forms.Label labelZmenitHeslo;
        private System.Windows.Forms.Button btnZmenit;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.TextBox textboxusername;
    }
}