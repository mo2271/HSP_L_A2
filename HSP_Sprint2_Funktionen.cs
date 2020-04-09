using System;

namespace HSP_Sprint2_Funktionen
{
    class HSP_Sprint2_Funktionen
    {
        static void Main(string[] args)
        {
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

            else if (profilabfrage=="2")    //Rechteck Hohlprofil
            {

            }

            else if (profilabfrage=="3")    //Kreis-Vollprofil
            {

            }

            else if (profilabfrage=="4")    //Kreis-Hohlprofil
            {

            }

            else
            {
                Console.WriteLine("Sie haben keine korrekte Ziffer für einen Profiltypen eingegeben!");
            }
             
      


        }
    }
}



