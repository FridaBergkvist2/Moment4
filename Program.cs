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