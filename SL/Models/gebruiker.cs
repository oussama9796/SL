using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL
{
    internal class Gebruiker
    {
        private int Id { get; set; }
        private String gebruikersnaam { get; set; }
        private String wachtwoord { get; set; }

        public Gebruiker(int id, String gebruikersnaam, String wachtwoord)
        {
            Id = id;
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
        }

    }
}
