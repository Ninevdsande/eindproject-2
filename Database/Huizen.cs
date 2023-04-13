using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eindproject_2.Database
{
    public class Huizen
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string type { get; set; }    
        public string locatie { get; set; } 
        public string beschrijving_kort { get; set; }
        public string beschrijving_lang { get; set; }
        public string datum_begin { get; set; }
        public string datum_eind { get; set; }
        public string afbeelding { get; set; }
        public string prijs { get; set; }
    }
}
