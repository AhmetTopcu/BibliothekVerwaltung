using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekVerwaltung
{
    class Spiel
    {
        public Spiel(string Name2,string Pfad2)
        {
            _Name = Name2;
            _Pfad = Pfad2;
        }
        private string _Name;
        public string Name
        {
            get { return _Name; } 
        }
        private string _Pfad;
        public string Pfad
        {
            get { return _Pfad; }
        }

    }
}
