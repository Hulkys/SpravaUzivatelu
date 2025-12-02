using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpravaUzivatelu
{
    public partial class Registrace : Form
    {
        public Registrace()
        {
            InitializeComponent();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {

        }

        private void Registrace_Load(object sender, EventArgs e)
        {
            labelregistrace.ForeColor = Color.White;
            labelusername.ForeColor = Color.White;
            labelpassword.ForeColor = Color.White;
            labellogin.ForeColor = Color.White;

            labelregistrace.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            labelusername.Font = new Font("Segoe UI", 10);
            labelpassword.Font = new Font("Segoe UI", 10);
            labellogin.Font = new Font("Segoe UI", 10, FontStyle.Underline);

            // === TEXTBOXY ===
            StyleTextBox(textboxusername);
            StyleTextBox(textboxpassword);

            // === LOGIN jako klikací text ===
            labellogin.Cursor = Cursors.Hand;
            labellogin.MouseEnter += (s, ev) => labellogin.ForeColor = Color.FromArgb(230, 230, 230);
            labellogin.MouseLeave += (s, ev) => labellogin.ForeColor = Color.White;
        }
        private void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.FromArgb(40, 255, 255, 255);
            txt.ForeColor = Color.White;
            txt.Font = new Font("Segoe UI", 12);
            txt.Padding = new Padding(5);

            txt.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.White, 2))
                {
                    Rectangle rect = new Rectangle(0, 0, txt.Width - 1, txt.Height - 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
        }


    }
}
