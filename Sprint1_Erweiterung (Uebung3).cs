using System;
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
            double X, Y;            // Kantenlängen
            double A;               // Flächeninhalt
            double X, Y;            // Kantenlängen
            double A;               // Flächeninhalt
            double R;               // Radius
            double W;               // Wandstärke des Profils
            double Xs, Ys;          // Flächenschwerpunktkoordinaten
            double Ixx, Iyy;        // Flächenträgheitsmomente
            string Basiseinheit;    // Abfrage der Einheit
            string profilabfrage;   // Abfrage des Profiltyps



            Console.WriteLine("Wählen Sie Ihren Profiltyp aus: [1]: Rechteck-Vollprofil, [2]: Rechteck-Hohlprofil, [3]: Kreis-Vollprofil, [4]: Kreis-Hohlprofil");

            profilabfrage = Convert.ToString(Console.ReadLine());


            if (profilabfrage == "1")       //Rechteck Vollprofil
            {

            }

            else if (profilabfrage == "2")    //Rechteck Hohlprofil
            {

            }

            else if (profilabfrage == "3")    //Kreis-Vollprofil
            {

            }

            else if (profilabfrage == "4")    //Kreis-Hohlprofil
            {
                Console.WriteLine("Außendurchmesser des Rohres:");
                R = Convert.ToInt32(Console.ReadLine()) / 2;

                Console.WriteLine("Wandstärke des Rohres:");
                W = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Basiseinheit der Längen:");
                Basiseinheit = Console.ReadLine();

                A = (Math.Pow(R, 2) - Math.Pow((R - W), 2) * Math.PI);
                Console.WriteLine("Flächeninhalt des Rohres: " + A + Basiseinheit + "^2");

                Xs = R;
                Console.WriteLine("Schwerpunktkoordinate in x-Richtung (Bezugspunkt unten links): " + Xs + Basiseinheit);

                Ys = Xs;
                Console.WriteLine("Schwerpunktkoordinate in x-Richtung (Bezugspunkt unten links): " + Ys + Basiseinheit);

                Ixx = (Math.PI * (Math.Pow(R, 4) - Math.Pow((R - W), 4))) / 64;
                Console.WriteLine("Flächenträgheitsmoment um die x-Achse: " + Ixx + Basiseinheit + "m^4");

                Iyy = Ixx;
                Console.WriteLine("Flächenträgheitsmoment um die x-Achse: " + Iyy+ Basiseinheit + "m^4");
            }

            else
            {
                Console.WriteLine("Sie haben keine korrekte Ziffer für einen Profiltypen eingegeben!");
            }


            Console.ReadKey();
        }

    }


}

