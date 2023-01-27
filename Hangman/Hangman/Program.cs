using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anfang Wortauswahl
            //deklaration eines Arrays mit 8 Elementen
            string[] woerter = { "", "", "", "", "", "", "", "" }; //<- Hier Beliebig viele Wörter als String eintragen
            //Wort auswählen
            Random wuerfel = new Random();
            int zufallszahl = wuerfel.Next(0, 8);
            string geheimwort = woerter[zufallszahl];
            int bustabenanz = geheimwort.Length;


            //Suchwort bestimmen / auffuellen mit Bindestrichen
            string suchwort = "";
            for (int i = 0; i < geheimwort.Length; i++)
            {
                suchwort += "-";
            }
            int fehler = 0;
            //Spielablauf
            Console.WriteLine("Hangman Spiel");
            Console.WriteLine("-------------\n");
            Console.WriteLine("Anzahl Bustaben: " + geheimwort.Length);
            Console.WriteLine("Geheimwort: " + suchwort);
            Console.Write("Benutereingabe: ");
            while (fehler < 5 && suchwort != geheimwort)
            {
                char eingabe;
                eingabe = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                //Ende Spieler gewonnen /verloren
                bool treffer = false;
                string kopieSuchwort = "";
                for (int i = 0; i < geheimwort.Length; i++)
                {
                    if (eingabe == geheimwort[i])
                    {
                        treffer = true;
                        kopieSuchwort += eingabe;
                        
                    }
                    else
                    {
                        kopieSuchwort += suchwort[i];
                        
                    }

                }
                if (!treffer)
                {
                    fehler++;
                    Console.WriteLine("Fehler: " + fehler );
                }

                if (fehler>=5 )
                {
                    Console.WriteLine("!!!VERLOREN!!!");
                }
                else
                {
                    Console.WriteLine("Gewonnen");
                }
                suchwort = kopieSuchwort;
                Console.WriteLine("Geheimwort: " + suchwort);

            }


            // Suchwort anzeigen



            Console.ReadKey();
        }
    }
}
