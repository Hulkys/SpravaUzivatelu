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
        public User()
        {
            InitializeComponent();
        }

        private void btnZmenit_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxZmenitHeslo.Text;

            //jestli neco zadal
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Zadejte nové heslo.");
                return;
            }
            UzivatelManager um = new UzivatelManager();
            ActionManager actionManager = new ActionManager(um);

            bool ok = actionManager.ChangePassword(Program.LoggedUser, newPassword);

            if (ok)
            {
                MessageBox.Show("Heslo bylo úspěšně změněno.");
                textBoxZmenitHeslo.Clear();
            }
            else
            {
                MessageBox.Show("Heslo se nepodařilo změnit.");
            }
        }
    }
}
