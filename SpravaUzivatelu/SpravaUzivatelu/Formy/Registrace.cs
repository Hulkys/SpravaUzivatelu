using SpravaUzivatelu.Manazeri;
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
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide(); // zavře Registraci
        }
        private void Registrace_Load(object sender, EventArgs e)
        {


            // Nastavení stylu tlačítka
            buttonprihlasit.FlatStyle = FlatStyle.Flat;
            buttonprihlasit.FlatAppearance.BorderColor = Color.Black; // černý okraj
            buttonprihlasit.FlatAppearance.BorderSize = 2; // tloušťka okraje

            // Počáteční barva tlačítka
            buttonprihlasit.BackColor = Color.White;

            // Najetí myší – světlejší modrá
            buttonprihlasit.MouseEnter += (s, eArgs) =>
            {
                buttonprihlasit.BackColor = Color.LightBlue;
            };

            // Odjetí myší – zpět šedá
            buttonprihlasit.MouseLeave += (s, eArgs) =>
            {
                buttonprihlasit.BackColor = Color.White;
            };
        }

        private void buttonprihlasit_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text;
            string password = textboxpassword.Text;

            UzivatelManager userManager = new UzivatelManager();
            bool success = userManager.Register(username, password);

            if (success)
            {
                MessageBox.Show("Registrace proběhla úspěšně.");
                // Po registraci otevřeme Login form
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide(); // zavře registraci
            }
            else
            {
                MessageBox.Show("Registrace se nepodařila. Jméno je již použito nebo je neplatné.");
            }
        }
    }
    
}
