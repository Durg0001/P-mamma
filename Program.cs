


using System;

namespace Pizzaria
{
    class Menu
    {
        static void Main(string[] args)
        /* fra Pizzarias Menuen udvælge jeg 3 Pizzaer samt sodavand og toppings
         det er for at give et overblik over hvad jeg prøvet at lave indenfor. 
        */

        {
            int Margherita = 69;
            int Calzone = 80;
            int Italiana = 75;

            int sodavand = 20;
            int toppings = 10;

            // gratis levering med medlemsskab i lokale det område, ellers 12 kr for levering.  
            int leveringen = 12;

            int result = (Margherita + toppings + sodavand);

            Console.Write(Margherita);
            Console.Write("+");
            Console.Write(toppings);
            Console.Write("+");
            Console.Write(sodavand);
            Console.Write("=");
            Console.WriteLine(result);


            // kunde med medlemsskab/uden. herunder har jeg prøvet at
            {
                String kunde1 = "Mads";
                int Alder = 25;
                int kontakt = 60124849;

                Console.WriteLine(kunde1);
                Console.Write(true);
                Console.WriteLine(" er kunde hos os");

                String NyKunde2 = "Rasmus";
                int AlderAfNyKunde2 = 20;
                int KontaktNyKunde2 = 70452030;

                Console.WriteLine(NyKunde2);
                Console.Write(true);
                Console.WriteLine(" er kunde hos os");

                String Kunde3 = "Peter";
                int AlderAfKunde3 = 17;
                int KontaktAfKunde3 = 25184715;

                Console.WriteLine(Kunde3);
                Console.Write(true);
                Console.WriteLine(" er kunde hos os");

                // Kunde 4 er ikke medlem endnu.
                string Kunde4 = "Mathias";
                int AlderAfKunde4 = 0;
                int KontaktAfKunde4 = 00000000;

                Console.WriteLine(Kunde4 + leveringen);
                Console.Write(false);
                Console.WriteLine(" er ny og er ikke Kunde hos os endnu + leveringsprice");
                Console.ReadLine();

               




            }
        }
    }
}
