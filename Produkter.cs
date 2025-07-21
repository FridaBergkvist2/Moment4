public class Produkter<T>
{
    public T Innehåll { get; set; }

    public void VisaInfo()
    {
        Console.WriteLine("Lådan innehåller:");
        Console.WriteLine(Innehåll.ToString());
    }
}