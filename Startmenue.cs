using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    // Startmenü-Klasse, die von AbstractAction erbt
    class Startmenue : AbstractAction
    {
        // Einstiegspunkt für das Startmenü
        public override void Execute()
        {
            // Variable für Benutzereingabe
            string eingabe;
            int eingabe_int;

            // Dauerschleife für Menü, läuft bis Benutzer das Spiel beendet
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wählen Sie eine Option:");
                Console.WriteLine("1. Reise starten");
                Console.WriteLine("2. Reise beenden");
                Console.Write("Eingabe: ");
                eingabe = Console.ReadLine();

                // Überprüfen, ob die Eingabe eine gültige Zahl ist
                if (!int.TryParse(eingabe, out eingabe_int))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
                    Console.ReadKey();
                    continue; // Zurück zum Menüanfang
                }

                // Spielstart
                if (eingabe_int == 1)
                {
                    StarteSpiel();
                }
                // Programm beenden
                else if (eingabe_int == 2)
                {
                    Console.WriteLine("Programm wird beendet...");
                    break; // Schleife beenden
                }
                // Ungültige Auswahl
                else
                {
                    Console.WriteLine("Ungültige Option. Bitte erneut versuchen.");
                    Console.ReadKey();
                }
            }
        }

        // Methode für den Übergang ins Spiel mit Intro-Bildschirm
        static void StarteSpiel()
        {
            string eingabe;
            int eingabe_int;

            // Intro-Bildschirm – läuft so lange, bis ENTER gedrückt wird
            do
            {
                Console.Clear();
                Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                     WELCOME TO                      ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                   YOUR LAST DAY                     ");
                Console.WriteLine("              Press Enter to continue                ");
                Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");

            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            Console.Clear();

            // Einführungstext anzeigen
            GebeEinleitung();
        }

        // Einführung in die Story mit Beschreibung des Spielziels
        static void GebeEinleitung()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                   INTRODUCTION                       ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Willkommen zu 'YOUR LAST DAY'! Du bist auf einer gefährlichen Reise,");
            Console.WriteLine("in der du Entscheidungen treffen musst, um zu überleben.");
            Console.WriteLine("In diesem Spiel wirst du verschiedenen Herausforderungen begegnen.");
            Console.WriteLine("Du spielst Rick Grimes – einen Polizisten, der alles für Gerechtigkeit tut.");
            Console.WriteLine("Doch als du an deinem Arbeitsplatz aufwachst, merkst du sofort:");
            Console.WriteLine("Etwas stimmt hier ganz und gar nicht...");
            Console.WriteLine();
            Console.WriteLine("Jede Entscheidung könnte dein Schicksal besiegeln – also wähle weise.");
            Console.WriteLine("Viel Glück!");
            Console.WriteLine();
            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");

            // Auf Eingabe warten, bevor es losgeht
            Console.ReadKey();
            Console.Clear();

            // Start von Level 1 (Polizeiwache)
            Level1 level1 = new Level1();
            level1.Execute();
        }
    }
}
