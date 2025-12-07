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

            UserManager userManager = new UserManager();
            var uzivatel = userManager.Login(jmeno, heslo);

            if (uzivatel != null)
            {
                Program.LoggedUser = uzivatel; // uložíme aktuálního uživatele

                if (uzivatel.Role == "admin")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else
                {
                    User userForm = new User();
                    userForm.Show();
                }

                this.Hide(); // skryje login form
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
