using System;

namespace russian_roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("russian roulette game");

            menu();
        }

        static void menu()
        {
            newLine();

            Console.Write("fire the gun? ");
            string gunAnswer = Console.ReadLine();

            if (gunAnswer == "yes")
            {
                fireGun();
            }
            else if (gunAnswer == "no")
            {
                Console.WriteLine("ok, turning gun barrel");
                menu();
            }
            else
            {
                Console.WriteLine("input must be yes or no");
                menu();
            }
        }

        public static Random random = new Random();
        static void fireGun()
        {
            int randomNumber1 = random.Next(1, 6);
            int randomNumber2 = random.Next(1, 6);

            if (randomNumber1 == randomNumber2)
            {
                Console.Clear();
                Console.WriteLine("the round had a bullet, you are Dead.");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("the round did not have a bullet");
                menu();
            }
        }

        static void newLine()
        {
            Console.WriteLine();
        }
    }
}
