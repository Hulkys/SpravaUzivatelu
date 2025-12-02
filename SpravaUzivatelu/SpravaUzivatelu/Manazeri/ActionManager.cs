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
            if (user == null || string.IsNullOrWhiteSpace(newPassword)) return false; //pokud uzivatel neexistuje nenastavi heslo

            // SHA
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(newPassword));
                user.PasswordHash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
            IOManager.SaveUsers(userManager.GetAll());
            return true;
        }

        public bool DeleteUser(Uzivatel admin, string name) //smaze uzivatele
        {
            if (admin == null) return false;
            if (!admin.Role.Equals("admin")) return false;

            var users = userManager.GetAll();
            var target = users.FirstOrDefault(u => u.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
            if (target == null) return false;
            if (target.Role == "admin") return false;

            users.Remove(target);
            IOManager.SaveUsers(users);
            return true;
        }
    }
}
