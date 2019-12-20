using System;

namespace Conditional_operators_inline
{
    class Program
    {
    
            static void Main(string[] args)
            {
                //How to implement conditional operator in program
                Random coin = new Random();
                int flip = coin.Next(0, 2);
                Console.WriteLine($"You flipped coin and got :{(flip < 1 ? "head" : "tails")}");
            }
        
    }

}
