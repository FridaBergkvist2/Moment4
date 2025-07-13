using System;
using System.IO;

class System
{
    static void Main()
    {
        string path = "Fridas_test_fil.txt";

        if (File.Exists(path))
        {
            string innehall = File.ReadAllText(path);
            Console.WriteLine("Filens innehåll:");
            Console.WriteLine(innehall);
        }
        else
        {
            Console.WriteLine("Filen finns inte.");
        }
    }
}