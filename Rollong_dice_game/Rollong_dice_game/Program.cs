using System;

namespace Rollong_dice_game
{
    /*Create a Random Game
    Let's invent a game to help us write if statements. We'll make up several rules to the game, then implement them in code.

    We'll use the Random.Next() method to simulate rolling three 6-sided dice. We'll evaluate the values to calculate the score. 
    If the score is greater than an arbitrary total, then we'll display a winning message to the user. Otherwise, we'll display a
    losing message to the user.

If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Let's play a game! Roll your dices!!!");
            Random dice = new Random();
        BEGIN:
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;
            string switch1;

            if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus points to total!");
                total += 2;
                Console.WriteLine($"Dice roll: {roll1}+{roll2}+{roll3}+ bonus={total}");
                if (total < 15)
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Wanna try again? Type Y...");
                    switch1 = Console.ReadLine();
                    if (switch1== "Y")
                        goto BEGIN;
                }
                if (total >= 15)
                    Console.WriteLine("You win!");
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
                Console.WriteLine($"Dice roll: {roll1}+{roll2}+{roll3}+ bonus={total}");
                if (total < 15)
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Wanna try again? Type Y...");
                    switch1 = Console.ReadLine();
                    if (switch1== "Y")
                        goto BEGIN;
                }
                if (total >= 15)
                    Console.WriteLine("You win!");
            }
            else {
                if (total < 15)
                {
                    Console.WriteLine($"Dice roll: {roll1}+{roll2}+{roll3}={total}");
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Wanna try again? Type Y...");
                    switch1=Console.ReadLine();
                    if(switch1=="Y")
                        goto BEGIN;

                }
                if (total >= 15)
                {
                    Console.WriteLine($"Dice roll: {roll1}+{roll2}+{roll3}={total}");
                    Console.WriteLine("You win!");
                }
            }
            
        }
    }
}
