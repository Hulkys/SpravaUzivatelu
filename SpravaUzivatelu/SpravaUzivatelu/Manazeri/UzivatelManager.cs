using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpravaUzivatelu.Manazeri
{
    internal class UzivatelManager
    {
        //ukládá všechny uživatele v paměti - spravuje to manager (registrace, přihlášení, admin)
        private List<Uzivatel> users;

        public UzivatelManager() //spustí se automaticky při vytvoření účtu. 
        {
            //načte uživatele ze souboru
            users = IOManager.LoadUsers();


            //zkontroluje, jestli už existuje admin
            if (!users.Any(u => u.Role == "admin"))
            {
                //Pokud není v seznamu žádný admin, vytvoří se automaticky
                users.Add(new Uzivatel
                {
                    Name = "admin",
                    PasswordHash = Hash("admin"),
                    Role = "admin",
                    Registered = DateTime.Now
                });
                IOManager.SaveUsers(users);
            } //aplikace má vždy minimálně jednoho administrátora
        }

        
    }
}
