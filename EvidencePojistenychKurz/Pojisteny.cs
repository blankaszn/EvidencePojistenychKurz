using EvidencePojistenychKurz;
using System;
namespace EvidencePojistenychKurz
{
    public class Pojisteny
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        private string Telefon { get; set; }
        private int Vek { get; set; }

        private Rozhrani rozhrani;



        public Pojisteny(string jmeno, string prijmeni, int vek, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Vek = vek;



        }

        public Pojisteny(Rozhrani rozhrani)
        {
            this.rozhrani = rozhrani;

            Console.WriteLine("\nZadejte jméno pojištěného:");
            Jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte přijmení:");
            Prijmeni = Console.ReadLine();

            // Kontrola telefonního čísla
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Zadejte telefonní číslo:");
                string telefonCislo = Console.ReadLine();

                if (telefonCislo.Length == 9 && int.TryParse(telefonCislo, out _))
                {
                    Telefon = telefonCislo;
                    break;
                }
                else
                {
                    if (i < 2)
                    {
                        Console.WriteLine("Telefonní číslo nebylo zadáno ve správném formátu. Zadejte ho prosím ve správném formátu: 123456789.");
                    }
                    else
                    {
                        rozhrani.UkonciAplikaci();
                    }
                }
            }

            // Kontrola věku
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Zadejte věk:");
                if (int.TryParse(Console.ReadLine(), out int vek) && vek >= 1 && vek <= 99)
                {
                    Vek = vek;
                    break;
                }
                else
                {
                    if (i < 2)
                    {
                        Console.WriteLine("Zadali jste neplatný věk. Zadejte číslovku v rozmezí 1-99.");
                    }
                    else
                    {
                        rozhrani.UkonciAplikaci();
                    }
                }
            }

        }

        public override string ToString()
        {
            return $"{Jmeno}    {Prijmeni}     {Vek}     {Telefon}";
        }

    }
}
