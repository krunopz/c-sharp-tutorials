using System;

namespace FizzBuzz_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FizzBuzz RULES: FizzBuzz rules:

            Output values from 1 to 100, one number per line.
            When the current value is divisible by 3, print the term Fizz next to the number.
            When the current value is divisible by 5, print the term Buzz next to the number.
            When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.*/

            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0) Console.Write($"{i} Fizz\n ");
                else if (i % 5 == 0 && i % 3 != 0) Console.Write($"{i} Buzz\n ");
                else if (i % 3 == 0 && i % 5 == 0) Console.Write($"{i} FizzBuzz\n ");
                else Console.WriteLine(i);



            }
            Console.ReadLine();
        }
    }
}
