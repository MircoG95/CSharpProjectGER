using System;

namespace WarmOderKalt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            Random rnd = new Random();
            int zufall = 0, eingabeNeu, eingabeAlt, diffNeu, diffAlt, modus = 0, counter = 1;
            bool check, sieg = false;
            string wahl;

            //Wahl der Schwierigkeit
            do
            {
                check = true;
                Console.WriteLine("(1) Zahl zwischen 1 und 100  (Standard)");
                Console.WriteLine("(2) Zahl zwischen 1 und 1000 (Hardmode)");
                Console.Write("Ihre Wahl: ");
                wahl = Console.ReadLine();

                if (wahl == "1")
                {
                    zufall = rnd.Next(1, 101);
                    modus = 100;
                }
                else if (wahl == "2")
                {
                    zufall = rnd.Next(1, 1001);
                    modus = 1000;
                }
                else
                {
                    Console.WriteLine("Bitte nur 1 oder 2 wählen");
                    check = false;
                }
            } while (!check);


            //Erste User-Eingabe
            do
            {
                Console.Write("Bitte geben Sie Ihre Zahl ein: ");
                check = int.TryParse(Console.ReadLine(), out eingabeNeu);
                if (!check || eingabeNeu < 1 || eingabeNeu > modus)
                {
                    check = false;
                    Console.WriteLine($"Bitte nur Zahlen zwischen 1 und {modus} angeben (in Ziffern!!!111).");
                }
            } while (!check);

            //Weitere Eingaben
            do
            {
                if (eingabeNeu != zufall)
                {
                    eingabeAlt = eingabeNeu;
                    do
                    {
                        Console.Write("Bitte geben Sie Ihre Zahl ein: ");
                        check = int.TryParse(Console.ReadLine(), out eingabeNeu);
                        if (!check || eingabeNeu < 1 || eingabeNeu > modus)
                        {
                            check = false;
                            Console.WriteLine($"Bitte nur Zahlen zwischen 1 und {modus} angeben (in Ziffern!!!111).");
                        }
                    } while (!check);
                    counter++;

                    diffAlt = Math.Abs(zufall - eingabeAlt);
                    diffNeu = Math.Abs(zufall - eingabeNeu);

                    if (diffNeu < diffAlt && eingabeNeu != zufall)
                    {
                        Console.WriteLine("Wärmer.");
                    }
                    else if (diffNeu > diffAlt && eingabeNeu != zufall)
                    {
                        Console.WriteLine("Kälter.");
                    }
                    else if (eingabeNeu != zufall)
                    {
                        Console.WriteLine("Keine Temperatur-Schwankung!");
                    }
                }
                else
                {
                    Console.WriteLine("Sie haben gewonnen!");
                    Console.WriteLine($"Sie haben {counter} Versuche gebraucht!");
                    sieg = true;
                }
            } while (!sieg);

        }
    }
}
