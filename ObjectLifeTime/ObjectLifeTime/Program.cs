using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar0 = new Car();
            Console.WriteLine("Constructor declared Name as {0}\n", myCar0.Name);

            Car myCar = new Car();

            myCar.Name = "Renault";
            myCar.Model = "Megane 1.4 16V";
            myCar.Year = 2001;
            myCar.Color = "metalic gold";

            Console.WriteLine($" My car is : {myCar.Name} , {myCar.Model} \n");

            //we can point several times to same object:
            Car myOtherCar;
            myOtherCar = myCar;
            Console.WriteLine($" My other car is : {myOtherCar.Name} , {myOtherCar.Model} \n");


            //or change some properties of an instance like this:
            myOtherCar.Model = "Megane Classic 1.6";

            Console.WriteLine($" My other, changed, car is : {myOtherCar.Name} , {myOtherCar.Model} \n");

            Car myThirdCar = new Car("WV", "Polo", 2000, "black");
            Console.WriteLine($"My third car is {myThirdCar.Name},{myThirdCar.Model},{myThirdCar.Year} and it is {myThirdCar.Color} color\n");
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Model { get; set;}
        public int Year { get; set; }
        public string Color { get; set; }

        //we could implement a CONSTRUCTOR that immediately sets a
        //propertie of a new instance, wihtout any declaration in main program like this:
        public Car()
        {
            // if not declared otherwise in program the car name will be BMW
            Name = "BMW";
            //You could load from a configuration file, database, etc. 
        }
        //oveloaded constructor--> we allow us to declare instance at the time we invoke it by Car(...,...)
        public Car(string name, string model, int year, string color)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;

        }
       


    }

   

}
