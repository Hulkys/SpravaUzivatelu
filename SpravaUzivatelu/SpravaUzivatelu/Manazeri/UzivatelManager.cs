using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


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
        private string Hash(string input) //vytvoření hashování
        {//hashovací algoritmus

            using (var sha = SHA256.Create()) //Vytvoří SHA256 hashovací algoritmus
            {
                var bytes = sha.ComputeHash /*Vypočítá has (ten sha.ComputeHash)*/(Encoding.UTF8.GetBytes(input)); //převede to na bajty
                return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant(); //heslo se nikdy neukládá v čitelné formě, pouze jako hash.
            }

        }
        //Vrátí celý seznam uživatelů, je to užitečný třeba pro administráta, který sei chce zobrazit registrovaný uživatelé
        public List<Uzivatel> GetAll() => users;
        public bool Register(string name, string password, string role = "user")
        //umožní vytovření novýho uživatle
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password)) return false; //Uživatel musí mít jméno i heslo
            if (users.Any(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase))) //Jméno nesmí být použito dvakrát
                return false;


            //Vytvoření instance nového uživatele
            Uzivatel um = new Uzivatel
            {
                Name = name,
                PasswordHash = Hash(password),
                Role = role,
                Registered = DateTime.Now
                //heslo se ukládá zahashované, ne v čitelné podobě
                //uloží se datum registrace
            };

            //Uložení do seznamu a do souboru
            users.Add(um);
            IOManager.SaveUsers(users);
            return true; //Vrací true, pokud je registrace úspěšná

            
        }
        public Uzivatel Login(string name, string password) //přihlášení uživatele

        {   //Vyhledá uživatele podle jména (bez rozlišení velkých a malých písmen)
            //Porovná hash uloženého hesla s hashem hesla, které zadal uživatel
            return users.FirstOrDefault(u =>
                u.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                u.PasswordHash == Hash(password));

            //Vrátí objekt uživatele, pokud přihlášení proběhlo správně.
            //Vrátí null, pokud je jméno nebo heslo špatně.
        }
    }

}
