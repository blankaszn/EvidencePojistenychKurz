using EvidencePojistenychKurz;
using System;
using System.Collections.Generic;
namespace EvidencePojistenychKurz
{
    public class EvidencePojistenych
    {

        List<Pojisteny> pojisteni;

        public EvidencePojistenych()
        {
            pojisteni = new List<Pojisteny>();
        }



        public void PridejPojisteneho(Pojisteny pojistenaOsoba)
        {
            pojisteni.Add(pojistenaOsoba);
        }

        public void VypisVsechnyPojistene()
        {
            foreach (Pojisteny a in pojisteni)
            {
                Console.WriteLine("\n" + a.ToString());
            }
        }

        public void VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojisteny> nalezenyPojisteny = new List<Pojisteny>();

            foreach (Pojisteny a in pojisteni)
            {
                if (a.Jmeno == jmeno && a.Prijmeni == prijmeni)
                {
                    nalezenyPojisteny.Add(a);
                }
            }

            if (nalezenyPojisteny.Count > 0)
            {
                foreach (Pojisteny a in nalezenyPojisteny)
                {
                    Console.WriteLine("\n" + a.ToString());
                }
            }
            else
            {
                Console.WriteLine($"\nPojištěný s jménem {jmeno} a příjmením {prijmeni} nebyl nalezen.");
            }
        }
    }
}




