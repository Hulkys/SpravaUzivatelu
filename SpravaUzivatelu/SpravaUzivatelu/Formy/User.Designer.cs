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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxZmenitHeslo = new System.Windows.Forms.TextBox();
            this.labelZmenitHeslo = new System.Windows.Forms.Label();
            this.btnZmenit = new System.Windows.Forms.Button();
            this.buttonZpetLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.textBoxZmenitHeslo.Location = new System.Drawing.Point(286, 194);
            this.textBoxZmenitHeslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZmenitHeslo.Name = "textBoxZmenitHeslo";
            this.textBoxZmenitHeslo.Size = new System.Drawing.Size(211, 20);
            this.textBoxZmenitHeslo.TabIndex = 21;
            // 
            // labelZmenitHeslo
            // 
            this.labelZmenitHeslo.AutoSize = true;
            this.labelZmenitHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZmenitHeslo.Location = new System.Drawing.Point(322, 88);
            this.labelZmenitHeslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelZmenitHeslo.Name = "labelZmenitHeslo";
            this.labelZmenitHeslo.Size = new System.Drawing.Size(133, 25);
            this.labelZmenitHeslo.TabIndex = 22;
            this.labelZmenitHeslo.Text = "změnit heslo";
            // 
            // btnZmenit
            // 
            this.btnZmenit.Location = new System.Drawing.Point(338, 236);
            this.btnZmenit.Margin = new System.Windows.Forms.Padding(2);
            this.btnZmenit.Name = "btnZmenit";
            this.btnZmenit.Size = new System.Drawing.Size(95, 47);
            this.btnZmenit.TabIndex = 23;
            this.btnZmenit.Text = "Změnit";
            this.btnZmenit.UseVisualStyleBackColor = true;
            this.btnZmenit.Click += new System.EventHandler(this.btnZmenit_Click);
            // 
            // buttonZpetLogin
            // 
            this.buttonZpetLogin.Location = new System.Drawing.Point(329, 316);
            this.buttonZpetLogin.Name = "buttonZpetLogin";
            this.buttonZpetLogin.Size = new System.Drawing.Size(111, 34);
            this.buttonZpetLogin.TabIndex = 28;
            this.buttonZpetLogin.Text = "Zpět na login";
            this.buttonZpetLogin.UseVisualStyleBackColor = true;
            this.buttonZpetLogin.Click += new System.EventHandler(this.buttonZpetLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(332, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(286, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "nové heslo:";
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentUser.Location = new System.Drawing.Point(503, 26);
            this.labelCurrentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(0, 39);
            this.labelCurrentUser.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(449, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "---";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZpetLogin);
            this.Controls.Add(this.btnZmenit);
            this.Controls.Add(this.labelZmenitHeslo);
            this.Controls.Add(this.textBoxZmenitHeslo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "User";
            this.Text = "UzivatelskeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxZmenitHeslo;
        private System.Windows.Forms.Label labelZmenitHeslo;
        private System.Windows.Forms.Button btnZmenit;
        private System.Windows.Forms.Button buttonZpetLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label label3;
    }
}