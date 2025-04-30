
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    internal class level3 : AbstractAction
    {
        public override void Execute()
        {
            Startmenue startmenue = new Startmenue();
            level4 level4 = new level4();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                      LEVEL 3                         ");
            Console.WriteLine("------------------------------------------------------");

            // Erste Entscheidung
            Console.WriteLine("Der aufzug hat dich und Joel in einer Bahnhaltestelle");
            Console.WriteLine("abegelassen, eine verlassene Bahnhaltestelle.");
            Console.WriteLine("Während ihr die Bahnhaltestelle durchsucht merkt ihr das eine");
            Console.WriteLine("Einsturzgefahr besteht, Sei achtsam.");
            Console.WriteLine("Du weißt das 2 Straßen weiter die schule auf euch wartet, die Schule, sie " +
                "wäre ein sicherer ort als die bahnhaltestelle.");
            string entscheidung1 = Console.ReadLine();

            if (entscheidung1.ToLower() == "brücke")
            {
                Console.WriteLine("Du hast die Brücke gewählt und gehst in Richtung der Sicherheit. Du hast gewonnen!");
                Console.ReadKey();
                level4.Execute();
            }
            else if (entscheidung1.ToLower() == "tunnel")
            {
                // Zweite Entscheidung im Tunnel
                Console.WriteLine("Du hast den Tunnel betreten, und es wird immer dunkler.");
                Console.WriteLine("Am Ende des Tunnels siehst du zwei Türen.");
                Console.WriteLine("Eine führt nach draußen, die andere führt zu einer dunklen Höhle.");
                Console.WriteLine("Welche Tür wählst du? (Tür 1 oder Tür 2)");
                string entscheidung2 = Console.ReadLine();

                if (entscheidung2 == "1")
                {
                    Console.WriteLine("Du gehst durch Tür 1 und findest den Ausgang. Du hast Überlebt fürs erste");
                    Console.ReadKey();
                    level4 level4 = new level4();
                }
                else if (entscheidung2 == "2")
                {
                    Console.WriteLine("Tür 2 führt dich in eine dunkle Höhle. Du bist gefangen und stirbst. Game Over.");
                }
                else
                {
                    Console.WriteLine("Ungültige Entscheidung. Du bleibst im Tunnel gefangen. Game Over.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Wahl. Du musst entweder die Brücke oder den Tunnel wählen. Game Over.");
            }

            Console.WriteLine("Drücke eine beliebige Taste, um das Spiel zu beenden.");
            Console.ReadKey();
            startmenue.Execute();
        }

    }
}

