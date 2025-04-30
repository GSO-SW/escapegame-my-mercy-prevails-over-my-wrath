using System;
using System.Threading;

namespace ExitGame
{
    internal class level5 : AbstractAction
    {
        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                     LEVEL 5: Feuerwehrwache          ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Rick und Joel erreichen eine verlassene Feuerwehrwache.\nDie Tore stehen offen, drinnen ist alles still.");
            Console.WriteLine("Ein alter Truck steht halb zerlegt in der Halle, und Blutspuren führen zur Tür mit der Aufschrift 'Einsatzleitung'.");
            Console.WriteLine("\nWas tust du? (Oder tippe 'exit' zum Beenden)");
            Console.WriteLine("1. Folge den Blutspuren zur Einsatzleitung.");
            Console.WriteLine("2. Gehe zur Umkleidekabine.");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine()?.ToLower();
            if (eingabe == "exit") Environment.Exit(0);

            if (eingabe == "1")
            {
                Einsatzleitung();
            }
            else if (eingabe == "2")
            {
                Umkleidekabine(); // Tod
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
                Execute();
            }
        }

        static void Einsatzleitung()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                Büro der Einsatzleitung               ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Chaos überall. Ein gefesselter Feuerwehrmann beginnt sich zu bewegen – er ist infiziert!");
            Console.WriteLine("\nWie reagierst du? (Oder tippe 'exit' zum Beenden)");
            Console.WriteLine("1. Du schießt sofort.");
            Console.WriteLine("2. Du versuchst, ihn mit dem Funkgerät zu schlagen.");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine()?.ToLower();
            if (eingabe == "exit") Environment.Exit(0);

            if (eingabe == "1")
            {
                Funkkontakt();
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Der Beißer ist schneller – du wirst gebissen.");
                Console.WriteLine("Du bist Tod!");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
                Einsatzleitung();
            }
        }

        static void Umkleidekabine()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                   Umkleidekabine                     ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Du betrittst die dunkle Kabine. Plötzlich greifen dich mehrere Beißer aus Spinden an.");
            Console.WriteLine("Du bist Tod!");
            Console.ReadKey();
            return;
        }

        static void Funkkontakt()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                    Funkkontakt                       ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Du erledigst den Beißer. Dann hörst du eine Stimme im Funkgerät:");
            Console.WriteLine("\"Hier ist Station 9. Überlebende bei Tankstelle – Interstate 84.\"");
            Console.WriteLine("Neben dir liegt ein Schlüssel mit der Aufschrift 'Garage'.");

            Console.WriteLine("\nWas tust du? (Oder tippe 'exit' zum Beenden)");
            Console.WriteLine("1. Nimm den Schlüssel und gehe zur Garage.");
            Console.WriteLine("2. Durchsuche lieber den Keller nach Vorräten.");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine()?.ToLower();
            if (eingabe == "exit") Environment.Exit(0);

            if (eingabe == "1")
            {
                Garage();
            }
            else if (eingabe == "2")
            {
                Keller(); // Tod
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
                Funkkontakt();
            }
        }

        static void Keller()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                        Keller                        ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Im Keller ist es kalt, finster und modrig.");
            Console.WriteLine("Du findest keine Vorräte – aber hungrige Gestalten...");
            Console.WriteLine("Du bist Tod!");
            Console.ReadKey();
            return;
        }

        static void Garage()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                        Garage                        ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Der Truck ist alt, aber anscheinend fahrtüchtig.");
            Console.WriteLine("Eine Horde nähert sich – du musst schnell handeln!");
            Console.WriteLine("\nWas tust du? (Oder tippe 'exit' zum Beenden)");
            Console.WriteLine("1. Starte den Motor und fahr sofort los.");
            Console.WriteLine("2. Verstecke dich mit Joel im Fahrzeug.");
            Console.WriteLine("3. Blockiere die Tür mit einem Feuerlöscher und bereite die Flucht vor.");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine()?.ToLower();
            if (eingabe == "exit") Environment.Exit(0);

            if (eingabe == "1" || eingabe == "2")
            {
                Console.WriteLine("Die Horde durchbricht das Tor und überrennt euch.");
                Console.WriteLine("Du bist Tod!");
                Console.ReadKey();
                return;
            }
            else if (eingabe == "3")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                      FINALE SZENE                    ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du blockierst die Tür und startest den Truck im letzten Moment.");
                Console.WriteLine("Rick fährt, Joel feuert aus dem Fenster – ihr brecht durch das Tor.");
                Console.WriteLine("Die Horde bleibt zurück, das Funkgerät rauscht noch immer.");
                Console.WriteLine("\nDie Straße vor euch ist leer. Die Welt ist zerstört – aber ihr lebt.");
                Console.WriteLine("Vielleicht... ist das der Anfang von etwas Neuem.");

                Thread.Sleep(10000); // 10 Sekunden warten

                Console.Clear();
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("               DU HAST DAS SPIEL BEWÄLTIGT!           ");
                Console.WriteLine("           Rick & Joel haben überlebt – fürs Erste.   ");
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
                Garage();
            }
        }
    }
}
