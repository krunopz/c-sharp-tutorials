using System;

namespace Array_basics
{
    class Program
    {
        /*Suppose we work in the fraud department of a company that matches online sellers with commission-based advertisers. 
         * Our advertisers have notified us of a rash of recent credit card chargebacks. These chargebacks occur a few months 
         * after commissions were paid out, long after the thieves have vanished. We've been asked to review several orders in
         * hopes of identifying markers of fraud. Maybe our company can use those markers in the future to identify potential 
         * fraudulent purchases.

        We need to work with a sequence of Order IDs. These orders are related inasmuch as we want to identify and analyze them 
        looking for common characteristics. Since we don't always know in advance how many orders we'll need to review, we can't c
        reate individual variables to hold each Order ID. How can we create a data structure to hold multiple related values?*/
        static void Main(string[] args)
        {
            string[] fraudulentOrderIDs = new string[6];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            fraudulentOrderIDs[3] = "D012";
            fraudulentOrderIDs[4] = "E246";
            fraudulentOrderIDs[5] = "F468";

            // or
            // string[] fraudulentOrderIDs = { "A123", "B456", "C789" };


            //or 
            /*
            The following code creates five random OrderIDs
            to test the fraud detection process.  OrderIDs 
            consist of a letter from A to E, and a three
               digit number. Ex. A123.

            Random random = new Random();
            string[] orderIDs = new string[5];

            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");

                orderIDs[i] = prefix + suffix;
            }
            */
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
            for (int i = 0; i < fraudulentOrderIDs.Length; i++)
            {
                Console.WriteLine(fraudulentOrderIDs[i]);
            }
            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine("Reassign First: {0}", fraudulentOrderIDs[0]);


            Console.WriteLine($"The number of fraudulent orders is: {fraudulentOrderIDs.Length} \n");

            Console.WriteLine("Check existing list of fraudulent ID's: \n 1. By starting letter \n 2. By ID \n");
            string choice = Console.ReadLine();
        CHOOSE:
            if (choice == "1")
                goto BYLETTER;
            else if (choice == "2")
                goto BYID;
            else
            {
                Console.WriteLine("You made a mistake. Retype your choice:");
                goto CHOOSE;
            }
        BYID:
            Console.WriteLine("Input ID of order you want to check: ");
            string suspicious;
            suspicious = Console.ReadLine();
            /*   bool check = false;
               foreach (string order in fraudulentOrderIDs)
               {
                   if (order == suspicious)
                   {
                       Console.WriteLine($"Order {suspicious} is suspicious!!!");
                       check= true;
                   }
               }*/
            Program list = new Program();
            bool check = list.Check(suspicious,fraudulentOrderIDs);
            if (check == true)
            {
                Console.WriteLine($"Order {suspicious} is suspicious!!!");
                goto END;
            }
            else
            {
                Console.WriteLine($"Order {suspicious} is not suspicious!!!");
                goto END;
            }
     
        BYLETTER:
            Console.WriteLine("Input the starting letter: \n");
            string letter = Console.ReadLine();
            foreach (string fraud in fraudulentOrderIDs)
            {
                if (fraud.StartsWith(letter))
                    Console.WriteLine(fraud);
            }
        END:
            Console.ReadLine();
        }
        private bool Check(string suspicious, string[] fraudulentOrderIDs)
        {
            foreach (string order in fraudulentOrderIDs)
            {
                if (order == suspicious)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
