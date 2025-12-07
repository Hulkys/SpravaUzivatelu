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
    public partial class User : Form
    {
        private Uzivatel currentUser;
        private UserManager userManager;
        public User()
        {
            InitializeComponent();
            currentUser = Program.LoggedUser;
            userManager = new UserManager();
            labelCurrentUser.Text = currentUser.Name;
        }

        private void btnZmenit_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxZmenitHeslo.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Zadejte nové heslo.");
                return;
            }

            // Najdeme uživatele v seznamu
            var allUsers = userManager.GetAll();
            var userToChange = allUsers.FirstOrDefault(u => u.Name == currentUser.Name);

            if (userToChange != null)
            {
                // Změníme hash hesla na nové
                using (var sha = System.Security.Cryptography.SHA256.Create())
                {
                    var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(newPassword));
                    userToChange.PasswordHash = BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
                }

                // Uložíme celý seznam uživatelů
                IOManager.SaveUsers(allUsers);

                MessageBox.Show("Heslo bylo úspěšně změněno!");
                textBoxZmenitHeslo.Clear();
            }
            else
            {
                MessageBox.Show("Uživatel nebyl nalezen.");
            }
        }

        private void buttonZpetLogin_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide(); // zavře Registraci
        }
    }
}
