using System;

namespace Integer_From_use_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I need two numbers from You. We will do some math. Let's start!" +
                "\n I will check Your input if it is a number and make you an options if it works. ");
           
        Start:
            Console.Write("Input number 1:");
            string input1 = Console.ReadLine();
           // int num1;
            if (int.TryParse(input1, out int num1))
            {
                Console.WriteLine("{0} is a number", num1);
            }
            else { 
                Console.WriteLine("{0} is not a number. Your calculations won't give you proper result.", input1);
                goto Start;
            }
        Number2:
            Console.Write("\n Input number 2: ");
            string input2 = Console.ReadLine();
            //int num2;
            if (int.TryParse(input2, out int num2))
            {
                Console.WriteLine("{0} is a number", num2);
                goto Options;
            }
            else
            {
                Console.WriteLine("{0} is not a number.  Your calculations won't give you proper result.", input2);
                goto Number2;
            }
        Options:
            Console.Write("What would You want to do?" +
                "\n 1. Add two numbers" +
                "\n 2. Add all the numbers from smaller to larger number of Your input? Make a choice: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("{0}+{1}= {2}", num1, num2, num1 + num2);
            }
            if(choice=="2")
            {
                if (num1 < num2)
                {
                    int sum = 0;
                    for (int i = num1; i <= num2; i++)
                    {
                        sum = sum + i;
                    }
                    Console.WriteLine("Sum of numbers is {0}", sum);
                }
                else {
                
                        int sum = 0;
                        for (int i = num2; i <= num1; i++)
                        {
                            sum = sum + i;
                        }
                        Console.WriteLine("Sum of numbers is {0}", sum);
                
                }
            }
        }
    }
}
