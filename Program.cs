using System.Drawing;

namespace TestTjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personer> list = new List<Personer>();
            Tjuv tjuv = new Tjuv("Lasse",2,2,ConsoleColor.Red,"pengar");
            Polis polis = new Polis("Kling", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98),ConsoleColor.DarkCyan,"smycken");
            Medborgare medborgare = new Medborgare("Fru Larsson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98),ConsoleColor.DarkYellow, "halsband");
            list.Add(tjuv);
            list.Add(polis);
            list.Add(medborgare);


            Console.Write("=CITY");
            for (int tak= 0; tak<=95;tak++)  
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
            for (int g = 0;g <=93; g++)
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
