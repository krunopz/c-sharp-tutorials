using System;

namespace if_elseif_tut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! So this is my new start! I haven't been here for a while. \n Let's start!");
            Console.Write("My name is Krunoslav Stefanek. \n What's Your name, please: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}!", userName);
            Console.WriteLine("Make a choice: \n 1. Say something!  \n 2. Make an addition operation! \n 3. Guess a color I'm thinking of.");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("What would You like to say? \n");
                string message = Console.ReadLine();
                Console.WriteLine("You said: " + message);

            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Tell me two numbers: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sum = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Let's assume that we have three colors: \n 1. blue \n 2. green \n 3. red \n What do you think: What's my favourite color?\n");
                int colorChoice = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();
                int n = RandomNumber(1,3);
                Console.WriteLine(n);
                if (colorChoice == 1 && n == 1)
                {
                    Console.Write("Nice! It is blue!");
                }
                else if (colorChoice == 2 && n == 2)
                {
                    Console.Write("Nice! It is green!");
                }
                else if (colorChoice == 3 && n == 3)
                {
                    Console.Write("Nice! It is red!");
                }
                else {
                    Console.Write("Sorry! You missed...");
                }
            }
            Console.ReadLine();
        }
        // Generate a random number between two numbers  
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
