using System;

namespace Subscription_renewal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            else if ((daysUntilExpiration) <= 5 && (daysUntilExpiration > 1))
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day! Renew now and save 20%!");
                discountPercentage = 20;
            }
            else
            {
                Console.WriteLine("Your supscription has expired.");
            }
            Console.WriteLine("Click here to save " + discountPercentage + "%.");
        }
    }
}
