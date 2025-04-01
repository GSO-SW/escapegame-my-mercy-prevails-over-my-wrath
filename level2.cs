using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    internal class level2 : AbstractAction
    {
        public override void Execute()
        {
            // Level 2 - Krankenhaus-Intro
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                      LEVEL 2                         ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Du befindest dich nun in einem düsteren Krankenhaus.");
            Console.WriteLine("Die Wände sind von Rost und Schimmel bedeckt, und überall liegt eine unheimliche Stille.");
            Console.WriteLine("Du und Joel fragen euch, was hier passiert ist und welche Kreaturen hier lauern.");
            Console.WriteLine("Doch plötzlich hörst du unheimliche Geräusche und laute Schritte, die sich der Tür nähern.");
            Console.WriteLine("Es gibt keine Zeit mehr zu verlieren, ihr müsst euch sofort entscheiden, was zu tun ist!");
            Console.WriteLine("\nDie Tür vor euch scheint der einzige Ausweg zu sein, aber sie ist blockiert und lässt sich nicht öffnen.");
            Console.WriteLine("Ein Fluchtweg könnte die einzige Möglichkeit sein, zu überleben.");

            Console.WriteLine("\nWähle eine Option:");
            Console.WriteLine("1. Das Risiko der Dunkelheit - Flucht in die U-Bahn");
            Console.WriteLine("2. Der verzweifelte Kampf - Konfrontation mit den Zombies");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                FluchtInDieUbahn();
            }
            else if (eingabe == "2")
            {
                KampfMitDenZombies();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch es erneut!");
                Execute(); 
            }
        }

        static void FluchtInDieUbahn()
        {
            // Entscheidung für die Flucht in die U-Bahn
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                Das Risiko der Dunkelheit             ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Rick entdeckt eine Seitentür mit einem verblichenen Schild: „Notausgang – Zugang zur U-Bahn“.");
            Console.WriteLine("„Hier entlang!“, zischt er.");
            Console.WriteLine("Die Tür klemmt. Ihr müsst sie mit Gewalt öffnen, doch das wird Lärm machen.");
            Console.WriteLine("Die Dunkelheit der U-Bahn scheint unheimlich tief und gefährlich. Niemand weiß, was dort unten lauert...");
            Console.WriteLine("\nWirst du das Risiko eingehen und fliehen?");
            Console.WriteLine("1. Ja, ich fliehe in die U-Bahn und hoffe auf das Beste.");
            Console.WriteLine("2. Nein, wir müssen einen anderen Weg finden.");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                Flucht in die U-Bahn                  ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du öffnest die Tür mit einem lauten Knacken und stürzt in die Dunkelheit der U-Bahn.");
                Console.WriteLine("Es dauert nicht lange, bis du seltsame Geräusche hörst. Die Dunkelheit ist erdrückend und du weißt nicht, was auf dich wartet...");
                Console.WriteLine("Doch in der Ferne siehst du ein schwaches Licht. Vielleicht gibt es doch noch Hoffnung.");
                Console.WriteLine("Der Weg in die U-Bahn war der richtige, aber du bist nicht allein.");
            }
            else if (eingabe == "2")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                Kein Fluchtweg – was nun?             ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du entscheidest dich, die U-Bahn nicht zu betreten, da sie zu gefährlich erscheint.");
                Console.WriteLine("Die Zombies kommen immer näher und es gibt keinen anderen Ausweg...");
                Console.WriteLine("Es bleibt keine Zeit für eine Entscheidung. Der Kampf beginnt.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch es erneut.");
                FluchtInDieUbahn(); 
            }
        }

        static void KampfMitDenZombies()
        {
            // Entscheidung für den Kampf mit den Zombies
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                Der verzweifelte Kampf                ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("„Scheiß drauf, wir kämpfen!“, faucht Joel.");
            Console.WriteLine("Er hebt seine Waffe. Doch die Munition ist knapp, und wenn ihr zu viele Zombies anlockt, könnte es das Ende bedeuten.");
            Console.WriteLine("„Wir müssen uns irgendwie einen Weg freikämpfen!“, ruft Rick.");
            Console.WriteLine("\nWirst du dich auf den Kampf einlassen?");
            Console.WriteLine("1. Ja, wir kämpfen bis zum letzten Atemzug.");
            Console.WriteLine("2. Wir müssen einen Plan ausarbeiten, bevor wir kämpfen.");
            Console.Write("Eingabe: ");

            string eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                Kampf mit den Zombies                 ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du und Joel nehmen eure Waffen und kämpfen verbittert gegen die Zombies.");
                Console.WriteLine("Es wird ein blutiger Kampf, bei dem viele Monster auf euch stürzen.");
                Console.WriteLine("Die Munition geht langsam zur Neige, aber ihr kämpft weiter, da der einzige Ausweg in der Flucht liegt.");
                Console.WriteLine("Schließlich schafft ihr es, die Zombies zu besiegen – aber der Preis war hoch.");
            }
            else if (eingabe == "2")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                Zu wenig Zeit für einen Plan          ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du versuchst, einen Plan auszuarbeiten, aber es bleibt keine Zeit.");
                Console.WriteLine("Die Zombies sind bereits auf euch zugestürmt, und es bleibt nur der direkte Kampf.");
                Console.WriteLine("Es könnte zu spät sein, um eine Chance zu haben...");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch es erneut.");
                KampfMitDenZombies();  
            }
        }
    }
}
