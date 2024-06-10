using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatOOP
{
    public class Profesor
    {
        public int id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godine { get; set;  }
        public string ImePrezime => $"{Ime} {Prezime}";

        public Profesor(string ime, string prezime, int godine)
        {
            Ime = ime;
            Prezime = prezime;
            Godine = godine;
        }
    }
}
