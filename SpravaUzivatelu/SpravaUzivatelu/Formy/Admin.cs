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
    public partial class Admin : Form
    {
        private Uzivatel currentAdmin;
        private UserManager userManager;
        public Admin()
        {
            InitializeComponent();
            userManager = new UserManager();
            currentAdmin = Program.LoggedUser;

            LoadUsersToList();
        }
        private void LoadUsersToList()
        {
            checkedListBoxUsers.Items.Clear();

            foreach (var u in userManager.GetAll())
            {
                // zobrazíme jméno + roli
                checkedListBoxUsers.Items.Add($"{u.Name} ({u.Role})");
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (checkedListBoxUsers.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vyberte uživatele k smazání.");
                return;
            }

            var allUsers = userManager.GetAll();

            // iterujeme přes všechny zaškrtnuté položky
            foreach (var item in checkedListBoxUsers.CheckedItems.Cast<string>().ToList())
            {
                string userName = item.Split(' ')[0]; // předpokládáme formát "jmeno (role)"

                if (userName.Equals(currentAdmin.Name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Nemůžete smazat sami sebe!");
                    continue;
                }

                var userToDelete = allUsers.FirstOrDefault(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));
                if (userToDelete != null)
                {
                    if (userToDelete.Role == "admin")
                    {
                        MessageBox.Show($"Nemůžete smazat admina {userToDelete.Name}.");
                        continue;
                    }

                    allUsers.Remove(userToDelete);
                }
            }

            // uložíme změny
            IOManager.SaveUsers(allUsers);

            MessageBox.Show("Vybraní uživatelé byli smazáni.");
            LoadUsersToList(); // aktualizujeme seznam
        }

        private void buttonZpetLogin_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide(); // zavře Registraci
        }
    }
}
