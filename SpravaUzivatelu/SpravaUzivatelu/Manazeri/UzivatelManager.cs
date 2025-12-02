using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUzivatelu.Manazeri
{
    internal class UzivatelManager
    {
        private List<Uzivatel> users;

        public UzivatelManager()
        {
            users = IOManager.LoadUsers();

            if (!users.Any(u => u.Role == "admin"))
            {
                users.Add(new Uzivatel
                {
                    Name = "admin",
                    PasswordHash = Hash("admin"),
                    Role = "admin",
                    Registered = DateTime.Now
                });
                IOManager.SaveUsers(users);
            }
        }

        public bool Register(string name, string password, string role = "user")
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password)) return false;
            if (users.Any(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                return false;

            var um = new Uzivatel
            {
                Name = name,
                PasswordHash = Hash(password),
                Role = role,
                Registered = DateTime.Now
            };

            users.Add(um);
            IOManager.SaveUsers(users);
            return true;
        }

        public Uzivatel Login(string name, string password)
        {
            return users.FirstOrDefault(u =>
                u.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                u.PasswordHash == Hash(password));
        }

        private string Hash(string input)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
            }
            
        }

        public List<Uzivatel> GetAll() => users;
    }
}
