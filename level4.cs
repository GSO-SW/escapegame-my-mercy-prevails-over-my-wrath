using System;

namespace ExitGame
{
    internal class level4 : AbstractAction
    {
        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                      LEVEL 4                         ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Du befindest dich nun in einer verlassenen Schule.");
            Console.WriteLine("Die Gänge sind still, die Luft abgestanden, und die Flure wirken wie aus einer anderen Zeit.");
            Console.WriteLine("Du und Joel merkt schnell: Hier stimmt etwas ganz und gar nicht.");
            Console.WriteLine("Überall hängen alte Klassenfotos, doch die Gesichter darauf wirken... seltsam verzerrt.");
            Console.WriteLine("Plötzlich hörst du ein Flüstern aus dem Lehrerzimmer – und dann Schritte hinter euch.");
            Console.WriteLine("\nDie Aula scheint versperrt zu sein, aber es gibt zwei Wege weiter.");

            Console.WriteLine("\nWähle eine Option:");
            Console.WriteLine("1. Durch den Keller – der unheimliche Weg ins Ungewisse");
            Console.WriteLine("2. Zur Bibliothek – vielleicht gibt es Hinweise auf das, was hier passiert ist");
            Console.WriteLine("(Tipp 'exit' zum Beenden)");
            Console.Write("Eingabe: ");

            string eingabe = EingabeMitExitCheck();

            if (eingabe == "1")
            {
                DurchDenKeller();
            }
            else if (eingabe == "2")
            {
                ZurBibliothek();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch es erneut!");
                Execute();
            }
        }

        static string EingabeMitExitCheck()
        {
            string input = Console.ReadLine()?.ToLower();
            if (input == "exit")
            {
                Console.WriteLine("\nSpiel wird beendet. Danke fürs Spielen!");
                Environment.Exit(0);
            }
            return input;
        }

        static void DurchDenKeller()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                 Der Weg durch den Keller             ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Ihr findet eine alte Eisentür mit der Aufschrift 'Heizraum'.");
            Console.WriteLine("Dahinter führt eine schmale Treppe in den Keller – völlig dunkel, modrig und kalt.");
            Console.WriteLine("Joel zögert, aber du gehst entschlossen voran mit einer Taschenlampe in der Hand.");
            Console.WriteLine("Unten angekommen, hört ihr plötzlich ein Klopfen... von innen, aus einem alten Spind.");
            Console.WriteLine("\nWas wirst du tun?");
            Console.WriteLine("1. Den Spind öffnen – vielleicht braucht jemand Hilfe.");
            Console.WriteLine("2. Ignorieren und schnell weitergehen.");
            Console.WriteLine("(Tipp 'exit' zum Beenden)");
            Console.Write("Eingabe: ");

            string eingabe = EingabeMitExitCheck();

            if (eingabe == "1")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                  Entscheidung: Öffnen                ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du öffnest vorsichtig den Spind... und plötzlich springt eine Gestalt heraus!");
                Console.WriteLine("Ein ehemaliger Schüler – oder das, was von ihm übrig ist.");
                Console.WriteLine("Es packt dich, und bevor du reagieren kannst, wird es dunkel.");
                Console.WriteLine("Du bist gestorben, das Spiel endet hier.");
                Console.ReadKey();
                Environment.Exit(0); // Tödliches Ende
            }
            else if (eingabe == "2")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("             Entscheidung: Nicht öffnen               ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Du gehst vorbei, aber das Klopfen wird lauter... und plötzlich kracht die Spindtür von innen auf!");
                Console.WriteLine("Eine Kreatur stürzt sich auf euch – ihr werdet überrascht!");
                Console.WriteLine("Joel wird verletzt, du ziehst ihn mit letzter Kraft durch eine Notausgangstür.");
                Console.WriteLine("Ihr lebt, aber der Preis war hoch.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch es erneut.");
                DurchDenKeller();
            }
        }

        static void ZurBibliothek()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                   Die verlassene Bibliothek          ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Ihr betretet die Bibliothek – voll mit alten Büchern, Staub und Spinnweben.");
            Console.WriteLine("Ein aufgeschlagenes Buch auf dem Pult zieht eure Aufmerksamkeit auf sich.");
            Console.WriteLine("Darin: Berichte von Schülern, die spurlos verschwanden. Und von einem geheimen Klassenzimmer.");
            Console.WriteLine("Ihr hört Schritte – jemand kommt näher. Schnell, ihr müsst euch entscheiden!");
            Console.WriteLine("\nWas tut ihr?");
            Console.WriteLine("1. Verstecken zwischen den Bücherregalen.");
            Console.WriteLine("2. Durch die Fenster ins Freie fliehen.");
            Console.WriteLine("(Tipp 'exit' zum Beenden)");
            Console.Write("Eingabe: ");

            string eingabe = EingabeMitExitCheck();

            if (eingabe == "1")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                Entscheidung: Verstecken              ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ihr kauert euch zwischen die Regale und haltet den Atem an.");
                Console.WriteLine("Eine dunkle Silhouette geht an euch vorbei... und verschwindet.");
                Console.WriteLine("Knapp entkommen. In dem Buch entdeckt ihr nun den Hinweis auf den nächsten Ort.");
                Console.WriteLine("Die Reise geht weiter – zur Féuerwehrwache! ");
                Console.ReadKey();
            }
            else if (eingabe == "2")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                Entscheidung: Flucht                  ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ihr springt durch das Fenster – zerbrochenes Glas schneidet euch, aber ihr seid draußen.");
                Console.WriteLine("Doch das Ding im Gebäude sieht euch – es wird euch folgen...");
                Console.WriteLine("Ihr habt überlebt – aber ihr seid jetzt gejagt.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Versuch es erneut.");
                ZurBibliothek();
            }
        }
    }
}

