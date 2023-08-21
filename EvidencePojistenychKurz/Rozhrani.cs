using EvidencePojistenychKurz;
using System;
namespace EvidencePojistenychKurz
{
    public class Rozhrani
    {

        private EvidencePojistenych evidenceRozhrani;

        public Rozhrani()
        {
            evidenceRozhrani = new EvidencePojistenych();
            VykresliUvodniObrazovku();
        }

        public void VykresliUvodniObrazovku()
        {
            Console.Clear();

            Console.WriteLine(
                "---------------------------\n" +
                "Evidence pojištěných\n" +
                "---------------------------\n");
            Console.WriteLine(
            "Vyberte si akci:\n" +
            "1 _ Přidat nového pojištěného\n" +
            "2 - Vypsat všechny pojištěné\n" +
            "3 - Vyhledat pojištěného\n" +
            "4 - konec");

            VyberAkci();
            Console.WriteLine("\n");
        }


        public void VyberAkci()
        {
            int volbaAkce;
            int pocetPokusu = 0;


            while (pocetPokusu < 5)
            {
                // Console.Write("Vyber akci: ");
                string volba = Console.ReadLine();
                bool jeCislo = int.TryParse(volba, out volbaAkce);

                if (jeCislo = true)
                {
                    pocetPokusu = 0;
                    VykonejAkci(volbaAkce);
                }
                else
                {
                    Console.WriteLine("Zadej čislo dle vybrané akce.");
                    pocetPokusu++;
                    if (pocetPokusu == 4)
                        Console.WriteLine("Máte poslední možnost vybrat validní možnost, jinak bude aplikace ukončena.");
                }
            }
            Console.WriteLine("\n");
            VykonejAkci(4);

        }

        public void VykonejAkci(int cisloAkce)
        {
            switch (cisloAkce)
            {
                case 1:
                    PridaPojisteneho();
                    break;
                case 2:
                    VypisePojistene();
                    break;
                case 3:
                    VyhledaPojisteneho();
                    break;
                case 4:
                    UkonciAplikaci();
                    break;
            }
            PokracujNaZadaniAkce();
        }


        public void PridaPojisteneho()
        {
            Pojisteny pojistenyNovy = new Pojisteny(this);
            evidenceRozhrani.PridejPojisteneho(pojistenyNovy);
            Console.WriteLine("\nData byla uložena. ");
        }

        public void PridaPojisteneho(string jmeno, string prijmeni, int den, int mesic, int rok, int telefon)
        {
            Pojisteny pojistenyNovy = new Pojisteny(this);
            evidenceRozhrani.PridejPojisteneho(pojistenyNovy);
        }

        public void PridaPojisteneho(Pojisteny pojisteny)
        {

            evidenceRozhrani.PridejPojisteneho(pojisteny);
        }

        public void VypisePojistene()
        {
            evidenceRozhrani.VypisVsechnyPojistene();
        }

        public void VyhledaPojisteneho()
        {
            Console.WriteLine("\nNapište jméno hledané osoby");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Napište příjmení hledané osoby");
            string prijmeni = Console.ReadLine();

            evidenceRozhrani.VyhledejPojisteneho(jmeno, prijmeni);
        }

        public void UkonciAplikaci()
        {
            Console.WriteLine("\nAplikace byla ukončena.");
            Environment.Exit(0);
        }

        public void PokracujNaZadaniAkce()
        {

            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();
            VykresliUvodniObrazovku();
        }

    }
}