﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1_Erweiterung__Uebung3_
{
    class Sprint1_Erweiterung__Uebung3_
    {
        static void Main(string[] args)
        {
            string Nutzerabfrage;   // Abfrage Ja/Nein
            Nutzerabfrage = "Yes";

            while (Nutzerabfrage == "Yes")
            {

                Console.Clear();

                double X, Y;            // Kantenlängen
                double A;               // Flächeninhalt


                double R;               // Radius
                double D;               // Durchmesser
                double W;               // Wandstärke des Profils
                double Xs, Ys;          // Flächenschwerpunktkoordinaten
                double Ixx, Iyy;        // Flächenträgheitsmomente
                string Basiseinheit;    // Abfrage der Einheit
                string profilabfrage;   // Abfrage des Profiltyps



                Console.WriteLine("Wählen Sie Ihren Profiltyp aus: [1]: Rechteck-Vollprofil, [2]: Rechteck-Hohlprofil, [3]: Kreis-Vollprofil, [4]: Kreis-Hohlprofil");

                profilabfrage = Convert.ToString(Console.ReadLine());


                if (profilabfrage == "1")       //Rechteck Vollprofil
                {
                    Console.WriteLine("Bitte geben Sie die Kantenlänge X ein:");    //Eingabe für X,Y und Basiseinheit.
                    X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die Kantenlänge Y ein:");
                    Y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die verwendete Basiseinheit an:");
                    Basiseinheit = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Kennwerte werden berechnet...");

                    A = X * Y;      // Fläche Rechteck

                    Xs = X / 2;     // SWP-Koordinate von der unteren linken Ecke
                    Ys = Y / 2;     // SWP-Koordinate von der unteren linken Ecke

                    Ixx = (X * (Y * Y * Y)) / 12;   // Berechnung FTM um die X-Achse
                    Iyy = (Y * (X * X * X)) / 12;   // Berechnung FTM um die Y-Achse

                    Console.WriteLine("Flächeninhalt:" + A + Basiseinheit + "^2");
                    Console.WriteLine("Flächenschwerpunktkoordinate in X Richtung (KO-System Ursprung unten links):" + Xs + Basiseinheit);
                    Console.WriteLine("Flächenschwerpunktkoordinate in Y Richtung (KO-System Ursprung unten links):" + Ys + Basiseinheit);
                    Console.WriteLine("Flächenträgheitsmoment um die x Achse:" + Ixx + Basiseinheit + "^4");
                    Console.WriteLine("Flächenträgheitsmoment um die y Achse:" + Iyy + Basiseinheit + "^4");
                }

                else if (profilabfrage == "2")    //Rechteck Hohlprofil
                {
                    Console.WriteLine("Bitte geben Sie die Kantenlänge X ein:");
                    X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die Kantenlänge Y ein:");
                    Y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die Wandstärke ein:");
                    W = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie eine Basiseinheit ein:");
                    Basiseinheit = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Kennwerte werden berechnet...");



                    double xx, yy; //Innenseiten ohne Wandstärke

                    xx = X - 2 * W;
                    yy = Y - 2 * W;

                    A = X * Y - ((xx) * (yy));

                    Xs = 0.5 * X;
                    Ys = 0.5 * Y;


                    Ixx = (Y * Math.Pow(X, 3))/12 - ((yy) * Math.Pow(xx, 3))/12;
                    Iyy = (X* Math.Pow(Y, 3))/12 - ((xx) * Math.Pow(yy, 3))/12;


                    Console.WriteLine("Flächeninhalt:" + A + Basiseinheit + "^2");
                    Console.WriteLine("Flächenschwerpunktkoordinate in X Richtung (KO-System Ursprung unten links):" + Xs + Basiseinheit);
                    Console.WriteLine("Flächenschwerpunktkoordinate in Y Richtung (KO-System Ursprung unten links):" + Ys + Basiseinheit);
                    Console.WriteLine("Flächenträgheitsmoment um die x Achse:" + Ixx + Basiseinheit + "^4");
                    Console.WriteLine("Flächenträgheitsmoment um die y Achse:" + Iyy + Basiseinheit + "^4");



                }

                else if (profilabfrage == "3")    //Kreis-Vollprofil
                {
                    Console.WriteLine("Bitte geben Sie den Durchmesser an:");
                    D = Convert.ToDouble(Console.ReadLine());       // Eingabe Durchmesser
                    Console.WriteLine("Bitte geben Sie die verwendete Basiseinheit an:");
                    Basiseinheit = Convert.ToString(Console.ReadLine());        // Angabe der Basiseinheit
                    Console.WriteLine("Kennwerte werden berechnet...");

                    A = Math.PI * Math.Pow((D / 4), 2);     // Flächeninhalt
                    Xs = D / 2;     // Flächenschwerpunkt X-Koordinate
                    Ys = Xs;        // Flächenschwerpunkt Y-Koordinate
                    Ixx = (Math.PI / 64) * Math.Pow(D, 4);      // Flächenträgheitsmoment
                    Iyy = Ixx;

                    Console.WriteLine("Flächeninhalt:" + A + Basiseinheit + "^2");
                    Console.WriteLine("Flächenschwerpunktkoordinate in X Richtung (KO-System Ursprung unten links):" + Xs + Basiseinheit);
                    Console.WriteLine("Flächenschwerpunktkoordinate in Y Richtung (KO-System Ursprung unten links):" + Ys + Basiseinheit);
                    Console.WriteLine("Flächenträgheitsmoment um die x Achse:" + Ixx + Basiseinheit + "^4");
                    Console.WriteLine("Flächenträgheitsmoment um die y Achse:" + Iyy + Basiseinheit + "^4");

                }

                else if (profilabfrage == "4")    //Kreis-Hohlprofil
                {
                    Console.WriteLine("Außendurchmesser des Rohres:");
                    R = Convert.ToInt32(Console.ReadLine()) / 2;

                    Console.WriteLine("Bitte geben Sie die Wandstärke ein:");
                    W = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie die verwendete Basiseinheit an:");
                    Basiseinheit = Console.ReadLine();
                    Console.WriteLine("Kennwerte werden berechnet...");

                    A = (Math.Pow(R, 2) - Math.Pow((R - W), 2) * Math.PI);
                    Console.WriteLine("Flächeninhalt des Rohres: " + A + Basiseinheit + "^2");

                    Xs = R;
                    Console.WriteLine("Schwerpunktkoordinate in x-Richtung (Bezugspunkt unten links): " + Xs + Basiseinheit);

                    Ys = Xs;
                    Console.WriteLine("Schwerpunktkoordinate in x-Richtung (Bezugspunkt unten links): " + Ys + Basiseinheit);

                    Ixx = (Math.PI * (Math.Pow(R, 4) - Math.Pow((R - W), 4))) / 64;
                    Console.WriteLine("Flächenträgheitsmoment um die x-Achse: " + Ixx + Basiseinheit + "^4");

                    Iyy = Ixx;
                    Console.WriteLine("Flächenträgheitsmoment um die x-Achse: " + Iyy + Basiseinheit + "^4");
                }

                else
                {
                    Console.WriteLine("Sie haben keine korrekte Ziffer für einen Profiltypen eingegeben!");
                }


                MessageBoxResult abfrage;   // Abfrage zum erneuten Programmdurchlauf über MessageBox
                abfrage = MessageBox.Show("Möchten Sie eine weitere Berechnung durchführen?", "Programmende",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question
                    );

                Nutzerabfrage = Convert.ToString(abfrage);  // Konvertiere Abfrage in Schleifen-String


            }
            Console.WriteLine("Beliebige Taste drücken zum Beenden...");
            Console.ReadKey();
        }

    }


}

