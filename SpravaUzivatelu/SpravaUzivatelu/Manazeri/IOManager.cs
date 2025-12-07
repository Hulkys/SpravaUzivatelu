using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpravaUzivatelu.Manazeri
{
    internal class IOManager
    {
        private static readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

        public static void SaveUsers(List<Uzivatel> users)
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(users);
            File.WriteAllText(path, jsonString);

        }

        public static List<Uzivatel> LoadUsers()
        {
            try
            {
                if (!File.Exists(path))
                {
                    return new List<Uzivatel>();
                }
                var json = File.ReadAllText(path);
                var users = System.Text.Json.JsonSerializer.Deserialize<List<Uzivatel>>(json);
                return users ?? new List<Uzivatel>();
            }
            catch
            {
                return new List<Uzivatel>();
            }
        }
    }
}   
