using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpravaUzivatelu.Manazeri
{
    internal class IOManager
    {
        private static readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

        public static void SaveUsers(List<Uzivatel> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Uzivatel> LoadUsers()
        {
            if (!File.Exists(path)) return new List<Uzivatel>();
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Uzivatel>>(json) ?? new List<Uzivatel>();
        }
    }
}
