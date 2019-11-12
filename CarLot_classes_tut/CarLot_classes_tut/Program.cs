using System;

namespace CarLot_classes_tut
{
    class Program
    {
        static void Main(string[] args)
        {
            //we create a new "variable- class" under name myCar, and then new object Car
            Car myCar = new Car();
            myCar.Maker = "VW";
            myCar.Model = "Polo";
            myCar.Year = 2000;
            myCar.Color = "black";

            Car myCar2 = new Car();
            myCar2.Maker = "Renault";
            myCar2.Model= "Megane";
            myCar2.Year = 2001;
            myCar2.Color = "gold";

            Car myCar3 = new Car();
            myCar3.Maker = "Fiat";
            myCar3.Model = "Punto Grande";
            myCar3.Year= 2007;
            myCar3.Color= "black";

            Console.WriteLine("My first car was {0}, {1}, {2}, {3} \n", myCar.Maker, myCar.Model, myCar.Year, myCar.Color);
            Console.WriteLine("My second car was {0}, {1}, {2}, {3} \n", myCar2.Maker, myCar2.Model, myCar2.Year, myCar2.Color);
            Console.WriteLine("My {0}'worth is {1}", myCar.Model, myCar.DetermineMarketValue());
        }
    }
    class Car
    {
        //for getting lines down type prop, and press Tab twice
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()       //we don't need to call in a variable  in brackets as they are already in class
        {
            decimal carValue;
            if (Year < 2000)
                carValue = 2000;
            else carValue = 10000;

            return carValue;
        }
    }
}
