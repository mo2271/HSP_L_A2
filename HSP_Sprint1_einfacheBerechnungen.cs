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














            Console.WriteLine("Flächeninhalt:" + A + Basiseinheit+"^2");
            Console.WriteLine("Flächenschwerpunktkoordinate in X Richtung:" + Xs +Basiseinheit);
            Console.WriteLine("Flächenschwerpunktkoordinate in Y Richtung:" + Ys +Basiseinheit);
            Console.WriteLine("Flächenträgheitsmoment um die x Achse:" + Ixx + Basiseinheit +"^4");
            Console.WriteLine("Flächenträgheitsmoment um die y Achse:" + Iyy + Basiseinheit +"^4");
            Console.ReadKey();





        }
    }
}
