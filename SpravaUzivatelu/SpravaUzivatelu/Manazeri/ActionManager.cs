using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUzivatelu.Manazeri
{
    internal class ActionManager
    {
        private readonly UzivatelManager userManager;

        public ActionManager(UzivatelManager um)
        {
            userManager = um;
        }

        public bool ChangePassword(Uzivatel user, string newPassword) //nacte usera a nove heslo
        {
            if (user == null || string.IsNullOrWhiteSpace(newPassword)) return false; //pokud uzivatel neexistuje nebo napsat nic do toho nenastavi heslo

            // SHA
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(newPassword));
                user.PasswordHash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
            IOManager.SaveUsers(userManager.GetAll());//uloží seznam s novým heslem
            return true;//finito
        }

        public bool DeleteUser(Uzivatel admin, string name) //smaze uzivatele
        {
            if (admin == null) return false; //pokud nemá žádnou rolu
            if (!admin.Role.Equals("admin")) return false; //pokud má roli "admin"
            //DÁL SE DOSTANE JEN ADMIN UŽ
            var users = userManager.GetAll(); //vezme všechny uživatele v JSONu
            var vybrany = users.FirstOrDefault(u => u.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));//koukne jestli je nějaký uživ. s tím jménem
            if (vybrany == null) return false; //pokud neexistuje, tak se nic nesmaže
            if (vybrany.Role == "admin") return false;//pokud role vybraneho uživatele ke smazání je admin, nesmaže se

            users.Remove(vybrany);//odebere vybraneho uživatele
            IOManager.SaveUsers(users);//uloží nově seznam bez danného uživatele
            return true;//finito
        }
    }
}
