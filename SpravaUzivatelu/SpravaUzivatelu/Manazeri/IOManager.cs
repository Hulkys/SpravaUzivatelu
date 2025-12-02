using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUzivatelu.Manazeri
{
    internal class IOManager
    {
        private static readonly string path = Path.Combine(AppContext.BaseDirectory, "Z:\\PRG 3\\SpravaUzivatelu");

        public static void SaveUsers(List<Uzivatel> users)
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public static List<Uzivatel> LoadUsers()
        {
            if (!File.Exists(path)) return new List<Uzivatel>();
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Uzivatel>>(json) ?? new List<Uzivatel>();
        }
    }
}
