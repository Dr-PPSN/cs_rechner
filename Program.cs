using System;

namespace cs_rechner
{
    class Program
    {
        static void Erstes()
        {

            //start des Programs
            Console.WriteLine("Bitte drücke jedes mal die Enter Taste um zu bestätigen!");
            Console.ReadLine();
            Zweites();
        }
        static void Zweites()
        {

            //erste Zahl
            Console.WriteLine("Bitte gib die erste Zahl ein:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //operator eingabe
            Console.WriteLine("Bitte gib jetzt +,-,* oder / ein:");
            string a = Console.ReadLine();
            Console.WriteLine("");

            //zweite Zahl
            Console.WriteLine("Bitte gib die Zweite Zahl ein:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //var b erstellen
            int b = 0;

            //überprüfen des Operators

            if (a == "+")
            {
                b = 1;
            }
            if (a == "-")
            {
                b = 2;
            }
            if (a == "*")
            {
                b = 3;
            }
            if (a == "/")
            {
                b = 4;
            }

            //rechnen der var x und y
            switch (b)
            {
                case 1:
                    Console.WriteLine("Das Ergebnis ist:");
                    Console.WriteLine(x + y);
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Das Ergebnis ist:");
                    Console.WriteLine(x - y);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Das Ergebnis ist:");
                    Console.WriteLine(x * y);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Das Ergebnis ist:");
                    Console.WriteLine(x / y);
                    Console.ReadLine();
                    break;
            }
            Zweites();
        }
        static void nachfrage()
        {

        }
        static void Main(string[] args)
        {
            Erstes();
        }
    }
}