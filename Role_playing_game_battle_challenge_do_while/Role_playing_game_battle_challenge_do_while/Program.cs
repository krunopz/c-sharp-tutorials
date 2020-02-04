using System;

namespace Role_playing_game_battle_challenge_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Role playing game battle challenge
                    In most role playing games, the player's character battles non-player characters, which are usually monsters or the 
                    "bad guys". Usually, a battle consists of each character generating a random value using dice and that value is subtracted
                    from the opponent's health score. Once either character's health reaches zero, they die or lose.

                    In this challenge, we'll boil down that interaction to its essence. A hero and a monster start with the same health 
                    score. During the hero's turn, they'll generate a random value which will be subtracted from the monster's health.
                    If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as both the hero 
                    and the monster have health greater than zero, the battle will resume.
                    
            Game Rules

            The hero and the monster will start with 10 health points.
            All attacks will be a value between 1 and 10.
            The hero will attack first.
            Print the amount of health the monster lost and their remaining health.
            If the monster's health is greater than 0, it can attack the hero.
            Print the amount of health the hero lost and their remaining health.
            Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
            Print the winner. */
            Console.WriteLine("Hello World! The GAME  starts! Hero attacks first:");
            int hero = 10;
            int monster = 10;
            int i = 1;
            Random random = new Random();
            int round = 1;
            do
            {
                int kick = random.Next(1, 10);
                if (hero <= 0 || monster <= 0) goto RESULT;
                if (i == 1) goto HERO_ATTACKS;
                if (i == 2) goto MONSTER_ATTACKS;

                HERO_ATTACKS:
                monster = monster - kick;
                Console.WriteLine("Hero attacks with {0} power. Monster now has {1}", kick, monster);
                i++;
                continue;


            MONSTER_ATTACKS: hero = hero - kick;
                Console.WriteLine("Monster attacks with {0} power. Hero now has {1}", kick, hero);
                i--;
                continue;


            } while (hero > 0 || monster > 0);
RESULT:            if (hero < monster) Console.WriteLine("Monster wins!");
            if (hero > monster) Console.WriteLine("Hero wins!");
            Console.ReadLine();
        }
    }
}
