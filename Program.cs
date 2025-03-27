using ExitGame;
using System;

namespace ExitGame
{
    class Gebaeude
    {
        public int Nummer;
        public bool Anwesenheit;
        public bool Zugang;
        public int[] Zugaenge = new int[9]; // Array mit 8 Elementen


    }

    class Program 
    { 
        static void Main(string[] args)
        {
            Gebaeude Polizeiwache = new Gebaeude();
            Polizeiwache.Nummer = 1;
            Polizeiwache.Anwesenheit = true;
            Polizeiwache.Zugang = true;
            Polizeiwache.Zugaenge[0] = 1; // Korrekte Initialisierung des Arrays

            Gebaeude Krankenhaus = new Gebaeude();
            Krankenhaus.Nummer = 2;
            Krankenhaus.Anwesenheit = false;
            Krankenhaus.Zugang = false;
            Krankenhaus.Zugaenge[0] = 2;
            Krankenhaus.Zugaenge[1] = 1;

            Gebaeude Bahnhaltestelle = new Gebaeude();
            Bahnhaltestelle.Nummer = 3;
            Bahnhaltestelle.Anwesenheit = false;
            Bahnhaltestelle.Zugang = false;
            Bahnhaltestelle.Zugaenge[0] = 3;
            Bahnhaltestelle.Zugaenge[1] = 2;

            Gebaeude Schule = new Gebaeude();
            Schule.Nummer = 4;
            Schule.Anwesenheit = false;
            Schule.Zugang = false;
            Schule.Zugaenge[0] = 4;
            Schule.Zugaenge[1] = 3;

            Gebaeude Feuerwehrwache = new Gebaeude();
            Feuerwehrwache.Nummer = 5;
            Feuerwehrwache.Anwesenheit = false;
            Feuerwehrwache.Zugang = false;
            Feuerwehrwache.Zugaenge[0] = 5;
            Feuerwehrwache.Zugaenge[1] = 4;

            Gebaeude Obdachlosenlager = new Gebaeude();
            Obdachlosenlager.Nummer = 6;
            Obdachlosenlager.Anwesenheit = false;
            Obdachlosenlager.Zugang = false;
            Obdachlosenlager.Zugaenge[0] = 6;
            Obdachlosenlager.Zugaenge[1] = 5;

            Gebaeude kino = new Gebaeude();
            kino.Nummer = 7; // Hier war ein Fehler: Nummer 6 wurde doppelt verwendet
            kino.Anwesenheit = false;
            kino.Zugang = false;
            kino.Zugaenge[0] = 7;
            kino.Zugaenge[1] = 5;

            Gebaeude schwimmbad = new Gebaeude();
            schwimmbad.Nummer = 8; // Hier war ein Fehler: Nummer 6 wurde doppelt verwendet
            schwimmbad.Anwesenheit = false;
            schwimmbad.Zugang = false;
            schwimmbad.Zugaenge[0] = 8;
            schwimmbad.Zugaenge[1] = 5;

            Gebaeude hafen = new Gebaeude();
            hafen.Nummer = 9; // Hier war ein Fehler: Nummer 6 wurde doppelt verwendet
            hafen.Anwesenheit = false;
            hafen.Zugang = false;
            hafen.Zugaenge[0] = 9;
            hafen.Zugaenge[1] = 5;

            Startmenue startmenue = new Startmenue();
            startmenue.Execute();
        }
    }
}



