

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte ein Datum eingeben (TT/MM/JJJJ):");
        DateTime eingegebenesDatum;

        // Überprüfen, ob das eingegebene Datum im richtigen Format vorliegt
        if (DateTime.TryParse(Console.ReadLine(), out eingegebenesDatum))
        {
            while (true)
            {
                DateTime aktuelleZeit = DateTime.Now;

                // Berechnung der vergangenen Zeit
                TimeSpan differenz = aktuelleZeit - eingegebenesDatum;

                // Berechnung der Jahre, Monate und Tage
                int jahre = (int)(differenz.Days / 365.25);
                int monate = (int)((differenz.Days % 365.25) / 30);
                int tage = (int)((differenz.Days % 365.25) % 30);

                // Berechnung der Stunden, Minuten und Sekunden
                int stunden = differenz.Hours;
                int minuten = differenz.Minutes;
                int sekunden = differenz.Seconds;

                // Ausgabe der vergangenen Zeit
                Console.Clear(); // Konsole löschen, um die Anzeige zu aktualisieren
                Console.WriteLine($"Vergangene Zeit: {jahre} Jahre, {monate} Monate, {tage} Tage, {stunden} Stunden, {minuten} Minuten, {sekunden} Sekunden.");

                // Eine Sekunde warten, bevor die Anzeige aktualisiert wird
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.WriteLine("Bitte ein gültiges Datum im Format TT/MM/JJJJ eingeben.");
        }
    }
}

