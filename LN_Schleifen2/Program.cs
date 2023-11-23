class LN_Schleifen2
{
    static void Main(string[] args)
    {
        // Initialisierung der Variablen
        Random zufall = new Random();
        string auswahl = "Ja";
        int spiel_anzahl = 1;
        int zufall_zahl = 0;
        int eingabe_zahl = 0;
        int versuche = 2; // Anzahl der Versuche pro Spiel
        int versuch_counter = 1; // Zählt die aktuellen Versuche

        // Haupt-Schleife für das Spiel
        do
        {
            // Zurücksetzen der Versuche und Versuchszähler für ein neues Spiel
            versuche = 2;
            versuch_counter = 1;

            // Ausgabe der aktuellen Spielnummer
            Console.WriteLine(spiel_anzahl + ". Spiel");

            // Zufällige Zahl für das aktuelle Spiel generieren
            zufall_zahl = zufall.Next(1, 50);
            Console.WriteLine("Ich habe eine Zahl gezogen :-) Rate mal, welche Zahl es war (1-50)?");

            // Innere Schleife für die Versuche
            while (versuche >= 0)
            {
                // Benutzer zur Eingabe der geratenen Zahl auffordern
                while (true)
                {
                    Console.Write("Gib die Zahl für den " + versuch_counter + ". Versuch ein:  ");
                    eingabe_zahl = Convert.ToInt32(Console.ReadLine());

                    if (eingabe_zahl >= 0 && eingabe_zahl <= 50)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Diese Zahl kann nicht verwendet werden. Gebe eine Zahl zwischen 1-50 ein");
                    }
                }

                // Überprüfen, ob die geratene Zahl korrekt ist
                if (zufall_zahl == eingabe_zahl)
                {
                    Console.WriteLine("Herzlichen Glückwunsch! Du hast die Zahl erraten.");
                    break;
                }
                // Überprüfen, ob die geratene Zahl zu klein ist
                else if (zufall_zahl > eingabe_zahl)
                {
                    // Unterschiedliche Ausgaben je nach Unterschied zwischen den Zahlen
                    if ((zufall_zahl - eingabe_zahl) > 15)
                        Console.WriteLine("Nein, meine Zahl ist deutlich größer.");
                    else if ((zufall_zahl - eingabe_zahl) >= 6 && (zufall_zahl - eingabe_zahl) <= 15)
                        Console.WriteLine("Nein, meine Zahl ist etwas größer.");
                    else
                        Console.WriteLine("Nein, meine Zahl ist größer.");
                }
                // Überprüfen, ob die geratene Zahl zu groß ist
                else if (zufall_zahl < eingabe_zahl)
                {
                    // Unterschiedliche Ausgaben je nach Unterschied zwischen den Zahlen
                    if ((eingabe_zahl - zufall_zahl) > 15)
                        Console.WriteLine("Nein, meine Zahl ist deutlich kleiner.");
                    else if ((eingabe_zahl - zufall_zahl) >= 6 && (eingabe_zahl - zufall_zahl) <= 15)
                        Console.WriteLine("Nein, meine Zahl ist etwas kleiner.");
                    else
                        Console.WriteLine("Nein, meine Zahl ist kleiner.");
                }

                // Versuchszähler und Anzahl der Versuche aktualisieren
                versuch_counter++;
                versuche--;
            }

            // Ausgabe, wenn alle Versuche aufgebraucht sind
            if (versuche == -1)
            {
                Console.WriteLine("Du hast leider verloren. Die Zahl lautet: " + zufall_zahl);
            }

            // Benutzer nach weiterem Spielwunsch fragen
            Console.Write("Möchtest Du noch einmal spielen? (Ja/Nein):  ");
            auswahl = Console.ReadLine();

            // Inkrementiere die Spielanzahl
            spiel_anzahl++;

        } while (auswahl == "Ja"); // Die äußere Schleife wird wiederholt, solange die Eingabe "Ja" ist.
    }
}
 