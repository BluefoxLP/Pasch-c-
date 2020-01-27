using System;
using System.Text.RegularExpressions;

namespace AS
{
    class Program
    {
        static void Main(string[] args)
        {



            static int Wurfel()
            {


                Random random = new Random();
                int zufall = random.Next(1, 7);
                return zufall;


            }

            static void Pasch(int z)
            {

                int a1 = Wurfel();
                LEER2();
                Console.WriteLine("ERSTER WÜRFEL:");
                Console.WriteLine(a1);
                LEER2();
                if (a1 == 6)
                {
                    z++;
                }
                int a2 = Wurfel();
                Console.WriteLine("ZWEITER WÜRFEL:");
                Console.WriteLine(a2);
                if (a2 == 6)
                {
                    z++;
                }

                if (a1 != a2)
                {
                    LEER2();
                    Console.WriteLine("ZUSAMMEN ERGIEBT DAS:");
                    a1 = a1;
                    int a10 = a2 + a1;
                    Console.WriteLine(a10);
                    LEER2();
                    Console.WriteLine("Willst du noch einmal Ja/Nein");
                    LEER2();
                    var userinput = Console.ReadLine();

                    while (!Regex.IsMatch(userinput, "(J|ja|A)|(N|n)(E|e)(I|i)(N|n)"))
                    {

                        LEER2();
                        Console.WriteLine("Willst du noch einmal?" +
                        " Antworte mit Ja oder Nein");
                        LEER2();
                        userinput = Console.ReadLine();
                        LEER2();


                    }
                    if (Regex.IsMatch(userinput, "(J|ja|A)"))//  userinput == "Ja" | userinput == "JA" | userinput == "ja")
                    {

                        Pasch(z);
                    }
                    if (Regex.IsMatch(userinput, "(N|n|E|e|I|i|N|n)"))
                    {
                        LEER2();
                        Console.WriteLine("ne es ist nicht wierd ein unendliches würfel spiel gemacht");
                    }


                }
                if (a1 == a2)
                {
                    LEER2();
                    Console.WriteLine("DU HAST EINEN PASCH GEWÜRFELT WILLST DU EINEN EXTRA WURF ODER PUNKTE");
                    Console.WriteLine("ANTWORTEN SIE MIT JA FÜR 4 PUNKTE UND NEIN FÜR EINEN EXTRA WURF WENN DIESER WURf DIE GLEICHE ZAHL HAT VON EINEN DEINER VORHERIGEN " +
                        "WÜRFEN BEKOMMST DU AUTOMATISCH NOCH EINEN");
                    LEER2();
                    var x = Console.ReadLine();
                    LEER2();
                    while (!Regex.IsMatch(x, "(J|ja|A)|(N|n|E|e|I|i|N|n)"))
                    {

                        Console.WriteLine("Gibt ja oder Nein ein");
                        LEER2();
                        x = Console.ReadLine();
                        LEER2();
                    }
                    if (Regex.IsMatch(x, "(J|ja|A)"))
                    {
                        a1 = a1 + 4;
                        int a6 = a2 + a1;

                        Console.WriteLine("ZUSAMMEN ERGIEBT DAS:");
                        Console.WriteLine(a6);
                        LEER2();
                    }



                    if (Regex.IsMatch(x, "(N|n)(E|e)(I|i)(N|n)"))
                    {

                        int a4 = Wurfel();
                        Console.WriteLine(a4);
                        LEER2();
                        if (a4 == 6)
                        {
                            z++;
                        }
                        if (a4 == a1)
                        {
                            Console.WriteLine("Du hast einen Weiteren Pasch");
                            LEER2();
                            int a5 = Wurfel();
                            Console.WriteLine(a5);
                            LEER2();
                            a5 = a1 + a2 + a4 + a5;
                            Console.WriteLine("Dein ergebnis ist " + a5 + " Du hattest aber Wirklich Glück");
                            LEER2();
                        }
                        else
                        {
                            a4 = a1 + a2 + a4;
                            Console.WriteLine("Dein Endergebnis beträgt " + a4);
                            LEER2();
                            Console.WriteLine("Du hast Sechser gewürfelt deine Insgesamten secher sind" + z);
                            LEER2();

                        }

                    }
                }




                
            }Pasch(0);


            static void LEER2()
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("=======================================================================================================================");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;

            }
        }
    }
}
