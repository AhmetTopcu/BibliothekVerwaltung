using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BibliothekVerwaltung
{
    public class Bibliothek
    {
        public List<string> Liste = new List<string>();

        public void NameHinzufuegen(string InhaltHinzufuegen)
        {
            if (InhaltHinzufuegen == null || InhaltHinzufuegen == "")
            {
                throw new ArgumentOutOfRangeException("Das Spiel " + InhaltHinzufuegen + "kann nicht hinzugefügt werden!");
            }
            else
            {
                Liste.Add(InhaltHinzufuegen);
            }
           
        }

        public void NameEntfernen(string InhaltEntfernen)
        {
            if (InhaltEntfernen == null || InhaltEntfernen == "")
            {
                throw new ArgumentOutOfRangeException("Das Spiel " + InhaltEntfernen + " kann nicht gelöscht werden!");     
            }
            else
            {
                Liste.Remove(InhaltEntfernen);
            }

            
        }
        public void Oeffnen(string sProgramm, string sPfad, int iInstallationsdatum, int iZuletztGespielt, string sKategorie, string sPublisher)
        {
            Liste.Sort((s1, s2) => s1[1].CompareTo(s2[1]));
            Spiel sp = new Spiel(sProgramm,iInstallationsdatum,iZuletztGespielt,sKategorie,sPublisher,sPfad);
            Process.Start(sp.Pfad);
        }   
        

    }
}
