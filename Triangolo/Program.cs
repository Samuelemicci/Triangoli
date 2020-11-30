using System;
using ClassLibrary1;

namespace Triangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //lancio metodo inserimento lato
            double lato1 = Class1.InsLato();
            //lancio metodo inserimento lato
            double lato2 = Class1.InsLato();
            //lancio metodo inserimento lato
            double lato3 = Class1.InsLato();
            //lancio metodo calcolo perimetro
            double perim = Class1.Perimetro(lato1, lato2, lato3);
            Console.WriteLine(perim);
            //lancio metodo riconoscimento triangolo
            string tipot = Class1.Riconoscimento(lato1, lato2, lato3);
            Console.WriteLine(tipot);
        }

    }
}
