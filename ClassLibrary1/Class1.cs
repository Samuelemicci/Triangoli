using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public static double InsLato()
        {
            Console.WriteLine("inserisci un valore");
            double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }
        public static double Perimetro(double kato1, double kato2, double kato3)
        {
            return kato1 + kato2 + kato3;
        }
        public static string Riconoscimento(double kato1, double kato2, double kato3)
        {
            string tipot = "";
            if (kato1 == kato2 && kato1 == kato3)
            {
                tipot = "equilatero";
            }
            else if (kato1 == kato2 || kato2 == kato3)
            {
                tipot = "isoscele";
            }
            else if (kato1 != kato2 && kato1 != kato3 && kato2 != kato3)
            {
                tipot = "scaleno";
            }

            return tipot;
        }
    }
}
