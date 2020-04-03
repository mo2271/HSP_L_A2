using System;

namespace HSP_Sprint1_einfacheBerechnungen
{
    class HSP_Sprint1_einfacheBerechnungen
    {
        static void Main(string[] args)
        {
            double X, Y;            //Kantenlängen
            double A;               //Flächeninhalt
            double Xs, Ys;          //Flächenschwerpunktkoordinaten
            double Ixx, Iyy;        //Flächenträgheitsmomente
            string Basiseinheit;    //Abfrage der Einheit
            string neustart;        //Abfrage, ob Programm wiederholt werden soll


            do

            {   //Euren Code bitte in diese Klammer einfügen. Danke!

                Ixx = (X * (Y ^ 3)) / 12;   // Berechnung FTM um die X-Achse
                Iyy = (Y * (X ^ 3)) / 12;   // Berechnung FTM um die Y-Achse






                Console.WriteLine("Flächeninhalt:" + A + Basiseinheit + "^2");
                Console.WriteLine("Flächenschwerpunktkoordinate in X Richtung:" + Xs + Basiseinheit);
                Console.WriteLine("Flächenschwerpunktkoordinate in Y Richtung:" + Ys + Basiseinheit);
                Console.WriteLine("Flächenträgheitsmoment um die x Achse:" + Ixx + Basiseinheit + "^4");
                Console.WriteLine("Flächenträgheitsmoment um die y Achse:" + Iyy + Basiseinheit + "^4");
                
                
                Console.WriteLine("Möchten Sie eine weitere Berechnung durchführen? (j/n)");        //Programmwiederholung?
                neustart = Convert.ToString(Console.ReadLine());
                
            }

            while (neustart == "j");

            Console.WriteLine("Das Berechnungstool wurde von Ihnen beendet. Zum Verlassen eine beliebige Taste drücken");
            Console.ReadKey();


        }
    }
}
