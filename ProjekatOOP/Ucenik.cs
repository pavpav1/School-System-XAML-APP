using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatOOP
{
    public class Ucenik
    {
        public int id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime => $"{Ime} {Prezime}";

        public Ucenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}
