using System;

namespace ExitGame
{
    public class Level1 : AbstractAction
    {
        public override void Execute()
        {
            string eingabe;
            // Beispiel für das erste Level
            //Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                     LEVEL 1: Die Polizeiwache        ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Rick Grimes war gerade am schlafen,es war spät in der nacht und er ging davon aus das seine schicht bald enden wird.\n Auf einmal ertönt das telefon und Rick Grimes Sprang auf.");
            Console.WriteLine("Das telefon Klingelt weiterhin.");
            Console.WriteLine();
            Console.WriteLine("1. Du nimmst das telefon ab.");
            Console.WriteLine("2. Du legst dich wieder schlafen");

            eingabe = Console.ReadLine();


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
                startmenue.Execute(); // Menü erneut anzeigen
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
                startmenue.Execute(); // Menü erneut anzeigen
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
                Console.WriteLine("Rick Grimes greift zu seiner dienst waffe, Er feurt die kugeln auf die zombies ab und Streckt sie nach einander nieder.\n Doch die schüsse locken eine horde an Zombies an.\n Sie brechen durch die tür die nach draußen führt und stürmen auf ihn zu.");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Rick Grimes entscheidet sich seine kugeln zu Sparen und versucht die zombies mit seiner Puren männlichen kraft zu erschlagen.");

                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                  KAMPF-SZENARIO                      ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ein Zombie springt aus dem Schatten auf Rick Grimes zu!");
                Console.WriteLine("Du musst schnell reagieren und 'A' drücken, um ihn abzuwehren!");
                Console.WriteLine("Du hast 3 Sekunden Zeit!");

                DateTime startTime = DateTime.Now;
                bool tasteGedrueckt = false;

                //Code für tastendruckn in einer bestimmten zeit
                while ((DateTime.Now - startTime).TotalSeconds < 3)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.A)
                        {
                            Console.WriteLine("Du hast den Zombie erfolgreich abgewehrt!");
                            tasteGedrueckt = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Falsche Taste! Der Zombie hat dich erwischt.");
                            break;
                        }
                    }

                    Thread.Sleep(100); 
                }

                Console.Clear();

                Console.WriteLine("Ein weiterer zombie versucht Rick Grimes von hinten anzugreifen.");
                Console.WriteLine("Du musst schnell reagieren und 'S' drücken, um ihn abzuwehren!");
                Console.WriteLine("Du hast 3 Sekunden Zeit!");
                while ((DateTime.Now - startTime).TotalSeconds < 3)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("Du hast den Zombie erfolgreich abgewehrt!");
                            tasteGedrueckt = true;
                            Console.Clear();
                            Console.WriteLine("Der Lärm lockt noch weiter Zombies an. Sie brechen durch die Tür die nach Draußen führt.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Falsche Taste! Der Zombie hat dich erwischt.");
                            break;
                        }
                    }

                    Thread.Sleep(100);
                }


                if (!tasteGedrueckt)
                {
                    Console.WriteLine("Du hast zu langsam reagiert. Der Zombie hat dich erwischt!");
                    Console.WriteLine("Du bist Tod!");
                    Console.WriteLine("Drücke eine Taste, um ins Hauptmenü zurückzukehren.");
                    Console.ReadKey();
                    startmenue.Execute();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }

            Console.WriteLine("Sie brechen durch die tür die nach draußen führt und stürmen auf ihn zu.\n Rick Grimes ertsarrt und weiss nicht was er tun soll.Auf einmal packt ihn ein mann mit cowboy Hut und sperrt ihn mit Rick Grimes in die waffenkammer.\");");
            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Der man der dich in die waffenkammer gesperrt hat Guckt dich an es, herscht stille für eine sekunden.\n Der Mysteriöse mann fängt an zu sprechen 'Howdy Partner'");
            Console.WriteLine("Du guckst den mann an. Was tust du?");

            Console.WriteLine("1: 'Howdy' zürcksagen");
            Console.WriteLine("2:  Fragen wer er ist?");
            Console.WriteLine("3:         Nichtsagen");

            eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.WriteLine("Die Mysteriöse person sagt:'Du hast da ja was angelockt partner.'\n Er gibt dir die hand du erweiderst das 'mein name ist Arthur Morgan'");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Die Mysteriöse person sagt: 'Ah natürlich, Mein name ist Arthur Morgan und ich ,partner, habe dir gerade den Arsch gerettet");
            }
            else if (eingabe == "3")
            {
                Console.WriteLine("DI emysteriöse person sagt: 'Hats dir sprache verschlagen partner, achso mein name ist Arthur Morgan'");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }

            Console.WriteLine("Arthur morgen sagt: 'Wir sollten über die Dachluke rauskommen in der nähe gibt es ein Krankenhaus wir sollten dahin gehen Partner'");
            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();

            Console.Clear();











            Console.WriteLine("Möchtest du weitermachen? Wähle weise");
            Console.WriteLine("1: Den Alptraum weiterspielen (Level 2)");
            Console.WriteLine("2: Auföhren (Angsthase)");
            eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                level2 level2 = new level2();

                level2.Execute();
            }
            else if (eingabe == "2");
            {
                Console.WriteLine("Feigling!");
                Console.WriteLine("Drücke eine taste um ins Hauptmeü zurückzukehren");
                Console.ReadKey();
                // Zurück ins Hauptmenü
                startmenue.Execute();

            }




        }
    }
}
