using System;

namespace ExitGame
{
    public class Level1 : AbstractAction
    {
        public override void Execute()
        {
            string eingabe;
            // Beispiel für das erste Level
            
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
                Console.Clear();
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
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe.");
                Console.ReadKey();
                Execute();
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        Auswahl2:
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
                
                startmenue.Execute(); 
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Rick Grimes entscheidest sich aufzurüsten und rennt links zur Waffenkammer.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
                goto Auswahl2;
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        Auswahl3:
            Console.Clear();

            Console.WriteLine("Rick Grimes rennt zur Waffenkammer, nur um 3 seiner Kollegen zu sehen, die leblos herumstreunern. In ihren Augen war der Tod geschrieben.\nAber sie kommen nicht durch die Gittertür an ihn ran.\nEr überlegt, wie er an die Waffen kommt.");
            Console.WriteLine("Er überlegt:");
            Console.WriteLine("1: Seine Waffe abfeuern");
            Console.WriteLine("2: Die Zombies mit seiner puren Männlichkeit überwältigen");

            eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.WriteLine("Rick Grimes greift zu seiner Dienstwaffe. Er feuert die Kugeln auf die Zombies ab und streckt sie nacheinander nieder.");
                Console.WriteLine("Doch die Schüsse locken eine Horde an Zombies an.");
                Console.WriteLine("Sie brechen durch die Tür, die nach draußen führt, und stürmen auf ihn zu.");
                Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Rick Grimes entscheidet sich, seine Kugeln zu sparen und versucht, die Zombies mit seiner puren männlichen Kraft zu erschlagen.");



                //Kampf
                Console.WriteLine("Ein Zombie springt aus dem Schatten auf Rick Grimes zu!");
                Console.WriteLine("Du musst schnell reagieren und 'A' drücken, um ihn abzuwehren!");
                Console.WriteLine("Du hast 3 Sekunden Zeit!");

                bool tasteGedrueckt = false;
                DateTime startTime = DateTime.Now;

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
                            Console.WriteLine("Du bist Tod!");
                            Console.WriteLine("Drücke eine Taste, um ins Hauptmenü zurückzukehren.");
                            Console.ReadKey();
                            return;
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
                    return;
                }
                Console.Clear();
                tasteGedrueckt = false;
                Console.WriteLine("Ein weiterer Zombie versucht Rick Grimes von hinten anzugreifen.");
                Console.WriteLine("Du musst schnell reagieren und 'S' drücken, um ihn abzuwehren!");
                Console.WriteLine("Du hast 3 Sekunden Zeit!");

                startTime = DateTime.Now;

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
                            Console.WriteLine("Der Lärm lockt noch weitere Zombies an. Sie brechen durch die Tür, die nach draußen führt.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Falsche Taste! Der Zombie hat dich erwischt.");
                            Console.WriteLine("Du bist Tod!");
                            Console.WriteLine("Drücke eine Taste, um ins Hauptmenü zurückzukehren.");
                            Console.ReadKey();
                            return;
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
                    return;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe.");
                Console.ReadKey();
                goto Auswahl3;
            }






           
            Console.WriteLine("Rick Grimes erstarrt und weiß nicht, was er tun soll.");
            Console.WriteLine("Auf einmal packt ihn ein Mann und sperrt sich mit ihm in die Waffenkammer.");
            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        Auswahl4:
            Console.Clear();
                Console.WriteLine("Der man der dich in die waffenkammer gesperrt hat Guckt dich an es, herscht stille für eine sekunden.\n Der Mysteriöse mann fängt an zu sprechen 'Hi'");
                Console.WriteLine("Du guckst den mann an. Was tust du?");
                Console.WriteLine("1: 'Hi' zürcksagen");
                Console.WriteLine("2:  Fragen wer er ist?");
                Console.WriteLine("3:         Nichtsagen");

                eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    Console.WriteLine("Die Mysteriöse person sagt:'Du hast da ja was angelockt.'\n Er gibt dir die hand du erweiderst das 'mein name istJoel Miller'");
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Die Mysteriöse person sagt: 'Ah natürlich, Mein name ist Joel Miller und ich habe dir gerade den Arsch gerettet");
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("DI emysteriöse person sagt: 'Hats dir sprache verschlagen, achso mein name ist Joel Miller'");
                }
                else
                {
                Console.Clear();
                    Console.WriteLine("Ungültige Eingabe.");
                Console.ReadKey();
                goto Auswahl4;
            }

                Console.WriteLine("Joel Miller sagt: 'Wir sollten über die Dachluke rauskommen in der nähe gibt es ein Krankenhaus wir sollten dahin gehen Partner'");
                Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Rick Grimes sagt 'Wir sollte uns noch die waffen holen'.\n Joel fragt: 'Weisst du wie man die Schränke aufbekommt, schließlich arbeitest du hier und wir brauchen eine zahlen kombination un das schloss zu öffnen'\n Rick grimes sagt 'Scheisse der ging... warte... UWU und das in zahlen'");
                Console.WriteLine();
                Console.WriteLine("Du stehst vor dem zahlenschloss, gebe den richtigen code ein aber pass auf, wenn due das falshce eingibst explodiert es wegen seines sicherheitssystem.");
                eingabe = Console.ReadLine();

                if(eingabe == "212321")
                {
                    Console.WriteLine("Erleichtert das Rick grimes das schloss aufbekommen hat sthet er nun vor zwei waffen, er nam mit was er tragen konnte.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Du hast es falsch eingegeben und das schloss jagt alles in die luft");
                    Console.WriteLine("Du bist Tod!");
                    Console.WriteLine("Drücke eine Taste, um ins Hauptmenü zurückzukehren.");
                    Console.ReadKey();
                    startmenue.Execute();
                    return;
                }

            Console.WriteLine("Trotzdem stehen beide immer noch vor einem problem, sie sind stuck in der waffenkammer");
            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        Auswahl5:
            Console.Clear();
            Console.WriteLine("Zu dem glück beider personen befand sich in der waffenkammer ein: Ferngesteuertes fahrzeug mit lenker,eine eiruhr, Panzertape und eine Uran-235,15-kilo TNT,\n Little boy mini-Atombombe die recihen würde um die hälfte der polizeistation in die luft zu jagen.");
            Console.WriteLine();
            Console.WriteLine("Was tust du?");
            Console.WriteLine("1: Du klebst die eieruhr ,mit dem panzertape, ans das verngesteurte fahrzeug und lenkst die Zombies ab");
            Console.WriteLine("2: Du klebst die Mini-atombombe ,mit dem panzertape, ans gitter, konfigurierst es mit der eieruhr und spielst mit dem Auto bis die bombe hochgeht");
            Console.WriteLine("3: Du klebst die Mini-atombobe ,mit dem panzertape ans auto, konfigurierst sie mit der eieruhr und fährst das auto weitgenug weg sodass sie euch nicht tötet");
            Console.ReadKey();

            if (eingabe == "1")
            {
                Console.WriteLine("Die beiden kleben die eieruhr an das Ferngetseurte fahrzeug und lockt die zombies mit den geräuschen weg");
                Console.Clear();
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Die beiden konfigurieren und kleben die bombe an das gitter um die zombies einfach wegzusprengen,\nals sie alles gemacht haben spielen sie mit dem auto um sich die zeit zu vertreiben, nach ein paar minuten war nix mehr von den beiden übrig");
                Console.WriteLine("Du bist Tod!");
                Console.WriteLine("Drücke eine Taste, um ins Hauptmenü zurückzukehren.");
                Console.ReadKey();
                return;
            }
            else if (eingabe == "3")
            {
                Console.WriteLine("Die beiden konfigurieren die bombe mit der eieruhr kelben sie an das Verngesteuerte auto und fahren es weit weg,\n die bombe explodiert und tötet alle zombies und hat die hälfte der polizeistation in die luft gejagt, doch beide leben noch");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe.");
                Console.ReadKey();
                goto Auswahl5;
            }

            Console.WriteLine("Als der weg sicher war bahnten sich beide auf den weg zum Krankenhaus");




            //Weiterleitung ins nächste level
            Console.WriteLine("Du bist dabei level 2 zu betreten !Möchtest du weitermachen?");
            Console.WriteLine("1: Den Alptraum weiterspielen (HORROR)");
            Console.WriteLine("2: Auföhren (Angsthase)");
            Console.WriteLine(" Wähle weise");
                eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    level2 level2 = new level2();

                    level2.Execute();
                }
                else if (eingabe == "2") ;
                {
                    Console.WriteLine("Feigling!");
                    Console.WriteLine("Drücke eine taste um ins Hauptmeü zurückzukehren");
                    Console.ReadKey();
                    startmenue.Execute();

                }

            }
        }
    }
