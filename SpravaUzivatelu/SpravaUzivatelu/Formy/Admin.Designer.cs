namespace SpravaUzivatelu
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelregistrace = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkedListBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.buttonZpetLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(355, 229);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(95, 47);
            this.btnDeleteSelected.TabIndex = 28;
            this.btnDeleteSelected.Text = "Smazat vybrané";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "smazat uživatele";
            // 
            // labelregistrace
            // 
            this.labelregistrace.AutoSize = true;
            this.labelregistrace.Font = new System.Drawing.Font("Segoe UI Historic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregistrace.Location = new System.Drawing.Point(341, 24);
            this.labelregistrace.Name = "labelregistrace";
            this.labelregistrace.Size = new System.Drawing.Size(136, 46);
            this.labelregistrace.TabIndex = 24;
            this.labelregistrace.Text = "ADMIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(809, 467);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Location = new System.Drawing.Point(346, 115);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxUsers.TabIndex = 29;
            // 
            // buttonZpetLogin
            // 
            this.buttonZpetLogin.Location = new System.Drawing.Point(694, 392);
            this.buttonZpetLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZpetLogin.Name = "buttonZpetLogin";
            this.buttonZpetLogin.Size = new System.Drawing.Size(95, 47);
            this.buttonZpetLogin.TabIndex = 30;
            this.buttonZpetLogin.Text = "Zpět na Login";
            this.buttonZpetLogin.UseVisualStyleBackColor = true;
            this.buttonZpetLogin.Click += new System.EventHandler(this.buttonZpetLogin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZpetLogin);
            this.Controls.Add(this.checkedListBoxUsers);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelregistrace);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Admin";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelregistrace;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsers;
        private System.Windows.Forms.Button buttonZpetLogin;
    }
}