namespace AracUygulamasi;

class Program
{
    static void Main(string[] args)
    {
        Surucu surucu = new Surucu(new Otobus());

        Console.WriteLine(surucu.Sur());
    }
}