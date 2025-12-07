using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SpravaUzivatelu
{
    internal class Uzivatel
    {
        public string Name { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "user";
        public DateTime Registered { get; set; }
    }
}
