using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Storage<Produkt> produktStorage = new Storage<Produkt>();
        Storage<string> stringStorage = new Storage<string>();
        Storage<int> intStorage = new Storage<int>();

        bool kör = true;

        while (kör)
        {
            Console.WriteLine("\n--- MENY ---");
            Console.WriteLine("1. Mata in böcker");
            Console.WriteLine("2. Öva felhantering");
            Console.WriteLine("3. Skriv ut vad som finns");
            Console.WriteLine("0. Avslut");
            Console.Write("Ditt val: ");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    MataInProdukter(produktStorage);
                    break;

                case "2":
                    TestaFelhantering(stringStorage, intStorage);
                    break;

                case "3":
                    SkrivUtAllt(produktStorage, stringStorage, intStorage);
                    break;

                case "0":
                    kör = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }

        Console.WriteLine("Programmet avslutas.");
    }

    static void MataInProdukter(Storage<Produkt> storage)
    {
        while (true)

        {

            try
            {
                Console.Write("Ange produktnamn (eller 'stopp'): ");
                string namn = Console.ReadLine();
                if (namn.ToLower() == "stopp")
                    break;

                Console.Write("Ange pris: ");
                double pris = Convert.ToDouble(Console.ReadLine());

                storage.LäggTill(new Produkt(namn, pris));
            }
            catch (FormatException)
            {
                Console.WriteLine("Fel: Ange ett korrekt pris (t.ex. 199,50).");
            }
        }
    }

    static void TestaFelhantering(Storage<string> strStorage, Storage<int> intStorage)
    {
 try
        {
            Console.Write("Ange ett heltal: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            intStorage.LäggTill(tal);
        }
        catch (FormatException)
        {
            Console.WriteLine("Fel: Du måste skriva ett heltal.");
        }
 finally
        {
Console.WriteLine($"Du skrev ett tal");
        }

 try
        {
            Console.Write("Skriv nåt, vad som helst: ");
            string text = Console.ReadLine();
            strStorage.LäggTill(text);
        }
 finally
        {
            Console.WriteLine("Textinmatning avslutad.");
        }
    }

    static void SkrivUtAllt(Storage<Produkt> p, Storage<string> s, Storage<int> i)
    {
        Console.WriteLine("\n--- Produkter ---");
        Console.WriteLine($"Antal: {p.Antal}");
        p.SkrivUtAlla();

        Console.WriteLine("\n--- Texter ---");
        s.SkrivUtAlla();

        Console.WriteLine("\n--- Heltal ---");
        i.SkrivUtAlla();
    }
}
