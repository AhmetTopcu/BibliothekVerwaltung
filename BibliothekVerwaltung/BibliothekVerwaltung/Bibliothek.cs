using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
