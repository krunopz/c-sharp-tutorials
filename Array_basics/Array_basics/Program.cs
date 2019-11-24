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
            for (int i = 0; i < fraudulentOrderIDs.Length; i++)
            {
                Console.WriteLine(fraudulentOrderIDs[i]);
            }
            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine("Reassign First: {0}", fraudulentOrderIDs[0]);


            Console.WriteLine($"The number of fraudulent orders is: {fraudulentOrderIDs.Length} \n");

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
            }
            else
                Console.WriteLine($"Order {suspicious} is not suspicious!!!");
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
