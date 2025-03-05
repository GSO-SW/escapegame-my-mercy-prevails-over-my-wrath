
using System.Security.Cryptography.X509Certificates;

{
    Gebaeude Polizeiwache = new Gebaeude ();
	Polizeiwache.Nummer = 1;
	Polizeiwache.Anwesenheit = true;
	Polizeiwache.Zugang = true;
	Polizeiwache.Zugaenge[0]=1;

    Gebaeude Krankenhaus = new Gebaeude ();
	Krankenhaus.Nummer = 2;
	Krankenhaus.Anwesenheit = false;
	Krankenhaus.Zugang = false;
	Krankenhaus.Zugaenge[1]=2;

    Gebaeude Bahnhaltestelle = new Gebaeude ();
	Bahnhaltestelle.Nummer = 3;
	Bahnhaltestelle.Anwesenheit = false;
	Bahnhaltestelle.Zugang = false;
	Bahnhaltestelle.Zugaenge[2]=3;

    Gebaeude Schule = new Gebaeude ();
	Schule.Nummer = 4;
	Schule.Anwesenheit = false;
	Schule.Zugang = false;
	Schule.Zugaenge[3]=4;

    Gebaeude Feuerwehrwache = new Gebaeude ();
	Feuerwehrwache.Nummer = 5;
	Feuerwehrwache.Anwesenheit = false;
	Feuerwehrwache.Zugang = false;
	Feuerwehrwache.Zugaenge[4]=5;

    Gebaeude Obdachlosenlager = new Gebaeude ();
	Obdachlosenlager.Nummer = 6;
	Obdachlosenlager.Anwesenheit = false;
	Obdachlosenlager.Zugang = false;
	Obdachlosenlager.Zugaenge[5]=6;

    Gebaeude Kino = new Gebaeude ();
	Kino.Nummer = 7;
	Kino.Anwesenheit = false;
	Kino.Zugang = false;
	Kino.Zugaenge[6]=7;

    Gebaeude Schwimmbad = new Gebaeude ();
	Schwimmbad.Nummer = 8;
	Schwimmbad.Anwesenheit = false;
	Schwimmbad.Zugang = false;
	Schwimmbad.Zugaenge[7]=8;
    
    Gebaeude Hafen = new Gebaeude ();
	Hafen .Nummer = 9;
	Hafen .Anwesenheit = false;
	Hafen .Zugang = false;
	Hafen .Zugaenge[8]=9;


    //Menü

    string eingabe;
    int eingabe_int;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Wählen Sie eine Option:");
        Console.WriteLine("1. Spiel Starten");
        Console.WriteLine("2. Programm schließen");
        Console.Write("Eingabe: ");
        eingabe = Console.ReadLine();

        if (!int.TryParse(eingabe, out eingabe_int))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
            Console.ReadKey();
            continue;
        }

        if (eingabe_int == 1)
        {
            StarteSpiel();
        }
        else if (eingabe_int == 2)
        {
            Console.WriteLine("Programm wird beendet...");
            break;
        }
        else
        {
            Console.WriteLine("Ungültige Option. Bitte erneut versuchen.");
            Console.ReadKey();
        }
    }
}

static void StarteSpiel()
{
    string eingabe;
    int eingabe_int;

    do
    {
        Console.Clear();
        Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
        Console.WriteLine("                                                     ");
        Console.WriteLine("                     WELCOME TO                      ");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("                   YOUR LAST DAY                      ");
        Console.WriteLine("                 Press 0 to continue                 ");
        Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");

        eingabe = Console.ReadLine();

    } while (!int.TryParse(eingabe, out eingabe_int) || eingabe_int != 0);

    Console.Clear();





}
