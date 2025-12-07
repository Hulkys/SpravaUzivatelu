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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpravaUzivatelu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void buttonprihlasit_Click(object sender, EventArgs e)
        {
            string jmeno = textboxusername.Text;
            string heslo = textboxpassword.Text;
            UzivatelManager userManager = new UzivatelManager();
            var uzivatel = userManager.Login(jmeno, heslo);

            if (uzivatel != null)
            {
                Program.LoggedUser = uzivatel;
                User f = new User();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Špatné jméno nebo heslo.");
            }
        }

        private void labelNaRegistrovani_Click(object sender, EventArgs e)
        {
            Registrace RegisterForm = new Registrace();
            RegisterForm.Show();
            this.Hide(); // zavře Registraci
        }
    }
}
