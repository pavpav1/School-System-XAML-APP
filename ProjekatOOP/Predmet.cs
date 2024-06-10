using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatOOP
{
    public class Predmet
    { 
        public string Naziv { get; set; } 
        public Predmet(string naziv)
        {
            Naziv = naziv; 
        }
    }
}
