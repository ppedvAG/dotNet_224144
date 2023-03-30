using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Parallel.Invoke(Zähle, Zähle, Zähle, Zähle);
        //Parallel.For(0, 100000, i => Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {i}"));


        string[] obstsorten = { "Apfel", "Banane", "Orange", "Kiwi", "Birne", "Erdbeere", "Himbeere", "Blaubeere", "Heidelbeere", "Mango", "Ananas", "Papaya", "Kirsche", "Pfirsich", "Nektarine", "Zwetschge", "Marille", "Feige", "Granatapfel", "Traube", "Melone", "Wassermelone", "Grapefruit", "Zitrone", "Limette", "Mandarine", "Pampelmuse", "Quitte", "Aprikose", "Passionsfrucht" };


        var gefilterteObstsorten = from obst in obstsorten
                                   where !obst.StartsWith("B") // Filterkriterium: Nur Obstsorten, die mit "A" beginnen
                                   select obst;

        Console.WriteLine("Obstsorten, die mit 'A' beginnen:");
        foreach (var obst in gefilterteObstsorten.AsParallel())
        {
            Console.WriteLine(obst);
        }

    }

    static void Zähle()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {i}");
        }
    }
}