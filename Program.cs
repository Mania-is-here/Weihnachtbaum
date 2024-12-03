namespace Weihnachtsbaum
{
    using System;
    using System.Timers;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stufe1:
            //
            //Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
            //Du kannst dir das Aussehen des Baums selber aussuchen
            //Nutze für die Ausgabe Schleifen.
            //
            //Beispiel:
            //       x
            //      xxx
            //     xxxxx
            //    xxxxxxx
            //   xxxxxxxxx
            //  xxxxxxxxxxx
            //      xxx
            //      xxx

            //Stufe 2:
            //
            //Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
            //Nutze ggf. Farben.

            //Stufe 3: 
            //
            //Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

            //Stufe 4:
            //
            //Lass den Baum Blinken und Funkeln
            //Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert. 

            int printX = 1;
            int printSpace = 9;
            for (int i = 6; i > 0; i--)
            {
                for (int j = printSpace; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int j = printX; j > 0; j--)
                {
                    Console.Write("x");
                }
                printX += 2;
                printSpace -= 1;
                Console.WriteLine();
            }

            int printSpaceT = 8;
            int printXt = 3;
            for (int i =2 ; i > 0; i--)
            {
                for (int j = printSpaceT; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int j = printXt; j > 0; j--)
                {
                    Console.Write("x");
                    printXt= printXt;
                    printSpaceT = printSpaceT;
                }
                Console.WriteLine();
            }
            ConsoleColor[] colors = (ConsoleColor[]) Enum.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            ConsoleColor randomColor = colors [random.Next(colors.Length)];
            Console.ForegroundColor = randomColor;

            string[] Christmasgreeting = {"Merry Christmas and Happy New Year to you and yours.", "You put the merry in Christmas!", "Have a blessed holiday season.", "May your holidays sparkle with joy and laughter!"};
            Random rand = new Random();
            int index = rand.Next(Christmasgreeting.Length);
            Console.WriteLine($"{Christmasgreeting[index]}");
            
        }
    }
}

