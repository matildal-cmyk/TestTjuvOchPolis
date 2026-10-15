using System.Drawing;

namespace TestTjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Slump = new Random();
            List<Personer> list = new List<Personer>();
            Tjuv tjuv = new Tjuv("Lasse", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, "pengar");
            Polis polis = new Polis("Kling", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.DarkCyan, "smycken");
            Medborgare medborgare = new Medborgare("Fru Larsson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.DarkYellow, "halsband");
            list.Add(tjuv);
            list.Add(polis);
            list.Add(medborgare);

            while (true)
            {
                Console.Clear();
                Console.Write("=CITY");
                for (int tak = 0; tak <= 95; tak++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                //Rita upp "staden"
                string[,] city = new string[25, 98];//100-2 för x
                for (int x = 0; x <= city.GetLength(0); x++)
                {
                    Console.Write("x");
                    for (int y = 0; y <= city.GetLength(1); y++)
                    {



                        Console.SetCursorPosition(x, y);
                        Console.Write("X");

                        x += Slump.Next(-1, 2);
                        y += Slump.Next(-1, 2);

                        x = Math.Clamp(x, 0, 99);
                        y = Math.Clamp(y, 0, 24);

                        Thread.Sleep(150);
                    }







                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();

                Console.Write("=STATUS");
                for (int g = 0; g <= 93; g++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                //Här ska det stå info om hur många som finns kvar 
                Console.WriteLine("Antal poliser: ");
                Console.WriteLine("Antal tjuvar: ");
                Console.WriteLine("Antal medborgare: ");

                Console.Write("=NEWSFEED");
                for (int i = 0; i <= 91; i++) //100 -bokstäverna
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                //Här ska det stå info om vilka som möts
                Console.WriteLine("Vilka som möts och säger hej eller tar från varandra");
            }
        }
    }
}

