using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekVerwaltung
{
    class Spiel
    {
        public Spiel(string Name2,int Installationsdatum2,int ZuletztGespielt2,string Kategorie2,string Publisher2,string Pfad2)
        {
            _Name = Name2;
            _Pfad = Pfad2;
            _Installationsdatum = Installationsdatum2;
            _ZuletztGespielt = ZuletztGespielt2;
            _Kategorie = Kategorie2;
            _Publisher = Publisher2;
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
        private int _Installationsdatum;
        public int Installationsdatum
        {
            get { return _Installationsdatum; }
        }
        private int _ZuletztGespielt;
        public int ZuletztGespielt
        {
            get { return _ZuletztGespielt; }
        }
        private string _Kategorie;
        public string Kategorie
        { get { return _Kategorie; } }
        private string _Publisher;
        public string Publisher
        { get { return _Publisher; } }

    }
}
