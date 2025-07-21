using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Storage<Produkt> produktStorage = new Storage<Produkt>();
List<Produkt> produkter = new List<Produkt>();
        bool kör = true;

while (kör)
{
    try
    {
        Console.Write("Ange produktnamn (eller 'stopp'): ");
        string namn = Console.ReadLine();
        if (namn.ToLower() == "stopp")
        {
            kör = false;
            continue;
        }

        Console.Write("Ange pris: ");
        double pris = Convert.ToDouble(Console.ReadLine());

        produkter.Add(new Produkt(namn, pris));
    }
    catch (FormatException)
    {
        Console.WriteLine("Fel: Du måste skriva ett giltigt pris (t.ex. 199,50).");
    }
}
        foreach (var produkt in produkter)
        {
            produktStorage.LäggTill(produkt);
        }
 
Console.WriteLine("\nProdukter i Storage:"); 
Console.WriteLine($"\nAntal produkter i Storage: {produktStorage.Antal}");
produktStorage.SkrivUtAlla();

    }
}
