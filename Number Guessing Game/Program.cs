using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;
            do
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);
                if (i > winNum)
                {
                    Console.WriteLine("Number to High!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Number to Low!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Correct!!!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to close.");
            Console.ReadKey(true);
        }
    }
}
