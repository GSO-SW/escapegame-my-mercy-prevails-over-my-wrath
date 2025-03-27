using System;

namespace ExitGame
{
    public class Level1
    {
        public void StarteLevel1()
        {
            string eingabe = Console.ReadLine();
            // Beispiel für das erste Level
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                     LEVEL 1: Die Polizeiwache        ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Rick Grimes war gerade am schlafen,es war spät in der nacht und er ging davon aus das seine schicht bald enden wird.\n Auf einmal ertönt das telefon und Rick Grimes Sprang auf.");
            Console.WriteLine("Das telefon Klingelt weiterhin.");
            Console.WriteLine();
            Console.WriteLine("1. Du nimmst das telefon ab.");
            Console.WriteLine("2. Du legst dich wieder schlafen");



            Startmenue startmenue = new Startmenue();

            if (eingabe == "1")
            {
                Console.WriteLine("Du nimmst das telefon ab.Rick Grimes hört ein unmenschliches tiefes grönen");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Rick Grimes entscheidest dich weiter zu schlafen was für ihm zum großen verhängniss wird.");
                Console.WriteLine("Du bist Tod!");
                Console.WriteLine("Drücke eine taste um ins Hauptmeü zurückzukehren");
                Console.ReadKey();
                // Zurück ins Hauptmenü
                startmenue.MenueAnzeigen(); // Menü erneut anzeigen
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Rick grimes springt auf,lässt den hörer dabei fallen.\n Er steht in einem korridor und kann sich entscheiden rechts nach draußen zu gehen oder links zur waffen kammer gehen");
            Console.WriteLine("Welchen weg soll er wählen?");
            Console.WriteLine("1: Rechts : Rausrennen");
            Console.WriteLine("2: Links : Waffenkamer");

            eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.WriteLine("Rick Grimes rennt zur tür hinaus und rammt sie auf nur um eine horde lebloser wandelnder körper laufen zu sehen.\n Er wird von der horde überannt und bei lebendigen leib gefressen.");
                Console.WriteLine("Du bist Tod!");
                Console.WriteLine("Drücke eine taste um ins Hauptmeü zurückzukehren");
                Console.ReadKey();
                // Zurück ins Hauptmenü
                startmenue.MenueAnzeigen(); // Menü erneut anzeigen
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Rick Grimes entscheidest sich aufzurüsten und rennt links zur Waffenkammer.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Rick grimes rennt zur waffenkammer nur um 3 seiner kollegen zu sehen die leblos herumstreunern,in ihren augen war der tod geschrieben.\n Aber sie kommen nicht durch die gitter tür an ihn ran.\n Er überlegt wie er an die waffen kommt.");
            Console.WriteLine("Er überlegt:");
            Console.WriteLine("1: Seine Waffe Abzufeuern");
            Console.WriteLine("2: Die zombies mit seiner puren männlichkeit zu überumpeln");
            eingabe= Console.ReadLine();

            if (eingabe == "1")
            {
                Console.WriteLine("Rick Grimes greift zu seiner dienst waffe, Er feurt die kugeln auf die zombies ab und Streckt sie nach einander nieder.\n Doch die schüsse locken eine horde an Zombies an.\n Sie brechen durch die tür die nach draußen führt und stürmen auf ihn zu.\n Rick Grimes ertsarrt und weiss nicht was er tun soll.Auf einmal packt ihn ein mann und sperrt ihn mit Rick Grimes in die waffenkammer.");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Rick Grimes");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();

            Console.Clear();


        }
    }
}
