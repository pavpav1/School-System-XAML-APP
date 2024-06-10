using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatOOP
{
    public class Ocena
    {

        public int Vrednost { get; set; }
        public string Ucenik { get; set; }
        public string Predmet { get; set; } 
        public string Profesor { get; set; }

        public Ocena(int vrednost, string ucenik, string predmet, string profesor)
        {
            Vrednost = vrednost;    
            Ucenik = ucenik;
            Predmet = predmet;  
            Profesor = profesor;    
        }
    }
}
