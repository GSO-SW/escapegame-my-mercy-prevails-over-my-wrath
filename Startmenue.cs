using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    class Startmenue : AbstractAction
    {
        public override void Execute()
        {
            // Gebäude und weitere Initialisierungen

            // Menü
            string eingabe;
            int eingabe_int;

           
            while (true)
            {
              Console.Clear();
              Console.WriteLine("Wählen Sie eine Option:");
              Console.WriteLine("1. Reise starten");
              Console.WriteLine("2. Reise beenden");
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

            // Einführung nach dem Spielstart
            GebeEinleitung();

            // Danach kannst du das erste Level starten oder was auch immer kommt
            // StarteErstesLevel();
        }

        static void GebeEinleitung()
        {
            // Einführungstext
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                   INTRODUCTION                       ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Willkommen zu 'YOUR LAST DAY'! Du bist auf einer gefährlichen Reise, ");
            Console.WriteLine("in der du Entscheidungen treffen musst, um zu überleben. ");
            Console.WriteLine("In diesem Spiel wirst du verschiedenen Herausforderungen begegnen. ");
            Console.WriteLine("Du spielst Rick Grimes einen Polizisten der alles für die Gerechtigkeit tut");
            Console.WriteLine("Jedoch als du aufwachst an deinem Arbeitsplatz hast du was bemerkt...................");   
            Console.WriteLine("Jede Entscheidung könnte dein Schicksal besiegeln also wähle weise. Viel Glück!");
            Console.WriteLine();
            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");

            // Auf Benutzereingabe warten, bevor das Spiel fortgesetzt wird
            Console.ReadKey();

            // Jetzt Bildschirm löschen, bevor das Spiel fortgesetzt wird
            Console.Clear();
            level2 level2 = new level2();
            level2.Execute();
        }
    }


}
