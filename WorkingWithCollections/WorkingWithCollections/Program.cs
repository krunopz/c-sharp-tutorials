using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;


namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Car car1 = new Car();
             car1.Make = "BMW";
             car1.Model = "X3";
             car1.SerNo = "A1";

             Car car2 = new Car();
             car2.Make = "Renault";
             car2.Model = "Clio";
             car2.SerNo = "B2";

             Book b1 = new Book();
             b1.Author = "W. Scott";
             b1.Title = "Ivanhoe";
             b1.ISBN = "0-000-000-0";

             Book b2 = new Book();
             b2.Author = "W. Shakespear";
             b2.Title = "MacBeth";
             b2.ISBN = "0-000-000-2";

            /*
             //Object initializer
             //No need for Constructor
             Car car3 = new Car() { Make = "Peugeot", Model = "2008", SerNo = "C3" };
             Car car4 = new Car() { Make = "VW", Model = "Polo", SerNo = "D4" };
             
            //Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Peugeot", Model = "2008", SerNo = "C3"},
                new Car { Make = "VW", Model = "Polo", SerNo = "D4" }
            };
        
            */

            //ArrayLists are dynamically sized, have cool features
            //like sorting, remove items,...
            //better for apps
            /* ArrayList myArrayList = new ArrayList();
             myArrayList.Add(car1);
             myArrayList.Add(car2);
             myArrayList.Add(b1);
             myArrayList.Remove(b1);


             foreach (Car car in myArrayList)
             {
                 Console.WriteLine(car.Make);

             }
             */

            /*List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);

            }
            */
            
            
            //Dictionary<TKey,TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.SerNo, car1);
            myDictionary.Add(car2.SerNo, car2);

            Console.WriteLine(myDictionary["A1"].Make);
            
            Console.ReadLine();
        }
    }
    class Car { 
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerNo { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    
    }

}
