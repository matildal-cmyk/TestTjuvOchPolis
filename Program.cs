using System.Drawing;
using TestTjuvOchPolis;

class Program
{
    static void Main()
    {
        // skapar lista med personer -----------------------------------------------------------------------------------------------------------------------------
        List<Personer> stad = new List<Personer>();

        stad.Add(new Polis("Klang", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Polis("Lasse", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Polis("Bengt", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Polis("Kling", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));

        stad.Add(new Medborgare("Lindström", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Medborgare("Pettersson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Medborgare("Lundström", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Medborgare("Andersson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));


        stad.Add(new Tjuv("Karlsson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Tjuv("Larsson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Tjuv("Svansson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Tjuv("Kalle", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));



        // --------------------------------------------------------------------------------------------------------------------------------------------------------















        // disable muspekarn
        Console.CursorVisible = false;
        //Console.Clear();



        // staden start --------------------------------------------
        Console.Write("=CITY");
        for (int tak = 0; tak <= 95; tak++)
        {
            Console.Write("=");
        }
        Console.WriteLine();

        //Rita upp "staden"
        string[,] city = new string[25, 98];//100-2 för x
        for (int i = 0; i <= city.GetLength(0); i++)
        {
            Console.Write("x");
            for (int j = 0; j <= city.GetLength(1); j++)
            {
                Console.Write(" ");
            }
            Console.Write("x");
            Console.WriteLine();
        }
        Console.Write("=STATUS");
        for (int g = 0; g <= 93; g++)
        {
            Console.Write("=");
        }
        Console.WriteLine();
        // --------------------------------------------------------


        Console.Write("=NEWSFEED");
        for (int g = 0; g <= 91; g++)
        {
            Console.Write("=");
        }
        Console.WriteLine();

        //skriva ut info under staden?
        //foreach (Personer person in stad)
        //{
        //    Console.WriteLine("direction stuff: " + person.Directions);
        //}





        // rörelse+print loop
        while (true)
        {
            foreach (Personer person in stad)

            {
                //recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text [rad 125].
                int oldX = person.PlatsX;
                int oldY = person.PlatsY;
                {

                    //plats x+y blir person direction x+y, kanske onödigt och kan ha person.directionX och Y direkt?
                    person.PlatsX += person.DirectionX;
                    person.PlatsY += person.DirectionY;


                    //// gå igenom väggen, "teleporteras" till andra sidan                    
                    if (person.PlatsX < 1) person.PlatsX = 96;
                    else if (person.PlatsX > 96) person.PlatsX = 1;
                    if (person.PlatsY < 1) person.PlatsY = 25;
                    else if (person.PlatsY > 25) person.PlatsY = 1;



                    // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                    Console.SetCursorPosition(oldX, oldY);
                    Console.Write(" ");



                    //skriver ut bokstav med olika färger per person typ
                    if (person is Tjuv)

                    {

                        Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("T");
                        Console.ResetColor();

                    }

                    if (person is Medborgare)

                    {

                        Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("M");
                        Console.ResetColor();

                    }

                    if (person is Polis)

                    {

                        Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("P");
                        Console.ResetColor();

                    }


                    //delay mellan rörelse
                    Thread.Sleep(75);
                }

            }
        }

    }
}